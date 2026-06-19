using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;


namespace WinFormsApp1.Forms.fClientes
{
    public partial class fClientesListar : Form
    {
        private List<Cliente> _listaLocalClientes = new List<Cliente>();
        public fClientesListar()
        { 
            InitializeComponent();
            this.Load += fClientesListar_Load; // Enganchamos el evento
        }


        private void ActualizarGrilla()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = nCliente.ListarClientes(); // siempre trae lo último de la DB
        }

        private void fClientesListar_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAgregarCliente_Click(object sender, EventArgs e)
        {
            fClientesAlta Alta = new fClientesAlta();

            if (Alta.ShowDialog() == DialogResult.OK)
            {
                ActualizarGrilla(); // ya no hace falta el Add manual, se vuelve a leer de la DB
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                

                Cliente clienteSeleccionado = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;

                fClientesEliminar Baja = new fClientesEliminar(clienteSeleccionado.Id);

                Baja.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un cliente de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void btEditarCliente_Click(object sender, EventArgs e)
        {

            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                Cliente clienteSeleccionado = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;
                fClientesModificar Modificar = new fClientesModificar(clienteSeleccionado);

                if (Modificar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un cliente de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
