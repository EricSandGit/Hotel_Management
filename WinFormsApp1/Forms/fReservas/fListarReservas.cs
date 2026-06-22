using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fReservas
{
    public partial class fListarReservas : Form
    {
        public fListarReservas()
        {
            InitializeComponent();
            
        }

        private void fListarReservas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgListarReservas.DataSource = null;
            dgListarReservas.DataSource = nReserva.ListarReservas();
        }

        private void btAgregarLReserva_Click(object sender, EventArgs e)
        {
            fAltaReserva altaReserva = new fAltaReserva();

            if (altaReserva.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }
        }

        private void btEliminarLReserva_Click(object sender, EventArgs e)
        {
            if (dgListarReservas.SelectedRows.Count > 0)
            {
                Reserva reservaSeleccionado = (Reserva)dgListarReservas.SelectedRows[0].DataBoundItem;

                fReservasEliminar baja = new fReservasEliminar(reservaSeleccionado.IdReserva);

                baja.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btModificarLReserva_Click(object sender, EventArgs e)
        {
            if (dgListarReservas.SelectedRows.Count > 0)
            {
                Reserva reservaSeleccionado = (Reserva)dgListarReservas.SelectedRows[0].DataBoundItem;

                fModificarReserva modificar = new fModificarReserva(reservaSeleccionado);

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCheckInLReserva_Click(object sender, EventArgs e)
        {
            if (dgListarReservas.SelectedRows.Count > 0)
            {
                Reserva reservaSeleccionada = (Reserva)dgListarReservas.SelectedRows[0].DataBoundItem;

                if (reservaSeleccionada.Estado.Equals("pendiente", StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult result = MessageBox.Show($"¿Desea registrar el Check-In para la reserva #{reservaSeleccionada.IdReserva}?", "Confirmar Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool exito = nEstadia.RegistrarCheckIn(reservaSeleccionada);

                        if (exito)
                        {
                            MessageBox.Show("Check-In registrado con éxito. La estadía ya está activa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el Check-In. Verifique los datos o la capacidad de la habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Solo se puede hacer Check-In a reservas en estado 'pendiente'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCheckOutLReserva_Click(object sender, EventArgs e)
        {
            if (dgListarReservas.SelectedRows.Count > 0)
            {
                Reserva reservaSeleccionada = (Reserva)dgListarReservas.SelectedRows[0].DataBoundItem;

                if (reservaSeleccionada.Estado.Equals("confirmada", StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult result = MessageBox.Show($"¿Desea registrar el Check-Out para la reserva #{reservaSeleccionada.IdReserva}?", "Confirmar Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Buscar la estadía activa para esta reserva
                        Estadia estadiaActiva = nEstadia.ListarEstadias()
                            .Find(est => est.IdReserva == reservaSeleccionada.IdReserva &&
                                         string.Equals(est.Estado, "activa", StringComparison.OrdinalIgnoreCase));

                        if (estadiaActiva != null)
                        {
                            bool exito = nEstadia.RegistrarCheckOut(estadiaActiva.IdEstadia);

                            if (exito)
                            {
                                MessageBox.Show("Check-Out registrado con éxito. Se ha generado la cuenta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar el Check-Out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna estadía activa asociada a esta reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Solo se puede hacer Check-Out a reservas en estado 'confirmada'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgListarReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
