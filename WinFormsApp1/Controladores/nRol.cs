using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Controladores
{
    internal class nRol
    {
        private static readonly pRol persistencia = new pRol();

        public static List<Rol> ListarRoles() => persistencia.ObtenerTodos();

        public static Rol ObtenerRolPorId(int id) => persistencia.ObtenerPorId(id);
    }
}
