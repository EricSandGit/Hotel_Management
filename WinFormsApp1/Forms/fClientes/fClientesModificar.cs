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
        private Cliente clienteAEditar;

        public fClientesModificar(Cliente cliente)
        {
            InitializeComponent();
            clienteAEditar = cliente;
           
        }

        

        private void fClientesModificar_Load(object sender, EventArgs e)
        {
            // Cargamos los datos actuales en los textbox
            textBox1.Text = clienteAEditar.Nombre;
            textBox2.Text = clienteAEditar.Apellido;
            textBox3.Text = clienteAEditar.Dni;
            textBox4.Text = clienteAEditar.Telefono;
            textBox5.Text = clienteAEditar.Email;
            textBox6.Text = clienteAEditar.Localidad;
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
                IdCliente = clienteAEditar.IdCliente,
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

            clienteAEditar.Nombre = clienteModificado.Nombre;
            clienteAEditar.Apellido = clienteModificado.Apellido;
            clienteAEditar.Dni = clienteModificado.Dni;
            clienteAEditar.Telefono = clienteModificado.Telefono;
            clienteAEditar.Email = clienteModificado.Email;
            clienteAEditar.Localidad = clienteModificado.Localidad;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

