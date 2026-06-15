using System;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Utilidades;

namespace WinFormsApp1.Controladores
{
    public class nUsuario
    {
        private readonly pUsuario persistencia = new pUsuario();

        public Usuario Login(string username, string passwordPlano)
        {
            Usuario usuario = persistencia.BuscarPorUsername(username);
            if (usuario == null) return null;
            if (!PasswordHelper.VerifyPassword(passwordPlano, usuario.PasswordHash)) return null;
            return usuario;
        }

        public void MigrarPasswordsAHash()
        {
            var usuarios = persistencia.ObtenerTodos();
            foreach (var u in usuarios)
            {
                if (!u.PasswordHash.StartsWith("$2"))
                {
                    u.PasswordHash = PasswordHelper.HashPassword(u.PasswordHash);
                    persistencia.Actualizar(u);
                }
            }
        }

        public bool CrearUsuario(string nombre, string username, string passwordPlano, int idRol)
        {
            if (persistencia.BuscarPorUsername(username) != null)
                return false; // username ya existe

            var nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Username = username,
                PasswordHash = PasswordHelper.HashPassword(passwordPlano),
                IdRol = idRol
            };
            persistencia.Agregar(nuevoUsuario);
            return true;
        }
    }
}
