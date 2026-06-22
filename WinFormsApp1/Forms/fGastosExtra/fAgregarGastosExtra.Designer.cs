namespace WinFormsApp1.Forms.fGastosExtra
{
    partial class fAgregarGastosExtra
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
            btGuardarGE = new Button();
            btCancelarGE = new Button();
            cbEstadia = new ComboBox();
            lbSeleccionarEstadia = new Label();
            tbConcepto = new TextBox();
            lbConcepto = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btGuardarGE
            // 
            btGuardarGE.BackColor = Color.FromArgb(30, 30, 30);
            btGuardarGE.FlatStyle = FlatStyle.Flat;
            btGuardarGE.ForeColor = SystemColors.Control;
            btGuardarGE.Location = new Point(255, 609);
            btGuardarGE.Name = "btGuardarGE";
            btGuardarGE.Size = new Size(350, 59);
            btGuardarGE.TabIndex = 0;
            btGuardarGE.Text = "Guardar";
            btGuardarGE.UseVisualStyleBackColor = false;
            btGuardarGE.Click += btGuardarGE_Click;
            // 
            // btCancelarGE
            // 
            btCancelarGE.BackColor = Color.FromArgb(30, 30, 30);
            btCancelarGE.FlatStyle = FlatStyle.Flat;
            btCancelarGE.ForeColor = Color.White;
            btCancelarGE.Location = new Point(640, 609);
            btCancelarGE.Name = "btCancelarGE";
            btCancelarGE.Size = new Size(350, 59);
            btCancelarGE.TabIndex = 1;
            btCancelarGE.Text = "Cancelar";
            btCancelarGE.UseVisualStyleBackColor = false;
            btCancelarGE.Click += btCancelarGE_Click;
            // 
            // cbEstadia
            // 
            cbEstadia.FormattingEnabled = true;
            cbEstadia.Location = new Point(368, 115);
            cbEstadia.Name = "cbEstadia";
            cbEstadia.Size = new Size(516, 33);
            cbEstadia.TabIndex = 2;
            // 
            // lbSeleccionarEstadia
            // 
            lbSeleccionarEstadia.AutoSize = true;
            lbSeleccionarEstadia.Location = new Point(522, 87);
            lbSeleccionarEstadia.Name = "lbSeleccionarEstadia";
            lbSeleccionarEstadia.Size = new Size(201, 25);
            lbSeleccionarEstadia.TabIndex = 3;
            lbSeleccionarEstadia.Text = "Seleccione una estadía...";
            // 
            // tbConcepto
            // 
            tbConcepto.Location = new Point(368, 293);
            tbConcepto.Name = "tbConcepto";
            tbConcepto.Size = new Size(516, 31);
            tbConcepto.TabIndex = 4;
            // 
            // lbConcepto
            // 
            lbConcepto.AutoSize = true;
            lbConcepto.Location = new Point(522, 265);
            lbConcepto.Name = "lbConcepto";
            lbConcepto.Size = new Size(178, 25);
            lbConcepto.TabIndex = 5;
            lbConcepto.Text = "Ingrese un concepto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 361);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 6;
            label1.Text = "Ingrese un monto:";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(368, 389);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(516, 31);
            numericUpDown1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(368, 479);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(516, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 451);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 9;
            label2.Text = "Ingrese una fecha:";
            // 
            // fAgregarGastosExtra
            // 
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(1215, 841);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(lbConcepto);
            Controls.Add(tbConcepto);
            Controls.Add(lbSeleccionarEstadia);
            Controls.Add(cbEstadia);
            Controls.Add(btCancelarGE);
            Controls.Add(btGuardarGE);
            Name = "fAgregarGastosExtra";
            Text = "fAgregarGastosExtra";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGuardarGE;
        private Button btCancelarGE;
        private ComboBox cbEstadia;
        private Label lbSeleccionarEstadia;
        private TextBox tbConcepto;
        private Label lbConcepto;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}