using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pCuenta
    {
        public static List<Cuenta> getAll()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_cuenta, id_estadia, total_habitacion, total_gastos, total_general, monto_pagado, estado FROM CUENTA");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

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

            return cuentas;
        }

        public static Cuenta GuardarCuenta(Cuenta c)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO CUENTA (id_estadia, total_habitacion, total_gastos, total_general, monto_pagado, estado) " +
                "VALUES (@IdEstadia, @TotalHabitacion, @TotalGastos, @TotalGeneral, @MontoPagado, @Estado); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", c.IdEstadia));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalHabitacion", c.TotalHabitacion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGastos", c.TotalGastos));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGeneral", c.TotalGeneral));
            sqliteCommand.Parameters.Add(new SqliteParameter("@MontoPagado", c.MontoPagado));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", c.Estado));
            sqliteCommand.Connection = Conexion.MiConexion;

            c.IdCuenta = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return c;
        }

        public static void ModificarCuenta(Cuenta c)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE CUENTA SET id_estadia = @IdEstadia, total_habitacion = @TotalHabitacion, " +
                "total_gastos = @TotalGastos, total_general = @TotalGeneral, monto_pagado = @MontoPagado, " +
                "estado = @Estado WHERE id_cuenta = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", c.IdEstadia));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalHabitacion", c.TotalHabitacion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGastos", c.TotalGastos));
            sqliteCommand.Parameters.Add(new SqliteParameter("@TotalGeneral", c.TotalGeneral));
            sqliteCommand.Parameters.Add(new SqliteParameter("@MontoPagado", c.MontoPagado));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", c.Estado));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", c.IdCuenta));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarCuenta(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM CUENTA WHERE id_cuenta = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
