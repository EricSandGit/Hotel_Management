namespace WinFormsApp1.Forms.fReservas
{
    partial class fModificarReserva
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
            btCancelar = new Button();
            btResAceptar = new Button();
            label6 = new Label();
            label5 = new Label();
            numResMenores = new NumericUpDown();
            numResAdultos = new NumericUpDown();
            cbResCliente = new ComboBox();
            cbResHabitaciones = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtResSalida = new DateTimePicker();
            dtResLlegada = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numResMenores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResAdultos).BeginInit();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(431, 393);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(137, 34);
            btCancelar.TabIndex = 33;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btResAceptar
            // 
            btResAceptar.Location = new Point(234, 393);
            btResAceptar.Name = "btResAceptar";
            btResAceptar.Size = new Size(137, 34);
            btResAceptar.TabIndex = 32;
            btResAceptar.Text = "Aceptar";
            btResAceptar.UseVisualStyleBackColor = true;
            btResAceptar.Click += btResAceptar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(597, 123);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 31;
            label6.Text = "Menores";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 24);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 30;
            label5.Text = "Adultos";
            // 
            // numResMenores
            // 
            numResMenores.Location = new Point(597, 163);
            numResMenores.Name = "numResMenores";
            numResMenores.Size = new Size(180, 31);
            numResMenores.TabIndex = 29;
            // 
            // numResAdultos
            // 
            numResAdultos.Location = new Point(597, 64);
            numResAdultos.Name = "numResAdultos";
            numResAdultos.Size = new Size(180, 31);
            numResAdultos.TabIndex = 28;
            // 
            // cbResCliente
            // 
            cbResCliente.FormattingEnabled = true;
            cbResCliente.Location = new Point(23, 62);
            cbResCliente.Name = "cbResCliente";
            cbResCliente.Size = new Size(182, 33);
            cbResCliente.TabIndex = 27;
            // 
            // cbResHabitaciones
            // 
            cbResHabitaciones.FormattingEnabled = true;
            cbResHabitaciones.Location = new Point(25, 162);
            cbResHabitaciones.Name = "cbResHabitaciones";
            cbResHabitaciones.Size = new Size(182, 33);
            cbResHabitaciones.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 24);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 25;
            label4.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 123);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 24;
            label3.Text = "Salida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 23;
            label2.Text = "Llegada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 123);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 22;
            label1.Text = "Habitaciones";
            // 
            // dtResSalida
            // 
            dtResSalida.Location = new Point(234, 162);
            dtResSalida.Name = "dtResSalida";
            dtResSalida.Size = new Size(334, 31);
            dtResSalida.TabIndex = 20;
            // 
            // dtResLlegada
            // 
            dtResLlegada.Location = new Point(234, 64);
            dtResLlegada.Name = "dtResLlegada";
            dtResLlegada.Size = new Size(334, 31);
            dtResLlegada.TabIndex = 19;
            // 
            // fModificarReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "fModificarReserva";
            Text = "fModificarReserva";
            Load += fModificarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numResMenores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResAdultos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btCancelar;
        private Button btResAceptar;
        private Label label6;
        private Label label5;
        private NumericUpDown numResMenores;
        private NumericUpDown numResAdultos;
        private ComboBox cbResCliente;
        private ComboBox cbResHabitaciones;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtResSalida;
        private DateTimePicker dtResLlegada;
    }
}