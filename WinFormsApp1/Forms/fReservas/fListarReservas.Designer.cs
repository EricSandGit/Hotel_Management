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
            dgListarReservas.Location = new Point(10, 14);
            dgListarReservas.Margin = new Padding(2);
            dgListarReservas.Name = "dgListarReservas";
            dgListarReservas.RowHeadersWidth = 62;
            dgListarReservas.Size = new Size(742, 446);
            dgListarReservas.TabIndex = 0;
            // 
            // btAgregarLReserva
            // 
            btAgregarLReserva.Location = new Point(398, 472);
            btAgregarLReserva.Margin = new Padding(2);
            btAgregarLReserva.Name = "btAgregarLReserva";
            btAgregarLReserva.Size = new Size(90, 27);
            btAgregarLReserva.TabIndex = 3;
            btAgregarLReserva.Text = "Agregar";
            btAgregarLReserva.UseVisualStyleBackColor = true;
            btAgregarLReserva.Click += btAgregarLReserva_Click;
            // 
            // btEliminarLReserva
            // 
            btEliminarLReserva.Location = new Point(492, 473);
            btEliminarLReserva.Margin = new Padding(2);
            btEliminarLReserva.Name = "btEliminarLReserva";
            btEliminarLReserva.Size = new Size(90, 27);
            btEliminarLReserva.TabIndex = 4;
            btEliminarLReserva.Text = "Eliminar";
            btEliminarLReserva.UseVisualStyleBackColor = true;
            btEliminarLReserva.Click += btEliminarLReserva_Click;
            // 
            // btModificarLReserva
            // 
            btModificarLReserva.Location = new Point(586, 473);
            btModificarLReserva.Margin = new Padding(2);
            btModificarLReserva.Name = "btModificarLReserva";
            btModificarLReserva.Size = new Size(90, 27);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 673);
            Controls.Add(btModificarLReserva);
            Controls.Add(btEliminarLReserva);
            Controls.Add(btAgregarLReserva);
            Controls.Add(dgListarReservas);
            Margin = new Padding(2);
            Name = "fListarReservas";
            Text = "fListarReservas";
            Load += fListarReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgListarReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgListarReservas;
        private Button btAgregarLReserva;
        private Button btEliminarLReserva;
        private Button btModificarLReserva;
        private Button btCheckInLReserva;
        private Button btCheckOutLReserva;
    }
}
