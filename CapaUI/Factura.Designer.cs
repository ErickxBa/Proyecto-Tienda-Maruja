namespace CapaUI
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCedulaCliente = new System.Windows.Forms.Label();
            this.textBoxCedulaCliente = new System.Windows.Forms.TextBox();
            this.labelCedulaEmpleado = new System.Windows.Forms.Label();
            this.textBoxCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.labelDetallesFactura = new System.Windows.Forms.Label();
            this.dataGridViewDetallesFactura = new System.Windows.Forms.DataGridView();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.textBoxTotalFactura = new System.Windows.Forms.TextBox();
            this.buttonAñadirDetalle = new System.Windows.Forms.Button();
            this.buttonEliminarDetalle = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(279, 23);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(273, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Registrar Factura";
            // 
            // labelCedulaCliente
            // 
            this.labelCedulaCliente.AutoSize = true;
            this.labelCedulaCliente.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedulaCliente.ForeColor = System.Drawing.Color.Black;
            this.labelCedulaCliente.Location = new System.Drawing.Point(8, 137);
            this.labelCedulaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCedulaCliente.Name = "labelCedulaCliente";
            this.labelCedulaCliente.Size = new System.Drawing.Size(290, 22);
            this.labelCedulaCliente.TabIndex = 1;
            this.labelCedulaCliente.Text = "Cédula de Identidad del Cliente:";
            // 
            // textBoxCedulaCliente
            // 
            this.textBoxCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCedulaCliente.Location = new System.Drawing.Point(379, 134);
            this.textBoxCedulaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCedulaCliente.Name = "textBoxCedulaCliente";
            this.textBoxCedulaCliente.Size = new System.Drawing.Size(332, 30);
            this.textBoxCedulaCliente.TabIndex = 2;
            // 
            // labelCedulaEmpleado
            // 
            this.labelCedulaEmpleado.AutoSize = true;
            this.labelCedulaEmpleado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedulaEmpleado.ForeColor = System.Drawing.Color.Black;
            this.labelCedulaEmpleado.Location = new System.Drawing.Point(8, 194);
            this.labelCedulaEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCedulaEmpleado.Name = "labelCedulaEmpleado";
            this.labelCedulaEmpleado.Size = new System.Drawing.Size(316, 22);
            this.labelCedulaEmpleado.TabIndex = 3;
            this.labelCedulaEmpleado.Text = "Cédula de Identidad del Empleado:";
            // 
            // textBoxCedulaEmpleado
            // 
            this.textBoxCedulaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCedulaEmpleado.Location = new System.Drawing.Point(379, 194);
            this.textBoxCedulaEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCedulaEmpleado.Name = "textBoxCedulaEmpleado";
            this.textBoxCedulaEmpleado.Size = new System.Drawing.Size(332, 30);
            this.textBoxCedulaEmpleado.TabIndex = 4;
            // 
            // labelDetallesFactura
            // 
            this.labelDetallesFactura.AutoSize = true;
            this.labelDetallesFactura.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetallesFactura.ForeColor = System.Drawing.Color.Black;
            this.labelDetallesFactura.Location = new System.Drawing.Point(8, 241);
            this.labelDetallesFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetallesFactura.Name = "labelDetallesFactura";
            this.labelDetallesFactura.Size = new System.Drawing.Size(203, 22);
            this.labelDetallesFactura.TabIndex = 5;
            this.labelDetallesFactura.Text = "Detalles de la Factura";
            // 
            // dataGridViewDetallesFactura
            // 
            this.dataGridViewDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallesFactura.Location = new System.Drawing.Point(13, 285);
            this.dataGridViewDetallesFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDetallesFactura.Name = "dataGridViewDetallesFactura";
            this.dataGridViewDetallesFactura.RowHeadersWidth = 51;
            this.dataGridViewDetallesFactura.Size = new System.Drawing.Size(332, 339);
            this.dataGridViewDetallesFactura.TabIndex = 6;
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFactura.ForeColor = System.Drawing.Color.Black;
            this.labelTotalFactura.Location = new System.Drawing.Point(18, 654);
            this.labelTotalFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(182, 22);
            this.labelTotalFactura.TabIndex = 7;
            this.labelTotalFactura.Text = "Total de la Factura:";
            // 
            // textBoxTotalFactura
            // 
            this.textBoxTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTotalFactura.Location = new System.Drawing.Point(228, 650);
            this.textBoxTotalFactura.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalFactura.Name = "textBoxTotalFactura";
            this.textBoxTotalFactura.Size = new System.Drawing.Size(199, 30);
            this.textBoxTotalFactura.TabIndex = 8;
            // 
            // buttonAñadirDetalle
            // 
            this.buttonAñadirDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAñadirDetalle.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAñadirDetalle.Location = new System.Drawing.Point(511, 271);
            this.buttonAñadirDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAñadirDetalle.Name = "buttonAñadirDetalle";
            this.buttonAñadirDetalle.Size = new System.Drawing.Size(200, 49);
            this.buttonAñadirDetalle.TabIndex = 9;
            this.buttonAñadirDetalle.Text = "Añadir Detalle";
            this.buttonAñadirDetalle.UseVisualStyleBackColor = false;
            this.buttonAñadirDetalle.Click += new System.EventHandler(this.buttonAñadirDetalle_Click);
            // 
            // buttonEliminarDetalle
            // 
            this.buttonEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonEliminarDetalle.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEliminarDetalle.Location = new System.Drawing.Point(511, 342);
            this.buttonEliminarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarDetalle.Name = "buttonEliminarDetalle";
            this.buttonEliminarDetalle.Size = new System.Drawing.Size(200, 49);
            this.buttonEliminarDetalle.TabIndex = 10;
            this.buttonEliminarDetalle.Text = "Eliminar Detalle";
            this.buttonEliminarDetalle.UseVisualStyleBackColor = false;
            this.buttonEliminarDetalle.Click += new System.EventHandler(this.buttonEliminarDetalle_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonRegistrar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegistrar.Location = new System.Drawing.Point(511, 409);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(200, 49);
            this.buttonRegistrar.TabIndex = 11;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnRegresar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegresar.Location = new System.Drawing.Point(511, 631);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 49);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonEliminarDetalle);
            this.Controls.Add(this.buttonAñadirDetalle);
            this.Controls.Add(this.textBoxTotalFactura);
            this.Controls.Add(this.labelTotalFactura);
            this.Controls.Add(this.dataGridViewDetallesFactura);
            this.Controls.Add(this.labelDetallesFactura);
            this.Controls.Add(this.textBoxCedulaEmpleado);
            this.Controls.Add(this.labelCedulaEmpleado);
            this.Controls.Add(this.textBoxCedulaCliente);
            this.Controls.Add(this.labelCedulaCliente);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCedulaCliente;
        private System.Windows.Forms.TextBox textBoxCedulaCliente;
        private System.Windows.Forms.Label labelCedulaEmpleado;
        private System.Windows.Forms.TextBox textBoxCedulaEmpleado;
        private System.Windows.Forms.Label labelDetallesFactura;
        private System.Windows.Forms.DataGridView dataGridViewDetallesFactura;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.TextBox textBoxTotalFactura;
        private System.Windows.Forms.Button buttonAñadirDetalle;
        private System.Windows.Forms.Button buttonEliminarDetalle;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
    }
}