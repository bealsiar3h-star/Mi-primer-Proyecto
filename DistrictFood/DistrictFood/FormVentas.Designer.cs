namespace DistrictFood
{
    partial class FormVentas
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
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAntojos = new System.Windows.Forms.Button();
            this.btnHamburguesas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.btnCobrarOrden = new System.Windows.Forms.Button();
            this.gpbFactura = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Idproductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.gpbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTodos.Location = new System.Drawing.Point(56, 211);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(140, 46);
            this.btnTodos.TabIndex = 0;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click_1);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Location = new System.Drawing.Point(56, 278);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(140, 46);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAntojos
            // 
            this.btnAntojos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAntojos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntojos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAntojos.Location = new System.Drawing.Point(56, 429);
            this.btnAntojos.Name = "btnAntojos";
            this.btnAntojos.Size = new System.Drawing.Size(140, 46);
            this.btnAntojos.TabIndex = 2;
            this.btnAntojos.Text = "Antojos";
            this.btnAntojos.UseVisualStyleBackColor = false;
            this.btnAntojos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHamburguesas
            // 
            this.btnHamburguesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHamburguesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHamburguesas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHamburguesas.Location = new System.Drawing.Point(56, 351);
            this.btnHamburguesas.Name = "btnHamburguesas";
            this.btnHamburguesas.Size = new System.Drawing.Size(140, 46);
            this.btnHamburguesas.TabIndex = 3;
            this.btnHamburguesas.Text = "Hamburguesas";
            this.btnHamburguesas.UseVisualStyleBackColor = false;
            this.btnHamburguesas.Click += new System.EventHandler(this.btnHamburguesas_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(56, 623);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(140, 46);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPizza.Location = new System.Drawing.Point(56, 512);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(140, 46);
            this.btnPizza.TabIndex = 5;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.button5_Click);
            // 
            // flpProductos
            // 
            this.flpProductos.AutoScroll = true;
            this.flpProductos.Location = new System.Drawing.Point(266, 12);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Size = new System.Drawing.Size(601, 681);
            this.flpProductos.TabIndex = 6;
            // 
            // dgvOrden
            // 
            this.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idproductos,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.dgvOrden.Location = new System.Drawing.Point(6, 32);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.RowHeadersWidth = 62;
            this.dgvOrden.RowTemplate.Height = 28;
            this.dgvOrden.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrden.Size = new System.Drawing.Size(415, 280);
            this.dgvOrden.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(257, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 29);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "C$0.00";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Trasferencia"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(240, 380);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(154, 34);
            this.cmbMetodoPago.TabIndex = 7;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtEfectivo.Location = new System.Drawing.Point(240, 433);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(154, 32);
            this.txtEfectivo.TabIndex = 9;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged_1);
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblVuelto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVuelto.Location = new System.Drawing.Point(235, 484);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(163, 26);
            this.lblVuelto.TabIndex = 7;
            this.lblVuelto.Text = "Vuelto C$0.00";
            // 
            // btnCobrarOrden
            // 
            this.btnCobrarOrden.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCobrarOrden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCobrarOrden.Location = new System.Drawing.Point(66, 549);
            this.btnCobrarOrden.Name = "btnCobrarOrden";
            this.btnCobrarOrden.Size = new System.Drawing.Size(311, 68);
            this.btnCobrarOrden.TabIndex = 8;
            this.btnCobrarOrden.Text = "Cobrar Orden";
            this.btnCobrarOrden.UseVisualStyleBackColor = false;
            this.btnCobrarOrden.Click += new System.EventHandler(this.btnCobrarOrden_Click);
            // 
            // gpbFactura
            // 
            this.gpbFactura.Controls.Add(this.label3);
            this.gpbFactura.Controls.Add(this.label2);
            this.gpbFactura.Controls.Add(this.label1);
            this.gpbFactura.Controls.Add(this.lblVuelto);
            this.gpbFactura.Controls.Add(this.btnCobrarOrden);
            this.gpbFactura.Controls.Add(this.txtEfectivo);
            this.gpbFactura.Controls.Add(this.cmbMetodoPago);
            this.gpbFactura.Controls.Add(this.lblTotal);
            this.gpbFactura.Controls.Add(this.dgvOrden);
            this.gpbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbFactura.Location = new System.Drawing.Point(890, 12);
            this.gpbFactura.Name = "gpbFactura";
            this.gpbFactura.Size = new System.Drawing.Size(427, 681);
            this.gpbFactura.TabIndex = 7;
            this.gpbFactura.TabStop = false;
            this.gpbFactura.Text = "Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Efectivo recibido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Metodo de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total a pagar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DistrictFood.Properties.Resources.Captura_de_pantalla_2026_11_14_172525;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Idproductos
            // 
            this.Idproductos.HeaderText = "Idproductos";
            this.Idproductos.MinimumWidth = 8;
            this.Idproductos.Name = "Idproductos";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(21)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1352, 716);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbFactura);
            this.Controls.Add(this.flpProductos);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnHamburguesas);
            this.Controls.Add(this.btnAntojos);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnTodos);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.gpbFactura.ResumeLayout(false);
            this.gpbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnAntojos;
        private System.Windows.Forms.Button btnHamburguesas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Button btnCobrarOrden;
        private System.Windows.Forms.GroupBox gpbFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}