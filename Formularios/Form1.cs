using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GestorEmpleados
{
    public partial class Form1 : Form
    {



        static string connectionString = ConfigurationManager.ConnectionStrings["sqlconnectionstring"].ConnectionString;
        List<Empleado> ListaEmpleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        #region Validacion LegajoExistente
        public bool LegajoExiste(int legajo)
        {
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {
                oConexion.Open();
                string query = "SELECT COUNT(1) FROM Empleados WHERE Legajo = @Legajo";
                using (SqlCommand command = new SqlCommand(query, oConexion))
                {
                    command.Parameters.AddWithValue("@Legajo", legajo);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        #endregion



        #region Evento Cargar Empleado
        private void btnCargar_Click(object sender, EventArgs e)
        {

            int legajo = Convert.ToInt32(txtLegajo.Text);
            string nombre = txtNombre.Text;
            string profesion = txtProfesion.Text;
            string apellido = txtApellido.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);

            //Cadena de Conexión
            //string connectionString = "Server= GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {
                oConexion.Open();
                // Consulta parametrizada para evitar inyección SQL
                string query = @"INSERT INTO Empleados (Legajo, Nombre, Apellido, Profesion, Sueldo)
                         VALUES (@Legajo, @Nombre, @Apellido, @Profesion, @Sueldo)";


                // Validar campos vacíos y sueldo negativo
                if (string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtProfesion.Text) ||
                    string.IsNullOrWhiteSpace(txtSueldo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                if (sueldo < 0)
                {
                    MessageBox.Show("El sueldo no puede ser negativo.");
                    return;
                }
                if (legajo <= 0)
                {
                    MessageBox.Show("El legajo debe ser un número positivo.");
                    return;
                }
                if (sueldo == 0)
                {
                    MessageBox.Show("El legajo Debe tener un valor mayor a 0.");
                }

                if (LegajoExiste(legajo))
                {
                    MessageBox.Show("El legajo ya existe. Por favor, ingrese un legajo único.");
                    return;
                }


                using (SqlCommand oComand = new SqlCommand(query, oConexion))
                {
                    oComand.Parameters.AddWithValue("@Legajo", legajo);
                    oComand.Parameters.AddWithValue("@Nombre", nombre);
                    oComand.Parameters.AddWithValue("@Apellido", apellido);
                    oComand.Parameters.AddWithValue("@Profesion", profesion);
                    oComand.Parameters.AddWithValue("@Sueldo", sueldo);

                    oComand.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado exitosamente.");

                }
            }
        }


        #endregion

        #region Imprimir datos
        private void btnImprimir_Click(object sender, EventArgs e)


        {
            //string connectionString = "Server= GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {
                oConexion.Open();

                string query = "SELECT * FROM Empleados";

                SqlDataAdapter adapter = new SqlDataAdapter(query, oConexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Mostramos los datos en un DataGridView
                dataGridView1.DataSource = dt;
            }

        }
        #endregion
        private void CargarDatos()
        {
            //dgvEmpleados.DataSource = null;
            //dgvEmpleados.DataSource = ListaEmpleados;
        }


        #region Evento Modificar sin accion
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(txtLegajo.Text);
            string nombre = txtNombre.Text;
            string profesion = txtProfesion.Text;
            string apellido = txtApellido.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            //Cadena de Conexión
            string connectionString = "Server= GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {
                oConexion.Open();
                // Consulta parametrizada para evitar inyección SQL
                string query = @"UPDATE Empleados 
                                 SET Nombre = @Nombre, Apellido = @Apellido, Profesion = @Profesion, Sueldo = @Sueldo
                                 WHERE Legajo = @Legajo";
                using (SqlCommand oComand = new SqlCommand(query, oConexion))
                {
                    oComand.Parameters.AddWithValue("@Legajo", legajo);
                    oComand.Parameters.AddWithValue("@Nombre", nombre);
                    oComand.Parameters.AddWithValue("@Apellido", apellido);
                    oComand.Parameters.AddWithValue("@Profesion", profesion);
                    oComand.Parameters.AddWithValue("@Sueldo", sueldo);
                    int rowsAffected = oComand.ExecuteNonQuery();
                    oComand.ExecuteNonQuery();
                    MessageBox.Show("Empleado modificado exitosamente.");
                }
            }
            //int i = dgvEmpleados.CurrentCell.RowIndex;
            //ListaEmpleados[i].Sueldo = Convert.ToDouble(txtSueldo.Text);
            //CargarDatos();
        }
        #endregion


        #region Evento Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Validamos que haya una fila seleccionada
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor selecciona un empleado en la tabla.");
                    return;
                }

                // Obtenemos el ID desde la fila seleccionada
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Confirmación antes de borrar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                    return;

                // Cadena de conexión

                conn.Open();

                string query = "DELETE FROM Empleados WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado eliminado correctamente.");
                }
            }

            // Refrescamos la grilla



        }
        //private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvEmpleados.SelectedRows.Count == 0)
        //    {
        //        return;
        //    }
        //    txtLegajo.Text = dgvEmpleados.CurrentRow.Cells["Legajo"].Value.ToString();
        //    txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
        //    txtProfesion.Text = dgvEmpleados.CurrentRow.Cells["Profesion"].Value.ToString();
        //    txtSueldo.Text = dgvEmpleados.CurrentRow.Cells["Sueldo"].Value.ToString();
        //}
        #endregion


        #region Evento Sali cerrar app
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btnImpAnalistas_Click(object sender, EventArgs e)
        {
            //List<Empleado> ListaEmpleadosAnalista = new List<Empleado>();
            //foreach (var empleado in ListaEmpleados)
            //{
            //    if (empleado.Profesion == "Analista")
            //    {
            //        ListaEmpleadosAnalista.Add(empleado);
            //    }
            //}
            //dgvEmpleados.DataSource = null;
            //dgvEmpleados.DataSource = ListaEmpleadosAnalista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLegajo.Clear();
            txtNombre.Clear();
            txtProfesion.Clear();
            txtSueldo.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int legajo = Convert.ToInt32(txtLegajo.Text);
            string nombre = txtNombre.Text;
            string profesion = txtProfesion.Text;
            string apellido = txtApellido.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            //Cadena de Conexión
            //string connectionString = "Server= GUSTAV-PC; Database= Empleados; Trusted_Connection=True";
            using (SqlConnection oConexion = new SqlConnection(connectionString))
            {
                oConexion.Open();
                // Consulta parametrizada para evitar inyección SQL
                string query = @"UPDATE Empleados 
                                 SET Nombre = @Nombre, Apellido = @Apellido, Profesion = @Profesion, Sueldo = @Sueldo
                                 WHERE Legajo = @Legajo";
                using (SqlCommand oComand = new SqlCommand(query, oConexion))
                {
                    oComand.Parameters.AddWithValue("@Legajo", legajo);
                    oComand.Parameters.AddWithValue("@Nombre", nombre);
                    oComand.Parameters.AddWithValue("@Apellido", apellido);
                    oComand.Parameters.AddWithValue("@Profesion", profesion);
                    oComand.Parameters.AddWithValue("@Sueldo", sueldo);
                    int rowsAffected = oComand.ExecuteNonQuery();
                    oComand.ExecuteNonQuery();
                    MessageBox.Show("Empleado modificado exitosamente.");
                }
            }
        }

        
    }
}
