namespace WinFormsApp1.Forms
{
    partial class fSesion
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
            lbBienvenida = new Label();
            lbRol = new Label();
            pnLateral = new Panel();
            btUsuario = new Button();
            btRol = new Button();
            btReserva = new Button();
            btHabitacion = new Button();
            btGastoExtra = new Button();
            btEstadia = new Button();
            btCuenta = new Button();
            btCliente = new Button();
            pnContenedor = new Panel();
            pnLateral.SuspendLayout();
            SuspendLayout();
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 15F);
            lbBienvenida.ForeColor = SystemColors.ButtonHighlight;
            lbBienvenida.Location = new Point(23, 9);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(183, 41);
            lbBienvenida.TabIndex = 0;
            lbBienvenida.Text = "Bienvenido!!";
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbRol.ForeColor = SystemColors.ButtonHighlight;
            lbRol.Location = new Point(3, 619);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(67, 32);
            lbRol.TabIndex = 1;
            lbRol.Text = "-Rol-";
            // 
            // pnLateral
            // 
            pnLateral.BackColor = Color.MidnightBlue;
            pnLateral.Controls.Add(btUsuario);
            pnLateral.Controls.Add(btRol);
            pnLateral.Controls.Add(btReserva);
            pnLateral.Controls.Add(btHabitacion);
            pnLateral.Controls.Add(btGastoExtra);
            pnLateral.Controls.Add(btEstadia);
            pnLateral.Controls.Add(btCuenta);
            pnLateral.Controls.Add(btCliente);
            pnLateral.Controls.Add(lbBienvenida);
            pnLateral.Controls.Add(lbRol);
            pnLateral.Location = new Point(0, 0);
            pnLateral.Name = "pnLateral";
            pnLateral.Size = new Size(281, 657);
            pnLateral.TabIndex = 2;
            // 
            // btUsuario
            // 
            btUsuario.BackColor = SystemColors.ActiveCaption;
            btUsuario.FlatAppearance.BorderSize = 0;
            btUsuario.FlatStyle = FlatStyle.Flat;
            btUsuario.ForeColor = SystemColors.ButtonHighlight;
            btUsuario.Location = new Point(0, 518);
            btUsuario.Name = "btUsuario";
            btUsuario.Size = new Size(281, 53);
            btUsuario.TabIndex = 9;
            btUsuario.Text = "Usuarios";
            btUsuario.UseVisualStyleBackColor = false;
            btUsuario.Click += btUsuario_Click;
            btUsuario.MouseEnter += button_MouseEnter;
            btUsuario.MouseLeave += button_MouseLeave;
            // 
            // btRol
            // 
            btRol.BackColor = SystemColors.ActiveCaption;
            btRol.FlatAppearance.BorderSize = 0;
            btRol.FlatStyle = FlatStyle.Flat;
            btRol.ForeColor = SystemColors.ButtonHighlight;
            btRol.Location = new Point(0, 464);
            btRol.Name = "btRol";
            btRol.Size = new Size(281, 53);
            btRol.TabIndex = 8;
            btRol.Text = "Roles";
            btRol.UseVisualStyleBackColor = false;
            btRol.Click += btRol_Click;
            btRol.MouseEnter += button_MouseEnter;
            btRol.MouseLeave += button_MouseLeave;
            // 
            // btReserva
            // 
            btReserva.BackColor = SystemColors.ActiveCaption;
            btReserva.FlatAppearance.BorderSize = 0;
            btReserva.FlatStyle = FlatStyle.Flat;
            btReserva.ForeColor = SystemColors.ButtonHighlight;
            btReserva.Location = new Point(0, 410);
            btReserva.Name = "btReserva";
            btReserva.Size = new Size(281, 53);
            btReserva.TabIndex = 7;
            btReserva.Text = "Reservas";
            btReserva.UseVisualStyleBackColor = false;
            btReserva.Click += btReserva_Click;
            btReserva.MouseEnter += button_MouseEnter;
            btReserva.MouseLeave += button_MouseLeave;
            // 
            // btHabitacion
            // 
            btHabitacion.BackColor = SystemColors.ActiveCaption;
            btHabitacion.FlatAppearance.BorderSize = 0;
            btHabitacion.FlatStyle = FlatStyle.Flat;
            btHabitacion.ForeColor = SystemColors.ButtonHighlight;
            btHabitacion.Location = new Point(0, 356);
            btHabitacion.Name = "btHabitacion";
            btHabitacion.Size = new Size(281, 53);
            btHabitacion.TabIndex = 6;
            btHabitacion.Text = "Habitaciones";
            btHabitacion.UseVisualStyleBackColor = false;
            btHabitacion.Click += btHabitacion_Click;
            btHabitacion.MouseEnter += button_MouseEnter;
            btHabitacion.MouseLeave += button_MouseLeave;
            // 
            // btGastoExtra
            // 
            btGastoExtra.BackColor = SystemColors.ActiveCaption;
            btGastoExtra.FlatAppearance.BorderSize = 0;
            btGastoExtra.FlatStyle = FlatStyle.Flat;
            btGastoExtra.ForeColor = SystemColors.ButtonHighlight;
            btGastoExtra.Location = new Point(0, 302);
            btGastoExtra.Name = "btGastoExtra";
            btGastoExtra.Size = new Size(281, 53);
            btGastoExtra.TabIndex = 5;
            btGastoExtra.Text = "Gastos Extras";
            btGastoExtra.UseVisualStyleBackColor = false;
            btGastoExtra.Click += btGastoExtra_Click;
            btGastoExtra.MouseEnter += button_MouseEnter;
            btGastoExtra.MouseLeave += button_MouseLeave;
            // 
            // btEstadia
            // 
            btEstadia.BackColor = SystemColors.ActiveCaption;
            btEstadia.FlatAppearance.BorderSize = 0;
            btEstadia.FlatStyle = FlatStyle.Flat;
            btEstadia.ForeColor = SystemColors.ButtonHighlight;
            btEstadia.Location = new Point(0, 248);
            btEstadia.Name = "btEstadia";
            btEstadia.Size = new Size(281, 53);
            btEstadia.TabIndex = 4;
            btEstadia.Text = "Estadias";
            btEstadia.UseVisualStyleBackColor = false;
            btEstadia.Click += btEstadia_Click;
            btEstadia.MouseEnter += button_MouseEnter;
            btEstadia.MouseLeave += button_MouseLeave;
            // 
            // btCuenta
            // 
            btCuenta.BackColor = SystemColors.ActiveCaption;
            btCuenta.FlatAppearance.BorderSize = 0;
            btCuenta.FlatStyle = FlatStyle.Flat;
            btCuenta.ForeColor = SystemColors.ButtonHighlight;
            btCuenta.Location = new Point(0, 194);
            btCuenta.Name = "btCuenta";
            btCuenta.Size = new Size(281, 53);
            btCuenta.TabIndex = 3;
            btCuenta.Text = "Cuentas";
            btCuenta.UseVisualStyleBackColor = false;
            btCuenta.Click += btCuenta_Click;
            btCuenta.MouseEnter += button_MouseEnter;
            btCuenta.MouseLeave += button_MouseLeave;
            // 
            // btCliente
            // 
            btCliente.BackColor = SystemColors.ActiveCaption;
            btCliente.FlatAppearance.BorderSize = 0;
            btCliente.FlatStyle = FlatStyle.Flat;
            btCliente.ForeColor = SystemColors.ButtonHighlight;
            btCliente.Location = new Point(0, 140);
            btCliente.Name = "btCliente";
            btCliente.Size = new Size(281, 53);
            btCliente.TabIndex = 2;
            btCliente.Text = "Clientes";
            btCliente.UseVisualStyleBackColor = false;
            btCliente.Click += btCliente_Click;
            btCliente.MouseEnter += button_MouseEnter;
            btCliente.MouseLeave += button_MouseLeave;
            // 
            // pnContenedor
            // 
            pnContenedor.Location = new Point(281, 0);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(905, 657);
            pnContenedor.TabIndex = 3;
            // 
            // fSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 656);
            ControlBox = false;
            Controls.Add(pnContenedor);
            Controls.Add(pnLateral);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "fSesion";
            Text = "fSesion";
            pnLateral.ResumeLayout(false);
            pnLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbBienvenida;
        private Label lbRol;
        private Panel pnLateral;
        private Button btCliente;
        private Button btCuenta;
        private Button btUsuario;
        private Button btRol;
        private Button btReserva;
        private Button btHabitacion;
        private Button btGastoExtra;
        private Button btEstadia;
        private Panel pnContenedor;
    }
}