using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nReserva
    {
        private static readonly pReserva persistencia = new pReserva();

        public static List<Reserva> ListarReservas() => persistencia.ObtenerTodos();

        public static Reserva ObtenerReservaPorId(int id) => persistencia.ObtenerPorId(id);

        public static bool ValidarDisponibilidad(int idHabitacion, DateTime fechaEntrada, DateTime fechaSalida, int idReservaAExcluir = 0)
        {
            
            if (fechaEntrada >= fechaSalida || fechaEntrada < DateTime.Today)
                return false;

            var reservas = ListarReservas();
            foreach (var r in reservas)
            {
                if (r.IdReserva == idReservaAExcluir) continue;

                if (r.IdHabitacion == idHabitacion && !string.Equals(r.Estado, "Cancelada", StringComparison.OrdinalIgnoreCase))
                {
                    // Fórmula de traslape: (StartA < EndB) y (EndA > StartB)
                    if (fechaEntrada < r.FechaSalida && fechaSalida > r.FechaEntrada)
                    {
                        return false; // Hay superposición de reservas
                    }
                }
            }
            return true;
        }

        // Verificar que la cantidad de huéspedes no supere la capacidad de la habitación
        public static bool ValidarCapacidad(int idHabitacion, int cantidadPersonas)
        {
            if (cantidadPersonas <= 0) return false;

            var h = nHabitacion.ObtenerHabitacionPorId(idHabitacion);
            if (h == null || h.IdHabitacion <= 0) return false;

            int maxCapacidad = nHabitacion.ObtenerCapacidadTotal(h);
            return cantidadPersonas <= maxCapacidad;
        }

    

        // Alta de reserva con validaciones de negocio
        public static bool CrearReserva(Reserva r)
        {
            if (r == null || r.IdCliente <= 0 || r.IdHabitacion <= 0 || r.IdUsuario <= 0)
                return false;

            // Verificar capacidad de la habitación
            if (!ValidarCapacidad(r.IdHabitacion, r.CantidadPersonas))
                return false;

            // Verificar disponibilidad y fechas
            if (!ValidarDisponibilidad(r.IdHabitacion, r.FechaEntrada, r.FechaSalida))
                return false;

            int id = persistencia.Agregar(r);
            return id > 0;
        }

        // Modificación de reserva con validaciones
        public static bool ActualizarReserva(Reserva r)
        {
            if (r == null || r.IdReserva <= 0 || r.IdCliente <= 0 || r.IdHabitacion <= 0 || r.IdUsuario <= 0)
                return false;

            // Verificar capacidad de la habitación
            if (!ValidarCapacidad(r.IdHabitacion, r.CantidadPersonas))
                return false;

            // Verificar disponibilidad excluyendo la reserva actual
            if (!ValidarDisponibilidad(r.IdHabitacion, r.FechaEntrada, r.FechaSalida, r.IdReserva))
                return false;

            return persistencia.Actualizar(r);
        }

        // Cancelación de reserva
        public static bool CancelarReserva(int id)
        {
            var r = ObtenerReservaPorId(id);
            if (r == null || r.IdReserva <= 0) return false;
            r.Estado = "Cancelada";
            return persistencia.Actualizar(r);
        }

        // Comprobar si la reserva tiene una estadía asignada
        public static bool TieneEstadiaAsignada(int idReserva)
        {
            return nEstadia.ListarEstadias().Exists(e => e.IdReserva == idReserva);
        }

        // Baja de reserva
        public static bool EliminarReserva(int id) => persistencia.Eliminar(id);
    }
}
