using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Modelos
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public Usuario() { }

        public Usuario(int idUsuario, int idRol, string nombre, string username, string passwordHash)
        {
            IdUsuario = idUsuario;
            IdRol = idRol;
            Nombre = nombre;
            Username = username;
            PasswordHash = passwordHash;
        }

        public override string ToString()
        {
            return $"[{IdUsuario}] {Nombre} ({Username})";
        }
    }
}
