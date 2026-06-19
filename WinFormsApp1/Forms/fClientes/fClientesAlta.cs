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
    public partial class fClientesAlta : Form
    {
        public Cliente ClienteNuevo { get; private set; }

        public fClientesAlta()
        {
            InitializeComponent();
        }

        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            {
                ClienteNuevo = new Cliente
                {
                    Nombre = textBox1.Text,
                    Apellido = textBox2.Text,
                    Dni = textBox3.Text,
                    Telefono = textBox4.Text,
                    Email = textBox5.Text,
                    Localidad = textBox6.Text
                };

                bool exito = nCliente.AgregarCliente(ClienteNuevo);

                if (!exito)
                {
                    MessageBox.Show("No se pudo guardar el cliente. Verificá que todos los campos estén completos y que el documento no esté duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // no cerramos la ventana, dejamos que corrija
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

