using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormAnoLetivo : Form
    {
        private string connectionString;

        public FormAnoLetivo()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
        }

        private void FormAnoLetivo_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Anos Letivos";
            CarregarAnosLetivos();
        }

        private void CarregarAnosLetivos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM AnoLetivo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAnoLetivo.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO AnoLetivo (ID, AnoInicial, AnoFinal) VALUES (@ID, @AnoInicial, @AnoFinal)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@AnoInicial", txtAnoInicial.Text);
                cmd.Parameters.AddWithValue("@AnoFinal", txtAnoFinal.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarAnosLetivos();
            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, insira um ID para remover o registro.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM AnoLetivo WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarAnosLetivos();
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtAnoInicial.Clear();
            txtAnoFinal.Clear();
        }
    }
}
