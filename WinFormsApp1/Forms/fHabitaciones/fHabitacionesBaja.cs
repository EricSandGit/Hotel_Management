using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;

namespace WinFormsApp1.Forms.fHabitaciones
{
    public partial class fHabitacionesBaja : Form
    {

        private int _idHabitacionAEliminar;
        public fHabitacionesBaja(int idHabitacion)
        {
            InitializeComponent();
            _idHabitacionAEliminar = idHabitacion;
        }

        private void btSiEstoySeguro_Click(object sender, EventArgs e)
        {
            bool exito = nHabitacion.EliminarHabitacion(_idHabitacionAEliminar);

            if (!exito)
            {
                MessageBox.Show("No se pudo eliminar la habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btNoVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
