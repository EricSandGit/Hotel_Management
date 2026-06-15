using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nGastoExtra
    {
        private static readonly pGastoExtra persistencia = new pGastoExtra();

        // Consulta de todos los gastos
        public static List<GastoExtra> ListarGastos() => persistencia.ObtenerTodos();

        // Consulta por id
        public static GastoExtra ObtenerGastoPorId(int id) => persistencia.ObtenerPorId(id);

        // Alta de gasto con validaciones de negocio (concepto obligatorio, monto positivo, estadía activa)
        public static bool AgregarGasto(GastoExtra g)
        {
            if (g == null || g.IdEstadia <= 0)
                return false;

            // Validar monto positivo
            if (g.Monto <= 0)
                return false;

            // Validar concepto obligatorio
            if (string.IsNullOrEmpty(g.Concepto))
                return false;

            // Asociar correctamente el gasto a una estadía activa
            var estadia = new pEstadia().ObtenerPorId(g.IdEstadia);
            if (estadia == null || estadia.IdEstadia <= 0 || estadia.Estado != "Activa")
                return false;

            int id = persistencia.Agregar(g);
            return id > 0;
        }

        // Modificación de gasto
        public static bool ActualizarGasto(GastoExtra g)
        {
            if (g == null || g.IdGasto <= 0 || g.IdEstadia <= 0)
                return false;

            // Validar monto positivo
            if (g.Monto <= 0)
                return false;

            // Validar concepto obligatorio
            if (string.IsNullOrEmpty(g.Concepto))
                return false;

            // Verificar existencia de la estadía asociada
            var estadia = new pEstadia().ObtenerPorId(g.IdEstadia);
            if (estadia == null || estadia.IdEstadia <= 0)
                return false;

            return persistencia.Actualizar(g);
        }

        // Baja de gasto
        public static bool EliminarGasto(int id) => persistencia.Eliminar(id);
    }
}
