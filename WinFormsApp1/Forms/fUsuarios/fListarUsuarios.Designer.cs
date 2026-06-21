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
            dgListarUsuarios = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btAgregarUsuario = new Button();
            btEliminarUsuario = new Button();
            btModificarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgListarUsuarios
            // 
            dgListarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarUsuarios.Location = new Point(52, 33);
            dgListarUsuarios.Name = "dgListarUsuarios";
            dgListarUsuarios.RowHeadersWidth = 51;
            dgListarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarUsuarios.Size = new Size(895, 534);
            dgListarUsuarios.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 600);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 600);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 2;
            // 
            // btAgregarUsuario
            // 
            btAgregarUsuario.Location = new Point(399, 590);
            btAgregarUsuario.Name = "btAgregarUsuario";
            btAgregarUsuario.Size = new Size(163, 47);
            btAgregarUsuario.TabIndex = 3;
            btAgregarUsuario.Text = "Agregar";
            btAgregarUsuario.UseVisualStyleBackColor = true;
            btAgregarUsuario.Click += btAgregarUsuario_Click;
            // 
            // btEliminarUsuario
            // 
            btEliminarUsuario.Location = new Point(590, 590);
            btEliminarUsuario.Name = "btEliminarUsuario";
            btEliminarUsuario.Size = new Size(163, 47);
            btEliminarUsuario.TabIndex = 4;
            btEliminarUsuario.Text = "Eliminar";
            btEliminarUsuario.UseVisualStyleBackColor = true;
            btEliminarUsuario.Click += btEliminarUsuario_Click;
            // 
            // btModificarUsuario
            // 
            btModificarUsuario.Location = new Point(784, 590);
            btModificarUsuario.Name = "btModificarUsuario";
            btModificarUsuario.Size = new Size(163, 47);
            btModificarUsuario.TabIndex = 5;
            btModificarUsuario.Text = "Modificar";
            btModificarUsuario.UseVisualStyleBackColor = true;
            btModificarUsuario.Click += btModificarUsuario_Click;
            // 
            // fListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 673);
            Controls.Add(btModificarUsuario);
            Controls.Add(btEliminarUsuario);
            Controls.Add(btAgregarUsuario);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgListarUsuarios);
            Name = "fListarUsuarios";
            Text = "fListarUsuarios";
            Load += fListarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgListarUsuarios;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btAgregarUsuario;
        private Button btEliminarUsuario;
        private Button btModificarUsuario;
    }
}