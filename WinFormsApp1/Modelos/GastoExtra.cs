using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    public class GastoExtra
    {
        public int IdGasto { get; set; }
        public int IdEstadia { get; set; }
        public string Concepto { get; set; } = string.Empty;
        public double Monto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public GastoExtra() { }

        public GastoExtra(int idGasto, int idEstadia, string concepto, double monto, DateTime fecha)
        {
            IdGasto = idGasto;
            IdEstadia = idEstadia;
            Concepto = concepto;
            Monto = monto;
            Fecha = fecha;
        }

        public override string ToString()
        {
            return $"Gasto {IdGasto} | Estadía: {IdEstadia} | {Concepto}: ${Monto} | {Fecha:dd/MM/yyyy}";
        }
    }
}
