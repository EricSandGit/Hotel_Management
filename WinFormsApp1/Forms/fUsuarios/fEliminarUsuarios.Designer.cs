namespace WinFormsApp1.Forms.fUsuarios
{
    partial class fEliminarUsuarios
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
            lbEstasSeguro = new Label();
            btSiEstoySeguro = new Button();
            btNoVolver = new Button();
            SuspendLayout();
            // 
            // lbEstasSeguro
            // 
            lbEstasSeguro.AutoSize = true;
            lbEstasSeguro.Location = new Point(38, 29);
            lbEstasSeguro.Name = "lbEstasSeguro";
            lbEstasSeguro.Size = new Size(265, 20);
            lbEstasSeguro.TabIndex = 0;
            lbEstasSeguro.Text = "¿Estás seguro de que quieres eliminar?";
            // 
            // btSiEstoySeguro
            // 
            btSiEstoySeguro.BackColor = Color.FromArgb(30, 30, 30);
            btSiEstoySeguro.FlatAppearance.BorderSize = 0;
            btSiEstoySeguro.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btSiEstoySeguro.FlatStyle = FlatStyle.Flat;
            btSiEstoySeguro.ForeColor = SystemColors.ButtonHighlight;
            btSiEstoySeguro.Location = new Point(12, 85);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(139, 35);
            btSiEstoySeguro.TabIndex = 9;
            btSiEstoySeguro.Text = "Sí, estoy seguro";
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
            btNoVolver.Location = new Point(191, 85);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(139, 35);
            btNoVolver.TabIndex = 10;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = false;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // fEliminarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(342, 154);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbEstasSeguro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fEliminarUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fEliminarUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEstasSeguro;
        private Button btSiEstoySeguro;
        private Button btNoVolver;
    }
}