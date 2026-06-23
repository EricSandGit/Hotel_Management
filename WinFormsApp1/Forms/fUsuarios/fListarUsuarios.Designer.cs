namespace WinFormsApp1.Forms.fUsuarios
{
    partial class fListarUsuarios
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
            btAgregarUsuario = new Button();
            btEliminarUsuario = new Button();
            btModificarUsuario = new Button();
            dgListarUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btAgregarUsuario
            // 
            btAgregarUsuario.BackColor = Color.FromArgb(30, 30, 30);
            btAgregarUsuario.FlatAppearance.BorderSize = 0;
            btAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btAgregarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btAgregarUsuario.Location = new Point(28, 442);
            btAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            btAgregarUsuario.Name = "btAgregarUsuario";
            btAgregarUsuario.Size = new Size(245, 35);
            btAgregarUsuario.TabIndex = 3;
            btAgregarUsuario.Text = "Agregar";
            btAgregarUsuario.UseVisualStyleBackColor = false;
            btAgregarUsuario.Click += btAgregarUsuario_Click;
            // 
            // btEliminarUsuario
            // 
            btEliminarUsuario.BackColor = Color.FromArgb(30, 30, 30);
            btEliminarUsuario.FlatAppearance.BorderSize = 0;
            btEliminarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btEliminarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btEliminarUsuario.Location = new Point(304, 442);
            btEliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            btEliminarUsuario.Name = "btEliminarUsuario";
            btEliminarUsuario.Size = new Size(245, 35);
            btEliminarUsuario.TabIndex = 4;
            btEliminarUsuario.Text = "Eliminar";
            btEliminarUsuario.UseVisualStyleBackColor = false;
            btEliminarUsuario.Click += btEliminarUsuario_Click;
            // 
            // btModificarUsuario
            // 
            btModificarUsuario.BackColor = Color.FromArgb(30, 30, 30);
            btModificarUsuario.FlatAppearance.BorderSize = 0;
            btModificarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btModificarUsuario.FlatStyle = FlatStyle.Flat;
            btModificarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btModificarUsuario.Location = new Point(584, 442);
            btModificarUsuario.Margin = new Padding(3, 2, 3, 2);
            btModificarUsuario.Name = "btModificarUsuario";
            btModificarUsuario.Size = new Size(245, 35);
            btModificarUsuario.TabIndex = 5;
            btModificarUsuario.Text = "Modificar";
            btModificarUsuario.UseVisualStyleBackColor = false;
            btModificarUsuario.Click += btModificarUsuario_Click;
            // 
            // dgListarUsuarios
            // 
            dgListarUsuarios.AllowUserToAddRows = false;
            dgListarUsuarios.AllowUserToDeleteRows = false;
            dgListarUsuarios.AllowUserToResizeColumns = false;
            dgListarUsuarios.AllowUserToResizeRows = false;
            dgListarUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListarUsuarios.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListarUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarUsuarios.EnableHeadersVisualStyles = false;
            dgListarUsuarios.Location = new Point(28, 25);
            dgListarUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgListarUsuarios.Name = "dgListarUsuarios";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgListarUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgListarUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgListarUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgListarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarUsuarios.Size = new Size(801, 387);
            dgListarUsuarios.TabIndex = 6;
            // 
            // fListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(850, 505);
            Controls.Add(dgListarUsuarios);
            Controls.Add(btModificarUsuario);
            Controls.Add(btEliminarUsuario);
            Controls.Add(btAgregarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fListarUsuarios";
            Text = "fListarUsuarios";
            Load += fListarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btAgregarUsuario;
        private Button btEliminarUsuario;
        private Button btModificarUsuario;
        private DataGridView dgListarUsuarios;
    }
}