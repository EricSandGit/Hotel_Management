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

namespace WinFormsApp1.Forms
{
    public partial class fAltaReserva : Form
    {
        public Reserva ReservaNueva { get; private set;  }

        private int idUsuarioLogueado = 1;

        public fAltaReserva()
        {
            InitializeComponent();

            dtResLlegada.MinDate = DateTime.Today;
            dtResSalida.MinDate = DateTime.Today.AddDays(1);
        }

        private void fAltaReserva_Load(object sender, EventArgs e)
        {
            
            var listaClientes = nCliente.ListarClientes();

            
            var clientesParaElCombo = listaClientes.Select(c => new
            {
                Id = c.Id,
                
                NombreVisible = $"{c.Apellido}, {c.Nombre} (DNI: {c.Dni})"
            }).ToList();

            cbResCliente.DataSource = clientesParaElCombo;
            cbResCliente.ValueMember = "Id";
            cbResCliente.DisplayMember = "NombreVisible";

            cbResCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbResCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            
            var listaHabitaciones = nHabitacion.ListarHabitaciones();
            cbResHabitaciones.DataSource = listaHabitaciones;
            cbResHabitaciones.ValueMember = "IdHabitacion";
            cbResHabitaciones.DisplayMember = "Numero";
        }

        private void dtResLlegada_ValueChanged(object sender, EventArgs e)
        {
            dtResSalida.MinDate = dtResLlegada.Value.AddDays(1);
        }

        // Lógica del botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbResCliente.SelectedValue == null || cbResHabitaciones.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente y una habitación.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidadAdultos = (int)numResAdultos.Value;
            int cantidadMenores = (int)numResMenores.Value;
            int totalPersonas = cantidadAdultos + cantidadMenores;

            if (totalPersonas == 0)
            {
                MessageBox.Show("La reserva debe tener al menos 1 persona.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reserva nuevaReserva = new Reserva
            {
                IdCliente = Convert.ToInt32(cbResCliente.SelectedValue),
                IdHabitacion = Convert.ToInt32(cbResHabitaciones.SelectedValue),
                IdUsuario = idUsuarioLogueado,
                FechaEntrada = dtResLlegada.Value.Date,
                FechaSalida = dtResSalida.Value.Date,
                CantidadPersonas = totalPersonas,
                Estado = "pendiente"
            };

            bool guardadoExitoso = nReserva.CrearReserva(nuevaReserva);

            if (guardadoExitoso)
            {
                MessageBox.Show("¡La reserva fue generada y guardada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la reserva.\n\n" +
                                "Posibles causas:\n" +
                                "- La habitación ya está ocupada en esas fechas.\n" +
                                "- La cantidad total de personas supera la capacidad de las camas.\n" +
                                "- Faltan datos obligatorios.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lógica del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}