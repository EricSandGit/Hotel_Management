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
            lbAdvertencia.Location = new Point(92, 74);
            lbAdvertencia.Name = "lbAdvertencia";
            lbAdvertencia.Size = new Size(520, 41);
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
            btSiEstoySeguro.Location = new Point(53, 190);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(270, 56);
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
            btNoVolver.Location = new Point(377, 190);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(270, 56);
            btNoVolver.TabIndex = 2;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = false;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // fClientesEliminar
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(716, 308);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbAdvertencia);
            Name = "fClientesEliminar";
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
