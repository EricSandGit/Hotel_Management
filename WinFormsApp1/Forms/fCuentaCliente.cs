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
            if (cbEstadia.SelectedItem is Estadia estadia)
            {
                // 2. Obtenemos los subtotales llamando al controlador (Capa de Negocio)
                double totalHabitacion = nCuenta.CalcularSubtotalHabitacion(estadia.IdEstadia);
                double totalGastosExtras = nCuenta.CalcularSubtotalGastos(estadia.IdEstadia);

                // 3. Mostramos los datos directamente en tus etiquetas
                lbCostoEstadia.Text = totalHabitacion.ToString("C2");
                lbCostoExtras.Text = totalGastosExtras.ToString("C2");
            }
        }
    }
}
