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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbContrasena = new Label();
            btIngresar = new Button();
            lbLogin = new Label();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(137, 143);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(83, 28);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 235);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(378, 27);
            textBox2.TabIndex = 3;
            // 
            // lbContrasena
            // 
            lbContrasena.AutoSize = true;
            lbContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContrasena.Location = new Point(106, 235);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(114, 28);
            lbContrasena.TabIndex = 2;
            lbContrasena.Text = "Contraseña:";
            // 
            // btIngresar
            // 
            btIngresar.Font = new Font("Segoe UI", 12F);
            btIngresar.Location = new Point(294, 336);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(197, 47);
            btIngresar.TabIndex = 4;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 15F);
            lbLogin.Location = new Point(294, 59);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(218, 35);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "INICIO DE SESIÓN";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbLogin);
            Controls.Add(btIngresar);
            Controls.Add(textBox2);
            Controls.Add(lbContrasena);
            Controls.Add(textBox1);
            Controls.Add(lbUsuario);
            Name = "fLogin";
            Text = "fLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbContrasena;
        private Button btIngresar;
        private Label lbLogin;
    }
}