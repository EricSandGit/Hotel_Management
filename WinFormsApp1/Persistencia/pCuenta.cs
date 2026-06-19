using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pCuenta : IRepositorio<Cuenta>
    {
        public List<Cuenta> ObtenerTodos()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cuenta, id_estadia, total_habitacion, total_gastos, total_general, monto_pagado, estado FROM CUENTA"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Cuenta cuenta = new Cuenta();
                        cuenta.IdCuenta = dataReader.GetInt32(0);
                        cuenta.IdEstadia = dataReader.GetInt32(1);
                        cuenta.TotalHabitacion = dataReader.GetDouble(2);
                        cuenta.TotalGastos = dataReader.GetDouble(3);
                        cuenta.TotalGeneral = dataReader.GetDouble(4);
                        cuenta.MontoPagado = dataReader.GetDouble(5);
                        cuenta.Estado = dataReader.GetString(6);
                        cuentas.Add(cuenta);
                    }
                }
            }

            return cuentas;
        }

        public Cuenta ObtenerPorId(int id)
        {
            Cuenta cuenta = new Cuenta();
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cuenta, id_estadia, total_habitacion, total_gastos, total_general, monto_pagado, estado FROM CUENTA WHERE id_cuenta = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        cuenta.IdCuenta = dataReader.GetInt32(0);
                        cuenta.IdEstadia = dataReader.GetInt32(1);
                        cuenta.TotalHabitacion = dataReader.GetDouble(2);
                        cuenta.TotalGastos = dataReader.GetDouble(3);
                        cuenta.TotalGeneral = dataReader.GetDouble(4);
                        cuenta.MontoPagado = dataReader.GetDouble(5);
                        cuenta.Estado = dataReader.GetString(6);
                    }
                }
            }
            return cuenta;
        }

        public int Agregar(Cuenta entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO CUENTA (id_estadia, total_habitacion, total_gastos, total_general, monto_pagado, estado) " +
                "VALUES (@IdEstadia, @TotalHabitacion, @TotalGastos, @TotalGeneral, @MontoPagado, @Estado); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", entidad.IdEstadia));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalHabitacion", entidad.TotalHabitacion));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGastos", entidad.TotalGastos));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGeneral", entidad.TotalGeneral));
                sqliteCommand.Parameters.Add(new SqliteParameter("@MontoPagado", entidad.MontoPagado));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdCuenta = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdCuenta;
        }

        public bool Actualizar(Cuenta entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE CUENTA SET id_estadia = @IdEstadia, total_habitacion = @TotalHabitacion, " +
                "total_gastos = @TotalGastos, total_general = @TotalGeneral, monto_pagado = @MontoPagado, " +
                "estado = @Estado WHERE id_cuenta = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", entidad.IdEstadia));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalHabitacion", entidad.TotalHabitacion));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGastos", entidad.TotalGastos));
                sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGeneral", entidad.TotalGeneral));
                sqliteCommand.Parameters.Add(new SqliteParameter("@MontoPagado", entidad.MontoPagado));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdCuenta));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM CUENTA WHERE id_cuenta = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
