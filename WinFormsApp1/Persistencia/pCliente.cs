using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pCliente
    {
        public static List<Cliente> getAll()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cliente, nombre, apellido, nro_documento, telefono, email, localidad FROM CLIENTE");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = dataReader.GetInt32(0);
                cliente.Nombre = dataReader.GetString(1);
                cliente.Apellido = dataReader.GetString(2);
                cliente.Dni = dataReader.GetString(3);
                cliente.Telefono = dataReader.IsDBNull(4) ? string.Empty : dataReader.GetString(4);
                cliente.Email = dataReader.IsDBNull(5) ? string.Empty : dataReader.GetString(5);
                cliente.Localidad = dataReader.IsDBNull(6) ? string.Empty : dataReader.GetString(6);
                clientes.Add(cliente);
            }

            return clientes;
        }

        public static Cliente GuardarCliente(Cliente c)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO CLIENTE (nombre, apellido, nro_documento, telefono, email, localidad) " +
                "VALUES (@Nombre, @Apellido, @NroDocumento, @Telefono, @Email, @Localidad); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", c.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Apellido", c.Apellido));
            sqliteCommand.Parameters.Add(new SqliteParameter("@NroDocumento", c.Dni));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Telefono", string.IsNullOrEmpty(c.Telefono) ? (object)DBNull.Value : c.Telefono));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Email", string.IsNullOrEmpty(c.Email) ? (object)DBNull.Value : c.Email));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Localidad", string.IsNullOrEmpty(c.Localidad) ? (object)DBNull.Value : c.Localidad));
            sqliteCommand.Connection = Conexion.MiConexion;

            c.Id = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return c;
        }

        public static void ModificarCliente(Cliente c)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE CLIENTE SET nombre = @Nombre, apellido = @Apellido, " +
                "nro_documento = @NroDocumento, telefono = @Telefono, email = @Email, localidad = @Localidad WHERE id_cliente = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", c.Nombre));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Apellido", c.Apellido));
            sqliteCommand.Parameters.Add(new SqliteParameter("@NroDocumento", c.Dni));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Telefono", string.IsNullOrEmpty(c.Telefono) ? (object)DBNull.Value : c.Telefono));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Email", string.IsNullOrEmpty(c.Email) ? (object)DBNull.Value : c.Email));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Localidad", string.IsNullOrEmpty(c.Localidad) ? (object)DBNull.Value : c.Localidad));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", c.Id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarCliente(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM CLIENTE WHERE id_cliente = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
