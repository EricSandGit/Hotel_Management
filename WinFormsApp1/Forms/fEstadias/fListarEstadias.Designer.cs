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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgListarEstadias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgListarEstadias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarEstadias.EnableHeadersVisualStyles = false;
            dgListarEstadias.GridColor = Color.PowderBlue;
            dgListarEstadias.Location = new Point(30, 27);
            dgListarEstadias.Margin = new Padding(2);
            dgListarEstadias.Name = "dgListarEstadias";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgListarEstadias.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgListarEstadias.RowHeadersWidth = 62;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dgListarEstadias.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgListarEstadias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarEstadias.Size = new Size(1144, 645);
            dgListarEstadias.TabIndex = 1;
            // 
            // btModificarEstadia
            // 
            btModificarEstadia.BackColor = Color.FromArgb(30, 30, 30);
            btModificarEstadia.ForeColor = SystemColors.ButtonHighlight;
            btModificarEstadia.Location = new Point(235, 696);
            btModificarEstadia.Margin = new Padding(2);
            btModificarEstadia.Name = "btModificarEstadia";
            btModificarEstadia.Size = new Size(350, 59);
            btModificarEstadia.TabIndex = 5;
            btModificarEstadia.Text = "Modificar";
            btModificarEstadia.UseVisualStyleBackColor = false;
            btModificarEstadia.Click += btModificarEstadia_Click;
            // 
            // btEliminarEstadia
            // 
            btEliminarEstadia.BackColor = Color.FromArgb(30, 30, 30);
            btEliminarEstadia.ForeColor = SystemColors.ButtonHighlight;
            btEliminarEstadia.Location = new Point(605, 696);
            btEliminarEstadia.Margin = new Padding(2);
            btEliminarEstadia.Name = "btEliminarEstadia";
            btEliminarEstadia.Size = new Size(350, 59);
            btEliminarEstadia.TabIndex = 6;
            btEliminarEstadia.Text = "Eliminar";
            btEliminarEstadia.UseVisualStyleBackColor = false;
            btEliminarEstadia.Click += btEliminarEstadia_Click;
            // 
            // fListarEstadias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(btEliminarEstadia);
            Controls.Add(btModificarEstadia);
            Controls.Add(dgListarEstadias);
            Name = "fListarEstadias";
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