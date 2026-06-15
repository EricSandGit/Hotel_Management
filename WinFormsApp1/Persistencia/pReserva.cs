using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pReserva : IRepositorio<Reserva>
    {
        public List<Reserva> ObtenerTodos()
        {
            List<Reserva> reservas = new List<Reserva>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_reserva, id_cliente, id_habitacion, id_usuario, fecha_entrada, fecha_salida, cantidad_personas, estado FROM RESERVA");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Reserva reserva = new Reserva();
                reserva.IdReserva = dataReader.GetInt32(0);
                reserva.IdCliente = dataReader.GetInt32(1);
                reserva.IdHabitacion = dataReader.GetInt32(2);
                reserva.IdUsuario = dataReader.GetInt32(3);
                reserva.FechaEntrada = Convert.ToDateTime(dataReader.GetValue(4));
                reserva.FechaSalida = Convert.ToDateTime(dataReader.GetValue(5));
                reserva.CantidadPersonas = dataReader.GetInt32(6);
                reserva.Estado = dataReader.GetString(7);
                reservas.Add(reserva);
            }

            return reservas;
        }

        public Reserva ObtenerPorId(int id)
        {
            Reserva reserva = new Reserva();
            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_reserva, id_cliente, id_habitacion, id_usuario, fecha_entrada, fecha_salida, cantidad_personas, estado FROM RESERVA WHERE id_reserva = @id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();
            while (dataReader.Read())
            {
                reserva.IdReserva = dataReader.GetInt32(0);
                reserva.IdCliente = dataReader.GetInt32(1);
                reserva.IdHabitacion = dataReader.GetInt32(2);
                reserva.IdUsuario = dataReader.GetInt32(3);
                reserva.FechaEntrada = Convert.ToDateTime(dataReader.GetValue(4));
                reserva.FechaSalida = Convert.ToDateTime(dataReader.GetValue(5));
                reserva.CantidadPersonas = dataReader.GetInt32(6);
                reserva.Estado = dataReader.GetString(7);
            }
            return reserva;
        }

        public int Agregar(Reserva entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO RESERVA (id_cliente, id_habitacion, id_usuario, fecha_entrada, fecha_salida, cantidad_personas, estado) " +
                "VALUES (@IdCliente, @IdHabitacion, @IdUsuario, @FechaEntrada, @FechaSalida, @CantidadPersonas, @Estado); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdCliente", entidad.IdCliente));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdHabitacion", entidad.IdHabitacion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", entidad.IdUsuario));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaEntrada", entidad.FechaEntrada.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaSalida", entidad.FechaSalida.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CantidadPersonas", entidad.CantidadPersonas));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
            sqliteCommand.Connection = Conexion.MiConexion;

            entidad.IdReserva = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return entidad.IdReserva;
        }

        public bool Actualizar(Reserva entidad)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE RESERVA SET id_cliente = @IdCliente, id_habitacion = @IdHabitacion, id_usuario = @IdUsuario, " +
                "fecha_entrada = @FechaEntrada, fecha_salida = @FechaSalida, cantidad_personas = @CantidadPersonas, " +
                "estado = @Estado WHERE id_reserva = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdCliente", entidad.IdCliente));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdHabitacion", entidad.IdHabitacion));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", entidad.IdUsuario));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaEntrada", entidad.FechaEntrada.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaSalida", entidad.FechaSalida.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CantidadPersonas", entidad.CantidadPersonas));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", entidad.Estado));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdReserva));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public bool Eliminar(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM RESERVA WHERE id_reserva = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            int rowsAffected = sqliteCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
