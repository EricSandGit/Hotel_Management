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
            cbEstadias = new ComboBox();
            lbSeleccionar = new Label();
            dgGastosExtra = new DataGridView();
            btAgregarGE = new Button();
            ((System.ComponentModel.ISupportInitialize)dgGastosExtra).BeginInit();
            SuspendLayout();
            // 
            // cbEstadias
            // 
            cbEstadias.BackColor = Color.White;
            cbEstadias.ForeColor = SystemColors.InactiveBorder;
            cbEstadias.FormattingEnabled = true;
            cbEstadias.Location = new Point(829, 742);
            cbEstadias.Name = "cbEstadias";
            cbEstadias.Size = new Size(245, 33);
            cbEstadias.TabIndex = 1;
            cbEstadias.SelectedIndexChanged += cbEstadias_SelectedIndexChanged;
            cbEstadias.Click += cbEstadias_Click;
            // 
            // lbSeleccionar
            // 
            lbSeleccionar.AutoSize = true;
            lbSeleccionar.Location = new Point(850, 714);
            lbSeleccionar.Name = "lbSeleccionar";
            lbSeleccionar.Size = new Size(201, 25);
            lbSeleccionar.TabIndex = 2;
            lbSeleccionar.Text = "Seleccione una estadía...";
            // 
            // dgGastosExtra
            // 
            dgGastosExtra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGastosExtra.BackgroundColor = Color.FromArgb(165, 150, 135);
            dgGastosExtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGastosExtra.GridColor = Color.FromArgb(165, 150, 135);
            dgGastosExtra.Location = new Point(30, 44);
            dgGastosExtra.Name = "dgGastosExtra";
            dgGastosExtra.RowHeadersWidth = 62;
            dgGastosExtra.Size = new Size(1144, 645);
            dgGastosExtra.TabIndex = 3;
            // 
            // btAgregarGE
            // 
            btAgregarGE.BackColor = Color.FromArgb(30, 30, 30);
            btAgregarGE.FlatAppearance.BorderSize = 0;
            btAgregarGE.FlatStyle = FlatStyle.Flat;
            btAgregarGE.ForeColor = SystemColors.ButtonHighlight;
            btAgregarGE.Location = new Point(30, 742);
            btAgregarGE.Name = "btAgregarGE";
            btAgregarGE.Size = new Size(350, 59);
            btAgregarGE.TabIndex = 4;
            btAgregarGE.Text = "Agregar";
            btAgregarGE.UseVisualStyleBackColor = false;
            btAgregarGE.Click += btAgregarGE_Click;
            // 
            // fGastosExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(btAgregarGE);
            Controls.Add(dgGastosExtra);
            Controls.Add(lbSeleccionar);
            Controls.Add(cbEstadias);
            Name = "fGastosExtra";
            Text = "fGastosExtra";
            Load += fGastosExtra_Load;
            ((System.ComponentModel.ISupportInitialize)dgGastosExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbEstadias;
        private Label lbSeleccionar;
        private DataGridView dgGastosExtra;
        private Button btAgregarGE;
    }
}