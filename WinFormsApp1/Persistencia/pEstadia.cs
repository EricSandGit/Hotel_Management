using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pEstadia : IRepositorio<Estadia>
    {
        public List<Estadia> ObtenerTodos()
        {
            List<Estadia> estadias = new List<Estadia>();

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_estadia, id_reserva, id_usuario, fecha_checkin, fecha_checkout, estado FROM ESTADIA"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Estadia estadia = new Estadia();
                        estadia.IdEstadia = dataReader.GetInt32(0);
                        estadia.IdReserva = dataReader.GetInt32(1);
                        estadia.IdUsuario = dataReader.GetInt32(2);
                        estadia.FechaCheckin = Convert.ToDateTime(dataReader.GetValue(3));
                        estadia.FechaCheckout = dataReader.IsDBNull(4) ? (DateTime?)null : Convert.ToDateTime(dataReader.GetValue(4));
                        estadia.Estado = dataReader.GetString(5);
                        estadias.Add(estadia);
                    }
                }
            }

            return estadias;
        }

        public Estadia ObtenerPorId(int id)
        {
            Estadia estadia = null;
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_estadia, id_reserva, id_usuario, fecha_checkin, fecha_checkout, estado FROM ESTADIA WHERE id_estadia = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        estadia = new Estadia();
                        estadia.IdEstadia = dataReader.GetInt32(0);
                        estadia.IdReserva = dataReader.GetInt32(1);
                        estadia.IdUsuario = dataReader.GetInt32(2);
                        estadia.FechaCheckin = Convert.ToDateTime(dataReader.GetValue(3));
                        estadia.FechaCheckout = dataReader.IsDBNull(4) ? (DateTime?)null : Convert.ToDateTime(dataReader.GetValue(4));
                        estadia.Estado = dataReader.GetString(5);
                    }
                }
            }
            return estadia;
        }

        public int Agregar(Estadia entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO ESTADIA (id_reserva, id_usuario, fecha_checkin, fecha_checkout, estado) " +
                "VALUES (@IdReserva, @IdUsuario, @FechaCheckin, @FechaCheckout, @Estado); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdReserva", entidad.IdReserva));
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", entidad.IdUsuario));
                sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckin", entidad.FechaCheckin.ToString("yyyy-MM-dd")));
                sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckout", entidad.FechaCheckout.HasValue ? entidad.FechaCheckout.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdEstadia = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdEstadia;
        }

        public bool Actualizar(Estadia entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE ESTADIA SET id_reserva = @IdReserva, id_usuario = @IdUsuario, " +
                "fecha_checkin = @FechaCheckin, fecha_checkout = @FechaCheckout, estado = @Estado WHERE id_estadia = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdReserva", entidad.IdReserva));
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", entidad.IdUsuario));
                sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckin", entidad.FechaCheckin.ToString("yyyy-MM-dd")));
                sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckout", entidad.FechaCheckout.HasValue ? entidad.FechaCheckout.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdEstadia));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM ESTADIA WHERE id_estadia = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
