namespace WinFormsApp1.Forms.fHabitaciones
{
    partial class fHabitacionesAlta
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
            textBoxPrecioPorNoche = new TextBox();
            lbCamasMatrimoniales = new Label();
            textBoxCamasMatrimoniales = new TextBox();
            lbCamasIndividuales = new Label();
            lbNumero = new Label();
            textBoxCamasIndividuales = new TextBox();
            textBoxNumero = new TextBox();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(30, 30, 30);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = SystemColors.ButtonHighlight;
            btCancelar.Location = new Point(411, 297);
            btCancelar.Margin = new Padding(1);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(118, 28);
            btCancelar.TabIndex = 29;
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
            btGuardar.Location = new Point(153, 297);
            btGuardar.Margin = new Padding(1);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(118, 28);
            btGuardar.TabIndex = 28;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbPrecioPorNoche
            // 
            lbPrecioPorNoche.AutoSize = true;
            lbPrecioPorNoche.Location = new Point(152, 205);
            lbPrecioPorNoche.Margin = new Padding(1, 0, 1, 0);
            lbPrecioPorNoche.Name = "lbPrecioPorNoche";
            lbPrecioPorNoche.Size = new Size(93, 15);
            lbPrecioPorNoche.TabIndex = 23;
            lbPrecioPorNoche.Text = "PrecioPorNoche";
            // 
            // textBoxPrecioPorNoche
            // 
            textBoxPrecioPorNoche.Location = new Point(261, 203);
            textBoxPrecioPorNoche.Margin = new Padding(1);
            textBoxPrecioPorNoche.Name = "textBoxPrecioPorNoche";
            textBoxPrecioPorNoche.Size = new Size(192, 23);
            textBoxPrecioPorNoche.TabIndex = 22;
            // 
            // lbCamasMatrimoniales
            // 
            lbCamasMatrimoniales.AutoSize = true;
            lbCamasMatrimoniales.Location = new Point(127, 161);
            lbCamasMatrimoniales.Margin = new Padding(1, 0, 1, 0);
            lbCamasMatrimoniales.Name = "lbCamasMatrimoniales";
            lbCamasMatrimoniales.Size = new Size(119, 15);
            lbCamasMatrimoniales.TabIndex = 21;
            lbCamasMatrimoniales.Text = "CamasMatrimoniales";
            // 
            // textBoxCamasMatrimoniales
            // 
            textBoxCamasMatrimoniales.Location = new Point(261, 160);
            textBoxCamasMatrimoniales.Margin = new Padding(1);
            textBoxCamasMatrimoniales.Name = "textBoxCamasMatrimoniales";
            textBoxCamasMatrimoniales.Size = new Size(192, 23);
            textBoxCamasMatrimoniales.TabIndex = 20;
            // 
            // lbCamasIndividuales
            // 
            lbCamasIndividuales.AutoSize = true;
            lbCamasIndividuales.Location = new Point(140, 117);
            lbCamasIndividuales.Margin = new Padding(1, 0, 1, 0);
            lbCamasIndividuales.Name = "lbCamasIndividuales";
            lbCamasIndividuales.Size = new Size(106, 15);
            lbCamasIndividuales.TabIndex = 19;
            lbCamasIndividuales.Text = "CamasIndividuales";
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(196, 77);
            lbNumero.Margin = new Padding(1, 0, 1, 0);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 18;
            lbNumero.Text = "Numero";
            // 
            // textBoxCamasIndividuales
            // 
            textBoxCamasIndividuales.Location = new Point(261, 115);
            textBoxCamasIndividuales.Margin = new Padding(1);
            textBoxCamasIndividuales.Name = "textBoxCamasIndividuales";
            textBoxCamasIndividuales.Size = new Size(192, 23);
            textBoxCamasIndividuales.TabIndex = 17;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(261, 77);
            textBoxNumero.Margin = new Padding(1);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(192, 23);
            textBoxNumero.TabIndex = 16;
            // 
            // fHabitacionesAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(670, 358);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(lbPrecioPorNoche);
            Controls.Add(textBoxPrecioPorNoche);
            Controls.Add(lbCamasMatrimoniales);
            Controls.Add(textBoxCamasMatrimoniales);
            Controls.Add(lbCamasIndividuales);
            Controls.Add(lbNumero);
            Controls.Add(textBoxCamasIndividuales);
            Controls.Add(textBoxNumero);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "fHabitacionesAlta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fHabitacionesAlta";
            Load += fHabitacionesAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btGuardar;
        private Label lbLocalidad;
        private Label lbCorreo;
        private TextBox textBox5;
        private Label lbPrecioPorNoche;
        private TextBox textBoxPrecioPorNoche;
        private Label lbCamasMatrimoniales;
        private TextBox textBoxCamasMatrimoniales;
        private Label lbCamasIndividuales;
        private Label lbNumero;
        private TextBox textBoxCamasIndividuales;
        private TextBox textBoxNumero;
    }
}