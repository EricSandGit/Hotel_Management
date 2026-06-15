using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nCliente
    {
        private static readonly pCliente persistencia = new pCliente();

        // Consulta de todos los clientes
        public static List<Cliente> ListarClientes() => persistencia.ObtenerTodos();

        // Consulta por id
        public static Cliente ObtenerClientePorId(int id) => persistencia.ObtenerPorId(id);

        // Consulta por documento (búsqueda en memoria de acuerdo al IRepositorio y pCliente existentes)
        public static Cliente BuscarPorDocumento(string nroDoc)
        {
            if (string.IsNullOrEmpty(nroDoc)) return null;
            return persistencia.ObtenerTodos().Find(c => c.Dni == nroDoc);
        }

        private static bool ValidarDatosObligatorios(Cliente c)
        {
            return !string.IsNullOrWhiteSpace(c.Dni) &&
                   !string.IsNullOrWhiteSpace(c.Nombre) &&
                   !string.IsNullOrWhiteSpace(c.Apellido) &&
                   !string.IsNullOrWhiteSpace(c.Telefono) &&
                   !string.IsNullOrWhiteSpace(c.Email) &&
                   !string.IsNullOrWhiteSpace(c.Localidad);
        }

        // Alta de cliente con validaciones obligatorias y de duplicados
        public static bool AgregarCliente(Cliente c)
        {
            if (c == null || !ValidarDatosObligatorios(c)) return false;

            // Evitar duplicados de documento
            if (BuscarPorDocumento(c.Dni) != null)
                return false;

            int id = persistencia.Agregar(c);
            return id > 0;
        }

        // Modificación de cliente con validaciones
        public static bool ActualizarCliente(Cliente c)
        {
            if (c == null || !ValidarDatosObligatorios(c)) return false;

            // Evitar duplicados de documento en otros registros
            var existente = BuscarPorDocumento(c.Dni);
            if (existente != null && existente.Id != c.Id)
                return false;

            return persistencia.Actualizar(c);
        }

        // Método guardar unificado para backward compatibility
        public static bool GuardarCliente(Cliente c)
        {
            if (c == null) return false;
            if (c.Id <= 0)
                return AgregarCliente(c);
            return ActualizarCliente(c);
        }

        // Baja de cliente
        public static bool EliminarCliente(int id) => persistencia.Eliminar(id);
    }
}
