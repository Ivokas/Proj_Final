using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Biblioteca MySQL

namespace Proj_Final
{
    public partial class FormAluno : Form
    {
        private string connectionString;

        public FormAluno()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
            this.Load += new EventHandler(FormAluno_Load); // Evento Load do formulário
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            ConfigurarDesign();
            CarregarDados();
        }

        private void ConfigurarDesign()
        {
            // Garante que todos os componentes do formulário apareçam corretamente
            lblNumero.Visible = true;
            txtNumero.Visible = true;
            lblCurso.Visible = true;
            txtCurso.Visible = true;
            lblNome.Visible = true;
            txtNome.Visible = true;
            lblApelido.Visible = true;
            txtApelido.Visible = true;
            lblDataNascimento.Visible = true;
            dtpDataNascimento.Visible = true;
            lblMorada.Visible = true;
            txtMorada.Visible = true;
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            lblTelefone.Visible = true;
            txtTelefone.Visible = true;
            btnAdicionar.Visible = true;
            btnRemover.Visible = true;
            btnLimpar.Visible = true;
            dataGridViewAlunos.Visible = true;
        }

        private void CarregarDados()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM aluno"; // Corrigido para "aluno"
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewAlunos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO aluno (Numero, Curso, Nome, Apelido, DataNascimento, Morada, Email, Telefone) VALUES (@Numero, @Curso, @Nome, @Apelido, @DataNascimento, @Morada, @Email, @Telefone)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@Curso", txtCurso.Text);
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Apelido", txtApelido.Text);
                        cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value);
                        cmd.Parameters.AddWithValue("@Morada", txtMorada.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Aluno adicionado com sucesso!");
                    CarregarDados();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar aluno: " + ex.Message);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlunos.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(dataGridViewAlunos.SelectedRows[0].Cells["ID"].Value); // Certifique-se de que a coluna existe
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM aluno WHERE ID = @ID"; // Corrigido para "aluno"
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", idAluno);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Aluno removido com sucesso!");
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover aluno: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno para remover.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumero.Clear();
            txtCurso.Clear();
            txtNome.Clear();
            txtApelido.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            txtMorada.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }
    }
}
