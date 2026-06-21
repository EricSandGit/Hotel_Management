using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pGastoExtra : IRepositorio<GastoExtra>
    {
        public List<GastoExtra> ObtenerTodos()
        {
            List<GastoExtra> gastos = new List<GastoExtra>();

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_gasto, id_estadia, concepto, monto, fecha FROM GASTO_EXTRA"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        GastoExtra gasto = new GastoExtra();
                        gasto.IdGasto = dataReader.GetInt32(0);
                        gasto.IdEstadia = dataReader.GetInt32(1);
                        gasto.Concepto = dataReader.GetString(2);
                        gasto.Monto = dataReader.GetDouble(3);
                        gasto.Fecha = Convert.ToDateTime(dataReader.GetValue(4));
                        gastos.Add(gasto);
                    }
                }
            }

            return gastos;
        }

        public GastoExtra ObtenerPorId(int id)
        {
            GastoExtra gasto = null;
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_gasto, id_estadia, concepto, monto, fecha FROM GASTO_EXTRA WHERE id_gasto = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        gasto = new GastoExtra();
                        gasto.IdGasto = dataReader.GetInt32(0);
                        gasto.IdEstadia = dataReader.GetInt32(1);
                        gasto.Concepto = dataReader.GetString(2);
                        gasto.Monto = dataReader.GetDouble(3);
                        gasto.Fecha = Convert.ToDateTime(dataReader.GetValue(4));
                    }
                }
            }
            return gasto;
        }

        public int Agregar(GastoExtra entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO GASTO_EXTRA (id_estadia, concepto, monto, fecha) " +
                "VALUES (@IdEstadia, @Concepto, @Monto, @Fecha); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", entidad.IdEstadia));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Concepto", entidad.Concepto));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Monto", entidad.Monto));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Fecha", entidad.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdGasto = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdGasto;
        }

        public bool Actualizar(GastoExtra entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE GASTO_EXTRA SET id_estadia = @IdEstadia, concepto = @Concepto, " +
                "monto = @Monto, fecha = @Fecha WHERE id_gasto = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", entidad.IdEstadia));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Concepto", entidad.Concepto));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Monto", entidad.Monto));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Fecha", entidad.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdGasto));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM GASTO_EXTRA WHERE id_gasto = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
