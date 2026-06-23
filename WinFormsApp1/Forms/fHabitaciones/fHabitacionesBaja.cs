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

        private int idHabitacionAEliminar;
        public fHabitacionesBaja(int idHabitacion)
        {
            InitializeComponent();
            idHabitacionAEliminar = idHabitacion;
        }

        private void btSiEstoySeguro_Click(object sender, EventArgs e)
        {
            if (nHabitacion.TieneReservasAsignadas(idHabitacionAEliminar))
            {
                MessageBox.Show(
                    "No se puede eliminar la habitación porque tiene reservas asociadas en el sistema.",
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                this.Close();
                return;
            }

            bool exito = nHabitacion.EliminarHabitacion(idHabitacionAEliminar);

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
