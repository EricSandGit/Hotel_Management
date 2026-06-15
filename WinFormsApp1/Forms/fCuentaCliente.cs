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
        pEstadia repoEstadia = new pEstadia();
        public fCuentaCliente()
        {
            InitializeComponent();
        }

        private void fCuentaCliente_Load(object sender, EventArgs e)
        {
            List<Estadia> listaEstadia = repoEstadia.ObtenerTodos();

            cbEstadia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadia.DataSource = listaEstadia;
            cbEstadia.DisplayMember = "IdEstadia";
            cbEstadia.ValueMember = "IdEstadia";
        }

        private void cbEstadia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstadia.SelectedItem is Estadia estadia)
            {
                // 2. Calculamos el valor de la habitación en una sola línea
                var reserva = new pReserva().ObtenerPorId(estadia.IdReserva);
                var habitacion = new pHabitacion().ObtenerPorId(reserva.IdHabitacion);

                // Calculamos los días. Si da 0 (mismo día), Math.Max asegura que cobre mínimo 1 noche
                int noches = Math.Max(1, (reserva.FechaSalida - reserva.FechaEntrada).Days);
                double totalHabitacion = noches * habitacion.PrecioPorNoche;

                // 3. Calculamos la suma de gastos extras con LINQ en una sola línea
                double totalGastosExtras = nGastoExtra.ListarGastos()
                    .Where(g => g.IdEstadia == estadia.IdEstadia)
                    .Sum(g => g.Monto);

                // 4. Mostramos los datos directamente en tus etiquetas
                lbCostoEstadia.Text = totalHabitacion.ToString("C2");
                lbCostoExtras.Text = totalGastosExtras.ToString("C2");
            }
        }
    }
}
