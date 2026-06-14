using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdHabitacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPersonas { get; set; }
        public string Estado { get; set; } = "pendiente";

        public Reserva() { }

        public Reserva(int idReserva, int idCliente, int idHabitacion, int idUsuario, DateTime fechaEntrada, DateTime fechaSalida, int cantidadPersonas, string estado)
        {
            IdReserva = idReserva;
            IdCliente = idCliente;
            IdHabitacion = idHabitacion;
            IdUsuario = idUsuario;
            FechaEntrada = fechaEntrada;
            FechaSalida = fechaSalida;
            CantidadPersonas = cantidadPersonas;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"Reserva {IdReserva} | Cliente: {IdCliente} | Hab: {IdHabitacion} | Entrada: {FechaEntrada:dd/MM/yyyy} | Salida: {FechaSalida:dd/MM/yyyy} | Estado: {Estado}";
        }
    }
}
