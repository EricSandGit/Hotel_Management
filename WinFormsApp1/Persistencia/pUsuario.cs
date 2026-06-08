using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pUsuario
    {
        public static List<Usuario> getAll()
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

        public static Usuario GuardarUsuario(Usuario u)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO USUARIO (id_rol, nombre, username, password_hash) " +
                "VALUES (@IdRol, @Nombre, @Username, @PasswordHash); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", u.IdRol));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", u.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Username", u.Username));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PasswordHash", u.PasswordHash));
            sqliteCommand.Connection = Conexion.MiConexion;

            u.IdUsuario = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return u;
        }

        public static void ModificarUsuario(Usuario u)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE USUARIO SET id_rol = @IdRol, nombre = @Nombre, username = @Username, password_hash = @PasswordHash " +
                "WHERE id_usuario = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdRol", u.IdRol));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", u.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Username", u.Username));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PasswordHash", u.PasswordHash));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", u.IdUsuario));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarUsuario(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM USUARIO WHERE id_usuario = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
