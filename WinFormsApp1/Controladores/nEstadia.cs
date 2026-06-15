using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nEstadia
    {
        private static readonly pEstadia persistencia = new pEstadia();

        // Consulta de todas las estadías
        public static List<Estadia> ListarEstadias() => persistencia.ObtenerTodos();

        // Consulta por id
        public static Estadia ObtenerEstadiaPorId(int id) => persistencia.ObtenerPorId(id);

        // Alta de estadía (manual)
        public static bool AgregarEstadia(Estadia e)
        {
            if (e == null || e.IdReserva <= 0 || e.IdUsuario <= 0)
                return false;

            // Verificar coherencia entre fechas si se especifican
            if (e.FechaCheckout.HasValue && e.FechaCheckin >= e.FechaCheckout.Value)
                return false;

            // Obtener la reserva para validar la capacidad y habitación
            var reserva = new pReserva().ObtenerPorId(e.IdReserva);
            if (reserva == null || reserva.IdReserva <= 0)
                return false;

            // Verificar capacidad de la habitación
            if (!nReserva.ValidarCapacidad(reserva.IdHabitacion, reserva.CantidadPersonas))
                return false;

            int id = persistencia.Agregar(e);
            return id > 0;
        }

        // Modificación de estadía
        public static bool ActualizarEstadia(Estadia e)
        {
            if (e == null || e.IdEstadia <= 0 || e.IdReserva <= 0 || e.IdUsuario <= 0)
                return false;

            // Verificar coherencia entre fechas
            if (e.FechaCheckout.HasValue && e.FechaCheckin >= e.FechaCheckout.Value)
                return false;

            return persistencia.Actualizar(e);
        }

        // Registrar Check-In desde una reserva
        public static bool RegistrarCheckIn(Reserva r)
        {
            if (r == null || r.IdReserva <= 0) return false;

            // Verificar capacidad de la habitación
            if (!nReserva.ValidarCapacidad(r.IdHabitacion, r.CantidadPersonas))
                return false;

            // Verificar coherencia temporal
            if (DateTime.Today > r.FechaSalida)
                return false;

            var estadia = new Estadia
            {
                IdReserva = r.IdReserva,
                IdUsuario = r.IdUsuario,
                FechaCheckin = DateTime.Now,
                FechaCheckout = null,
                Estado = "Activa"
            };

            int id = persistencia.Agregar(estadia);
            if (id > 0)
            {
                // Actualizar el estado de la reserva
                r.Estado = "En Curso";
                new pReserva().Actualizar(r);
                return true;
            }
            return false;
        }

        // Registrar Check-Out (Cierra la estadía, finaliza la reserva y genera la cuenta)
        public static bool RegistrarCheckOut(int idEstadia)
        {
            var estadia = persistencia.ObtenerPorId(idEstadia);
            if (estadia == null || estadia.IdEstadia <= 0 || estadia.Estado == "Finalizada") 
                return false;

            // Finalizar la estadía
            estadia.FechaCheckout = DateTime.Now;
            estadia.Estado = "Finalizada";

            bool ok = persistencia.Actualizar(estadia);
            if (ok)
            {
                // Finalizar la reserva asociada
                var reserva = new pReserva().ObtenerPorId(estadia.IdReserva);
                if (reserva != null && reserva.IdReserva > 0)
                {
                    reserva.Estado = "Finalizada";
                    new pReserva().Actualizar(reserva);
                }

                // Generar automáticamente la cuenta consolidada para esta estadía
                nCuenta.GenerarCuenta(idEstadia);
            }
            return ok;
        }

        // Baja de estadía
        public static bool EliminarEstadia(int id) => persistencia.Eliminar(id);
    }
}
