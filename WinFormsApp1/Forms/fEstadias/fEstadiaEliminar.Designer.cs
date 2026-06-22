namespace WinFormsApp1.Forms.fEstadias
{
    partial class fEstadiaEliminar
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
            btCancelar = new Button();
            btEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(288, 185);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(147, 34);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "No, Volver";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(123, 185);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(147, 34);
            btEliminar.TabIndex = 4;
            btEliminar.Text = "Si, Estoy seguro";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 72);
            label1.Name = "label1";
            label1.Size = new Size(312, 25);
            label1.TabIndex = 3;
            label1.Text = "¿Estas seguro que lo quieres eliminar?";
            // 
            // fEstadiaEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 291);
            Controls.Add(btCancelar);
            Controls.Add(btEliminar);
            Controls.Add(label1);
            Name = "fEstadiaEliminar";
            Text = "fEstadiaEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btEliminar;
        private Label label1;
    }
}