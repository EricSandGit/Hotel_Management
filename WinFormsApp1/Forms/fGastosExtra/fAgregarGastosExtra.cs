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

namespace WinFormsApp1.Forms.fGastosExtra
{
    public partial class fAgregarGastosExtra : Form
    {
        public fAgregarGastosExtra()
        {
            InitializeComponent();
            
            // Cargar estadías activas al inicializar
            var estadiasActivas = nEstadia.ListarEstadias()
                .Where(e => string.Equals(e.Estado, "activa", StringComparison.OrdinalIgnoreCase))
                .ToList();
            
            cbEstadia.DataSource = estadiasActivas;
            cbEstadia.ValueMember = "IdEstadia";
            cbEstadia.DisplayMember = "ToString";
            
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 1000000;
        }

        private void btGuardarGE_Click(object sender, EventArgs e)
        {
            if (cbEstadia.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una estadía.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbConcepto.Text))
            {
                MessageBox.Show("Por favor, ingrese un concepto para el gasto extra.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("El monto del gasto extra debe ser mayor a 0.", "Monto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoGasto = new GastoExtra
            {
                IdEstadia = Convert.ToInt32(cbEstadia.SelectedValue),
                Concepto = tbConcepto.Text.Trim(),
                Monto = Convert.ToDouble(numericUpDown1.Value),
                Fecha = dateTimePicker1.Value
            };

            bool exito = nGastoExtra.CrearGasto(nuevoGasto);
            if (!exito)
            {
                MessageBox.Show("No se pudo registrar el gasto extra. Verifique que la estadía esté activa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelarGE_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
