namespace CapaUI
{
    partial class AddDetalle
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

        private void InitializeComponent()
        {
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.labelUnidades = new System.Windows.Forms.Label();
            this.textBoxUnidades = new System.Windows.Forms.TextBox();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.Black;
            this.labelProducto.Location = new System.Drawing.Point(12, 32);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(153, 22);
            this.labelProducto.TabIndex = 0;
            this.labelProducto.Text = "ID del producto:";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxProducto.Location = new System.Drawing.Point(230, 27);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(200, 30);
            this.textBoxProducto.TabIndex = 1;
            // 
            // labelUnidades
            // 
            this.labelUnidades.AutoSize = true;
            this.labelUnidades.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidades.ForeColor = System.Drawing.Color.Black;
            this.labelUnidades.Location = new System.Drawing.Point(12, 106);
            this.labelUnidades.Name = "labelUnidades";
            this.labelUnidades.Size = new System.Drawing.Size(98, 22);
            this.labelUnidades.TabIndex = 4;
            this.labelUnidades.Text = "Unidades:";
            // 
            // textBoxUnidades
            // 
            this.textBoxUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUnidades.Location = new System.Drawing.Point(230, 104);
            this.textBoxUnidades.Name = "textBoxUnidades";
            this.textBoxUnidades.Size = new System.Drawing.Size(200, 30);
            this.textBoxUnidades.TabIndex = 5;
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAnadir.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadir.ForeColor = System.Drawing.Color.White;
            this.buttonAnadir.Location = new System.Drawing.Point(114, 177);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(200, 40);
            this.buttonAnadir.TabIndex = 6;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = false;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // AddDetalle
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.textBoxUnidades);
            this.Controls.Add(this.labelUnidades);
            this.Controls.Add(this.textBoxProducto);
            this.Controls.Add(this.labelProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Detalle a Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label labelUnidades;
        private System.Windows.Forms.TextBox textBoxUnidades;
        private System.Windows.Forms.Button buttonAnadir;
    }
}