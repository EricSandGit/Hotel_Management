using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fHabitaciones
{
    public partial class fHabitacionesListar : Form
    {
        public fHabitacionesListar()
        {
            InitializeComponent();
            this.Load += fHabitacionesListar_Load;
        }

        private void btAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarGrilla()
        {
            dataGridViewHabitacion.DataSource = null;
            dataGridViewHabitacion.DataSource = nHabitacion.ListarHabitaciones();
        }

        private void fHabitacionesListar_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAgregarHabitacion_Click(object sender, EventArgs e)
        {
            fHabitacionesAlta Alta = new fHabitacionesAlta();
            if (Alta.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }
        }

        private void btEditarHabitacion_Click(object sender, EventArgs e)
        {
            if (dataGridViewHabitacion.SelectedRows.Count > 0)
            {
                Habitacion habSeleccionada = (Habitacion)dataGridViewHabitacion.SelectedRows[0].DataBoundItem;
                fHabitacionesModificar Modificar = new fHabitacionesModificar(habSeleccionada);

                if (Modificar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una habitación de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEliminarHabitacion_Click(object sender, EventArgs e)
        {
            if (dataGridViewHabitacion.SelectedRows.Count > 0)
            {
                Habitacion habSeleccionada = (Habitacion)dataGridViewHabitacion.SelectedRows[0].DataBoundItem;
                fHabitacionesBaja Baja = new fHabitacionesBaja(habSeleccionada.IdHabitacion);

                Baja.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná una habitación de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
