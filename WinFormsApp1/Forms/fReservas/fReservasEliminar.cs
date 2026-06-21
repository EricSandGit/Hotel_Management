using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;

namespace WinFormsApp1.Forms.fReservas
{
    public partial class fReservasEliminar : Form
    {

        private int idReservaAEliminar;
        public fReservasEliminar(int idReserva)
        {
            InitializeComponent();

            idReservaAEliminar = idReserva;


        }




        private void btEliminar_Click(object sender, EventArgs e)
        {
            bool exito = nReserva.EliminarReserva(idReservaAEliminar);

            if (!exito)
            {
                MessageBox.Show("No se pudo eliminar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
