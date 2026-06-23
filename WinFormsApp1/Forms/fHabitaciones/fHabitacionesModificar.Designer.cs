namespace WinFormsApp1.Forms.fHabitaciones
{
    partial class fHabitacionesModificar
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
            btGuardar = new Button();
            lbPrecioPorNoche = new Label();
            textBox4 = new TextBox();
            lbCamasMatrimoniales = new Label();
            textBox3 = new TextBox();
            lbCamasIndividuales = new Label();
            lbNumero = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(30, 30, 30);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = SystemColors.ButtonHighlight;
            btCancelar.Location = new Point(418, 275);
            btCancelar.Margin = new Padding(1);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(118, 28);
            btCancelar.TabIndex = 39;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.FromArgb(30, 30, 30);
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.ForeColor = SystemColors.ButtonHighlight;
            btGuardar.Location = new Point(160, 275);
            btGuardar.Margin = new Padding(1);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(118, 28);
            btGuardar.TabIndex = 38;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbPrecioPorNoche
            // 
            lbPrecioPorNoche.AutoSize = true;
            lbPrecioPorNoche.Location = new Point(159, 183);
            lbPrecioPorNoche.Margin = new Padding(1, 0, 1, 0);
            lbPrecioPorNoche.Name = "lbPrecioPorNoche";
            lbPrecioPorNoche.Size = new Size(93, 15);
            lbPrecioPorNoche.TabIndex = 37;
            lbPrecioPorNoche.Text = "PrecioPorNoche";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 181);
            textBox4.Margin = new Padding(1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 36;
            // 
            // lbCamasMatrimoniales
            // 
            lbCamasMatrimoniales.AutoSize = true;
            lbCamasMatrimoniales.Location = new Point(134, 139);
            lbCamasMatrimoniales.Margin = new Padding(1, 0, 1, 0);
            lbCamasMatrimoniales.Name = "lbCamasMatrimoniales";
            lbCamasMatrimoniales.Size = new Size(119, 15);
            lbCamasMatrimoniales.TabIndex = 35;
            lbCamasMatrimoniales.Text = "CamasMatrimoniales";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 138);
            textBox3.Margin = new Padding(1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 34;
            // 
            // lbCamasIndividuales
            // 
            lbCamasIndividuales.AutoSize = true;
            lbCamasIndividuales.Location = new Point(147, 95);
            lbCamasIndividuales.Margin = new Padding(1, 0, 1, 0);
            lbCamasIndividuales.Name = "lbCamasIndividuales";
            lbCamasIndividuales.Size = new Size(106, 15);
            lbCamasIndividuales.TabIndex = 33;
            lbCamasIndividuales.Text = "CamasIndividuales";
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(203, 55);
            lbNumero.Margin = new Padding(1, 0, 1, 0);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 32;
            lbNumero.Text = "Numero";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 93);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 55);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 30;
            // 
            // fHabitacionesModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(670, 358);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(lbPrecioPorNoche);
            Controls.Add(textBox4);
            Controls.Add(lbCamasMatrimoniales);
            Controls.Add(textBox3);
            Controls.Add(lbCamasIndividuales);
            Controls.Add(lbNumero);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "fHabitacionesModificar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fHabitacionesModificar";
            Load += fHabitacionesModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btGuardar;
        private Label lbPrecioPorNoche;
        private TextBox textBox4;
        private Label lbCamasMatrimoniales;
        private TextBox textBox3;
        private Label lbCamasIndividuales;
        private Label lbNumero;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}