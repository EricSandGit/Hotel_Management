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

                var moneda = new System.Globalization.CultureInfo("es-AR");


                dgCuenta.DataSource = new List<object>
        {
            new {
                IdEstadia = estadiaSeleccionada.IdEstadia,
                CostoHabitacion = totalHabitacion.ToString("C2", moneda),
                GastosExtras = totalGastosExtras.ToString("C2", moneda),
                TotalGeneral = (totalHabitacion + totalGastosExtras).ToString("C2", moneda)
            }
        };

                dgCuenta.AllowUserToAddRows = false;
            }
            else
            {
                dgCuenta.DataSource = null;
            }
        }



    }
}
