namespace CapaUI
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelProductoID = new System.Windows.Forms.Label();
            this.textBoxProductoID = new System.Windows.Forms.TextBox();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.labelPrecioProducto = new System.Windows.Forms.Label();
            this.textBoxPrecioProducto = new System.Windows.Forms.TextBox();
            this.labelStockProducto = new System.Windows.Forms.Label();
            this.textBoxStockProducto = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventario.Location = new System.Drawing.Point(40, 140);
            this.dataGridViewInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.RowHeadersWidth = 51;
            this.dataGridViewInventario.Size = new System.Drawing.Size(395, 130);
            this.dataGridViewInventario.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonAgregar.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(527, 72);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(233, 50);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar Producto";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonEditar.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditar.Location = new System.Drawing.Point(527, 145);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(233, 52);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar Producto";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonEliminar.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(527, 219);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(233, 47);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar Producto";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(339, 23);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(149, 33);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Inventario";
            // 
            // labelProductoID
            // 
            this.labelProductoID.AutoSize = true;
            this.labelProductoID.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductoID.Location = new System.Drawing.Point(35, 292);
            this.labelProductoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductoID.Name = "labelProductoID";
            this.labelProductoID.Size = new System.Drawing.Size(139, 26);
            this.labelProductoID.TabIndex = 5;
            this.labelProductoID.Text = "Producto ID:";
            // 
            // textBoxProductoID
            // 
            this.textBoxProductoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxProductoID.Location = new System.Drawing.Point(179, 289);
            this.textBoxProductoID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductoID.Name = "textBoxProductoID";
            this.textBoxProductoID.Size = new System.Drawing.Size(199, 30);
            this.textBoxProductoID.TabIndex = 6;
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProducto.Location = new System.Drawing.Point(35, 342);
            this.labelNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(97, 26);
            this.labelNombreProducto.TabIndex = 7;
            this.labelNombreProducto.Text = "Nombre:";
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNombreProducto.Location = new System.Drawing.Point(179, 338);
            this.textBoxNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(199, 30);
            this.textBoxNombreProducto.TabIndex = 8;
            // 
            // labelPrecioProducto
            // 
            this.labelPrecioProducto.AutoSize = true;
            this.labelPrecioProducto.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProducto.Location = new System.Drawing.Point(35, 391);
            this.labelPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioProducto.Name = "labelPrecioProducto";
            this.labelPrecioProducto.Size = new System.Drawing.Size(83, 26);
            this.labelPrecioProducto.TabIndex = 9;
            this.labelPrecioProducto.Text = "Precio:";
            // 
            // textBoxPrecioProducto
            // 
            this.textBoxPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPrecioProducto.Location = new System.Drawing.Point(179, 387);
            this.textBoxPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            this.textBoxPrecioProducto.Size = new System.Drawing.Size(199, 30);
            this.textBoxPrecioProducto.TabIndex = 10;
            // 
            // labelStockProducto
            // 
            this.labelStockProducto.AutoSize = true;
            this.labelStockProducto.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockProducto.Location = new System.Drawing.Point(35, 440);
            this.labelStockProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockProducto.Name = "labelStockProducto";
            this.labelStockProducto.Size = new System.Drawing.Size(74, 26);
            this.labelStockProducto.TabIndex = 11;
            this.labelStockProducto.Text = "Stock:";
            // 
            // textBoxStockProducto
            // 
            this.textBoxStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxStockProducto.Location = new System.Drawing.Point(179, 436);
            this.textBoxStockProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStockProducto.Name = "textBoxStockProducto";
            this.textBoxStockProducto.Size = new System.Drawing.Size(199, 30);
            this.textBoxStockProducto.TabIndex = 12;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnRegresar.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(549, 429);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 50);
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
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.textBoxStockProducto);
            this.Controls.Add(this.labelStockProducto);
            this.Controls.Add(this.textBoxPrecioProducto);
            this.Controls.Add(this.labelPrecioProducto);
            this.Controls.Add(this.textBoxNombreProducto);
            this.Controls.Add(this.labelNombreProducto);
            this.Controls.Add(this.textBoxProductoID);
            this.Controls.Add(this.labelProductoID);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridViewInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelProductoID;
        private System.Windows.Forms.TextBox textBoxProductoID;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.Label labelPrecioProducto;
        private System.Windows.Forms.TextBox textBoxPrecioProducto;
        private System.Windows.Forms.Label labelStockProducto;
        private System.Windows.Forms.TextBox textBoxStockProducto;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}