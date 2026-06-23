using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms
{

    public partial class fCuentaCliente : Form
    {

        public fCuentaCliente()
        {
            InitializeComponent();
        }

        private void fCuentaCliente_Load(object sender, EventArgs e)
        {
            List<Estadia> listaEstadia = nEstadia.ListarEstadias();

            cbEstadia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadia.DataSource = listaEstadia;
            cbEstadia.DisplayMember = "IdEstadia";
            cbEstadia.ValueMember = "IdEstadia";
        }

        private void cbEstadia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            Estadia estadiaSeleccionada = (Estadia)cbEstadia.SelectedItem;

            if (estadiaSeleccionada != null)
            {
                double totalHabitacion = nCuenta.CalcularSubtotalHabitacion(estadiaSeleccionada.IdEstadia);
                double totalGastosExtras = nCuenta.CalcularSubtotalGastos(estadiaSeleccionada.IdEstadia);

                // Buscar si ya existe la cuenta en la DB
                Cuenta cuentaAsociada = nCuenta.ListarCuentas().Find(c => c.IdEstadia == estadiaSeleccionada.IdEstadia);
                string estadoPago = cuentaAsociada != null ? cuentaAsociada.Estado : "pendiente";

                var moneda = new System.Globalization.CultureInfo("es-AR");

                dgCuenta.DataSource = new List<object>
                {
                    new {
                        IdEstadia = estadiaSeleccionada.IdEstadia,
                        CostoHabitacion = totalHabitacion.ToString("C2", moneda),
                        GastosExtras = totalGastosExtras.ToString("C2", moneda),
                        TotalGeneral = (totalHabitacion + totalGastosExtras).ToString("C2", moneda),
                        Estado = estadoPago.ToUpper()
                    }
                };

                dgCuenta.AllowUserToAddRows = false;
            }
            else
            {
                dgCuenta.DataSource = null;
            }
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            Estadia estadiaSeleccionada = (Estadia)cbEstadia.SelectedItem;
            if (estadiaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una estadía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar si ya existe la cuenta en la DB
            Cuenta cuentaAsociada = nCuenta.ListarCuentas().Find(c => c.IdEstadia == estadiaSeleccionada.IdEstadia);

            if (cuentaAsociada == null)
            {
                // Si no existe, la generamos automáticamente para poder cambiar su estado
                bool generada = nCuenta.GenerarCuenta(estadiaSeleccionada.IdEstadia);
                if (generada)
                {
                    cuentaAsociada = nCuenta.ListarCuentas().Find(c => c.IdEstadia == estadiaSeleccionada.IdEstadia);
                }

                if (cuentaAsociada == null)
                {
                    MessageBox.Show("No se pudo generar la cuenta para la estadía seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (cuentaAsociada.Estado.ToLower() == "pagada")
            {
                MessageBox.Show("Esta cuenta ya está pagada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cambiar el estado de la cuenta a "pagada"
            cuentaAsociada.Estado = "pagada";
            cuentaAsociada.MontoPagado = cuentaAsociada.TotalGeneral;

            bool exito = nCuenta.ActualizarCuenta(cuentaAsociada);
            if (exito)
            {
                MessageBox.Show("La cuenta ha sido pagada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el estado de la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
