namespace WinFormsApp1.Forms
{
    partial class fCuentaCliente
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
            lbCuentaCliente = new Label();
            cbEstadia = new ComboBox();
            lbSeleccionar = new Label();
            lbCostoHabitacion = new Label();
            label1 = new Label();
            lbCostoEstadia = new Label();
            lbCostoExtras = new Label();
            SuspendLayout();
            // 
            // lbCuentaCliente
            // 
            lbCuentaCliente.AutoSize = true;
            lbCuentaCliente.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCuentaCliente.Location = new Point(29, 32);
            lbCuentaCliente.Name = "lbCuentaCliente";
            lbCuentaCliente.Size = new Size(438, 41);
            lbCuentaCliente.TabIndex = 0;
            lbCuentaCliente.Text = "CUENTA TOTAL DE ESTADÍA";
            // 
            // cbEstadia
            // 
            cbEstadia.FormattingEnabled = true;
            cbEstadia.Location = new Point(29, 143);
            cbEstadia.Name = "cbEstadia";
            cbEstadia.Size = new Size(438, 33);
            cbEstadia.TabIndex = 1;
            cbEstadia.SelectedIndexChanged += cbEstadia_SelectedIndexChanged;
            // 
            // lbSeleccionar
            // 
            lbSeleccionar.AutoSize = true;
            lbSeleccionar.Location = new Point(29, 115);
            lbSeleccionar.Name = "lbSeleccionar";
            lbSeleccionar.Size = new Size(201, 25);
            lbSeleccionar.TabIndex = 2;
            lbSeleccionar.Text = "Seleccione una estadía...";
            // 
            // lbCostoHabitacion
            // 
            lbCostoHabitacion.AutoSize = true;
            lbCostoHabitacion.Location = new Point(43, 228);
            lbCostoHabitacion.Name = "lbCostoHabitacion";
            lbCostoHabitacion.Size = new Size(160, 25);
            lbCostoHabitacion.TabIndex = 3;
            lbCostoHabitacion.Text = "Valor de la Estadía:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 330);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 4;
            label1.Text = "Valor de Gastos Extra:";
            // 
            // lbCostoEstadia
            // 
            lbCostoEstadia.AutoSize = true;
            lbCostoEstadia.Location = new Point(41, 266);
            lbCostoEstadia.Name = "lbCostoEstadia";
            lbCostoEstadia.Size = new Size(59, 25);
            lbCostoEstadia.TabIndex = 5;
            lbCostoEstadia.Text = "label2";
            // 
            // lbCostoExtras
            // 
            lbCostoExtras.AutoSize = true;
            lbCostoExtras.Location = new Point(43, 367);
            lbCostoExtras.Name = "lbCostoExtras";
            lbCostoExtras.Size = new Size(59, 25);
            lbCostoExtras.TabIndex = 6;
            lbCostoExtras.Text = "label2";
            // 
            // fCuentaCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 594);
            Controls.Add(lbCostoExtras);
            Controls.Add(lbCostoEstadia);
            Controls.Add(label1);
            Controls.Add(lbCostoHabitacion);
            Controls.Add(lbSeleccionar);
            Controls.Add(cbEstadia);
            Controls.Add(lbCuentaCliente);
            Name = "fCuentaCliente";
            Text = "fCuentaCliente";
            Load += fCuentaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCuentaCliente;
        private ComboBox cbEstadia;
        private Label lbSeleccionar;
        private Label lbCostoHabitacion;
        private Label label1;
        private Label lbCostoEstadia;
        private Label lbCostoExtras;
    }
}