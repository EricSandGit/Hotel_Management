using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    internal class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public Rol() { }

        public Rol(int idRol, string nombre, string? descripcion)
        {
            IdRol = idRol;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"[{IdRol}] {Nombre}";
        }
    }
}
