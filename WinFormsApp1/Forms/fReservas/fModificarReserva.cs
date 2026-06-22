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
    public partial class fModificarReserva : Form
    {

        private Reserva reservaAModificar;

        public fModificarReserva(Reserva reserva)
        {
            InitializeComponent();
            reservaAModificar = reserva;
        }

        private void fModificarReserva_Load(object sender, EventArgs e)
        {
          
            var listaClientes = nCliente.ListarClientes();
            var clientesParaElCb = listaClientes.Select(c => new
            {
                Id = c.IdCliente,
                NombreVisible = $"{c.Apellido}, {c.Nombre} (DNI: {c.Dni})"
            }).ToList();

            cbResCliente.DataSource = clientesParaElCb;
            cbResCliente.ValueMember = "Id";
            cbResCliente.DisplayMember = "NombreVisible";
            cbResCliente.SelectedValue = reservaAModificar.IdCliente;

            var listaHabitaciones = nHabitacion.ListarHabitaciones();
            cbResHabitaciones.DataSource = listaHabitaciones;
            cbResHabitaciones.ValueMember = "IdHabitacion";
            cbResHabitaciones.DisplayMember = "Numero";
            cbResHabitaciones.SelectedValue = reservaAModificar.IdHabitacion;

           
            dtResLlegada.Value = reservaAModificar.FechaEntrada;
            dtResSalida.Value = reservaAModificar.FechaSalida;
            numResAdultos.Value = reservaAModificar.CantidadPersonas;
            numResMenores.Value = 0;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btResAceptar_Click(object sender, EventArgs e)
        {
            if (cbResCliente.SelectedValue == null || cbResHabitaciones.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente y una habitación.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reservaModificada = new Reserva
            {
                IdReserva = reservaAModificar.IdReserva,
                IdCliente = Convert.ToInt32(cbResCliente.SelectedValue),
                IdHabitacion = Convert.ToInt32(cbResHabitaciones.SelectedValue),
                IdUsuario = reservaAModificar.IdUsuario,
                FechaEntrada = dtResLlegada.Value.Date,
                FechaSalida = dtResSalida.Value.Date,
                CantidadPersonas = (int)numResAdultos.Value + (int)numResMenores.Value,
                Estado = reservaAModificar.Estado
            };

            bool exito = nReserva.ActualizarReserva(reservaModificada);
            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar la reserva. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reservaAModificar.IdCliente = reservaModificada.IdCliente;
            reservaAModificar.IdHabitacion = reservaModificada.IdHabitacion;
            reservaAModificar.FechaEntrada = reservaModificada.FechaEntrada;
            reservaAModificar.FechaSalida = reservaModificada.FechaSalida;
            reservaAModificar.CantidadPersonas = reservaModificada.CantidadPersonas;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

