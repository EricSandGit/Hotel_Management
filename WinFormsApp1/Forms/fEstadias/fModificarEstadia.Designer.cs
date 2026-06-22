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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstReserva = new System.Windows.Forms.ComboBox();
            this.cbEstUsuario = new System.Windows.Forms.ComboBox();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.chkCheckoutNulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(400, 320);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(120, 35);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(220, 320);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(120, 35);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.Text = "Reserva ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.Text = "Usuario ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.Text = "Fecha Check-in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.Text = "Fecha Check-out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.Text = "Estado";
            // 
            // cbEstReserva
            // 
            this.cbEstReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstReserva.FormattingEnabled = true;
            this.cbEstReserva.Location = new System.Drawing.Point(30, 60);
            this.cbEstReserva.Name = "cbEstReserva";
            this.cbEstReserva.Size = new System.Drawing.Size(250, 28);
            this.cbEstReserva.TabIndex = 0;
            // 
            // cbEstUsuario
            // 
            this.cbEstUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstUsuario.FormattingEnabled = true;
            this.cbEstUsuario.Location = new System.Drawing.Point(30, 130);
            this.cbEstUsuario.Name = "cbEstUsuario";
            this.cbEstUsuario.Size = new System.Drawing.Size(250, 28);
            this.cbEstUsuario.TabIndex = 1;
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(30, 200);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(250, 27);
            this.dtCheckin.TabIndex = 2;
            // 
            // dtCheckout
            // 
            this.dtCheckout.Enabled = false;
            this.dtCheckout.Location = new System.Drawing.Point(350, 200);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(250, 27);
            this.dtCheckout.TabIndex = 4;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "activa",
            "finalizada"});
            this.cbEstado.Location = new System.Drawing.Point(350, 60);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(250, 28);
            this.cbEstado.TabIndex = 3;
            // 
            // chkCheckoutNulo
            // 
            this.chkCheckoutNulo.AutoSize = true;
            this.chkCheckoutNulo.Location = new System.Drawing.Point(350, 240);
            this.chkCheckoutNulo.Name = "chkCheckoutNulo";
            this.chkCheckoutNulo.Size = new System.Drawing.Size(163, 24);
            this.chkCheckoutNulo.TabIndex = 7;
            this.chkCheckoutNulo.Text = "Sin Check-out (Nulo)";
            this.chkCheckoutNulo.UseVisualStyleBackColor = true;
            this.chkCheckoutNulo.CheckedChanged += new System.EventHandler(this.chkCheckoutNulo_CheckedChanged);
            // 
            // fModificarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(230, 225, 212);
            this.ClientSize = new System.Drawing.Size(650, 390);
            this.Controls.Add(this.chkCheckoutNulo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dtCheckout);
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.cbEstUsuario);
            this.Controls.Add(this.cbEstReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Name = "fModificarEstadia";
            this.Text = "Modificar Estadía";
            this.Load += new System.EventHandler(this.fModificarEstadia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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