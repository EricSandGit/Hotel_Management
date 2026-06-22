namespace WinFormsApp1.Forms.fUsuarios
{
    partial class fModificarUsuarios
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
            tbContrasena = new TextBox();
            tbUsername = new TextBox();
            tbNombre = new TextBox();
            cbRoles = new ComboBox();
            lbContrasena = new Label();
            lbUsername = new Label();
            lbNombre = new Label();
            lbRol = new Label();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(30, 30, 30);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = SystemColors.ButtonHighlight;
            btCancelar.Location = new Point(468, 326);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(178, 59);
            btCancelar.TabIndex = 19;
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
            btGuardar.Location = new Point(173, 326);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(178, 59);
            btGuardar.TabIndex = 18;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(493, 182);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(178, 27);
            tbContrasena.TabIndex = 17;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(173, 182);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(178, 27);
            tbUsername.TabIndex = 16;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(493, 65);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(178, 27);
            tbNombre.TabIndex = 15;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(173, 65);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(178, 28);
            cbRoles.TabIndex = 14;
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Location = new Point(404, 181);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(83, 20);
            lbContrasena.TabIndex = 13;
            lbContrasena.Text = "Contraseña";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(92, 185);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 12;
            lbUsername.Text = "Username";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(423, 68);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 11;
            lbNombre.Text = "Nombre";
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Location = new Point(136, 68);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(31, 20);
            lbRol.TabIndex = 10;
            lbRol.Text = "Rol";
            // 
            // fModificarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
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
            Name = "fModificarUsuarios";
            Text = "fModificarUsuarios";
            Load += fModificarUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btGuardar;
        private TextBox tbContrasena;
        private TextBox tbUsername;
        private TextBox tbNombre;
        private ComboBox cbRoles;
        private Label lbContrasena;
        private Label lbUsername;
        private Label lbNombre;
        private Label lbRol;
    }
}