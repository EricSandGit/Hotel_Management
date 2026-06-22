namespace WinFormsApp1.Forms.fClientes
{
    partial class fClientesModificar
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
            lbLocalidad = new Label();
            textBox6 = new TextBox();
            lbCorreo = new Label();
            textBox5 = new TextBox();
            lbTelefono = new Label();
            textBox4 = new TextBox();
            lbDocumento = new Label();
            textBox3 = new TextBox();
            lbApellido = new Label();
            lbNombre = new Label();
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
            btCancelar.Location = new Point(472, 395);
            btCancelar.Margin = new Padding(1, 1, 1, 1);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(135, 37);
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
            btGuardar.Location = new Point(177, 395);
            btGuardar.Margin = new Padding(1, 1, 1, 1);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(135, 37);
            btGuardar.TabIndex = 28;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Location = new Point(220, 323);
            lbLocalidad.Margin = new Padding(1, 0, 1, 0);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(74, 20);
            lbLocalidad.TabIndex = 27;
            lbLocalidad.Text = "Localidad";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(302, 323);
            textBox6.Margin = new Padding(1, 1, 1, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(219, 27);
            textBox6.TabIndex = 26;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(164, 269);
            lbCorreo.Margin = new Padding(1, 0, 1, 0);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(132, 20);
            lbCorreo.TabIndex = 25;
            lbCorreo.Text = "Correo Electronico";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(302, 266);
            textBox5.Margin = new Padding(1, 1, 1, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 27);
            textBox5.TabIndex = 24;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(177, 215);
            lbTelefono.Margin = new Padding(1, 0, 1, 0);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(119, 20);
            lbTelefono.TabIndex = 23;
            lbTelefono.Text = "Telefono/Celular";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(302, 212);
            textBox4.Margin = new Padding(1, 1, 1, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 27);
            textBox4.TabIndex = 22;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(205, 155);
            lbDocumento.Margin = new Padding(1, 0, 1, 0);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(87, 20);
            lbDocumento.TabIndex = 21;
            lbDocumento.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 155);
            textBox3.Margin = new Padding(1, 1, 1, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 20;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(227, 96);
            lbApellido.Margin = new Padding(1, 0, 1, 0);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(66, 20);
            lbApellido.TabIndex = 19;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(227, 44);
            lbNombre.Margin = new Padding(1, 0, 1, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 18;
            lbNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 95);
            textBox2.Margin = new Padding(1, 1, 1, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 44);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 16;
            // 
            // fClientesModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(770, 476);
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
            Name = "fClientesModificar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fClientesModificar";
            Load += fClientesModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btGuardar;
        private Label lbLocalidad;
        private TextBox textBox6;
        private Label lbCorreo;
        private TextBox textBox5;
        private Label lbTelefono;
        private TextBox textBox4;
        private Label lbDocumento;
        private TextBox textBox3;
        private Label lbApellido;
        private Label lbNombre;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}