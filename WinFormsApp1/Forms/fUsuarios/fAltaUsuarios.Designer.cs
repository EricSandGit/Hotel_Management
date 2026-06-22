namespace WinFormsApp1.Forms.fUsuarios
{
    partial class fAltaUsuarios
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
            lbRol = new Label();
            lbNombre = new Label();
            lbUsername = new Label();
            lbContrasena = new Label();
            cbRoles = new ComboBox();
            tbNombre = new TextBox();
            tbUsername = new TextBox();
            tbContrasena = new TextBox();
            btGuardar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Location = new Point(120, 54);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(31, 20);
            lbRol.TabIndex = 0;
            lbRol.Text = "Rol";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(87, 152);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(76, 243);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Location = new Point(68, 332);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(83, 20);
            lbContrasena.TabIndex = 3;
            lbContrasena.Text = "Contraseña";
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(157, 51);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(178, 28);
            cbRoles.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(157, 149);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(178, 27);
            tbNombre.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(157, 240);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(178, 27);
            tbUsername.TabIndex = 6;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(157, 329);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(178, 27);
            tbContrasena.TabIndex = 7;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(423, 360);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 8;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(608, 360);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(94, 29);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // fAltaUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(tbContrasena);
            Controls.Add(tbUsername);
            Controls.Add(tbNombre);
            Controls.Add(cbRoles);
            Controls.Add(lbContrasena);
            Controls.Add(lbUsername);
            Controls.Add(lbNombre);
            Controls.Add(lbRol);
            Name = "fAltaUsuarios";
            Text = "fAltaUsuarios";
            Load += fAltaUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRol;
        private Label lbNombre;
        private Label lbUsername;
        private Label lbContrasena;
        private ComboBox cbRoles;
        private TextBox tbNombre;
        private TextBox tbUsername;
        private TextBox tbContrasena;
        private Button btGuardar;
        private Button btCancelar;
    }
}