using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nCuenta
    {
        private static readonly pCuenta persistencia = new pCuenta();

        // Consulta de todas las cuentas
        public static List<Cuenta> ListarCuentas() => persistencia.ObtenerTodos();

        // Consulta por id
        public static Cuenta ObtenerCuentaPorId(int id) => persistencia.ObtenerPorId(id);

        // Calcular subtotal de habitación basándose en estadía, reserva y precio por noche de habitación
        public static double CalcularSubtotalHabitacion(int idEstadia)
        {
            var estadia = new pEstadia().ObtenerPorId(idEstadia);
            if (estadia == null || estadia.IdEstadia <= 0) return 0;

            var reserva = new pReserva().ObtenerPorId(estadia.IdReserva);
            if (reserva == null || reserva.IdReserva <= 0) return 0;

            var habitacion = new pHabitacion().ObtenerPorId(reserva.IdHabitacion);
            if (habitacion == null || habitacion.IdHabitacion <= 0) return 0;

            int noches = (int)(reserva.FechaSalida - reserva.FechaEntrada).TotalDays;
            if (noches <= 0) noches = 1;

            return nHabitacion.CalcularPrecio(habitacion, noches);
        }

        // Calcular subtotal de gastos extras de una estadía
        public static double CalcularSubtotalGastos(int idEstadia)
        {
            var listGastos = new pGastoExtra().ObtenerTodos();
            double totalGastos = 0;
            foreach (var g in listGastos)
            {
                if (g.IdEstadia == idEstadia)
                {
                    totalGastos += g.Monto;
                }
            }
            return totalGastos;
        }

        // Obtener saldo pendiente de una cuenta por id
        public static double ObtenerSaldoPendiente(int idCuenta)
        {
            var cuenta = persistencia.ObtenerPorId(idCuenta);
            if (cuenta == null || cuenta.IdCuenta <= 0) return 0;
            return cuenta.TotalGeneral - cuenta.MontoPagado;
        }

        // Generar Cuenta consolidando reservas, estadías y gastos extras
        public static bool GenerarCuenta(int idEstadia)
        {
            // Evitar duplicados de cuenta para la misma estadía
            var cuentasExistentes = ListarCuentas();
            if (cuentasExistentes.Exists(x => x.IdEstadia == idEstadia))
                return false;

            double totalHabitacion = CalcularSubtotalHabitacion(idEstadia);
            double totalGastos = CalcularSubtotalGastos(idEstadia);
            double totalGeneral = totalHabitacion + totalGastos;

            var cuenta = new Cuenta
            {
                IdEstadia = idEstadia,
                TotalHabitacion = totalHabitacion,
                TotalGastos = totalGastos,
                TotalGeneral = totalGeneral,
                MontoPagado = 0,
                Estado = "Impaga"
            };

            int id = persistencia.Agregar(cuenta);
            return id > 0;
        }

        // Registrar pagos y actualizar estado
        public static bool RegistrarPago(int idCuenta, double monto)
        {
            if (monto <= 0) return false;

            var cuenta = persistencia.ObtenerPorId(idCuenta);
            if (cuenta == null || cuenta.IdCuenta <= 0) return false;

            cuenta.MontoPagado += monto;
            if (cuenta.MontoPagado >= cuenta.TotalGeneral)
            {
                cuenta.Estado = "Pagada";
            }
            return persistencia.Actualizar(cuenta);
        }

        // Modificar cuenta
        public static bool ActualizarCuenta(Cuenta c)
        {
            if (c == null || c.IdCuenta <= 0 || c.TotalGeneral <= 0)
                return false;

            return persistencia.Actualizar(c);
        }

        // Baja de cuenta
        public static bool EliminarCuenta(int id) => persistencia.Eliminar(id);
    }
}
