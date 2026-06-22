namespace WinFormsApp1.Forms.fClientes
{
    partial class fClientesAlta
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbNombre = new Label();
            lbApellido = new Label();
            textBox3 = new TextBox();
            lbDocumento = new Label();
            textBox4 = new TextBox();
            lbTelefono = new Label();
            textBox5 = new TextBox();
            lbCorreo = new Label();
            textBox6 = new TextBox();
            lbLocalidad = new Label();
            btGuardar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 48);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 99);
            textBox2.Margin = new Padding(1, 1, 1, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(223, 48);
            lbNombre.Margin = new Padding(1, 0, 1, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(223, 100);
            lbApellido.Margin = new Padding(1, 0, 1, 0);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(66, 20);
            lbApellido.TabIndex = 4;
            lbApellido.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 159);
            textBox3.Margin = new Padding(1, 1, 1, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 6;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(201, 159);
            lbDocumento.Margin = new Padding(1, 0, 1, 0);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(87, 20);
            lbDocumento.TabIndex = 7;
            lbDocumento.Text = "Documento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(298, 216);
            textBox4.Margin = new Padding(1, 1, 1, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 27);
            textBox4.TabIndex = 8;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(173, 219);
            lbTelefono.Margin = new Padding(1, 0, 1, 0);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(119, 20);
            lbTelefono.TabIndex = 9;
            lbTelefono.Text = "Telefono/Celular";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(298, 270);
            textBox5.Margin = new Padding(1, 1, 1, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 27);
            textBox5.TabIndex = 10;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(160, 273);
            lbCorreo.Margin = new Padding(1, 0, 1, 0);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(128, 20);
            lbCorreo.TabIndex = 11;
            lbCorreo.Text = "CorreoElectronico";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(298, 327);
            textBox6.Margin = new Padding(1, 1, 1, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(219, 27);
            textBox6.TabIndex = 12;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Location = new Point(216, 327);
            lbLocalidad.Margin = new Padding(1, 0, 1, 0);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(74, 20);
            lbLocalidad.TabIndex = 13;
            lbLocalidad.Text = "Localidad";
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.FromArgb(30, 30, 30);
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.ForeColor = SystemColors.ButtonHighlight;
            btGuardar.Location = new Point(173, 399);
            btGuardar.Margin = new Padding(1, 1, 1, 1);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(135, 37);
            btGuardar.TabIndex = 14;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click_1;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(30, 30, 30);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = SystemColors.ButtonHighlight;
            btCancelar.Location = new Point(468, 399);
            btCancelar.Margin = new Padding(1, 1, 1, 1);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(135, 37);
            btCancelar.TabIndex = 15;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click_1;
            // 
            // fClientesAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(766, 477);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(lbLocalidad);
            Controls.Add(textBox6);
            Controls.Add(lbCorreo);
            Controls.Add(textBox5);
            Controls.Add(lbTelefono);
            Controls.Add(textBox4);
            Controls.Add(lbDocumento);
            Controls.Add(textBox3);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "fClientesAlta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fClientesAlta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbNombre;
        private Label lbApellido;
        private TextBox textBox3;
        private Label lbDocumento;
        private TextBox textBox4;
        private Label lbTelefono;
        private TextBox textBox5;
        private Label lbCorreo;
        private TextBox textBox6;
        private Label lbLocalidad;
        private Button btGuardar;
        private Button btCancelar;
    }
}