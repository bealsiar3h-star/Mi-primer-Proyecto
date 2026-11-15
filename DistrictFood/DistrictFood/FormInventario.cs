using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DistrictFood
{
    public partial class FormInventario : Form
    {
        int idSeleccionado = 0;
        TextBox txtNombre, txtPrecio, txtStock;
        ComboBox cmbCategoria;
        DataGridView dgvProductos;

        public FormInventario()
        {
            InitializeComponent();
            ConstruirInterfaz();
            CargarTabla();
        }

        private void ConstruirInterfaz()
        {
            // Configuración de la ventana
            this.Text = "District Food - Gestión de Inventario";
            this.Size = new Size(1050, 620);
            this.BackColor = Color.FromArgb(29, 21, 11);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitulo = new Label() { Text = "GESTIÓN DE MENÚ E INVENTARIO", ForeColor = Color.FromArgb(255, 140, 0), Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(30, 20), AutoSize = true };
            this.Controls.Add(lblTitulo);

            // Controles de entrada (Izquierda)
            CrearEtiqueta("Nombre del Producto:", 30, 75);
            txtNombre = new TextBox() { Location = new Point(30, 100), Width = 280, Font = new Font("Segoe UI", 11) };

            CrearEtiqueta("Categoría:", 30, 145);
            cmbCategoria = new ComboBox() { Location = new Point(30, 170), Width = 280, Font = new Font("Segoe UI", 11), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbCategoria.Items.AddRange(new string[] { "Hamburguesas", "Pizza", "Antojos", "Bebidas y Postres" });
            cmbCategoria.SelectedIndex = 0;

            CrearEtiqueta("Precio (C$):", 30, 215);
            txtPrecio = new TextBox() { Location = new Point(30, 240), Width = 280, Font = new Font("Segoe UI", 11) };

            CrearEtiqueta("Stock Disponible:", 30, 285);
            txtStock = new TextBox() { Location = new Point(30, 310), Width = 280, Font = new Font("Segoe UI", 11) };

            this.Controls.AddRange(new Control[] { txtNombre, cmbCategoria, txtPrecio, txtStock });

            // Botones CRUD
            Button btnGuardar = CrearBoton("Guardar Nuevo", 30, 370, Color.FromArgb(255, 140, 0), Color.White);
            btnGuardar.Click += BtnGuardar_Click;

            Button btnEditar = CrearBoton("Actualizar", 175, 370, Color.FromArgb(255, 204, 0), Color.Black);
            btnEditar.Click += BtnEditar_Click;

            Button btnEliminar = CrearBoton("Eliminar", 30, 425, Color.FromArgb(218, 41, 28), Color.White);
            btnEliminar.Click += BtnEliminar_Click;

            Button btnVolver = CrearBoton("Volver a Ventas", 175, 425, Color.FromArgb(60, 50, 40), Color.White);
            btnVolver.Click += BtnVolver_Click;

            this.Controls.AddRange(new Control[] { btnGuardar, btnEditar, btnEliminar, btnVolver });

            // Tabla de productos (Derecha)
            dgvProductos = new DataGridView()
            {
                Location = new Point(340, 75),
                Size = new Size(660, 470),
                BackgroundColor = Color.FromArgb(42, 31, 18),
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };
            dgvProductos.CellClick += DgvProductos_CellClick;
            this.Controls.Add(dgvProductos);
        }

        private void CrearEtiqueta(string texto, int x, int y)
        {
            this.Controls.Add(new Label() { Text = texto, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(x, y), AutoSize = true });
        }

        private Button CrearBoton(string texto, int x, int y, Color fondo, Color letra)
        {
            return new Button()
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(135, 42),
                BackColor = fondo,
                ForeColor = letra,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
            };
        }

        private void CargarTabla()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdProducto, Nombre, Categoria, Precio, Stock FROM Productos WHERE Estado = 1", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;
            }
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Completa todos los campos."); return;
            }
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Nombre, Categoria, Precio, Stock, Estado) VALUES (@n, @c, @p, @s, 1)", con);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@c", cmbCategoria.Text);
                cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@s", Convert.ToInt32(txtStock.Text));
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Producto agregado al catálogo.", "District Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarTabla();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Haz clic en un producto de la tabla primero."); return; }
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Nombre=@n, Categoria=@c, Precio=@p, Stock=@s WHERE IdProducto=@id", con);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@c", cmbCategoria.Text);
                cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@s", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Producto actualizado.", "District Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Haz clic en un producto de la tabla primero."); return; }
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Estado=0 WHERE IdProducto=@id", con);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Producto eliminado del menú.", "District Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Limpiar();
            CargarTabla();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas();
            ventas.Show();
            this.Close();
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
            }
        }
    }
}