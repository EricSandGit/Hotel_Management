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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            _clienteAEditar.Nombre = textBox1.Text;
            _clienteAEditar.Apellido = textBox2.Text;
            _clienteAEditar.Dni = textBox3.Text;
            _clienteAEditar.Telefono = textBox4.Text;
            _clienteAEditar.Email = textBox5.Text;
            _clienteAEditar.Localidad = textBox6.Text;

            bool exito = nCliente.ActualizarCliente(_clienteAEditar);

            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar el cliente. Verificá los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
