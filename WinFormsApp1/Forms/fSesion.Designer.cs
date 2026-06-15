namespace WinFormsApp1.Forms
{
    partial class fSesion
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
            lbBienvenida = new Label();
            lbRol = new Label();
            SuspendLayout();
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 15F);
            lbBienvenida.Location = new Point(15, 11);
            lbBienvenida.Margin = new Padding(4, 0, 4, 0);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(183, 41);
            lbBienvenida.TabIndex = 0;
            lbBienvenida.Text = "Bienvenido!!";
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbRol.Location = new Point(15, 55);
            lbRol.Margin = new Padding(4, 0, 4, 0);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(67, 32);
            lbRol.TabIndex = 1;
            lbRol.Text = "-Rol-";
            // 
            // fSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 566);
            Controls.Add(lbRol);
            Controls.Add(lbBienvenida);
            Margin = new Padding(4, 4, 4, 4);
            Name = "fSesion";
            Text = "fSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBienvenida;
        private Label lbRol;
    }
}