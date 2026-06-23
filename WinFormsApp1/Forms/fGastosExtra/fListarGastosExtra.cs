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
using WinFormsApp1.Forms.fGastosExtra;

namespace WinFormsApp1.Forms
{
    public partial class FGastosExtra : Form
    {
        public FGastosExtra()
        {
            InitializeComponent();
        }

        private void fGastosExtra_Load(object sender, EventArgs e)
        {
            List<Estadia> listaEstadia = nEstadia.ListarEstadias();

            cbEstadias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadias.DataSource = listaEstadia;
            cbEstadias.DisplayMember = "IdEstadia";
            cbEstadias.ValueMember = "IdEstadia";
        }

        private void cbEstadias_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarGrilla()
        {
            Estadia seleccionarEstadia = (Estadia)cbEstadias.SelectedItem;
            if (seleccionarEstadia != null)
            {
                List<GastoExtra> todosLosGastos = nGastoExtra.ListarGastos();
                List<GastoExtra> gastosFiltrados = todosLosGastos.Where(g => g.IdEstadia == seleccionarEstadia.IdEstadia).ToList();
                dgGastosExtra.DataSource = null;
                dgGastosExtra.DataSource = gastosFiltrados;

                dgGastosExtra.Columns["Monto"].DefaultCellStyle.Format = "C2";
                dgGastosExtra.Columns["Monto"].DefaultCellStyle.FormatProvider =
                    new System.Globalization.CultureInfo("es-AR");
            }
            else
            {
                dgGastosExtra.DataSource = null;
            }
        }

        private void cbEstadias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAgregarGE_Click(object sender, EventArgs e)
        {
            fAgregarGastosExtra alta = new fAgregarGastosExtra();
            if (alta.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }
        }

        private void dgGastosExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btEliminarGE_Click(object sender, EventArgs e)
        {
            if (dgGastosExtra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un gasto extra para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el gasto seleccionado
            GastoExtra gastoSeleccionado = (GastoExtra)dgGastosExtra.SelectedRows[0].DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar el gasto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                nGastoExtra.EliminarGasto(gastoSeleccionado.IdGasto);
                ActualizarGrilla();
            }
        }
    }
}
