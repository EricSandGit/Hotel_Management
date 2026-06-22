using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fUsuarios
{
    public partial class fListarUsuarios : Form
    {
        public fListarUsuarios()
        {
            InitializeComponent();
        }

        private void ActualizarGrilla()
        {
            dgListarUsuarios.DataSource = null;
            dgListarUsuarios.DataSource = nUsuario.ListarUsuarios();
        }

        private void fListarUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAgregarUsuario_Click(object sender, EventArgs e)
        {
            fAltaUsuarios alta = new fAltaUsuarios();

            if (alta.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }
        }

        private void btEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgListarUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dgListarUsuarios.SelectedRows[0].DataBoundItem;
                fEliminarUsuarios baja = new fEliminarUsuarios(usuarioSeleccionado.IdUsuario);

                baja.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un usuario de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgListarUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dgListarUsuarios.SelectedRows[0].DataBoundItem;
                fModificarUsuarios modificar = new fModificarUsuarios(usuarioSeleccionado);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un usuario de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}