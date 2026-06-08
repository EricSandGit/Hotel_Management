using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pRol
    {
        public static List<Rol> getAll()
        {
            List<Rol> roles = new List<Rol>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_rol, nombre, descripcion FROM ROL");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Rol rol = new Rol();
                rol.IdRol = dataReader.GetInt32(0);
                rol.Nombre = dataReader.GetString(1);
                rol.Descripcion = dataReader.IsDBNull(2) ? string.Empty : dataReader.GetString(2);
                roles.Add(rol);
            }

            return roles;
        }

        public static Rol GuardarRol(Rol r)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO ROL (nombre, descripcion) VALUES (@Nombre, @Descripcion); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", r.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Descripcion", string.IsNullOrEmpty(r.Descripcion) ? (object)DBNull.Value : r.Descripcion));
            sqliteCommand.Connection = Conexion.MiConexion;

            r.IdRol = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return r;
        }

        public static void ModificarRol(Rol r)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE ROL SET nombre = @Nombre, descripcion = @Descripcion WHERE id_rol = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", r.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Descripcion", string.IsNullOrEmpty(r.Descripcion) ? (object)DBNull.Value : r.Descripcion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", r.IdRol));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarRol(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM ROL WHERE id_rol = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
