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
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            tbUsuario.Margin = new Padding(4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(472, 31);
            tbUsuario.TabIndex = 1;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(282, 294);
            tbContrasena.Margin = new Padding(4);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(472, 31);
            tbContrasena.TabIndex = 3;
            tbContrasena.TextChanged += tbContrasena_TextChanged;
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContrasena.Location = new Point(132, 294);
            lbContrasena.Margin = new Padding(4, 0, 4, 0);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(139, 32);
            lbContrasena.TabIndex = 2;
            lbContrasena.Text = "Contraseña:";
            // 
            // btIngresar
            // 
            btIngresar.Font = new Font("Segoe UI", 12F);
            btIngresar.Location = new Point(368, 420);
            btIngresar.Margin = new Padding(4);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(246, 59);
            btIngresar.TabIndex = 4;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 15F);
            lbLogin.Location = new Point(368, 74);
            lbLogin.Margin = new Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(258, 41);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "INICIO DE SESIÓN";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbLogin);
            Controls.Add(btIngresar);
            Controls.Add(tbContrasena);
            Controls.Add(lbContrasena);
            Controls.Add(tbUsuario);
            Controls.Add(lbUsuario);
            Margin = new Padding(4);
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
    }
}