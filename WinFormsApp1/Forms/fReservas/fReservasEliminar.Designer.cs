namespace WinFormsApp1.Forms.fReservas
{
    partial class fReservasEliminar
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
            label1 = new Label();
            btEliminar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 66);
            label1.Name = "label1";
            label1.Size = new Size(312, 25);
            label1.TabIndex = 0;
            label1.Text = "¿Estas seguro que lo quieres eliminar?";
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(83, 179);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(147, 34);
            btEliminar.TabIndex = 1;
            btEliminar.Text = "Si, Estoy seguro";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(248, 179);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(147, 34);
            btCancelar.TabIndex = 2;
            btCancelar.Text = "No, Volver";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // fReservasEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 252);
            Controls.Add(btCancelar);
            Controls.Add(btEliminar);
            Controls.Add(label1);
            Name = "fReservasEliminar";
            Text = "fReservasEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btEliminar;
        private Button btCancelar;
    }
}