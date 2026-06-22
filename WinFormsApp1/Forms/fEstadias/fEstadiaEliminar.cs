using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;

namespace WinFormsApp1.Forms.fEstadias
{
    public partial class fEstadiaEliminar : Form
    {

        private int idEstadiaAEliminar;
        public fEstadiaEliminar(int idEstadia)
        {
            InitializeComponent();
            idEstadiaAEliminar = idEstadia;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (nEstadia.TieneDependencias(idEstadiaAEliminar))
            {
                MessageBox.Show(
                    "No se puede eliminar la estadía porque tiene una cuenta o gastos extras asociados.",
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                this.Close();
                return;
            }

            bool exito = nEstadia.EliminarEstadia(idEstadiaAEliminar);

            if (!exito)
            {
                MessageBox.Show("No se pudo eliminar la estadia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
