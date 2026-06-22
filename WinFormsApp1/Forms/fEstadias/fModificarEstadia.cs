using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fEstadias
{
    public partial class fModificarEstadia : Form
    {
        private Estadia estadiaAModificar;

        public fModificarEstadia(Estadia estadia)
        {
            InitializeComponent();
            estadiaAModificar = estadia;
        }

        private void fModificarEstadia_Load(object sender, EventArgs e)
        {
            
            var reservas = nReserva.ListarReservas();
            cbEstReserva.DataSource = reservas;
            cbEstReserva.ValueMember = "IdReserva";
            cbEstReserva.DisplayMember = "IdReserva";
            cbEstReserva.SelectedValue = estadiaAModificar.IdReserva;

           
            var usuarios = nUsuario.ListarUsuarios();
            cbEstUsuario.DataSource = usuarios;
            cbEstUsuario.ValueMember = "IdUsuario";
            cbEstUsuario.DisplayMember = "Nombre";
            cbEstUsuario.SelectedValue = estadiaAModificar.IdUsuario;

          
            dtCheckin.Value = estadiaAModificar.FechaCheckin;
            if (estadiaAModificar.FechaCheckout.HasValue)
            {
                dtCheckout.Value = estadiaAModificar.FechaCheckout.Value;
                chkCheckoutNulo.Checked = false;
                dtCheckout.Enabled = true;
                cbEstado.Enabled = true;
            }
            else
            {
                dtCheckout.Value = DateTime.Now;
                chkCheckoutNulo.Checked = true;
                dtCheckout.Enabled = false;
                cbEstado.Enabled = false;
            }

            cbEstado.SelectedItem = estadiaAModificar.Estado;
        }

        private void chkCheckoutNulo_CheckedChanged(object sender, EventArgs e)
        {
            dtCheckout.Enabled = !chkCheckoutNulo.Checked;
            if (chkCheckoutNulo.Checked)
            {
                cbEstado.SelectedItem = "activa";
                cbEstado.Enabled = false;
            }
            else
            {
                cbEstado.Enabled = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (cbEstReserva.SelectedValue == null || cbEstUsuario.SelectedValue == null || cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime? fechaCheckout = chkCheckoutNulo.Checked ? (DateTime?)null : dtCheckout.Value;

            if (fechaCheckout == null && cbEstado.SelectedItem.ToString() == "finalizada")
            {
                MessageBox.Show("No se puede finalizar la estadía si no se registra una fecha de check-out.", "Validación de estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fechaCheckout.HasValue && dtCheckin.Value >= fechaCheckout.Value)
            {
                MessageBox.Show("La fecha de check-out debe ser posterior a la fecha de check-in.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var estadiaModificada = new Estadia
            {
                IdEstadia = estadiaAModificar.IdEstadia,
                IdReserva = Convert.ToInt32(cbEstReserva.SelectedValue),
                IdUsuario = Convert.ToInt32(cbEstUsuario.SelectedValue),
                FechaCheckin = dtCheckin.Value,
                FechaCheckout = fechaCheckout,
                Estado = cbEstado.SelectedItem.ToString()
            };

            bool exito = nEstadia.ActualizarEstadia(estadiaModificada);
            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar la estadía. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            estadiaAModificar.IdReserva = estadiaModificada.IdReserva;
            estadiaAModificar.IdUsuario = estadiaModificada.IdUsuario;
            estadiaAModificar.FechaCheckin = estadiaModificada.FechaCheckin;
            estadiaAModificar.FechaCheckout = estadiaModificada.FechaCheckout;
            estadiaAModificar.Estado = estadiaModificada.Estado;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
