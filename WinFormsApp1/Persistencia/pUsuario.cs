using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pUsuario : IRepositorio<Usuario>
    {
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password_hash FROM USUARIO");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = dataReader.GetInt32(0);
                usuario.IdRol = dataReader.GetInt32(1);
                usuario.Nombre = dataReader.GetString(2);
                usuario.Username = dataReader.GetString(3);
                usuario.PasswordHash = dataReader.GetString(4);
                usuarios.Add(usuario);
            }

            return usuarios;
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario usuario = new Usuario();
            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password_hash FROM USUARIO WHERE id_usuario = @id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();
            while (dataReader.Read())
            {
                usuario.IdUsuario = dataReader.GetInt32(0);
                usuario.IdRol = dataReader.GetInt32(1);
                usuario.Nombre = dataReader.GetString(2);
                usuario.Username = dataReader.GetString(3);
                usuario.PasswordHash = dataReader.GetString(4);
            }
            return usuario;
        }

        public Usuario BuscarPorUsername(string username)
        {
            Usuario usuario = null;
            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password_hash FROM USUARIO WHERE username = @username");
            sqliteCommand.Parameters.Add(new SqliteParameter("@username", username));
            sqliteCommand.Connection = Conexion.MiConexion;
             SqliteDataReader dataReader = sqliteCommand.ExecuteReader();
            while (dataReader.Read())
            {
                usuario = new Usuario();
                usuario.IdUsuario = dataReader.GetInt32(0);
                usuario.IdRol = dataReader.GetInt32(1);
                usuario.Nombre = dataReader.GetString(2);
                usuario.Username = dataReader.GetString(3);
                usuario.PasswordHash = dataReader.GetString(4);
            }
            return usuario;
        }

        public int Agregar(Usuario entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO USUARIO (id_rol, nombre, username, password_hash) " +
                "VALUES (@IdRol, @Nombre, @Username, @PasswordHash); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", entidad.IdRol));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Username", entidad.Username));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PasswordHash", entidad.PasswordHash));
            sqliteCommand.Connection = Conexion.MiConexion;

            entidad.IdUsuario = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return entidad.IdUsuario;
        }

        public bool Actualizar(Usuario entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE USUARIO SET id_rol = @IdRol, nombre = @Nombre, username = @Username, password_hash = @PasswordHash " +
                "WHERE id_usuario = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", entidad.IdRol));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Username", entidad.Username));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PasswordHash", entidad.PasswordHash));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdUsuario));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public bool Eliminar(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM USUARIO WHERE id_usuario = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
