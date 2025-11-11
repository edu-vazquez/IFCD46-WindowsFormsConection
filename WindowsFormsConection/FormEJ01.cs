using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    public partial class FormEJ01 : Form
    {
        string connectionString;
        SqlConnection connection; // se declara la variable de conexión

        public FormEJ01()
        {
            InitializeComponent();

            var csb = new SqlConnectionStringBuilder
            {
                DataSource = "187.33.155.14,54321",
                InitialCatalog = "EduardoEmployees",
                UserID = "sa",
                Password = Program.Password
            };
            connectionString = csb.ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                tbxEstadoDeConeccion.Text = "Conectado";
                tbxEstadoDeConeccion.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            connection.Close();
            tbxEstadoDeConeccion.Text = "Desconectado";
            tbxEstadoDeConeccion.BackColor = Color.LightCoral;
        }
    }
}
