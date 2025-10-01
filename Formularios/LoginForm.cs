using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorEmpleados
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {


        //static string connectionString = "Server= GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
        string connectionString = ConfigurationManager.ConnectionStrings["sqlconnectionstring"].ConnectionString;
        SqlConnection oConexion;
        SqlCommand cmd;
        SqlDataReader read;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)

        {
            string NombreUsuario = txtUsuario.Text.Trim();
            string Contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(NombreUsuario) || string.IsNullOrEmpty(Contraseña))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string connectionString = "Server = GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {

                try
                {
                    oConexion.Open();
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                    using (SqlCommand command = new SqlCommand(query, oConexion))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", Contraseña);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form1 mainForm = new Form1();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }   
        

        
        private void groupBoxUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
