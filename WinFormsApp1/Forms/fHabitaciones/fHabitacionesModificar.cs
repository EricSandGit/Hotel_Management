using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fHabitaciones
{
    public partial class fHabitacionesModificar : Form
    {

        private Habitacion _habitacionAEditar;

        public fHabitacionesModificar(Habitacion habitacion)
        {
            InitializeComponent();
            _habitacionAEditar = habitacion;
        }

        private void fHabitacionesModificar_Load(object sender, EventArgs e)
        {
            textBox1.Text = _habitacionAEditar.Numero.ToString();
            textBox2.Text = _habitacionAEditar.CamasIndividuales.ToString();
            textBox3.Text = _habitacionAEditar.CamasMatrimoniales.ToString();
            textBox4.Text = _habitacionAEditar.PrecioPorNoche.ToString();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int numero) ||
               !int.TryParse(textBox2.Text, out int camasInd) ||
               !int.TryParse(textBox3.Text, out int camasMat) ||
               !double.TryParse(textBox4.Text, out double precio))
            {
                MessageBox.Show("Revisá que Número, Camas y Precio sean valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _habitacionAEditar.Numero = numero;
            _habitacionAEditar.CamasIndividuales = camasInd;
            _habitacionAEditar.CamasMatrimoniales = camasMat;
            _habitacionAEditar.PrecioPorNoche = precio;

            bool exito = nHabitacion.ActualizarHabitacion(_habitacionAEditar);

            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar la habitación. Verificá los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
