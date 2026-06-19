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
            btCancelar.Location = new Point(1003, 810);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(286, 76);
            btCancelar.TabIndex = 29;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(376, 810);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(286, 76);
            btGuardar.TabIndex = 28;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Location = new Point(467, 662);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(144, 41);
            lbLocalidad.TabIndex = 27;
            lbLocalidad.Text = "Localidad";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(642, 662);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(461, 47);
            textBox6.TabIndex = 26;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(348, 552);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(263, 41);
            lbCorreo.TabIndex = 25;
            lbCorreo.Text = "Correo Electronico";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(642, 546);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(461, 47);
            textBox5.TabIndex = 24;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(376, 440);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(235, 41);
            lbTelefono.TabIndex = 23;
            lbTelefono.Text = "Telefono/Celular";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(642, 434);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(461, 47);
            textBox4.TabIndex = 22;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(436, 317);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(175, 41);
            lbDocumento.TabIndex = 21;
            lbDocumento.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(642, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 47);
            textBox3.TabIndex = 20;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(483, 197);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(128, 41);
            lbApellido.TabIndex = 19;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(483, 91);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(128, 41);
            lbNombre.TabIndex = 18;
            lbNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(642, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(461, 47);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(642, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 47);
            textBox1.TabIndex = 16;
            // 
            // fClientesModificar
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 976);
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
            Name = "fClientesModificar";
            Text = "fClientesModificar";
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