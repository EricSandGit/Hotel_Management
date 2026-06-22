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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgListarReservas = new DataGridView();
            btAgregarLReserva = new Button();
            btEliminarLReserva = new Button();
            btModificarLReserva = new Button();
            btCheckInLReserva = new Button();
            btCheckOutLReserva = new Button();
            btCheckIn = new Button();
            btCheckOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListarReservas).BeginInit();
            SuspendLayout();
            // 
            // dgListarReservas
            // 
            dgListarReservas.AllowUserToAddRows = false;
            dgListarReservas.AllowUserToDeleteRows = false;
            dgListarReservas.AllowUserToResizeColumns = false;
            dgListarReservas.AllowUserToResizeRows = false;
            dgListarReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListarReservas.BackgroundColor = Color.FromArgb(165, 150, 135);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListarReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListarReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListarReservas.EnableHeadersVisualStyles = false;
            dgListarReservas.GridColor = Color.PowderBlue;
            dgListarReservas.Location = new Point(35, 24);
            dgListarReservas.Margin = new Padding(2);
            dgListarReservas.Name = "dgListarReservas";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(195, 180, 165);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgListarReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgListarReservas.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 95, 80);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgListarReservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgListarReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListarReservas.Size = new Size(1144, 645);
            dgListarReservas.TabIndex = 0;
            dgListarReservas.CellContentClick += dgListarReservas_CellContentClick;
            // 
            // btAgregarLReserva
            // 
            btAgregarLReserva.BackColor = Color.FromArgb(30, 30, 30);
            btAgregarLReserva.ForeColor = SystemColors.ButtonHighlight;
            btAgregarLReserva.Location = new Point(35, 690);
            btAgregarLReserva.Margin = new Padding(2);
            btAgregarLReserva.Name = "btAgregarLReserva";
            btAgregarLReserva.Size = new Size(350, 59);
            btAgregarLReserva.TabIndex = 3;
            btAgregarLReserva.Text = "Agregar";
            btAgregarLReserva.UseVisualStyleBackColor = false;
            btAgregarLReserva.Click += btAgregarLReserva_Click;
            // 
            // btEliminarLReserva
            // 
            btEliminarLReserva.BackColor = Color.FromArgb(30, 30, 30);
            btEliminarLReserva.ForeColor = SystemColors.ButtonHighlight;
            btEliminarLReserva.Location = new Point(444, 690);
            btEliminarLReserva.Margin = new Padding(2);
            btEliminarLReserva.Name = "btEliminarLReserva";
            btEliminarLReserva.Size = new Size(350, 59);
            btEliminarLReserva.TabIndex = 4;
            btEliminarLReserva.Text = "Eliminar";
            btEliminarLReserva.UseVisualStyleBackColor = false;
            btEliminarLReserva.Click += btEliminarLReserva_Click;
            // 
            // btModificarLReserva
            // 
            btModificarLReserva.BackColor = Color.FromArgb(30, 30, 30);
            btModificarLReserva.ForeColor = SystemColors.ButtonHighlight;
            btModificarLReserva.Location = new Point(829, 690);
            btModificarLReserva.Margin = new Padding(2);
            btModificarLReserva.Name = "btModificarLReserva";
            btModificarLReserva.Size = new Size(350, 59);
            btModificarLReserva.TabIndex = 5;
            btModificarLReserva.Text = "Modificar";
            btModificarLReserva.UseVisualStyleBackColor = false;
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
            // btCheckIn
            // 
            btCheckIn.BackColor = Color.FromArgb(30, 30, 30);
            btCheckIn.ForeColor = SystemColors.ButtonHighlight;
            btCheckIn.Location = new Point(35, 771);
            btCheckIn.Margin = new Padding(2);
            btCheckIn.Name = "btCheckIn";
            btCheckIn.Size = new Size(350, 59);
            btCheckIn.TabIndex = 6;
            btCheckIn.Text = "Check In";
            btCheckIn.UseVisualStyleBackColor = false;
            btCheckIn.Click += btCheckInLReserva_Click;
            // 
            // btCheckOut
            // 
            btCheckOut.BackColor = Color.FromArgb(30, 30, 30);
            btCheckOut.ForeColor = SystemColors.ButtonHighlight;
            btCheckOut.Location = new Point(829, 771);
            btCheckOut.Margin = new Padding(2);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(350, 59);
            btCheckOut.TabIndex = 7;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = false;
            btCheckOut.Click += btCheckOutLReserva_Click;
            // 
            // fListarReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(btCheckOut);
            Controls.Add(btCheckIn);
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
        private Button btCheckIn;
        private Button btCheckOut;
    }
}
