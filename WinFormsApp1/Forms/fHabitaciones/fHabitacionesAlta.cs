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
    public partial class fHabitacionesAlta : Form
    {

        public Habitacion HabitacionNueva { get; private set; }
        public fHabitacionesAlta()
        {
            InitializeComponent();
        }

        private void fHabitacionesAlta_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNumero.Text, out int numero) ||
                !int.TryParse(textBoxCamasIndividuales.Text, out int camasInd) ||
                !int.TryParse(textBoxCamasMatrimoniales.Text, out int camasMat) ||
                !double.TryParse(textBoxPrecioPorNoche.Text, out double precio))
            {
                MessageBox.Show("Revisá que Número, Camas y Precio sean valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HabitacionNueva = new Habitacion
            {
                Numero = numero,
                CamasIndividuales = camasInd,
                CamasMatrimoniales = camasMat,
                PrecioPorNoche = precio
            };

            bool exito = nHabitacion.CrearHabitacion(HabitacionNueva);

            if (!exito)
            {
                MessageBox.Show("No se pudo guardar la habitación. Verificá que el número no esté repetido y que haya al menos una cama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
