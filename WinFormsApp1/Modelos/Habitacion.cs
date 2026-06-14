using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public int CamasIndividuales { get; set; }
        public int CamasMatrimoniales { get; set; }
        public double PrecioPorNoche { get; set; }

        public Habitacion() { }

        public Habitacion(int idHabitacion, int numero, int camasIndividuales, int camasMatrimoniales, double precioPorNoche)
        {
            IdHabitacion = idHabitacion;
            Numero = numero;
            CamasIndividuales = camasIndividuales;
            CamasMatrimoniales = camasMatrimoniales;
            PrecioPorNoche = precioPorNoche;
        }

        public override string ToString()
        {
            return $"Habitación {Numero} | Camas Ind: {CamasIndividuales}, Mat: {CamasMatrimoniales} | Precio: ${PrecioPorNoche}";
        }
    }
}
