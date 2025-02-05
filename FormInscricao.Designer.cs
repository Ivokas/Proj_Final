namespace Proj_Final
{
    partial class FormInscricao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewInscricoes;
        private System.Windows.Forms.ComboBox comboAluno;
        private System.Windows.Forms.ComboBox comboUnidadeCurricular;
        private System.Windows.Forms.ComboBox comboAnoLetivo;
        private System.Windows.Forms.ComboBox comboEpocaAvaliacao;
        private System.Windows.Forms.ComboBox comboEstadoEpoca;
        private System.Windows.Forms.CheckBox checkBoxPresenca;
        private System.Windows.Forms.NumericUpDown numericNota;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Label labelUnidadeCurricular;
        private System.Windows.Forms.Label labelAnoLetivo;
        private System.Windows.Forms.Label labelEpocaAvaliacao;
        private System.Windows.Forms.Label labelEstadoEpoca;
        private System.Windows.Forms.Label labelPresenca;
        private System.Windows.Forms.Label labelNota;

        private void InitializeComponent()
        {
            this.dataGridViewInscricoes = new System.Windows.Forms.DataGridView();
            this.comboAluno = new System.Windows.Forms.ComboBox();
            this.comboUnidadeCurricular = new System.Windows.Forms.ComboBox();
            this.comboAnoLetivo = new System.Windows.Forms.ComboBox();
            this.comboEpocaAvaliacao = new System.Windows.Forms.ComboBox();
            this.comboEstadoEpoca = new System.Windows.Forms.ComboBox();
            this.checkBoxPresenca = new System.Windows.Forms.CheckBox();
            this.numericNota = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labelAluno = new System.Windows.Forms.Label();
            this.labelUnidadeCurricular = new System.Windows.Forms.Label();
            this.labelAnoLetivo = new System.Windows.Forms.Label();
            this.labelEpocaAvaliacao = new System.Windows.Forms.Label();
            this.labelEstadoEpoca = new System.Windows.Forms.Label();
            this.labelPresenca = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInscricoes
            // 
            this.dataGridViewInscricoes.ColumnHeadersHeight = 29;
            this.dataGridViewInscricoes.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewInscricoes.Name = "dataGridViewInscricoes";
            this.dataGridViewInscricoes.ReadOnly = true;
            this.dataGridViewInscricoes.RowHeadersWidth = 51;
            this.dataGridViewInscricoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscricoes.Size = new System.Drawing.Size(760, 200);
            this.dataGridViewInscricoes.TabIndex = 0;
            // 
            // comboAluno
            // 
            this.comboAluno.Location = new System.Drawing.Point(160, 240);
            this.comboAluno.Name = "comboAluno";
            this.comboAluno.Size = new System.Drawing.Size(200, 21);
            this.comboAluno.TabIndex = 2;
            // 
            // comboUnidadeCurricular
            // 
            this.comboUnidadeCurricular.Location = new System.Drawing.Point(160, 280);
            this.comboUnidadeCurricular.Name = "comboUnidadeCurricular";
            this.comboUnidadeCurricular.Size = new System.Drawing.Size(200, 21);
            this.comboUnidadeCurricular.TabIndex = 4;
            // 
            // comboAnoLetivo
            // 
            this.comboAnoLetivo.Location = new System.Drawing.Point(160, 320);
            this.comboAnoLetivo.Name = "comboAnoLetivo";
            this.comboAnoLetivo.Size = new System.Drawing.Size(200, 21);
            this.comboAnoLetivo.TabIndex = 6;
            // 
            // comboEpocaAvaliacao
            // 
            this.comboEpocaAvaliacao.Location = new System.Drawing.Point(160, 360);
            this.comboEpocaAvaliacao.Name = "comboEpocaAvaliacao";
            this.comboEpocaAvaliacao.Size = new System.Drawing.Size(200, 21);
            this.comboEpocaAvaliacao.TabIndex = 8;
            // 
            // comboEstadoEpoca
            // 
            this.comboEstadoEpoca.Location = new System.Drawing.Point(160, 400);
            this.comboEstadoEpoca.Name = "comboEstadoEpoca";
            this.comboEstadoEpoca.Size = new System.Drawing.Size(200, 21);
            this.comboEstadoEpoca.TabIndex = 10;
            // 
            // checkBoxPresenca
            // 
            this.checkBoxPresenca.Location = new System.Drawing.Point(160, 440);
            this.checkBoxPresenca.Name = "checkBoxPresenca";
            this.checkBoxPresenca.Size = new System.Drawing.Size(104, 24);
            this.checkBoxPresenca.TabIndex = 12;
            this.checkBoxPresenca.Text = "Presente";
            // 
            // numericNota
            // 
            this.numericNota.DecimalPlaces = 2;
            this.numericNota.Location = new System.Drawing.Point(160, 480);
            this.numericNota.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericNota.Name = "numericNota";
            this.numericNota.Size = new System.Drawing.Size(100, 20);
            this.numericNota.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionar.Location = new System.Drawing.Point(400, 240);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAlterar.Location = new System.Drawing.Point(400, 320);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemover.Location = new System.Drawing.Point(400, 280);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(400, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labelAluno
            // 
            this.labelAluno.Location = new System.Drawing.Point(20, 240);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(100, 23);
            this.labelAluno.TabIndex = 1;
            this.labelAluno.Text = "Aluno:";
            // 
            // labelUnidadeCurricular
            // 
            this.labelUnidadeCurricular.Location = new System.Drawing.Point(20, 280);
            this.labelUnidadeCurricular.Name = "labelUnidadeCurricular";
            this.labelUnidadeCurricular.Size = new System.Drawing.Size(100, 23);
            this.labelUnidadeCurricular.TabIndex = 3;
            this.labelUnidadeCurricular.Text = "Unidade Curricular:";
            // 
            // labelAnoLetivo
            // 
            this.labelAnoLetivo.Location = new System.Drawing.Point(20, 320);
            this.labelAnoLetivo.Name = "labelAnoLetivo";
            this.labelAnoLetivo.Size = new System.Drawing.Size(100, 23);
            this.labelAnoLetivo.TabIndex = 5;
            this.labelAnoLetivo.Text = "Ano Letivo:";
            // 
            // labelEpocaAvaliacao
            // 
            this.labelEpocaAvaliacao.Location = new System.Drawing.Point(20, 360);
            this.labelEpocaAvaliacao.Name = "labelEpocaAvaliacao";
            this.labelEpocaAvaliacao.Size = new System.Drawing.Size(100, 23);
            this.labelEpocaAvaliacao.TabIndex = 7;
            this.labelEpocaAvaliacao.Text = "Época Avaliação:";
            // 
            // labelEstadoEpoca
            // 
            this.labelEstadoEpoca.Location = new System.Drawing.Point(20, 400);
            this.labelEstadoEpoca.Name = "labelEstadoEpoca";
            this.labelEstadoEpoca.Size = new System.Drawing.Size(100, 23);
            this.labelEstadoEpoca.TabIndex = 9;
            this.labelEstadoEpoca.Text = "Estado Época:";
            // 
            // labelPresenca
            // 
            this.labelPresenca.Location = new System.Drawing.Point(20, 440);
            this.labelPresenca.Name = "labelPresenca";
            this.labelPresenca.Size = new System.Drawing.Size(100, 23);
            this.labelPresenca.TabIndex = 11;
            this.labelPresenca.Text = "Presença:";
            // 
            // labelNota
            // 
            this.labelNota.Location = new System.Drawing.Point(20, 480);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(100, 23);
            this.labelNota.TabIndex = 13;
            this.labelNota.Text = "Nota:";
            // 
            // FormInscricao
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dataGridViewInscricoes);
            this.Controls.Add(this.labelAluno);
            this.Controls.Add(this.comboAluno);
            this.Controls.Add(this.labelUnidadeCurricular);
            this.Controls.Add(this.comboUnidadeCurricular);
            this.Controls.Add(this.labelAnoLetivo);
            this.Controls.Add(this.comboAnoLetivo);
            this.Controls.Add(this.labelEpocaAvaliacao);
            this.Controls.Add(this.comboEpocaAvaliacao);
            this.Controls.Add(this.labelEstadoEpoca);
            this.Controls.Add(this.comboEstadoEpoca);
            this.Controls.Add(this.labelPresenca);
            this.Controls.Add(this.checkBoxPresenca);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.numericNota);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Name = "FormInscricao";
            this.Text = "Gerenciamento de Inscrições";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
