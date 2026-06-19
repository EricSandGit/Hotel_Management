using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pCliente : IRepositorio<Cliente>
    {
        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cliente, nombre, apellido, nro_documento, telefono, email, localidad FROM CLIENTE"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = dataReader.GetInt32(0);
                        cliente.Nombre = dataReader.GetString(1);
                        cliente.Apellido = dataReader.GetString(2);
                        cliente.Dni = dataReader.GetString(3);
                        cliente.Telefono = dataReader.IsDBNull(4) ? string.Empty : dataReader.GetString(4);
                        cliente.Email = dataReader.IsDBNull(5) ? string.Empty : dataReader.GetString(5);
                        cliente.Localidad = dataReader.IsDBNull(6) ? string.Empty : dataReader.GetString(6);
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }

        public Cliente ObtenerPorId(int id)
        {
            Cliente cliente = null;
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cliente, nombre, apellido, nro_documento, telefono, email, localidad FROM CLIENTE WHERE id_cliente = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        cliente = new Cliente();
                        cliente.IdCliente = dataReader.GetInt32(0);
                        cliente.Nombre = dataReader.GetString(1);
                        cliente.Apellido = dataReader.GetString(2);
                        cliente.Dni = dataReader.GetString(3);
                        cliente.Telefono = dataReader.IsDBNull(4) ? string.Empty : dataReader.GetString(4);
                        cliente.Email = dataReader.IsDBNull(5) ? string.Empty : dataReader.GetString(5);
                        cliente.Localidad = dataReader.IsDBNull(6) ? string.Empty : dataReader.GetString(6);
                    }
                }
            }
            return cliente;
        }

        public int Agregar(Cliente entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO CLIENTE (nombre, apellido, nro_documento, telefono, email, localidad) " +
                "VALUES (@Nombre, @Apellido, @NroDocumento, @Telefono, @Email, @Localidad); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Apellido", entidad.Apellido));
                sqliteCommand.Parameters.Add(new SqliteParameter("@NroDocumento", entidad.Dni));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Telefono", string.IsNullOrEmpty(entidad.Telefono) ? (object)DBNull.Value : entidad.Telefono));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Email", string.IsNullOrEmpty(entidad.Email) ? (object)DBNull.Value : entidad.Email));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Localidad", string.IsNullOrEmpty(entidad.Localidad) ? (object)DBNull.Value : entidad.Localidad));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdCliente = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdCliente;
        }

        public bool Actualizar(Cliente entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE CLIENTE SET nombre = @Nombre, apellido = @Apellido, " +
                "nro_documento = @NroDocumento, telefono = @Telefono, email = @Email, localidad = @Localidad WHERE id_cliente = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Nombre", entidad.Nombre));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Apellido", entidad.Apellido));
                sqliteCommand.Parameters.Add(new SqliteParameter("@NroDocumento", entidad.Dni));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Telefono", string.IsNullOrEmpty(entidad.Telefono) ? (object)DBNull.Value : entidad.Telefono));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Email", string.IsNullOrEmpty(entidad.Email) ? (object)DBNull.Value : entidad.Email));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Localidad", string.IsNullOrEmpty(entidad.Localidad) ? (object)DBNull.Value : entidad.Localidad));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdCliente));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM CLIENTE WHERE id_cliente = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
