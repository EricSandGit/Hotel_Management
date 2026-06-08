using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    internal class Estadia
    {
        public int IdEstadia { get; set; }
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCheckin { get; set; }
        public DateTime? FechaCheckout { get; set; }
        public string Estado { get; set; } = "activa";

        public Estadia() { }

        public Estadia(int idEstadia, int idReserva, int idUsuario, DateTime fechaCheckin, DateTime? fechaCheckout, string estado)
        {
            IdEstadia = idEstadia;
            IdReserva = idReserva;
            IdUsuario = idUsuario;
            FechaCheckin = fechaCheckin;
            FechaCheckout = fechaCheckout;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"Estadía {IdEstadia} | Reserva: {IdReserva} | Check-in: {FechaCheckin:dd/MM/yyyy} | Estado: {Estado}";
        }
    }
}
