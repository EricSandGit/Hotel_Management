using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public int IdEstadia { get; set; }
        public double TotalHabitacion { get; set; }
        public double TotalGastos { get; set; }
        public double TotalGeneral { get; set; }
        public double MontoPagado { get; set; }
        public string Estado { get; set; } = "pendiente";

        public Cuenta() { }

        public Cuenta(int idCuenta, int idEstadia, double totalHabitacion, double totalGastos, double totalGeneral, double montoPagado, string estado)
        {
            IdCuenta = idCuenta;
            IdEstadia = idEstadia;
            TotalHabitacion = totalHabitacion;
            TotalGastos = totalGastos;
            TotalGeneral = totalGeneral;
            MontoPagado = montoPagado;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"Cuenta {IdCuenta} | Estadía: {IdEstadia} | Total: ${TotalGeneral} | Pagado: ${MontoPagado} | Estado: {Estado}";
        }
    }
}
