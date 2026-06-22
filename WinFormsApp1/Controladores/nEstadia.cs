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
        public static bool CrearEstadia(Estadia e)
        {
            if (e == null || e.IdReserva <= 0 || e.IdUsuario <= 0)
                return false;

            // Verificar coherencia entre fechas si se especifican
            if (e.FechaCheckout.HasValue && e.FechaCheckin >= e.FechaCheckout.Value)
                return false;

            // Obtener la reserva para validar la capacidad y habitación
            // Obtener la reserva para validar la capacidad y habitación
            var reserva = nReserva.ObtenerReservaPorId(e.IdReserva);
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

            // No permitir check-in si no es el día de la reserva (FechaEntrada)
            if (DateTime.Today != r.FechaEntrada.Date)
                return false;

            // Verificar capacidad de la habitación
            if (!nReserva.ValidarCapacidad(r.IdHabitacion, r.CantidadPersonas))
                return false;

            // Verificar coherencia temporal
            if (DateTime.Today > r.FechaSalida)
                return false;

            // Verificar si ya existe una estadía asociada a esta reserva
            var estadiaExistente = ListarEstadias().Find(e => e.IdReserva == r.IdReserva);
            if (estadiaExistente != null)
            {
                // Si ya existe la estadía, sincronizamos el estado de la reserva y retornamos éxito
                if (!string.Equals(r.Estado, "confirmada", StringComparison.OrdinalIgnoreCase))
                {
                    r.Estado = "confirmada";
                    nReserva.ActualizarReserva(r);
                }
                return true;
            }

            var estadia = new Estadia
            {
                IdReserva = r.IdReserva,
                IdUsuario = r.IdUsuario,
                FechaCheckin = DateTime.Now,
                FechaCheckout = null,
                Estado = "activa"
            };

            int id = persistencia.Agregar(estadia);
            if (id > 0)
            {
                // Actualizar el estado de la reserva
                r.Estado = "confirmada";
                nReserva.ActualizarReserva(r);
                return true;
            }
            return false;
        }

        // Registrar Check-Out (Cierra la estadía, finaliza la reserva y genera la cuenta)
        public static bool RegistrarCheckOut(int idEstadia)
        {
            var estadia = persistencia.ObtenerPorId(idEstadia);
            if (estadia == null || estadia.IdEstadia <= 0 || string.Equals(estadia.Estado, "finalizada", StringComparison.OrdinalIgnoreCase)) 
                return false;

            // Buscar la reserva asociada para validar la fecha de salida
            var reserva = nReserva.ObtenerReservaPorId(estadia.IdReserva);
            if (reserva == null) return false;

            // No permitir check-out si no es el día de la salida
            if (DateTime.Today != reserva.FechaSalida.Date)
                return false;

            // Finalizar la estadía
            estadia.FechaCheckout = DateTime.Now;
            estadia.Estado = "finalizada";

            bool ok = persistencia.Actualizar(estadia);
            if (ok)
            {
                // Finalizar la reserva asociada
                reserva.Estado = "confirmada";
                nReserva.ActualizarReserva(reserva);

                // Generar automáticamente la cuenta consolidada para esta estadía
                nCuenta.GenerarCuenta(idEstadia);
            }
            return ok;
        }

        // Comprobar si la estadía tiene dependencias activas (cuentas o gastos extras)
        public static bool TieneDependencias(int idEstadia)
        {
            bool tieneCuenta = nCuenta.ListarCuentas().Exists(c => c.IdEstadia == idEstadia);
            bool tieneGasto = nGastoExtra.ListarGastos().Exists(g => g.IdEstadia == idEstadia);
            return tieneCuenta || tieneGasto;
        }

        // Baja de estadía
        public static bool EliminarEstadia(int id) => persistencia.Eliminar(id);
    }
}
