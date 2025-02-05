using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormEpocaAvaliacao : Form
    {
        private string connectionString;

        public FormEpocaAvaliacao()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
        }

        private void FormEpocaAvaliacao_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Épocas de Avaliação";
            CarregarEpocasAvaliacao();
        }

        private void CarregarEpocasAvaliacao()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM EpocaAvaliacao";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEpocas.DataSource = dt;
            }
        }
    }
}
