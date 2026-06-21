using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Forms
{
    public partial class fGastosExtra : Form
    {
        
        public fGastosExtra()
        {
            InitializeComponent();
        }

        private void fGastosExtra_Load(object sender, EventArgs e)
        {
            List<Estadia> listaEstadia = nEstadia.ListarEstadias();

            cbEstadias.DropDownStyle =ComboBoxStyle.DropDownList;
            cbEstadias.DataSource = listaEstadia;
            cbEstadias.DisplayMember = "IdEstadia";
            cbEstadias.ValueMember = "IdEstadia";

        }

        private void cbEstadias_Click(object sender, EventArgs e)
        {

        }

        private void cbEstadias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estadia seleccionarEstadia = (Estadia)cbEstadias.SelectedItem;
            if (seleccionarEstadia != null)
            {

                List<GastoExtra> todosLosGastos = nGastoExtra.ListarGastos();
                List<GastoExtra> gastosFiltrados = todosLosGastos.Where(g => g.IdEstadia == seleccionarEstadia.IdEstadia).ToList();
                dgGastosExtra.DataSource = null;
                dgGastosExtra.DataSource = gastosFiltrados;

            }
        }
    }
}
