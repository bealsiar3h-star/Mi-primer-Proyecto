using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistrictFood
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT Rol FROM Usuarios WHERE NombreUsuario = @user AND Contrasena = @pass";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        MessageBox.Show("¡Bienvenido a District Food! Rol: " + resultado.ToString(), "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Aquí abriremos la pantalla de Ventas en el siguiente paso

                        FormVentas ventas = new FormVentas();
                        ventas.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
