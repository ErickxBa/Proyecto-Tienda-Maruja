namespace CapaUI
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelClienteID = new System.Windows.Forms.Label();
            this.textBoxClienteID = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelDireccionCliente = new System.Windows.Forms.Label();
            this.textBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this.labelTelefonoCliente = new System.Windows.Forms.Label();
            this.textBoxTelefonoCliente = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(415, 136);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.Size = new System.Drawing.Size(340, 216);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(362, 23);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(133, 37);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Clientes";
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteID.Location = new System.Drawing.Point(17, 153);
            this.labelClienteID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(101, 22);
            this.labelClienteID.TabIndex = 2;
            this.labelClienteID.Text = "Cliente ID:";
            // 
            // textBoxClienteID
            // 
            this.textBoxClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxClienteID.Location = new System.Drawing.Point(161, 150);
            this.textBoxClienteID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClienteID.Name = "textBoxClienteID";
            this.textBoxClienteID.Size = new System.Drawing.Size(199, 30);
            this.textBoxClienteID.TabIndex = 3;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(17, 203);
            this.labelNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(85, 22);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre:";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNombreCliente.Location = new System.Drawing.Point(161, 199);
            this.textBoxNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(199, 30);
            this.textBoxNombreCliente.TabIndex = 5;
            // 
            // labelDireccionCliente
            // 
            this.labelDireccionCliente.AutoSize = true;
            this.labelDireccionCliente.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccionCliente.Location = new System.Drawing.Point(17, 252);
            this.labelDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccionCliente.Name = "labelDireccionCliente";
            this.labelDireccionCliente.Size = new System.Drawing.Size(102, 22);
            this.labelDireccionCliente.TabIndex = 6;
            this.labelDireccionCliente.Text = "Dirección:";
            // 
            // textBoxDireccionCliente
            // 
            this.textBoxDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDireccionCliente.Location = new System.Drawing.Point(161, 248);
            this.textBoxDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            this.textBoxDireccionCliente.Size = new System.Drawing.Size(199, 30);
            this.textBoxDireccionCliente.TabIndex = 7;
            // 
            // labelTelefonoCliente
            // 
            this.labelTelefonoCliente.AutoSize = true;
            this.labelTelefonoCliente.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoCliente.Location = new System.Drawing.Point(17, 301);
            this.labelTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefonoCliente.Name = "labelTelefonoCliente";
            this.labelTelefonoCliente.Size = new System.Drawing.Size(90, 22);
            this.labelTelefonoCliente.TabIndex = 8;
            this.labelTelefonoCliente.Text = "Teléfono:";
            // 
            // textBoxTelefonoCliente
            // 
            this.textBoxTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTelefonoCliente.Location = new System.Drawing.Point(161, 297);
            this.textBoxTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefonoCliente.Name = "textBoxTelefonoCliente";
            this.textBoxTelefonoCliente.Size = new System.Drawing.Size(199, 30);
            this.textBoxTelefonoCliente.TabIndex = 9;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAgregar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(13, 392);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(185, 49);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar Cliente";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEliminar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(241, 392);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 49);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnRegresar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(625, 392);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(162, 49);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxTelefonoCliente);
            this.Controls.Add(this.labelTelefonoCliente);
            this.Controls.Add(this.textBoxDireccionCliente);
            this.Controls.Add(this.labelDireccionCliente);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxClienteID);
            this.Controls.Add(this.labelClienteID);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dataGridViewClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelClienteID;
        private System.Windows.Forms.TextBox textBoxClienteID;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelDireccionCliente;
        private System.Windows.Forms.TextBox textBoxDireccionCliente;
        private System.Windows.Forms.Label labelTelefonoCliente;
        private System.Windows.Forms.TextBox textBoxTelefonoCliente;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}














