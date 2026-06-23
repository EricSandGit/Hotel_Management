namespace WinFormsApp1.Forms.fHabitaciones
{
    partial class fHabitacionesBaja
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
            btNoVolver = new Button();
            btSiEstoySeguro = new Button();
            lbAdvertencia = new Label();
            SuspendLayout();
            // 
            // btNoVolver
            // 
            btNoVolver.BackColor = Color.FromArgb(30, 30, 30);
            btNoVolver.FlatAppearance.BorderSize = 0;
            btNoVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btNoVolver.FlatStyle = FlatStyle.Flat;
            btNoVolver.ForeColor = SystemColors.ButtonHighlight;
            btNoVolver.Location = new Point(159, 67);
            btNoVolver.Margin = new Padding(1, 1, 1, 1);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(111, 20);
            btNoVolver.TabIndex = 5;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = false;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // btSiEstoySeguro
            // 
            btSiEstoySeguro.BackColor = Color.FromArgb(30, 30, 30);
            btSiEstoySeguro.FlatAppearance.BorderSize = 0;
            btSiEstoySeguro.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btSiEstoySeguro.FlatStyle = FlatStyle.Flat;
            btSiEstoySeguro.ForeColor = SystemColors.ButtonHighlight;
            btSiEstoySeguro.Location = new Point(25, 67);
            btSiEstoySeguro.Margin = new Padding(1, 1, 1, 1);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(111, 20);
            btSiEstoySeguro.TabIndex = 4;
            btSiEstoySeguro.Text = "Si, estoy seguro";
            btSiEstoySeguro.UseVisualStyleBackColor = false;
            btSiEstoySeguro.Click += btSiEstoySeguro_Click;
            // 
            // lbAdvertencia
            // 
            lbAdvertencia.AutoSize = true;
            lbAdvertencia.Location = new Point(41, 25);
            lbAdvertencia.Margin = new Padding(1, 0, 1, 0);
            lbAdvertencia.Name = "lbAdvertencia";
            lbAdvertencia.Size = new Size(205, 15);
            lbAdvertencia.TabIndex = 3;
            lbAdvertencia.Text = "¿Estas seguro que lo quieres eliminar?";
            // 
            // fHabitacionesBaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(295, 113);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbAdvertencia);
            Margin = new Padding(1, 1, 1, 1);
            Name = "fHabitacionesBaja";
            Text = "fHabitacionesBaja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNoVolver;
        private Button btSiEstoySeguro;
        private Label lbAdvertencia;
    }
}