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
            cbEstadia = new ComboBox();
            lbSeleccionar = new Label();
            dgCuenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCuenta).BeginInit();
            SuspendLayout();
            // 
            // cbEstadia
            // 
            cbEstadia.FormattingEnabled = true;
            cbEstadia.Location = new Point(36, 725);
            cbEstadia.Name = "cbEstadia";
            cbEstadia.Size = new Size(438, 33);
            cbEstadia.TabIndex = 1;
            cbEstadia.SelectedIndexChanged += cbEstadia_SelectedIndexChanged;
            // 
            // lbSeleccionar
            // 
            lbSeleccionar.AutoSize = true;
            lbSeleccionar.Location = new Point(36, 697);
            lbSeleccionar.Name = "lbSeleccionar";
            lbSeleccionar.Size = new Size(201, 25);
            lbSeleccionar.TabIndex = 2;
            lbSeleccionar.Text = "Seleccione una estadía...";
            // 
            // dgCuenta
            // 
            dgCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCuenta.BackgroundColor = Color.FromArgb(165, 150, 135);
            dgCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCuenta.GridColor = Color.FromArgb(165, 150, 135);
            dgCuenta.Location = new Point(36, 36);
            dgCuenta.Name = "dgCuenta";
            dgCuenta.RowHeadersWidth = 62;
            dgCuenta.Size = new Size(1144, 645);
            dgCuenta.TabIndex = 7;
            // 
            // fCuentaCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(dgCuenta);
            Controls.Add(lbSeleccionar);
            Controls.Add(cbEstadia);
            Name = "fCuentaCliente";
            Text = "fCuentaCliente";
            Load += fCuentaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbEstadia;
        private Label lbSeleccionar;
        private DataGridView dgCuenta;
    }
}