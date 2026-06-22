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
            lbRol.Location = new Point(120, 55);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(31, 20);
            lbRol.TabIndex = 0;
            lbRol.Text = "Rol";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(407, 55);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(76, 172);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Location = new Point(388, 168);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(83, 20);
            lbContrasena.TabIndex = 3;
            lbContrasena.Text = "Contraseña";
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(157, 52);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(178, 28);
            cbRoles.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(477, 52);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(178, 27);
            tbNombre.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(157, 169);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(178, 27);
            tbUsername.TabIndex = 6;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(477, 169);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(178, 27);
            tbContrasena.TabIndex = 7;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.FromArgb(30, 30, 30);
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.ForeColor = SystemColors.ButtonHighlight;
            btGuardar.Location = new Point(157, 313);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(178, 59);
            btGuardar.TabIndex = 8;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(30, 30, 30);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = SystemColors.ButtonHighlight;
            btCancelar.Location = new Point(452, 313);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(178, 59);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // fAltaUsuarios
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