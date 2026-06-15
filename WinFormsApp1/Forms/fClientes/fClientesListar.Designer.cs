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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(30, 28);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 102;
            dataGridViewClientes.Size = new Size(1677, 779);
            dataGridViewClientes.TabIndex = 0;
            // 
            // btEditarCliente
            // 
            btEditarCliente.Location = new Point(1462, 837);
            btEditarCliente.Name = "btEditarCliente";
            btEditarCliente.Size = new Size(245, 76);
            btEditarCliente.TabIndex = 1;
            btEditarCliente.Text = "Editar";
            btEditarCliente.UseVisualStyleBackColor = true;
            btEditarCliente.Click += btEditarCliente_Click;
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.Location = new Point(1199, 837);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(245, 76);
            btEliminarCliente.TabIndex = 2;
            btEliminarCliente.Text = "Eliminar";
            btEliminarCliente.UseVisualStyleBackColor = true;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // btAgregarCliente
            // 
            btAgregarCliente.Location = new Point(928, 837);
            btAgregarCliente.Name = "btAgregarCliente";
            btAgregarCliente.Size = new Size(245, 76);
            btAgregarCliente.TabIndex = 3;
            btAgregarCliente.Text = "Agregar";
            btAgregarCliente.UseVisualStyleBackColor = true;
            btAgregarCliente.Click += btAgregarCliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(701, 852);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 49);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 852);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(644, 47);
            textBox1.TabIndex = 5;
            // 
            // fClientesListar
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 968);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btAgregarCliente);
            Controls.Add(btEliminarCliente);
            Controls.Add(btEditarCliente);
            Controls.Add(dataGridViewClientes);
            Name = "fClientesListar";
            Text = "fClientesListar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Button btEditarCliente;
        private Button btEliminarCliente;
        private Button btAgregarCliente;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}