using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DistrictFood
{
    public partial class FormVentas : Form
    {
        decimal totalOrden = 0;

        public FormVentas()
        {
            InitializeComponent();
            ConfigurarTabla();
            if (cmbMetodoPago.Items.Count > 0) cmbMetodoPago.SelectedIndex = 0;
            CargarProductos("Todos");
        }
        
           private void ConfigurarTabla()
        {
           
            dgvOrden.Columns.Clear();
            dgvOrden.Columns.Add("IdProducto", "ID");
            dgvOrden.Columns.Add("Nombre", "Producto");
            dgvOrden.Columns.Add("Cantidad", "Cant");
            dgvOrden.Columns.Add("Precio", "Precio");
            dgvOrden.Columns.Add("Subtotal", "Total");

            
            dgvOrden.Columns["IdProducto"].Visible = false;
            dgvOrden.RowHeadersVisible = false;

            
            dgvOrden.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrden.Columns["Cantidad"].Width = 42;
            dgvOrden.Columns["Precio"].Width = 65;
            dgvOrden.Columns["Subtotal"].Width = 70;

            
            dgvOrden.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrden.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrden.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrden.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvOrden.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

           
            dgvOrden.BackgroundColor = Color.FromArgb(25, 25, 25);
            dgvOrden.BorderStyle = BorderStyle.None;
            dgvOrden.EnableHeadersVisualStyles = false;
            dgvOrden.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 31, 18);
            dgvOrden.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 140, 0);
            dgvOrden.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvOrden.ColumnHeadersHeight = 28;

            dgvOrden.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            dgvOrden.DefaultCellStyle.ForeColor = Color.White;
            dgvOrden.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            dgvOrden.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 140, 0);
            dgvOrden.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvOrden.RowTemplate.Height = 26;

            
            dgvOrden.AllowUserToAddRows = false;
            dgvOrden.AllowUserToResizeColumns = false;
            dgvOrden.MultiSelect = true;
            dgvOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrden.ReadOnly = true;

            
            dgvOrden.CellDoubleClick -= DgvOrden_CellDoubleClick;
            dgvOrden.CellDoubleClick += DgvOrden_CellDoubleClick;
        }
        

        private void DgvOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvOrden.Rows[e.RowIndex];
            int cantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

            if (cantActual > 1)
            {
                cantActual--;
                fila.Cells["Cantidad"].Value = cantActual;
                fila.Cells["Subtotal"].Value = cantActual * precio;
            }
            else
            {
                dgvOrden.Rows.RemoveAt(e.RowIndex);
            }
            CalcularTotal();
            txtEfectivo_TextChanged(null, null);
        }

        private void CargarProductos(string categoria)
        {
            flpProductos.Controls.Clear();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = categoria == "Todos"
                    ? "SELECT IdProducto, Nombre, Precio, Stock FROM Productos WHERE Estado = 1 AND Stock > 0"
                    : "SELECT IdProducto, Nombre, Precio, Stock FROM Productos WHERE Estado = 1 AND Stock > 0 AND Categoria = @cat";

                SqlCommand cmd = new SqlCommand(query, con);
                if (categoria != "Todos") cmd.Parameters.AddWithValue("@cat", categoria);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Button btn = new Button();
                        btn.Size = new Size(145, 110);
                        btn.BackColor = Color.FromArgb(42, 31, 18);
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(255, 140, 0);
                        btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                        btn.Text = $"{dr["Nombre"]}\n\nC$ {dr["Precio"]}\n(Stock: {dr["Stock"]})";
                        btn.Tag = new object[] { dr["IdProducto"], dr["Nombre"], Convert.ToDecimal(dr["Precio"]), Convert.ToInt32(dr["Stock"]) };
                        btn.Click += Producto_Click;
                        flpProductos.Controls.Add(btn);
                    }
                }
            }
        }

        
        private void Producto_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object[] datos = (object[])btn.Tag;
            int id = Convert.ToInt32(datos[0]);
            string nombre = datos[1].ToString();
            decimal precio = Convert.ToDecimal(datos[2]);
            int stockDisponible = Convert.ToInt32(datos[3]);

            bool existe = false;
            foreach (DataGridViewRow fila in dgvOrden.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null && Convert.ToInt32(fila.Cells["IdProducto"].Value) == id)
                {
                    int cant = Convert.ToInt32(fila.Cells["Cantidad"].Value) + 1;
                    if (cant > stockDisponible)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    fila.Cells["Cantidad"].Value = cant;
                    fila.Cells["Subtotal"].Value = cant * precio;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dgvOrden.Rows.Add(id, nombre, 1, precio, precio);
            }
            CalcularTotal();
            txtEfectivo_TextChanged(null, null);
        }

        private void CalcularTotal()
        {
            totalOrden = 0;
            foreach (DataGridViewRow fila in dgvOrden.Rows)
            {
                if (fila.Cells["Subtotal"].Value != null)
                {
                    totalOrden += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                }
            }
            lblTotal.Text = "C$ " + totalOrden.ToString("N2");
        }

        
        private void btnTodos_Click(object sender, EventArgs e) => CargarProductos("Todos");
        private void btnTodos_Click_1(object sender, EventArgs e) => CargarProductos("Todos");
        private void btnBebidas_Click(object sender, EventArgs e) => CargarProductos("Bebidas y Postres");
        private void btnHamburguesas_Click_1(object sender, EventArgs e) => CargarProductos("Hamburguesas");
        private void button5_Click(object sender, EventArgs e) => CargarProductos("Pizza");
        private void button2_Click(object sender, EventArgs e) => CargarProductos("Antojos");

        
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEfectivo.Text, out decimal pago))
            {
                decimal vuelto = pago - totalOrden;
                lblVuelto.Text = vuelto >= 0 ? "Vuelto: C$ " + vuelto.ToString("N2") : "Falta dinero";
            }
            else
            {
                lblVuelto.Text = "Vuelto: C$ 0.00";
            }
        }
        private void txtEfectivo_TextChanged_1(object sender, EventArgs e) => txtEfectivo_TextChanged(sender, e);

        
        private void btnCobrarOrden_Click(object sender, EventArgs e)
        {
            if (totalOrden <= 0)
            {
                MessageBox.Show("Agrega productos a la orden.", "Orden vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idVenta = 0;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string queryVenta = "INSERT INTO Ventas (IdUsuario, MetodoPago, Total) OUTPUT INSERTED.IdVenta VALUES (1, @metodo, @total)";
                SqlCommand cmdVenta = new SqlCommand(queryVenta, con);
                cmdVenta.Parameters.AddWithValue("@metodo", cmbMetodoPago.Text);
                cmdVenta.Parameters.AddWithValue("@total", totalOrden);
                idVenta = (int)cmdVenta.ExecuteScalar();

                foreach (DataGridViewRow fila in dgvOrden.Rows)
                {
                    if (fila.Cells["IdProducto"].Value == null) continue;

                    int idProd = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                    int cant = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    decimal sub = Convert.ToDecimal(fila.Cells["Subtotal"].Value);

                    string queryDet = "INSERT INTO DetalleVentas (IdVenta, IdProducto, Cantidad, PrecioUnitario, Subtotal) VALUES (@idV, @idP, @cant, @prec, @sub)";
                    SqlCommand cmdDet = new SqlCommand(queryDet, con);
                    cmdDet.Parameters.AddWithValue("@idV", idVenta);
                    cmdDet.Parameters.AddWithValue("@idP", idProd);
                    cmdDet.Parameters.AddWithValue("@cant", cant);
                    cmdDet.Parameters.AddWithValue("@prec", precio);
                    cmdDet.Parameters.AddWithValue("@sub", sub);
                    cmdDet.ExecuteNonQuery();

                    SqlCommand cmdStock = new SqlCommand("UPDATE Productos SET Stock = Stock - @cant WHERE IdProducto = @idP", con);
                    cmdStock.Parameters.AddWithValue("@cant", cant);
                    cmdStock.Parameters.AddWithValue("@idP", idProd);
                    cmdStock.ExecuteNonQuery();
                }
            }

            string resumen = $"===== DISTRICT FOOD POS =====\n" +
                             $"Orden #: {idVenta}\n" +
                             $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                             $"Método de Pago: {cmbMetodoPago.Text}\n" +
                             $"-----------------------------\n" +
                             $"TOTAL PAGADO: C$ {totalOrden:N2}\n" +
                             $"{lblVuelto.Text}\n" +
                             $"========================\n" +
                             $"¡Gracias por su compra!";

            MessageBox.Show(resumen, "Recibo Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvOrden.Rows.Clear();
            txtEfectivo.Clear();
            CalcularTotal();
            CargarProductos("Todos");
        }

        private void btnCobrar_Click(object sender, EventArgs e) => btnCobrarOrden_Click(sender, e);

        
        private void button1_Click(object sender, EventArgs e)
        {
            FormInventario inv = new FormInventario();
            inv.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}