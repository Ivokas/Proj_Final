using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormUnidadeCurricular : Form
    {
        private string connectionString;

        public FormUnidadeCurricular()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
            CarregarUnidadesCurriculares();
            CarregarCombos();
        }

        private void FormUnidadeCurricular_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Unidades Curriculares";
            CarregarUnidadesCurriculares();
            CarregarCombos();
        }

        private void CarregarUnidadesCurriculares()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM UnidadeCurricular";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUnidadesCurriculares.DataSource = dt;
            }
        }

        private void CarregarCombos()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                // Carregar cursos no comboCurso
                string queryCurso = "SELECT referencia, nome FROM Curso";
                MySqlCommand cmdCurso = new MySqlCommand(queryCurso, conexao);
                MySqlDataAdapter daCurso = new MySqlDataAdapter(cmdCurso);
                DataTable dtCurso = new DataTable();
                daCurso.Fill(dtCurso);

                comboCurso.DataSource = dtCurso;
                comboCurso.DisplayMember = "nome"; // Exibe o nome do curso
                comboCurso.ValueMember = "referencia"; // Guarda a referência

                // Carregar docentes no comboDocente
                string queryDocente = "SELECT numero, CONCAT(nomeProprio, ' ', apelido) AS NomeCompleto FROM Docente";
                MySqlCommand cmdDocente = new MySqlCommand(queryDocente, conexao);
                MySqlDataAdapter daDocente = new MySqlDataAdapter(cmdDocente);
                DataTable dtDocente = new DataTable();
                daDocente.Fill(dtDocente);

                comboDocente.DataSource = dtDocente;
                comboDocente.DisplayMember = "NomeCompleto"; // Exibe NomePróprio + Apelido
                comboDocente.ValueMember = "numero"; // Guarda o número do docente
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) " +
                               "VALUES (@Id, @Curso, @Docente, @Nome, @Sigla, @Creditos, @Ano, @Semestre)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtID.Text);
                cmd.Parameters.AddWithValue("@Curso", comboCurso.SelectedValue);
                cmd.Parameters.AddWithValue("@Docente", comboDocente.SelectedValue);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Sigla", txtSigla.Text);
                cmd.Parameters.AddWithValue("@Creditos", numCreditos.Value);
                cmd.Parameters.AddWithValue("@Ano", numAno.Value);
                cmd.Parameters.AddWithValue("@Semestre", numSemestre.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarUnidadesCurriculares();
            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidadesCurriculares.SelectedRows.Count > 0)
            {
                string id = dataGridViewUnidadesCurriculares.SelectedRows[0].Cells["id"].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM UnidadeCurricular WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                CarregarUnidadesCurriculares();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidadesCurriculares.SelectedRows.Count > 0)
            {
                string id = txtID.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE UnidadeCurricular SET referenciaCurso = @Curso, numeroDocente = @Docente, nome = @Nome, " +
                                   "sigla = @Sigla, creditos = @Creditos, ano = @Ano, semestre = @Semestre WHERE id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Curso", comboCurso.SelectedValue);
                    cmd.Parameters.AddWithValue("@Docente", comboDocente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Sigla", txtSigla.Text);
                    cmd.Parameters.AddWithValue("@Creditos", numCreditos.Value);
                    cmd.Parameters.AddWithValue("@Ano", numAno.Value);
                    cmd.Parameters.AddWithValue("@Semestre", numSemestre.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                CarregarUnidadesCurriculares();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para alterar.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            comboCurso.SelectedIndex = -1;
            comboDocente.SelectedIndex = -1;
            txtNome.Clear();
            txtSigla.Clear();
            numCreditos.Value = 0;
            numAno.Value = 0;
            numSemestre.Value = 0;
        }

        private void dataGridViewUnidadesCurriculares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUnidadesCurriculares.Rows[e.RowIndex];

                txtID.Text = row.Cells["id"].Value.ToString();
                comboCurso.SelectedValue = row.Cells["referenciaCurso"].Value;
                comboDocente.SelectedValue = row.Cells["numeroDocente"].Value;
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtSigla.Text = row.Cells["sigla"].Value.ToString();
                numCreditos.Value = Convert.ToDecimal(row.Cells["creditos"].Value);
                numAno.Value = Convert.ToInt32(row.Cells["ano"].Value);
                numSemestre.Value = Convert.ToInt32(row.Cells["semestre"].Value);
            }
        }
    }
}
