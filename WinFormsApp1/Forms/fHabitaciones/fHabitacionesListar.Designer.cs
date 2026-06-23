namespace WinFormsApp1.Forms.fHabitaciones
{
    partial class fHabitacionesListar
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btEliminarHabitacion = new Button();
            btEditarHabitacion = new Button();
            dataGridViewHabitacion = new DataGridView();
            btAgregarHabitacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitacion).BeginInit();
            SuspendLayout();
            // 
            // btEliminarHabitacion
            // 
            btEliminarHabitacion.BackColor = Color.Black;
            btEliminarHabitacion.FlatAppearance.BorderSize = 0;
            btEliminarHabitacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btEliminarHabitacion.FlatStyle = FlatStyle.Flat;
            btEliminarHabitacion.ForeColor = SystemColors.ButtonHighlight;
            btEliminarHabitacion.Location = new Point(302, 431);
            btEliminarHabitacion.Margin = new Padding(2, 1, 2, 1);
            btEliminarHabitacion.Name = "btEliminarHabitacion";
            btEliminarHabitacion.Size = new Size(245, 35);
            btEliminarHabitacion.TabIndex = 6;
            btEliminarHabitacion.Text = "Eliminar";
            btEliminarHabitacion.UseVisualStyleBackColor = false;
            btEliminarHabitacion.Click += btEliminarHabitacion_Click;
            // 
            // btEditarHabitacion
            // 
            btEditarHabitacion.BackColor = Color.Black;
            btEditarHabitacion.FlatAppearance.BorderSize = 0;
            btEditarHabitacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btEditarHabitacion.FlatStyle = FlatStyle.Flat;
            btEditarHabitacion.ForeColor = SystemColors.ButtonHighlight;
            btEditarHabitacion.Location = new Point(586, 431);
            btEditarHabitacion.Margin = new Padding(2, 1, 2, 1);
            btEditarHabitacion.Name = "btEditarHabitacion";
            btEditarHabitacion.Size = new Size(245, 35);
            btEditarHabitacion.TabIndex = 5;
            btEditarHabitacion.Text = "Editar";
            btEditarHabitacion.UseVisualStyleBackColor = false;
            btEditarHabitacion.Click += btEditarHabitacion_Click;
            // 
            // dataGridViewHabitacion
            // 
            dataGridViewHabitacion.AllowUserToAddRows = false;
            dataGridViewHabitacion.AllowUserToDeleteRows = false;
            dataGridViewHabitacion.AllowUserToResizeColumns = false;
            dataGridViewHabitacion.AllowUserToResizeRows = false;
            dataGridViewHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHabitacion.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewHabitacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHabitacion.EnableHeadersVisualStyles = false;
            dataGridViewHabitacion.Location = new Point(18, 20);
            dataGridViewHabitacion.Margin = new Padding(2, 1, 2, 1);
            dataGridViewHabitacion.Name = "dataGridViewHabitacion";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewHabitacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewHabitacion.RowHeadersWidth = 102;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewHabitacion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewHabitacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHabitacion.Size = new Size(814, 392);
            dataGridViewHabitacion.TabIndex = 4;
            // 
            // btAgregarHabitacion
            // 
            btAgregarHabitacion.BackColor = Color.Black;
            btAgregarHabitacion.FlatAppearance.BorderSize = 0;
            btAgregarHabitacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btAgregarHabitacion.FlatStyle = FlatStyle.Flat;
            btAgregarHabitacion.ForeColor = SystemColors.ButtonHighlight;
            btAgregarHabitacion.Location = new Point(18, 431);
            btAgregarHabitacion.Margin = new Padding(2);
            btAgregarHabitacion.Name = "btAgregarHabitacion";
            btAgregarHabitacion.Size = new Size(245, 35);
            btAgregarHabitacion.TabIndex = 7;
            btAgregarHabitacion.Text = "Agregar";
            btAgregarHabitacion.UseVisualStyleBackColor = false;
            btAgregarHabitacion.Click += btAgregarHabitacion_Click;
            // 
            // fHabitacionesListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(851, 505);
            Controls.Add(btAgregarHabitacion);
            Controls.Add(btEliminarHabitacion);
            Controls.Add(btEditarHabitacion);
            Controls.Add(dataGridViewHabitacion);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "fHabitacionesListar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fHabitacionesListar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHabitacion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btEliminarHabitacion;
        private Button btEditarHabitacion;
        private DataGridView dataGridViewHabitacion;
        private Button btAgregarHabitacion;
    }
}