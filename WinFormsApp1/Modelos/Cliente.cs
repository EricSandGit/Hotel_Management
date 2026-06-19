using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Dni { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;

        public Cliente() { }

        public Cliente(int idCliente, string dni, string nombre, string apellido,
                       string telefono, string email, string localidad)
        {
            IdCliente = idCliente;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Localidad = localidad;
        }

        public override string ToString()
        {
            return $"[{IdCliente}] {Apellido}, {Nombre} | DNI: {Dni} | Tel: {Telefono} | Email: {Email} | Localidad: {Localidad} ";
        }
    }
}
