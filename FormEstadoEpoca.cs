using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormEstadoEpoca : Form
    {
        private string connectionString;

        public FormEstadoEpoca()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
        }

        private void FormEstadoEpoca_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Estados de Época";
            CarregarEstadosEpoca();
        }

        private void CarregarEstadosEpoca()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM EstadoEpoca";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEstados.DataSource = dt;
            }
        }
    }
}
