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
            btAgregarUsuario = new Button();
            btEliminarUsuario = new Button();
            btModificarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgListarUsuarios
            // 
            dgListarUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListarUsuarios.BackgroundColor = Color.FromArgb(165, 150, 135);
            dgListarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarUsuarios.Location = new Point(32, 33);
            dgListarUsuarios.Name = "dgListarUsuarios";
            dgListarUsuarios.RowHeadersWidth = 51;
            dgListarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarUsuarios.Size = new Size(915, 534);
            dgListarUsuarios.TabIndex = 0;
            // 
            // btAgregarUsuario
            // 
            btAgregarUsuario.BackColor = Color.FromArgb(30, 30, 30);
            btAgregarUsuario.FlatAppearance.BorderSize = 0;
            btAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btAgregarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btAgregarUsuario.Location = new Point(32, 590);
            btAgregarUsuario.Name = "btAgregarUsuario";
            btAgregarUsuario.Size = new Size(280, 47);
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
            btEliminarUsuario.Location = new Point(348, 590);
            btEliminarUsuario.Name = "btEliminarUsuario";
            btEliminarUsuario.Size = new Size(280, 47);
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
            btModificarUsuario.Location = new Point(667, 590);
            btModificarUsuario.Name = "btModificarUsuario";
            btModificarUsuario.Size = new Size(280, 47);
            btModificarUsuario.TabIndex = 5;
            btModificarUsuario.Text = "Modificar";
            btModificarUsuario.UseVisualStyleBackColor = false;
            btModificarUsuario.Click += btModificarUsuario_Click;
            // 
            // fListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(972, 673);
            Controls.Add(btModificarUsuario);
            Controls.Add(btEliminarUsuario);
            Controls.Add(btAgregarUsuario);
            Controls.Add(dgListarUsuarios);
            Name = "fListarUsuarios";
            Text = "fListarUsuarios";
            Load += fListarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgListarUsuarios;
        private Button btAgregarUsuario;
        private Button btEliminarUsuario;
        private Button btModificarUsuario;
    }
}