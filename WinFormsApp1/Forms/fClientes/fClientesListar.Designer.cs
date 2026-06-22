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
            dataGridViewClientes = new DataGridView();
            btEditarCliente = new Button();
            btEliminarCliente = new Button();
            btAgregarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(14, 14);
            dataGridViewClientes.Margin = new Padding(2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 102;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(789, 380);
            dataGridViewClientes.TabIndex = 0;
            // 
            // btEditarCliente
            // 
            btEditarCliente.Location = new Point(688, 408);
            btEditarCliente.Margin = new Padding(2);
            btEditarCliente.Name = "btEditarCliente";
            btEditarCliente.Size = new Size(115, 37);
            btEditarCliente.TabIndex = 1;
            btEditarCliente.Text = "Editar";
            btEditarCliente.UseVisualStyleBackColor = true;
            btEditarCliente.Click += btEditarCliente_Click;
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.Location = new Point(564, 408);
            btEliminarCliente.Margin = new Padding(2);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(115, 37);
            btEliminarCliente.TabIndex = 2;
            btEliminarCliente.Text = "Eliminar";
            btEliminarCliente.UseVisualStyleBackColor = true;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // btAgregarCliente
            // 
            btAgregarCliente.Location = new Point(437, 408);
            btAgregarCliente.Margin = new Padding(2);
            btAgregarCliente.Name = "btAgregarCliente";
            btAgregarCliente.Size = new Size(115, 37);
            btAgregarCliente.TabIndex = 3;
            btAgregarCliente.Text = "Agregar";
            btAgregarCliente.UseVisualStyleBackColor = true;
            btAgregarCliente.Click += btAgregarCliente_Click;
            // 
            // fClientesListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 673);
            Controls.Add(btAgregarCliente);
            Controls.Add(btEliminarCliente);
            Controls.Add(btEditarCliente);
            Controls.Add(dataGridViewClientes);
            Margin = new Padding(2);
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
