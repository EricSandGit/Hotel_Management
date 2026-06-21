using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fClientes
{
    public partial class fClientesModificar : Form
    {
        private Cliente _clienteAEditar;

        public fClientesModificar(Cliente cliente)
        {
            InitializeComponent();
            _clienteAEditar = cliente;
           
        }

        

        private void fClientesModificar_Load(object sender, EventArgs e)
        {
            // Cargamos los datos actuales en los textbox
            textBox1.Text = _clienteAEditar.Nombre;
            textBox2.Text = _clienteAEditar.Apellido;
            textBox3.Text = _clienteAEditar.Dni;
            textBox4.Text = _clienteAEditar.Telefono;
            textBox5.Text = _clienteAEditar.Email;
            textBox6.Text = _clienteAEditar.Localidad;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            var clienteModificado = new Cliente
            {
                IdCliente = _clienteAEditar.IdCliente,
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                Dni = textBox3.Text,
                Telefono = textBox4.Text,
                Email = textBox5.Text,
                Localidad = textBox6.Text
            };

            bool exito = nCliente.ActualizarCliente(clienteModificado);

            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar el cliente. Verificá los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _clienteAEditar.Nombre = clienteModificado.Nombre;
            _clienteAEditar.Apellido = clienteModificado.Apellido;
            _clienteAEditar.Dni = clienteModificado.Dni;
            _clienteAEditar.Telefono = clienteModificado.Telefono;
            _clienteAEditar.Email = clienteModificado.Email;
            _clienteAEditar.Localidad = clienteModificado.Localidad;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

