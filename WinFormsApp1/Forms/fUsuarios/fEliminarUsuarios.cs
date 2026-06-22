using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;

namespace WinFormsApp1.Forms.fUsuarios
{
    public partial class fEliminarUsuarios : Form
    {
        private int idUsuario;

        public fEliminarUsuarios(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btNoVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btSiEstoySeguro_Click(object sender, EventArgs e)
        {
            if (nUsuario.TieneAsignaciones(idUsuario))
            {
                MessageBox.Show(
                    "No se puede eliminar el usuario porque ha registrado reservas o estadías activas en el sistema.",
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            bool exito = nUsuario.EliminarUsuario(idUsuario);

            if (exito)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
    }
}