namespace WinFormsApp1.Forms
{
    partial class fLogin
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
            lbUsuario = new Label();
            tbUsuario = new TextBox();
            tbContrasena = new TextBox();
            lbContrasena = new Label();
            btIngresar = new Button();
            lbLogin = new Label();
            btSalir = new Button();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsuario.ForeColor = SystemColors.ButtonHighlight;
            lbUsuario.Location = new Point(137, 143);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(83, 28);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(226, 143);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(378, 27);
            tbUsuario.TabIndex = 1;
            tbUsuario.KeyDown += tbUsuario_KeyDown;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(226, 235);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(378, 27);
            tbContrasena.TabIndex = 3;
            tbContrasena.KeyDown += tbContrasena_KeyDown;
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContrasena.ForeColor = SystemColors.ButtonHighlight;
            lbContrasena.Location = new Point(106, 235);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(114, 28);
            lbContrasena.TabIndex = 2;
            lbContrasena.Text = "Contraseña:";
            // 
            // btIngresar
            // 
            btIngresar.BackColor = Color.FromArgb(45, 45, 48);
            btIngresar.FlatAppearance.BorderSize = 0;
            btIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 65);
            btIngresar.FlatStyle = FlatStyle.Flat;
            btIngresar.Font = new Font("Segoe UI", 12F);
            btIngresar.ForeColor = SystemColors.ButtonHighlight;
            btIngresar.Location = new Point(294, 336);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(197, 47);
            btIngresar.TabIndex = 4;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 15F);
            lbLogin.ForeColor = SystemColors.ButtonHighlight;
            lbLogin.Location = new Point(294, 59);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(218, 35);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "INICIO DE SESIÓN";
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.FromArgb(45, 45, 48);
            btSalir.FlatAppearance.BorderSize = 0;
            btSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 45, 45);
            btSalir.FlatStyle = FlatStyle.Flat;
            btSalir.Font = new Font("Segoe UI", 12F);
            btSalir.ForeColor = SystemColors.ButtonHighlight;
            btSalir.Location = new Point(294, 389);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(197, 47);
            btSalir.TabIndex = 6;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
           
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(btSalir);
            Controls.Add(lbLogin);
            Controls.Add(btIngresar);
            Controls.Add(tbContrasena);
            Controls.Add(lbContrasena);
            Controls.Add(tbUsuario);
            Controls.Add(lbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fLogin";
            Text = "fLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private TextBox tbUsuario;
        private TextBox tbContrasena;
        private Label lbContrasena;
        private Button btIngresar;
        private Label lbLogin;
        private Button btSalir;
    }
}
