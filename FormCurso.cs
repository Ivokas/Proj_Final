using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormCurso : Form
    {
        private string connectionString;

        public FormCurso()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Cursos";
            CarregarCursos();
        }

        private void CarregarCursos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Curso";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewCursos.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Curso (Referencia, Nome, Sigla, DataInicio) VALUES (@Referencia, @Nome, @Sigla, @DataInicio)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Referencia", txtReferencia.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Sigla", txtSigla.Text);
                cmd.Parameters.AddWithValue("@DataInicio", dateTimePickerDataInicio.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarCursos();
            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                int idCurso = Convert.ToInt32(dataGridViewCursos.SelectedRows[0].Cells["ID"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM Curso WHERE ID = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", idCurso);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                CarregarCursos();
            }
            else
            {
                MessageBox.Show("Selecione um curso para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtReferencia.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            dateTimePickerDataInicio.Value = DateTime.Now;
        }
    }
}
