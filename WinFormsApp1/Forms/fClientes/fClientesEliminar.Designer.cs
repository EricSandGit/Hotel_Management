namespace WinFormsApp1.Forms.fClientes
{
    partial class fClientesEliminar
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
            lbAdvertencia = new Label();
            btSiEstoySeguro = new Button();
            btNoVolver = new Button();
            SuspendLayout();
            // 
            // lbAdvertencia
            // 
            lbAdvertencia.AutoSize = true;
            lbAdvertencia.Location = new Point(43, 36);
            lbAdvertencia.Margin = new Padding(1, 0, 1, 0);
            lbAdvertencia.Name = "lbAdvertencia";
            lbAdvertencia.Size = new Size(261, 20);
            lbAdvertencia.TabIndex = 0;
            lbAdvertencia.Text = "¿Estas seguro que lo quieres eliminar?";
            // 
            // btSiEstoySeguro
            // 
            btSiEstoySeguro.BackColor = Color.FromArgb(30, 30, 30);
            btSiEstoySeguro.FlatAppearance.BorderSize = 0;
            btSiEstoySeguro.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btSiEstoySeguro.FlatStyle = FlatStyle.Flat;
            btSiEstoySeguro.ForeColor = SystemColors.ButtonHighlight;
            btSiEstoySeguro.Location = new Point(25, 93);
            btSiEstoySeguro.Margin = new Padding(1, 1, 1, 1);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(127, 27);
            btSiEstoySeguro.TabIndex = 1;
            btSiEstoySeguro.Text = "Si, estoy seguro";
            btSiEstoySeguro.UseVisualStyleBackColor = false;
            btSiEstoySeguro.Click += btSiEstoySeguro_Click;
            // 
            // btNoVolver
            // 
            btNoVolver.BackColor = Color.FromArgb(30, 30, 30);
            btNoVolver.FlatAppearance.BorderSize = 0;
            btNoVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btNoVolver.FlatStyle = FlatStyle.Flat;
            btNoVolver.ForeColor = SystemColors.ButtonHighlight;
            btNoVolver.Location = new Point(177, 93);
            btNoVolver.Margin = new Padding(1, 1, 1, 1);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(127, 27);
            btNoVolver.TabIndex = 2;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = false;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // fClientesEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(337, 150);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbAdvertencia);
            Margin = new Padding(1, 1, 1, 1);
            Name = "fClientesEliminar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fClientesEliminar";
            Load += fClientesEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAdvertencia;
        private Button btSiEstoySeguro;
        private Button btNoVolver;
    }
}
