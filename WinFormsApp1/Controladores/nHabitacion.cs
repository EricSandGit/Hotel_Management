using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nHabitacion
    {
        private static readonly pHabitacion persistencia = new pHabitacion();

        // Consulta de todas las habitaciones
        public static List<Habitacion> ListarHabitaciones() => persistencia.ObtenerTodos();

        // Consulta por id
        public static Habitacion ObtenerHabitacionPorId(int id) => persistencia.ObtenerPorId(id);

        // Calcular o validar capacidad total de camas (individuales = 1 persona, matrimoniales = 2 personas)
        public static int ObtenerCapacidadTotal(Habitacion h)
        {
            if (h == null) return 0;
            return h.CamasIndividuales + (h.CamasMatrimoniales * 2);
        }

        // Alta de habitación con validaciones de negocio e inconsistencias
        public static bool AgregarHabitacion(Habitacion h)
        {
            if (h == null) return false;

            // Validar campos obligatorios y datos consistentes
            if (h.Numero <= 0 || h.PrecioPorNoche <= 0)
                return false;

            // Validar que la cantidad de camas sea válida y que haya al menos una cama
            if (h.CamasIndividuales < 0 || h.CamasMatrimoniales < 0 || (h.CamasIndividuales + h.CamasMatrimoniales == 0))
                return false;

            // Impedir números de habitación duplicados
            var todas = ListarHabitaciones();
            if (todas.Exists(x => x.Numero == h.Numero))
                return false;

            int id = persistencia.Agregar(h);
            return id > 0;
        }

        // Modificación de habitación con validaciones
        public static bool ActualizarHabitacion(Habitacion h)
        {
            if (h == null || h.IdHabitacion <= 0) return false;

            // Validar campos obligatorios y consistencia
            if (h.Numero <= 0 || h.PrecioPorNoche <= 0)
                return false;

            // Validar que la cantidad de camas sea válida
            if (h.CamasIndividuales < 0 || h.CamasMatrimoniales < 0 || (h.CamasIndividuales + h.CamasMatrimoniales == 0))
                return false;

            // Impedir números de habitación duplicados en otros registros
            var todas = ListarHabitaciones();
            if (todas.Exists(x => x.Numero == h.Numero && x.IdHabitacion != h.IdHabitacion))
                return false;

            return persistencia.Actualizar(h);
        }

        // Guardar unificado
        public static bool GuardarHabitacion(Habitacion h)
        {
            if (h == null) return false;
            if (h.IdHabitacion <= 0)
                return AgregarHabitacion(h);
            return ActualizarHabitacion(h);
        }

        // Baja de habitación
        public static bool EliminarHabitacion(int id) => persistencia.Eliminar(id);

        // Calcular precio de la estancia por cantidad de noches
        public static double CalcularPrecio(Habitacion h, int noches)
        {
            if (h == null || noches <= 0) return 0;
            return h.PrecioPorNoche * noches;
        }
    }
}
