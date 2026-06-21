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
            dataGridViewClientes.Location = new Point(18, 17);
            dataGridViewClientes.Margin = new Padding(2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 102;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(986, 475);
            dataGridViewClientes.TabIndex = 0;
            // 
            // btEditarCliente
            // 
            btEditarCliente.Location = new Point(860, 510);
            btEditarCliente.Margin = new Padding(2);
            btEditarCliente.Name = "btEditarCliente";
            btEditarCliente.Size = new Size(144, 46);
            btEditarCliente.TabIndex = 1;
            btEditarCliente.Text = "Editar";
            btEditarCliente.UseVisualStyleBackColor = true;
            btEditarCliente.Click += btEditarCliente_Click;
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.Location = new Point(705, 510);
            btEliminarCliente.Margin = new Padding(2);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(144, 46);
            btEliminarCliente.TabIndex = 2;
            btEliminarCliente.Text = "Eliminar";
            btEliminarCliente.UseVisualStyleBackColor = true;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // btAgregarCliente
            // 
            btAgregarCliente.Location = new Point(546, 510);
            btAgregarCliente.Margin = new Padding(2);
            btAgregarCliente.Name = "btAgregarCliente";
            btAgregarCliente.Size = new Size(144, 46);
            btAgregarCliente.TabIndex = 3;
            btAgregarCliente.Text = "Agregar";
            btAgregarCliente.UseVisualStyleBackColor = true;
            btAgregarCliente.Click += btAgregarCliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(412, 520);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 520);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 31);
            textBox1.TabIndex = 5;
            // 
            // fClientesListar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 590);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btAgregarCliente);
            Controls.Add(btEliminarCliente);
            Controls.Add(btEditarCliente);
            Controls.Add(dataGridViewClientes);
            Margin = new Padding(2);
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
