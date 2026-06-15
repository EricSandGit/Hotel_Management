using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Herramientas;

namespace WinFormsApp1.Controladores
{
    internal class nUsuario
    {
        private static readonly pUsuario persistencia = new pUsuario();

        // Validar autenticación
        public static Usuario Login(string username, string passwordPlano)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordPlano))
                return null;

            Usuario usuario = persistencia.BuscarPorUsername(username);
            if (usuario == null) return null;
            if (!Hash.VerifyPassword(passwordPlano, usuario.PasswordHash)) return null;
            return usuario;
        }

        // Realiza la migración única de contraseñas a BCrypt
        public static void MigrarPasswordsAHash()
        {
            var usuarios = persistencia.ObtenerTodos();
            foreach (var u in usuarios)
            {
                if (!u.PasswordHash.StartsWith("$2"))
                {
                    u.PasswordHash = Hash.HashPassword(u.PasswordHash);
                    persistencia.Actualizar(u);
                }
            }
        }

        // Crear usuario (Alta) con validaciones de datos obligatorios y duplicados
        public static bool CrearUsuario(string nombre, string username, string passwordPlano, int idRol)
        {
            // Validar datos obligatorios antes de guardar
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordPlano) || idRol <= 0)
                return false;

            // Evitar usuarios duplicados
            if (persistencia.BuscarPorUsername(username) != null)
                return false;

            var nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Username = username,
                PasswordHash = Hash.HashPassword(passwordPlano),
                IdRol = idRol
            };
            persistencia.Agregar(nuevoUsuario);
            return true;
        }

        // Modificar usuario
        public static bool ActualizarUsuario(Usuario u)
        {
            // Validar datos obligatorios
            if (u == null || u.IdUsuario <= 0 || string.IsNullOrEmpty(u.Nombre) || string.IsNullOrEmpty(u.Username) || u.IdRol <= 0)
                return false;

            // Evitar usuarios duplicados
            var existente = persistencia.BuscarPorUsername(u.Username);
            if (existente != null && existente.IdUsuario != u.IdUsuario)
                return false;

            return persistencia.Actualizar(u);
        }

        // Consulta de todos los usuarios
        public static List<Usuario> ListarUsuarios() => persistencia.ObtenerTodos();

        // Consulta de usuario por id
        public static Usuario ObtenerUsuarioPorId(int id) => persistencia.ObtenerPorId(id);

        // Eliminar usuario (Baja)
        public static bool EliminarUsuario(int id) => persistencia.Eliminar(id);
    }
}
