using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_Final
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu Principal";
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            FormAluno form = new FormAluno();
            form.ShowDialog();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            FormCurso form = new FormCurso();
            form.ShowDialog();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            FormDocente form = new FormDocente();
            form.ShowDialog();
        }

        private void btnUnidadeCurricular_Click(object sender, EventArgs e)
        {
            FormUnidadeCurricular form = new FormUnidadeCurricular();
            form.ShowDialog();
        }

        private void btnAnoLetivo_Click(object sender, EventArgs e)
        {
            FormAnoLetivo form = new FormAnoLetivo();
            form.ShowDialog();
        }

        private void btnEpocaAvaliacao_Click(object sender, EventArgs e)
        {
            FormEpocaAvaliacao form = new FormEpocaAvaliacao();
            form.ShowDialog();
        }

        private void btnEstadoEpoca_Click(object sender, EventArgs e)
        {
            FormEstadoEpoca form = new FormEstadoEpoca();
            form.ShowDialog();
        }

        private void btnInscricao_Click(object sender, EventArgs e)
        {
            FormInscricao form = new FormInscricao();
            form.ShowDialog();
        }
    }
}
