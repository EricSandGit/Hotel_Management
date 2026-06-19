using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelos;
using WinFormsApp1.Controladores;

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
            dgListarReservas.DataSource = null;
            dgListarReservas.DataSource = nReserva.ListarReservas();
        }

        

        

        private void btAgregarLReserva_Click(object sender, EventArgs e)
        {
            fAltaReserva altaReserva = new fAltaReserva();

            if(altaReserva.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla();
            }
            
        }
    }
}

