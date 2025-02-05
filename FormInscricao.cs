using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormInscricao : Form
    {
        private string connectionString;

        public FormInscricao()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
            CarregarInscricoes();
            CarregarCombos();
            InicializarCampos();
        }

        private void FormInscricao_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Inscrições";
            CarregarInscricoes();
            CarregarCombos();
            InicializarCampos();
        }

        private void CarregarInscricoes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota FROM Inscricao";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewInscricoes.DataSource = dt;
            }
        }

        private void CarregarCombos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                PreencherComboBox("SELECT numero, CONCAT(nomeProprio, ' ', apelido) AS Nome FROM Aluno", comboAluno, "Nome", "numero", conn);
                PreencherComboBox("SELECT id, nome FROM UnidadeCurricular", comboUnidadeCurricular, "nome", "id", conn);
                PreencherComboBox("SELECT id FROM AnoLetivo", comboAnoLetivo, "id", "id", conn);
                PreencherComboBox("SELECT id, descricao FROM EpocaAvaliacao", comboEpocaAvaliacao, "descricao", "id", conn);
                PreencherComboBox("SELECT id, descricao FROM EstadoEpoca", comboEstadoEpoca, "descricao", "id", conn);
            }
        }

        private void PreencherComboBox(string query, ComboBox comboBox, string display, string value, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
        }

        private void InicializarCampos()
        {
            comboAluno.SelectedIndex = -1;
            comboUnidadeCurricular.SelectedIndex = -1;
            comboAnoLetivo.SelectedIndex = -1;
            comboEpocaAvaliacao.SelectedIndex = -1;
            comboEstadoEpoca.SelectedIndex = -1;
            checkBoxPresenca.Checked = false;
            numericNota.Value = 0;
            numericNota.ResetText();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota) " +
                               "VALUES (@numeroAluno, @idUnidadeCurricular, @idAnoLetivo, @idEpocaAvaliacao, @idEstadoEpoca, @Presenca, @Nota)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroAluno", comboAluno.SelectedValue);
                cmd.Parameters.AddWithValue("@idUnidadeCurricular", comboUnidadeCurricular.SelectedValue);
                cmd.Parameters.AddWithValue("@idAnoLetivo", comboAnoLetivo.SelectedValue);
                cmd.Parameters.AddWithValue("@idEpocaAvaliacao", comboEpocaAvaliacao.SelectedValue);
                cmd.Parameters.AddWithValue("@idEstadoEpoca", comboEstadoEpoca.SelectedValue);
                cmd.Parameters.AddWithValue("@Presenca", checkBoxPresenca.Checked ? "P" : "F");
                cmd.Parameters.AddWithValue("@Nota", numericNota.Value > 0 ? (object)numericNota.Value : DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarInscricoes();
            InicializarCampos();
        }

        private void dataGridViewInscricoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewInscricoes.Rows[e.RowIndex];
                comboAluno.SelectedValue = row.Cells["numeroAluno"].Value;
                comboUnidadeCurricular.SelectedValue = row.Cells["idUnidadeCurricular"].Value;
                comboAnoLetivo.SelectedValue = row.Cells["idAnoLetivo"].Value;
                comboEpocaAvaliacao.SelectedValue = row.Cells["idEpocaAvaliacao"].Value;
                comboEstadoEpoca.SelectedValue = row.Cells["idEstadoEpoca"].Value;
                checkBoxPresenca.Checked = row.Cells["presenca"].Value.ToString() == "P";
                numericNota.Value = row.Cells["nota"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["nota"].Value) : 0;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Inscricao WHERE numeroAluno=@numeroAluno AND idUnidadeCurricular=@idUnidadeCurricular " +
                               "AND idAnoLetivo=@idAnoLetivo AND idEpocaAvaliacao=@idEpocaAvaliacao";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroAluno", comboAluno.SelectedValue);
                cmd.Parameters.AddWithValue("@idUnidadeCurricular", comboUnidadeCurricular.SelectedValue);
                cmd.Parameters.AddWithValue("@idAnoLetivo", comboAnoLetivo.SelectedValue);
                cmd.Parameters.AddWithValue("@idEpocaAvaliacao", comboEpocaAvaliacao.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarInscricoes();
            InicializarCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Inscricao SET idEstadoEpoca=@idEstadoEpoca, presenca=@Presenca, nota=@Nota " +
                               "WHERE numeroAluno=@numeroAluno AND idUnidadeCurricular=@idUnidadeCurricular " +
                               "AND idAnoLetivo=@idAnoLetivo AND idEpocaAvaliacao=@idEpocaAvaliacao";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idEstadoEpoca", comboEstadoEpoca.SelectedValue);
                cmd.Parameters.AddWithValue("@Presenca", checkBoxPresenca.Checked ? "P" : "F");
                cmd.Parameters.AddWithValue("@Nota", numericNota.Value > 0 ? (object)numericNota.Value : DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CarregarInscricoes();
            InicializarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }
    }
}
