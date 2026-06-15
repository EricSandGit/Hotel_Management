using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pRol : IRepositorio<Rol>
    {
        public List<Rol> ObtenerTodos()
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

        public Rol ObtenerPorId(int id)
        {
            Rol rol = new Rol();
            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_rol, nombre, descripcion FROM ROL WHERE id_rol = @id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();
            while (dataReader.Read())
            {
                rol.IdRol = dataReader.GetInt32(0);
                rol.Nombre = dataReader.GetString(1);
                rol.Descripcion = dataReader.IsDBNull(2) ? string.Empty : dataReader.GetString(2);
            }
            return rol;
        }

        public int Agregar(Rol entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO ROL (nombre, descripcion) VALUES (@Nombre, @Descripcion); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Descripcion", string.IsNullOrEmpty(entidad.Descripcion) ? (object)DBNull.Value : entidad.Descripcion));
            sqliteCommand.Connection = Conexion.MiConexion;

            entidad.IdRol = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return entidad.IdRol;
        }

        public bool Actualizar(Rol entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE ROL SET nombre = @Nombre, descripcion = @Descripcion WHERE id_rol = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Descripcion", string.IsNullOrEmpty(entidad.Descripcion) ? (object)DBNull.Value : entidad.Descripcion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdRol));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public bool Eliminar(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM ROL WHERE id_rol = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
