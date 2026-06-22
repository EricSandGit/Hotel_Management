namespace WinFormsApp1.Forms.fEstadias
{
    partial class fModificarEstadia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btCancelar = new Button();
            btAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbEstReserva = new ComboBox();
            cbEstUsuario = new ComboBox();
            dtCheckin = new DateTimePicker();
            dtCheckout = new DateTimePicker();
            cbEstado = new ComboBox();
            chkCheckoutNulo = new CheckBox();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(400, 320);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(120, 35);
            btCancelar.TabIndex = 6;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(220, 320);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(120, 35);
            btAceptar.TabIndex = 5;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 12;
            label1.Text = "Reserva ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 11;
            label2.Text = "Usuario ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 170);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 10;
            label3.Text = "Fecha Check-in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 170);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 9;
            label4.Text = "Fecha Check-out";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 30);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // cbEstReserva
            // 
            cbEstReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstReserva.FormattingEnabled = true;
            cbEstReserva.Location = new Point(30, 60);
            cbEstReserva.Name = "cbEstReserva";
            cbEstReserva.Size = new Size(250, 28);
            cbEstReserva.TabIndex = 0;
            // 
            // cbEstUsuario
            // 
            cbEstUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstUsuario.FormattingEnabled = true;
            cbEstUsuario.Location = new Point(30, 130);
            cbEstUsuario.Name = "cbEstUsuario";
            cbEstUsuario.Size = new Size(250, 28);
            cbEstUsuario.TabIndex = 1;
            // 
            // dtCheckin
            // 
            dtCheckin.Location = new Point(30, 200);
            dtCheckin.Name = "dtCheckin";
            dtCheckin.Size = new Size(250, 27);
            dtCheckin.TabIndex = 2;
            // 
            // dtCheckout
            // 
            dtCheckout.Enabled = false;
            dtCheckout.Location = new Point(350, 200);
            dtCheckout.Name = "dtCheckout";
            dtCheckout.Size = new Size(250, 27);
            dtCheckout.TabIndex = 4;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "activa", "finalizada" });
            cbEstado.Location = new Point(350, 60);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(250, 28);
            cbEstado.TabIndex = 3;
            // 
            // chkCheckoutNulo
            // 
            chkCheckoutNulo.AutoSize = true;
            chkCheckoutNulo.Location = new Point(350, 240);
            chkCheckoutNulo.Name = "chkCheckoutNulo";
            chkCheckoutNulo.Size = new Size(168, 24);
            chkCheckoutNulo.TabIndex = 7;
            chkCheckoutNulo.Text = "Sin Check-out (Nulo)";
            chkCheckoutNulo.UseVisualStyleBackColor = true;
            chkCheckoutNulo.CheckedChanged += chkCheckoutNulo_CheckedChanged;
            // 
            // fModificarEstadia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 225, 212);
            ClientSize = new Size(650, 390);
            Controls.Add(chkCheckoutNulo);
            Controls.Add(cbEstado);
            Controls.Add(dtCheckout);
            Controls.Add(dtCheckin);
            Controls.Add(cbEstUsuario);
            Controls.Add(cbEstReserva);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btAceptar);
            Controls.Add(btCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fModificarEstadia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Estadía";
            Load += fModificarEstadia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstReserva;
        private System.Windows.Forms.ComboBox cbEstUsuario;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.CheckBox chkCheckoutNulo;
    }
}