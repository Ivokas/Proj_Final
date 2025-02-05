namespace Proj_Final
{
    partial class FormAluno
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;

        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblMorada = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(20, 50);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(42, 15);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(110, 47);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(150, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(20, 110);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(51, 15);
            this.lblApelido.TabIndex = 6;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(110, 107);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(150, 20);
            this.txtApelido.TabIndex = 7;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(20, 140);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(84, 15);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data de Nasc:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(110, 140);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(150, 20);
            this.dtpDataNascimento.TabIndex = 9;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(20, 170);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(53, 15);
            this.lblMorada.TabIndex = 10;
            this.lblMorada.Text = "Morada:";
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(110, 165);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(150, 20);
            this.txtMorada.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 230);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(58, 15);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(110, 227);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionar.Location = new System.Drawing.Point(280, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 30);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemover.Location = new System.Drawing.Point(280, 57);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 30);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(280, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.ColumnHeadersHeight = 29;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(20, 270);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.RowHeadersWidth = 51;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewAlunos.TabIndex = 19;
            // 
            // FormAluno
            // 
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Name = "FormAluno";
            this.Text = "Gerenciamento de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
