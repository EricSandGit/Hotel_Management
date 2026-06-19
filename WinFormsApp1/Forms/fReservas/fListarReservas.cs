using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelos;
using WinFormsApp1.Controladores;
using System.Linq;

namespace WinFormsApp1.Forms.fReservas
{
    public partial class fListarReservas : Form
    {

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
            var reservas = nReserva.ListarReservas();
            var clientes = nCliente.ListarClientes();

            var reservasConCliente = from r in reservas
                                     join c in clientes on r.IdCliente equals c.IdCliente
                                     select new
                                     {
                                         IdReserva = r.IdReserva,
                                         Cliente = $"{c.Apellido}, {c.Nombre}",
                                         IdHabitacion = r.IdHabitacion,
                                         FechaEntrada = r.FechaEntrada,
                                         FechaSalida = r.FechaSalida,
                                         CantidadPersonas = r.CantidadPersonas,
                                         Estado = r.Estado
                                     };

            dgListarReservas.DataSource = null;
            dgListarReservas.DataSource = reservasConCliente.ToList();
        }





        private void btAgregarLReserva_Click(object sender, EventArgs e)
        {
            fAltaReserva altaReserva = new fAltaReserva();

            if (altaReserva.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgListarReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

