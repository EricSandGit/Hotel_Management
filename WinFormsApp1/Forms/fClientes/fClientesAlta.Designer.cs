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
            textBox1.Location = new Point(633, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 47);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(633, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(461, 47);
            textBox2.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(474, 99);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(128, 41);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(474, 205);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(128, 41);
            lbApellido.TabIndex = 4;
            lbApellido.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(633, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 47);
            textBox3.TabIndex = 6;
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(427, 325);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(175, 41);
            lbDocumento.TabIndex = 7;
            lbDocumento.Text = "Documento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(633, 442);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(461, 47);
            textBox4.TabIndex = 8;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(367, 448);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(235, 41);
            lbTelefono.TabIndex = 9;
            lbTelefono.Text = "Telefono/Celular";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(633, 554);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(461, 47);
            textBox5.TabIndex = 10;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(339, 560);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(255, 41);
            lbCorreo.TabIndex = 11;
            lbCorreo.Text = "CorreoElectronico";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(633, 670);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(461, 47);
            textBox6.TabIndex = 12;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Location = new Point(458, 670);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(144, 41);
            lbLocalidad.TabIndex = 13;
            lbLocalidad.Text = "Localidad";
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(367, 818);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(286, 76);
            btGuardar.TabIndex = 14;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click_1;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(994, 818);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(286, 76);
            btCancelar.TabIndex = 15;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click_1;
            // 
            // fClientesAlta
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 978);
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
            Name = "fClientesAlta";
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