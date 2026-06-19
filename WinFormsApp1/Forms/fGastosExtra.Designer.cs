namespace WinFormsApp1.Forms
{
    partial class fGastosExtra
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
            lbGastosExtra = new Label();
            cbEstadias = new ComboBox();
            lbSeleccionar = new Label();
            dgGastosExtra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgGastosExtra).BeginInit();
            SuspendLayout();
            // 
            // lbGastosExtra
            // 
            lbGastosExtra.AutoSize = true;
            lbGastosExtra.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGastosExtra.Location = new Point(61, 57);
            lbGastosExtra.Name = "lbGastosExtra";
            lbGastosExtra.Size = new Size(247, 41);
            lbGastosExtra.TabIndex = 0;
            lbGastosExtra.Text = "GASTOS EXTRA";
            // 
            // cbEstadias
            // 
            cbEstadias.FormattingEnabled = true;
            cbEstadias.Location = new Point(61, 183);
            cbEstadias.Name = "cbEstadias";
            cbEstadias.Size = new Size(245, 33);
            cbEstadias.TabIndex = 1;
            cbEstadias.SelectedIndexChanged += cbEstadias_SelectedIndexChanged;
            cbEstadias.Click += cbEstadias_Click;
            // 
            // lbSeleccionar
            // 
            lbSeleccionar.AutoSize = true;
            lbSeleccionar.Location = new Point(84, 155);
            lbSeleccionar.Name = "lbSeleccionar";
            lbSeleccionar.Size = new Size(201, 25);
            lbSeleccionar.TabIndex = 2;
            lbSeleccionar.Text = "Seleccione una estadía...";
            // 
            // dgGastosExtra
            // 
            dgGastosExtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGastosExtra.GridColor = SystemColors.Info;
            dgGastosExtra.Location = new Point(381, 57);
            dgGastosExtra.Name = "dgGastosExtra";
            dgGastosExtra.RowHeadersWidth = 62;
            dgGastosExtra.Size = new Size(760, 428);
            dgGastosExtra.TabIndex = 3;
            // 
            // fGastosExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 534);
            Controls.Add(dgGastosExtra);
            Controls.Add(lbSeleccionar);
            Controls.Add(cbEstadias);
            Controls.Add(lbGastosExtra);
            Name = "fGastosExtra";
            Text = "fGastosExtra";
            Load += fGastosExtra_Load;
            ((System.ComponentModel.ISupportInitialize)dgGastosExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGastosExtra;
        private ComboBox cbEstadias;
        private Label lbSeleccionar;
        private DataGridView dgGastosExtra;
    }
}