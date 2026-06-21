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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
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
            lbUsuario.Location = new Point(171, 179);
            lbUsuario.Margin = new Padding(4, 0, 4, 0);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(99, 32);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(282, 179);
            tbUsuario.Margin = new Padding(4, 4, 4, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(472, 31);
            tbUsuario.TabIndex = 1;
            tbUsuario.KeyDown += tbUsuario_KeyDown;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(282, 294);
            tbContrasena.Margin = new Padding(4, 4, 4, 4);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(472, 31);
            tbContrasena.TabIndex = 3;
            tbContrasena.KeyDown += tbContrasena_KeyDown;
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContrasena.ForeColor = SystemColors.ButtonHighlight;
            lbContrasena.Location = new Point(132, 294);
            lbContrasena.Margin = new Padding(4, 0, 4, 0);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(139, 32);
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
            btIngresar.Location = new Point(368, 420);
            btIngresar.Margin = new Padding(4, 4, 4, 4);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(246, 59);
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
            lbLogin.Location = new Point(368, 74);
            lbLogin.Margin = new Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(258, 41);
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
            btSalir.Location = new Point(368, 486);
            btSalir.Margin = new Padding(4, 4, 4, 4);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(246, 59);
            btSalir.TabIndex = 6;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 562);
            Controls.Add(btSalir);
            Controls.Add(lbLogin);
            Controls.Add(btIngresar);
            Controls.Add(tbContrasena);
            Controls.Add(lbContrasena);
            Controls.Add(tbUsuario);
            Controls.Add(lbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "fLogin";
            Text = "fLogin";
            Load += fLogin_Load;
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
