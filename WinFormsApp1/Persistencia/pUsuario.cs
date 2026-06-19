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

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password FROM USUARIO"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = dataReader.GetInt32(0);
                        usuario.IdRol = dataReader.GetInt32(1);
                        usuario.Nombre = dataReader.GetString(2);
                        usuario.Username = dataReader.GetString(3);
                        usuario.Password = dataReader.GetString(4);
                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario usuario = new Usuario();
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password FROM USUARIO WHERE id_usuario = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuario.IdUsuario = dataReader.GetInt32(0);
                        usuario.IdRol = dataReader.GetInt32(1);
                        usuario.Nombre = dataReader.GetString(2);
                        usuario.Username = dataReader.GetString(3);
                        usuario.Password = dataReader.GetString(4);
                    }
                }
            }
            return usuario;
        }

        public Usuario BuscarPorUsername(string username)
        {
            Usuario usuario = null;
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_usuario, id_rol, nombre, username, password FROM USUARIO WHERE username = @username"))
                {
                sqliteCommand.Parameters.Add(new SqliteParameter("@username", username));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuario = new Usuario();
                        usuario.IdUsuario = dataReader.GetInt32(0);
                        usuario.IdRol = dataReader.GetInt32(1);
                        usuario.Nombre = dataReader.GetString(2);
                        usuario.Username = dataReader.GetString(3);
                        usuario.Password = dataReader.GetString(4);
                    }
                }
            }
            return usuario;
        }

        public int Agregar(Usuario entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO USUARIO (id_rol, nombre, username, password) " +
                "VALUES (@IdRol, @Nombre, @Username, @Password); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", entidad.IdRol));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Username", entidad.Username));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Password", entidad.Password));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdUsuario = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdUsuario;
        }

        public bool Actualizar(Usuario entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE USUARIO SET id_rol = @IdRol, nombre = @Nombre, username = @Username, password = @Password " +
                "WHERE id_usuario = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", entidad.IdRol));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Username", entidad.Username));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Password", entidad.Password));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdUsuario));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM USUARIO WHERE id_usuario = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
