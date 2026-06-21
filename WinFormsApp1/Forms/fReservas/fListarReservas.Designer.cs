namespace WinFormsApp1.Forms.fReservas
{
    partial class fListarReservas
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
            dgListarReservas = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btAgregarLReserva = new Button();
            btEliminarLReserva = new Button();
            btModificarLReserva = new Button();
            btCheckInLReserva = new Button();
            btCheckOutLReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListarReservas).BeginInit();
            SuspendLayout();
            // 
            // dgListarReservas
            // 
            dgListarReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarReservas.Location = new Point(12, 18);
            dgListarReservas.Name = "dgListarReservas";
            dgListarReservas.RowHeadersWidth = 62;
            dgListarReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarReservas.Size = new Size(1170, 558);
            dgListarReservas.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 594);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 31);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(326, 592);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 33);
            comboBox1.TabIndex = 2;
            // 
            // btAgregarLReserva
            // 
            btAgregarLReserva.Location = new Point(497, 590);
            btAgregarLReserva.Name = "btAgregarLReserva";
            btAgregarLReserva.Size = new Size(112, 34);
            btAgregarLReserva.TabIndex = 3;
            btAgregarLReserva.Text = "Agregar";
            btAgregarLReserva.UseVisualStyleBackColor = true;
            btAgregarLReserva.Click += btAgregarLReserva_Click;
            // 
            // btEliminarLReserva
            // 
            btEliminarLReserva.Location = new Point(615, 591);
            btEliminarLReserva.Name = "btEliminarLReserva";
            btEliminarLReserva.Size = new Size(112, 34);
            btEliminarLReserva.TabIndex = 4;
            btEliminarLReserva.Text = "Eliminar";
            btEliminarLReserva.UseVisualStyleBackColor = true;
            btEliminarLReserva.Click += btEliminarLReserva_Click;
            // 
            // btModificarLReserva
            // 
            btModificarLReserva.Location = new Point(733, 591);
            btModificarLReserva.Name = "btModificarLReserva";
            btModificarLReserva.Size = new Size(112, 34);
            btModificarLReserva.TabIndex = 5;
            btModificarLReserva.Text = "Modificar";
            btModificarLReserva.UseVisualStyleBackColor = true;
            btModificarLReserva.Click += btModificarLReserva_Click;
            // 
            // btCheckInLReserva
            // 
            btCheckInLReserva.Location = new Point(851, 591);
            btCheckInLReserva.Name = "btCheckInLReserva";
            btCheckInLReserva.Size = new Size(160, 34);
            btCheckInLReserva.TabIndex = 6;
            btCheckInLReserva.Text = "Check In";
            btCheckInLReserva.UseVisualStyleBackColor = true;
            btCheckInLReserva.Click += btCheckInLReserva_Click;
            // 
            // btCheckOutLReserva
            // 
            btCheckOutLReserva.Location = new Point(1022, 591);
            btCheckOutLReserva.Name = "btCheckOutLReserva";
            btCheckOutLReserva.Size = new Size(160, 34);
            btCheckOutLReserva.TabIndex = 7;
            btCheckOutLReserva.Text = "Check Out";
            btCheckOutLReserva.UseVisualStyleBackColor = true;
            // 
            // fListarReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 664);
            Controls.Add(btCheckOutLReserva);
            Controls.Add(btCheckInLReserva);
            Controls.Add(btModificarLReserva);
            Controls.Add(btEliminarLReserva);
            Controls.Add(btAgregarLReserva);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgListarReservas);
            Name = "fListarReservas";
            Text = "fListarReservas";
            Load += fListarReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgListarReservas;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btAgregarLReserva;
        private Button btEliminarLReserva;
        private Button btModificarLReserva;
        private Button btCheckInLReserva;
        private Button btCheckOutLReserva;
    }
}
