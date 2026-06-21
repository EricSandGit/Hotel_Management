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
            lbAdvertencia.Location = new Point(54, 45);
            lbAdvertencia.Margin = new Padding(2, 0, 2, 0);
            lbAdvertencia.Name = "lbAdvertencia";
            lbAdvertencia.Size = new Size(312, 25);
            lbAdvertencia.TabIndex = 0;
            lbAdvertencia.Text = "¿Estas seguro que lo quieres eliminar?";
            // 
            // btSiEstoySeguro
            // 
            btSiEstoySeguro.Location = new Point(31, 116);
            btSiEstoySeguro.Margin = new Padding(2);
            btSiEstoySeguro.Name = "btSiEstoySeguro";
            btSiEstoySeguro.Size = new Size(159, 34);
            btSiEstoySeguro.TabIndex = 1;
            btSiEstoySeguro.Text = "Si, estoy seguro";
            btSiEstoySeguro.UseVisualStyleBackColor = true;
            btSiEstoySeguro.Click += btSiEstoySeguro_Click;
            // 
            // btNoVolver
            // 
            btNoVolver.Location = new Point(222, 116);
            btNoVolver.Margin = new Padding(2);
            btNoVolver.Name = "btNoVolver";
            btNoVolver.Size = new Size(159, 34);
            btNoVolver.TabIndex = 2;
            btNoVolver.Text = "No, volver";
            btNoVolver.UseVisualStyleBackColor = true;
            btNoVolver.Click += btNoVolver_Click;
            // 
            // fClientesEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 188);
            Controls.Add(btNoVolver);
            Controls.Add(btSiEstoySeguro);
            Controls.Add(lbAdvertencia);
            Margin = new Padding(2);
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
