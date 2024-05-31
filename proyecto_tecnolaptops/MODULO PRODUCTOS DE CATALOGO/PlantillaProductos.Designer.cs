namespace MODULO_PRODUCTOS_DE_CATALOGO
{
    partial class PlantillaProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCarrito = new System.Windows.Forms.CheckBox();
            this.imagenProducto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre_Producto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenProducto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbCarrito);
            this.panel1.Controls.Add(this.imagenProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 342);
            this.panel1.TabIndex = 6;
            // 
            // cbCarrito
            // 
            this.cbCarrito.AutoSize = true;
            this.cbCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCarrito.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrito.Image = global::MODULO_PRODUCTOS_DE_CATALOGO.Properties.Resources._8333853_add_to_cart_trolley_shopping_icon;
            this.cbCarrito.Location = new System.Drawing.Point(700, 6);
            this.cbCarrito.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCarrito.Name = "cbCarrito";
            this.cbCarrito.Size = new System.Drawing.Size(76, 48);
            this.cbCarrito.TabIndex = 4;
            this.cbCarrito.UseVisualStyleBackColor = true;
            this.cbCarrito.CheckedChanged += new System.EventHandler(this.cbCarrito_CheckedChanged);
            // 
            // imagenProducto
            // 
            this.imagenProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenProducto.Location = new System.Drawing.Point(62, 31);
            this.imagenProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imagenProducto.Name = "imagenProducto";
            this.imagenProducto.Size = new System.Drawing.Size(266, 273);
            this.imagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenProducto.TabIndex = 0;
            this.imagenProducto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNombre_Producto);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Location = new System.Drawing.Point(353, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 261);
            this.panel2.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(12, 193);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(192, 36);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // lblNombre_Producto
            // 
            this.lblNombre_Producto.AutoSize = true;
            this.lblNombre_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre_Producto.Location = new System.Drawing.Point(12, 30);
            this.lblNombre_Producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre_Producto.Name = "lblNombre_Producto";
            this.lblNombre_Producto.Size = new System.Drawing.Size(337, 37);
            this.lblNombre_Producto.TabIndex = 1;
            this.lblNombre_Producto.Text = "Nombre del producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(12, 85);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(106, 36);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // PlantillaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PlantillaProductos";
            this.Size = new System.Drawing.Size(848, 342);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenProducto;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox cbCarrito;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblNombre_Producto;
        public System.Windows.Forms.Label lblPrecio;
    }
}
