using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormDocente : Form
    {
        private string connectionString;

        public FormDocente()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["EscolaDB"].ConnectionString;
            CarregarDocentes();
        }

        private void FormDocente_Load(object sender, EventArgs e)
        {
            this.Text = "Gerenciamento de Docentes";
            CarregarDocentes();
        }

        private void CarregarDocentes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Numero, NomeProprio, Apelido, DataNascimento, Email, Telefone, Extensao, Salario FROM docente";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewDocentes.DataSource = dt;
                        dataGridViewDocentes.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum docente encontrado na base de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewDocentes.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar docentes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO Docente (Numero, NomeProprio, Apelido, DataNascimento, Email, Telefone, Extensao, Salario) " +
                                   "VALUES (@Numero, @NomeProprio, @Apelido, @DataNascimento, @Email, @Telefone, @Extensao, @Salario)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@NomeProprio", txtNomeProprio.Text);
                    cmd.Parameters.AddWithValue("@Apelido", txtApelido.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@Extensao", txtExtensao.Text);
                    cmd.Parameters.AddWithValue("@Salario", numSalario.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                CarregarDocentes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocentes.SelectedRows.Count > 0)
            {
                try
                {
                    int numeroDocente = Convert.ToInt32(dataGridViewDocentes.SelectedRows[0].Cells["Numero"].Value);

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Docente WHERE Numero = @Numero";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Numero", numeroDocente);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    CarregarDocentes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um docente para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumero.Clear();
            txtNomeProprio.Clear();
            txtApelido.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            txtEmail.Clear();
            txtTelefone.Clear();
            txtExtensao.Clear();
            numSalario.Value = 0;
        }
    }
}
