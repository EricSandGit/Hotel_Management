namespace WinFormsApp1.Forms.fClientes
{
    partial class fClientesListar
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
            dataGridViewClientes = new DataGridView();
            btEditarCliente = new Button();
            btEliminarCliente = new Button();
            btAgregarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToResizeColumns = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.Location = new Point(18, 23);
            dataGridViewClientes.Margin = new Padding(2, 2, 2, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientes.RowHeadersWidth = 102;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(930, 522);
            dataGridViewClientes.TabIndex = 0;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // btEditarCliente
            // 
            btEditarCliente.BackColor = Color.Black;
            btEditarCliente.FlatAppearance.BorderSize = 0;
            btEditarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btEditarCliente.FlatStyle = FlatStyle.Flat;
            btEditarCliente.ForeColor = SystemColors.ButtonHighlight;
            btEditarCliente.Location = new Point(668, 571);
            btEditarCliente.Margin = new Padding(2, 2, 2, 2);
            btEditarCliente.Name = "btEditarCliente";
            btEditarCliente.Size = new Size(280, 47);
            btEditarCliente.TabIndex = 1;
            btEditarCliente.Text = "Editar";
            btEditarCliente.UseVisualStyleBackColor = false;
            btEditarCliente.Click += btEditarCliente_Click;
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.BackColor = Color.Black;
            btEliminarCliente.FlatAppearance.BorderSize = 0;
            btEliminarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btEliminarCliente.FlatStyle = FlatStyle.Flat;
            btEliminarCliente.ForeColor = SystemColors.ButtonHighlight;
            btEliminarCliente.Location = new Point(344, 571);
            btEliminarCliente.Margin = new Padding(2, 2, 2, 2);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(280, 47);
            btEliminarCliente.TabIndex = 2;
            btEliminarCliente.Text = "Eliminar";
            btEliminarCliente.UseVisualStyleBackColor = false;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // btAgregarCliente
            // 
            btAgregarCliente.BackColor = Color.Black;
            btAgregarCliente.FlatAppearance.BorderSize = 0;
            btAgregarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48, 0);
            btAgregarCliente.FlatStyle = FlatStyle.Flat;
            btAgregarCliente.ForeColor = SystemColors.ButtonHighlight;
            btAgregarCliente.Location = new Point(18, 571);
            btAgregarCliente.Margin = new Padding(2, 2, 2, 2);
            btAgregarCliente.Name = "btAgregarCliente";
            btAgregarCliente.Size = new Size(280, 47);
            btAgregarCliente.TabIndex = 3;
            btAgregarCliente.Text = "Agregar";
            btAgregarCliente.UseVisualStyleBackColor = false;
            btAgregarCliente.Click += btAgregarCliente_Click;
            // 
            // fClientesListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(905, 515);
            Controls.Add(btAgregarCliente);
            Controls.Add(btEliminarCliente);
            Controls.Add(btEditarCliente);
            Controls.Add(dataGridViewClientes);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fClientesListar";
            Text = "fClientesListar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Button btEditarCliente;
        private Button btEliminarCliente;
        private Button btAgregarCliente;
    }
}
