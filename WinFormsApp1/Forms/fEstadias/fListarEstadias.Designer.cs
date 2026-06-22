namespace WinFormsApp1.Forms.fEstadias
{
    partial class fListarEstadias
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
            dgListarEstadias = new DataGridView();
            btModificarEstadia = new Button();
            btEliminarEstadia = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListarEstadias).BeginInit();
            SuspendLayout();
            // 
            // dgListarEstadias
            // 
            dgListarEstadias.AllowUserToAddRows = false;
            dgListarEstadias.AllowUserToDeleteRows = false;
            dgListarEstadias.AllowUserToResizeColumns = false;
            dgListarEstadias.AllowUserToResizeRows = false;
            dgListarEstadias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListarEstadias.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListarEstadias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListarEstadias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarEstadias.EnableHeadersVisualStyles = false;
            dgListarEstadias.GridColor = Color.PowderBlue;
            dgListarEstadias.Location = new Point(24, 22);
            dgListarEstadias.Margin = new Padding(2);
            dgListarEstadias.Name = "dgListarEstadias";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgListarEstadias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgListarEstadias.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgListarEstadias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgListarEstadias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarEstadias.Size = new Size(915, 516);
            dgListarEstadias.TabIndex = 1;
            // 
            // btModificarEstadia
            // 
            btModificarEstadia.BackColor = Color.FromArgb(30, 30, 30);
            btModificarEstadia.ForeColor = SystemColors.ButtonHighlight;
            btModificarEstadia.Location = new Point(188, 557);
            btModificarEstadia.Margin = new Padding(2);
            btModificarEstadia.Name = "btModificarEstadia";
            btModificarEstadia.Size = new Size(280, 47);
            btModificarEstadia.TabIndex = 5;
            btModificarEstadia.Text = "Modificar";
            btModificarEstadia.UseVisualStyleBackColor = false;
            btModificarEstadia.Click += btModificarEstadia_Click;
            // 
            // btEliminarEstadia
            // 
            btEliminarEstadia.BackColor = Color.FromArgb(30, 30, 30);
            btEliminarEstadia.ForeColor = SystemColors.ButtonHighlight;
            btEliminarEstadia.Location = new Point(484, 557);
            btEliminarEstadia.Margin = new Padding(2);
            btEliminarEstadia.Name = "btEliminarEstadia";
            btEliminarEstadia.Size = new Size(280, 47);
            btEliminarEstadia.TabIndex = 6;
            btEliminarEstadia.Text = "Eliminar";
            btEliminarEstadia.UseVisualStyleBackColor = false;
            btEliminarEstadia.Click += btEliminarEstadia_Click;
            // 
            // fListarEstadias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(972, 673);
            Controls.Add(btEliminarEstadia);
            Controls.Add(btModificarEstadia);
            Controls.Add(dgListarEstadias);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fListarEstadias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListarEstadias";
            Load += fListarEstadias_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarEstadias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgListarEstadias;
        private Button btModificarEstadia;
        private Button btEliminarEstadia;
    }
}