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
        private int _idClienteAEliminar;

        // 2. Modificamos esta línea agregando "int idCliente" adentro de los paréntesis
        public fClientesEliminar(int idCliente)
        {
            InitializeComponent();

            // 3. Guardamos el ID que nos llega en nuestra variable
            _idClienteAEliminar = idCliente;
        }
        

        private void btNoVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSiEstoySeguro_Click(object sender, EventArgs e)
        {
            bool exito = nCliente.EliminarCliente(_idClienteAEliminar);

            if (!exito)
            {
                MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}

