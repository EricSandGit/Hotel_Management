namespace WinFormsApp1.Forms
{
    partial class FGastosExtra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cbEstadias = new ComboBox();
            lbSeleccionar = new Label();
            dgGastosExtra = new DataGridView();
            btAgregarGE = new Button();
            btEliminarGE = new Button();
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
            dgGastosExtra.AllowUserToAddRows = false;
            dgGastosExtra.AllowUserToDeleteRows = false;
            dgGastosExtra.AllowUserToResizeColumns = false;
            dgGastosExtra.AllowUserToResizeRows = false;
            dgGastosExtra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGastosExtra.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgGastosExtra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgGastosExtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGastosExtra.Enabled = false;
            dgGastosExtra.EnableHeadersVisualStyles = false;
            dgGastosExtra.GridColor = Color.FromArgb(165, 150, 135);
            dgGastosExtra.Location = new Point(30, 44);
            dgGastosExtra.Name = "dgGastosExtra";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgGastosExtra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgGastosExtra.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgGastosExtra.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgGastosExtra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGastosExtra.Size = new Size(1144, 645);
            dgGastosExtra.TabIndex = 3;
            dgGastosExtra.CellContentClick += dgGastosExtra_CellContentClick;
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
            // btEliminarGE
            // 
            btEliminarGE.BackColor = Color.FromArgb(30, 30, 30);
            btEliminarGE.FlatAppearance.BorderSize = 0;
            btEliminarGE.FlatStyle = FlatStyle.Flat;
            btEliminarGE.ForeColor = SystemColors.ButtonHighlight;
            btEliminarGE.Location = new Point(404, 742);
            btEliminarGE.Name = "btEliminarGE";
            btEliminarGE.Size = new Size(350, 59);
            btEliminarGE.TabIndex = 5;
            btEliminarGE.Text = "Eliminar";
            btEliminarGE.UseVisualStyleBackColor = false;
            btEliminarGE.Click += btEliminarGE_Click;
            // 
            // FGastosExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(btEliminarGE);
            Controls.Add(btAgregarGE);
            Controls.Add(dgGastosExtra);
            Controls.Add(lbSeleccionar);
            Controls.Add(cbEstadias);
            Name = "FGastosExtra";
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
        private Button btEliminarGE;
    }
}