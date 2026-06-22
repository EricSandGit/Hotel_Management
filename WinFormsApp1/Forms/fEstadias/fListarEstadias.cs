using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Forms.fReservas;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fEstadias
{
    public partial class fListarEstadias : Form
    {
        public fListarEstadias()
        {
            InitializeComponent();
        }



        private void ActualizarGrilla()
        {
            dgListarEstadias.DataSource = null;
            dgListarEstadias.DataSource = nEstadia.ListarEstadias();
        }

        private void fListarEstadias_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btEliminarEstadia_Click(object sender, EventArgs e)
        {
            if (dgListarEstadias.SelectedRows.Count > 0)
            {
                Estadia estadiaSeleccionada = (Estadia)dgListarEstadias.SelectedRows[0].DataBoundItem;

                fEstadiaEliminar Baja = new fEstadiaEliminar(estadiaSeleccionada.IdEstadia);

                Baja.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una estadia de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btModificarEstadia_Click(object sender, EventArgs e)
        {
            if (dgListarEstadias.SelectedRows.Count > 0)
            {
                Estadia estadiaSeleccionada = (Estadia)dgListarEstadias.SelectedRows[0].DataBoundItem;

                fModificarEstadia Modificar = new fModificarEstadia(estadiaSeleccionada);

                if (Modificar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una estadia de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
