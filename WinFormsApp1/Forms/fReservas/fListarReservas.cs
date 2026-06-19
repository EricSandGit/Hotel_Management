using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fReservas
{
    public partial class fListarReservas : Form
    {
        private List<Reserva> _listaLocalReservas = new List<Reserva>();
        public fListarReservas()
        {
            InitializeComponent();
            this.Load += fListarReservas_Load;
        }

        private void fListarReservas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {
            dgListarReservas.DataSource = null;
            dgListarReservas.DataSource = _listaLocalReservas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAgregarLReserva_Click(object sender, EventArgs e)
        {
            fAltaReserva altaReserva = new fAltaReserva();

            if(altaReserva.ShowDialog() == DialogResult.OK)
            {
                _listaLocalReservas.Add(altaReserva.ReservaNueva);
                ActualizarGrilla();
            }
            
        }
    }
}
