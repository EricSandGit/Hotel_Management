namespace WinFormsApp1.Forms
{
    partial class fAltaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAltaReserva));
            dtResLlegada = new DateTimePicker();
            dtResSalida = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbResHabitaciones = new ComboBox();
            cbResCliente = new ComboBox();
            numResMenores = new NumericUpDown();
            numResAdultos = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            btResAceptar = new Button();
            btCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numResMenores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResAdultos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dtResLlegada
            // 
            dtResLlegada.Location = new Point(222, 58);
            dtResLlegada.Margin = new Padding(2);
            dtResLlegada.Name = "dtResLlegada";
            dtResLlegada.Size = new Size(334, 31);
            dtResLlegada.TabIndex = 0;
            // 
            // dtResSalida
            // 
            dtResSalida.Location = new Point(222, 156);
            dtResSalida.Margin = new Padding(2);
            dtResSalida.Name = "dtResSalida";
            dtResSalida.Size = new Size(334, 31);
            dtResSalida.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 4;
            label1.Text = "Habitaciones";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 5;
            label2.Text = "Llegada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Salida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 18);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 9;
            label4.Text = "Cliente";
            // 
            // cbResHabitaciones
            // 
            cbResHabitaciones.FormattingEnabled = true;
            cbResHabitaciones.Location = new Point(14, 156);
            cbResHabitaciones.Margin = new Padding(2);
            cbResHabitaciones.Name = "cbResHabitaciones";
            cbResHabitaciones.Size = new Size(182, 33);
            cbResHabitaciones.TabIndex = 10;
            // 
            // cbResCliente
            // 
            cbResCliente.FormattingEnabled = true;
            cbResCliente.Location = new Point(12, 56);
            cbResCliente.Margin = new Padding(2);
            cbResCliente.Name = "cbResCliente";
            cbResCliente.Size = new Size(182, 33);
            cbResCliente.TabIndex = 11;
            // 
            // numResMenores
            // 
            numResMenores.Location = new Point(586, 158);
            numResMenores.Margin = new Padding(2);
            numResMenores.Name = "numResMenores";
            numResMenores.Size = new Size(180, 31);
            numResMenores.TabIndex = 13;
            // 
            // numResAdultos
            // 
            numResAdultos.Location = new Point(586, 58);
            numResAdultos.Margin = new Padding(2);
            numResAdultos.Name = "numResAdultos";
            numResAdultos.Size = new Size(180, 31);
            numResAdultos.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 14;
            label5.Text = "Adultos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(586, 118);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 15;
            label6.Text = "Menores";
            // 
            // btResAceptar
            // 
            btResAceptar.BackColor = Color.Black;
            btResAceptar.ForeColor = SystemColors.ControlLightLight;
            btResAceptar.Location = new Point(222, 267);
            btResAceptar.Margin = new Padding(2);
            btResAceptar.Name = "btResAceptar";
            btResAceptar.Size = new Size(138, 34);
            btResAceptar.TabIndex = 16;
            btResAceptar.Text = "Aceptar";
            btResAceptar.UseVisualStyleBackColor = false;
            btResAceptar.Click += btnAceptar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Black;
            btCancelar.ForeColor = SystemColors.ControlLightLight;
            btCancelar.Location = new Point(418, 267);
            btCancelar.Margin = new Padding(2);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(138, 34);
            btCancelar.TabIndex = 17;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(563, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // fAltaReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(800, 363);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btCancelar);
            Controls.Add(btResAceptar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numResMenores);
            Controls.Add(numResAdultos);
            Controls.Add(cbResCliente);
            Controls.Add(cbResHabitaciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtResSalida);
            Controls.Add(dtResLlegada);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "fAltaReserva";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fmReservas";
            Load += fAltaReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numResMenores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResAdultos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DateTimePicker dtResLlegada;
        private DateTimePicker dtResSalida;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbResHabitaciones;
        private ComboBox cbResCliente;
        private NumericUpDown numResMenores;
        private NumericUpDown numResAdultos;
        private Label label5;
        private Label label6;
        private Button btResAceptar;
        private Button btCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}