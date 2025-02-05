namespace Proj_Final
{
    partial class FormDocente
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNomeProprio;
        private System.Windows.Forms.TextBox txtNomeProprio;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblExtensao;
        private System.Windows.Forms.TextBox txtExtensao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.NumericUpDown numSalario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridViewDocentes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNomeProprio = new System.Windows.Forms.Label();
            this.txtNomeProprio = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblExtensao = new System.Windows.Forms.Label();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.numSalario = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridViewDocentes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).BeginInit();
            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 20);
            this.lblNumero.Text = "Número:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(150, 17);
            this.txtNumero.Size = new System.Drawing.Size(150, 23);

            // lblNomeProprio
            this.lblNomeProprio.AutoSize = true;
            this.lblNomeProprio.Location = new System.Drawing.Point(20, 50);
            this.lblNomeProprio.Text = "Nome Próprio:";

            // txtNomeProprio
            this.txtNomeProprio.Location = new System.Drawing.Point(150, 47);
            this.txtNomeProprio.Size = new System.Drawing.Size(150, 23);

            // lblApelido
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(20, 80);
            this.lblApelido.Text = "Apelido:";

            // txtApelido
            this.txtApelido.Location = new System.Drawing.Point(150, 77);
            this.txtApelido.Size = new System.Drawing.Size(150, 23);

            // lblDataNascimento
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(20, 110);
            this.lblDataNascimento.Text = "Data de Nascimento:";

            // dtpDataNascimento
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(150, 107);
            this.dtpDataNascimento.Size = new System.Drawing.Size(150, 23);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 140);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(150, 137);
            this.txtEmail.Size = new System.Drawing.Size(150, 23);

            // lblTelefone
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 170);
            this.lblTelefone.Text = "Telefone:";

            // txtTelefone
            this.txtTelefone.Location = new System.Drawing.Point(150, 167);
            this.txtTelefone.Size = new System.Drawing.Size(150, 23);

            // lblExtensao
            this.lblExtensao.AutoSize = true;
            this.lblExtensao.Location = new System.Drawing.Point(20, 200);
            this.lblExtensao.Text = "Extensão:";

            // txtExtensao
            this.txtExtensao.Location = new System.Drawing.Point(150, 197);
            this.txtExtensao.Size = new System.Drawing.Size(150, 23);

            // lblSalario
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(20, 230);
            this.lblSalario.Text = "Salário:";

            // numSalario
            this.numSalario.Location = new System.Drawing.Point(150, 227);
            this.numSalario.Size = new System.Drawing.Size(150, 23);
            this.numSalario.DecimalPlaces = 2;
            this.numSalario.Maximum = 99999;

            // btnAdicionar
            this.btnAdicionar.Location = new System.Drawing.Point(330, 17);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // btnRemover
            this.btnRemover.Location = new System.Drawing.Point(330, 53);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            // btnLimpar
            this.btnLimpar.Location = new System.Drawing.Point(330, 89);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // dataGridViewDocentes
            this.dataGridViewDocentes.Location = new System.Drawing.Point(20, 270);
            this.dataGridViewDocentes.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FormDocente
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNumero, this.txtNumero, this.lblNomeProprio, this.txtNomeProprio, this.lblApelido, this.txtApelido,
                this.lblDataNascimento, this.dtpDataNascimento, this.lblEmail, this.txtEmail, this.lblTelefone, this.txtTelefone,
                this.lblExtensao, this.txtExtensao, this.lblSalario, this.numSalario, this.btnAdicionar, this.btnRemover, this.btnLimpar,
                this.dataGridViewDocentes
            });
            this.Text = "Gerenciamento de Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
