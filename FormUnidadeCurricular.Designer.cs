namespace Proj_Final
{
    partial class FormUnidadeCurricular
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.ComboBox comboDocente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.NumericUpDown numCreditos;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.NumericUpDown numSemestre;
        private System.Windows.Forms.DataGridView dataGridViewUnidadesCurriculares;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblSemestre;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.comboDocente = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.numCreditos = new System.Windows.Forms.NumericUpDown();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.numSemestre = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewUnidadesCurriculares = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidadesCurriculares)).BeginInit();

            this.SuspendLayout();

            // Labels
            this.lblID.Text = "ID:";
            this.lblCurso.Text = "Curso:";
            this.lblDocente.Text = "Docente:";
            this.lblNome.Text = "Nome:";
            this.lblSigla.Text = "Sigla:";
            this.lblCreditos.Text = "Créditos:";
            this.lblAno.Text = "Ano:";
            this.lblSemestre.Text = "Semestre:";

            // Labels - Configurações
            int labelWidth = 80;
            int campoWidth = 200;
            int campoAltura = 25;
            int espacoY = 30;
            int espacoX = 120;
            int startX = 20;
            int startY = 20;

            this.lblID.SetBounds(startX, startY, labelWidth, campoAltura);
            this.txtID.SetBounds(startX + espacoX, startY, campoWidth, campoAltura);

            this.lblCurso.SetBounds(startX, startY + espacoY, labelWidth, campoAltura);
            this.comboCurso.SetBounds(startX + espacoX, startY + espacoY, campoWidth, campoAltura);

            this.lblDocente.SetBounds(startX, startY + espacoY * 2, labelWidth, campoAltura);
            this.comboDocente.SetBounds(startX + espacoX, startY + espacoY * 2, campoWidth, campoAltura);

            this.lblNome.SetBounds(startX, startY + espacoY * 3, labelWidth, campoAltura);
            this.txtNome.SetBounds(startX + espacoX, startY + espacoY * 3, campoWidth, campoAltura);

            this.lblSigla.SetBounds(startX, startY + espacoY * 4, labelWidth, campoAltura);
            this.txtSigla.SetBounds(startX + espacoX, startY + espacoY * 4, campoWidth, campoAltura);

            this.lblCreditos.SetBounds(startX, startY + espacoY * 5, labelWidth, campoAltura);
            this.numCreditos.SetBounds(startX + espacoX, startY + espacoY * 5, campoWidth / 3, campoAltura);

            this.lblAno.SetBounds(startX, startY + espacoY * 6, labelWidth, campoAltura);
            this.numAno.SetBounds(startX + espacoX, startY + espacoY * 6, campoWidth / 3, campoAltura);

            this.lblSemestre.SetBounds(startX, startY + espacoY * 7, labelWidth, campoAltura);
            this.numSemestre.SetBounds(startX + espacoX, startY + espacoY * 7, campoWidth / 3, campoAltura);

            // Botões
            int botaoLargura = 100;
            int botaoAltura = 30;
            int botaoX = 350;
            int botaoEspacoY = 40;

            this.btnAdicionar.SetBounds(botaoX, startY, botaoLargura, botaoAltura);
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.btnRemover.SetBounds(botaoX, startY + botaoEspacoY, botaoLargura, botaoAltura);
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.btnAlterar.SetBounds(botaoX, startY + botaoEspacoY * 2, botaoLargura, botaoAltura);
            this.btnAlterar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);

            this.btnLimpar.SetBounds(botaoX, startY + botaoEspacoY * 3, botaoLargura, botaoAltura);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // DataGridView
            this.dataGridViewUnidadesCurriculares.SetBounds(20, 300, 540, 200);
            this.dataGridViewUnidadesCurriculares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnidadesCurriculares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnidadesCurriculares_CellClick);

            // Adicionando os componentes ao formulário
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblID, txtID, lblCurso, comboCurso, lblDocente, comboDocente,
                lblNome, txtNome, lblSigla, txtSigla, lblCreditos, numCreditos,
                lblAno, numAno, lblSemestre, numSemestre, btnAdicionar,
                btnRemover, btnAlterar, btnLimpar, dataGridViewUnidadesCurriculares
            });

            // Configuração do Formulário
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Text = "Gerenciamento de Unidades Curriculares";
            this.ResumeLayout(false);
        }
    }
}
