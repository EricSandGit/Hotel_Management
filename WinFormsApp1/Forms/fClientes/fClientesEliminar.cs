using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Forms.fClientes
{
    public partial class fClientesEliminar : Form
    {
        private int idClienteAEliminar;

        public fClientesEliminar(int idCliente)
        {
            InitializeComponent();

            idClienteAEliminar = idCliente;
        }


        private void btNoVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSiEstoySeguro_Click(object sender, EventArgs e)
        {
            bool exito = nCliente.EliminarCliente(idClienteAEliminar);

            if (!exito)
            {
                MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void fClientesEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}

