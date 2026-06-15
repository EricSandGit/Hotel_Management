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
            lbAdvertencia.Location = new Point(92, 73);
            lbAdvertencia.Name = "lbAdvertencia";
            lbAdvertencia.Size = new Size(507, 41);
            lbAdvertencia.TabIndex = 0;
            lbAdvertencia.Text = "Estas seguro que lo quieres eliminar?";
            lbAdvertencia.Click += lbAdvertencia_Click;
            // 
            // btSiEstoySeguro
            // 
            btSiEstoySeguro.Location = new Point(52, 190);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(270, 55);
            btSiEstoySeguro.TabIndex = 1;
            btSiEstoySeguro.Text = "Si, estoy seguro";
            btSiEstoySeguro.UseVisualStyleBackColor = true;
            btSiEstoySeguro.Click += btSiEstoySeguro_Click;
            // 
            // btNoVolver
            // 
            btNoVolver.Location = new Point(377, 190);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(270, 55);
            btNoVolver.TabIndex = 2;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = true;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // fClientesEliminar
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 309);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbAdvertencia);
            Name = "fClientesEliminar";
            Text = "fClientesEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAdvertencia;
        private Button btSiEstoySeguro;
        private Button btNoVolver;
    }
}