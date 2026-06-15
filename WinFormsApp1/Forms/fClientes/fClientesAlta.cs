using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            // Armamos el objeto con lo que el usuario escribió en los textboxes
            ClienteNuevo = new Cliente
            {
                Nombre = textBox1.Text,
                Apellido = textBox2.Text,
                Dni = textBox3.Text,
                Telefono = textBox4.Text,
                Email = textBox5.Text,
                Localidad = textBox6.Text
            };

            // Le avisamos al sistema que la operación fue un éxito (OK)
            this.DialogResult = DialogResult.OK;

            // Cerramos la ventana de Alta
            this.Close();
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

