namespace CapaUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.buttonNuevaFactura = new System.Windows.Forms.Button();
            this.buttonHistorialFacturas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(27, 23);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(67, 179);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(290, 132);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Tienda \r\nMaruja\r\nSede Guayaquil";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSubtitulo.Location = new System.Drawing.Point(107, 328);
            this.labelSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(234, 31);
            this.labelSubtitulo.TabIndex = 2;
            this.labelSubtitulo.Text = "Todo a tu alcance";
            // 
            // buttonInventario
            // 
            this.buttonInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonInventario.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInventario.Location = new System.Drawing.Point(520, 104);
            this.buttonInventario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(200, 49);
            this.buttonInventario.TabIndex = 3;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.UseVisualStyleBackColor = false;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonClientes.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClientes.Location = new System.Drawing.Point(520, 165);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(200, 49);
            this.buttonClientes.TabIndex = 4;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonEmpleados.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmpleados.Location = new System.Drawing.Point(520, 227);
            this.buttonEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(200, 49);
            this.buttonEmpleados.TabIndex = 5;
            this.buttonEmpleados.Text = "Empleados";
            this.buttonEmpleados.UseVisualStyleBackColor = false;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // buttonNuevaFactura
            // 
            this.buttonNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonNuevaFactura.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNuevaFactura.Location = new System.Drawing.Point(520, 288);
            this.buttonNuevaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevaFactura.Name = "buttonNuevaFactura";
            this.buttonNuevaFactura.Size = new System.Drawing.Size(200, 49);
            this.buttonNuevaFactura.TabIndex = 6;
            this.buttonNuevaFactura.Text = "Nueva Factura";
            this.buttonNuevaFactura.UseVisualStyleBackColor = false;
            this.buttonNuevaFactura.Click += new System.EventHandler(this.buttonNuevaFactura_Click);
            // 
            // buttonHistorialFacturas
            // 
            this.buttonHistorialFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonHistorialFacturas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorialFacturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHistorialFacturas.Location = new System.Drawing.Point(520, 350);
            this.buttonHistorialFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistorialFacturas.Name = "buttonHistorialFacturas";
            this.buttonHistorialFacturas.Size = new System.Drawing.Size(200, 49);
            this.buttonHistorialFacturas.TabIndex = 7;
            this.buttonHistorialFacturas.Text = "Historial Facturas";
            this.buttonHistorialFacturas.UseVisualStyleBackColor = false;
            this.buttonHistorialFacturas.Click += new System.EventHandler(this.buttonHistorialFacturas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSalir.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(27, 421);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.buttonHistorialFacturas);
            this.Controls.Add(this.buttonNuevaFactura);
            this.Controls.Add(this.buttonEmpleados);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonInventario);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Maruja - Sede Guayaquil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Button buttonNuevaFactura;
        private System.Windows.Forms.Button buttonHistorialFacturas;
        private System.Windows.Forms.Button btnSalir;
    }
}