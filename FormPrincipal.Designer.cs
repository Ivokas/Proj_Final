namespace Proj_Final
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnUnidadeCurricular = new System.Windows.Forms.Button();
            this.btnAnoLetivo = new System.Windows.Forms.Button();
            this.btnEpocaAvaliacao = new System.Windows.Forms.Button();
            this.btnEstadoEpoca = new System.Windows.Forms.Button();
            this.btnInscricao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(56, 13);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(153, 27);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(56, 46);
            this.btnCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(153, 27);
            this.btnCurso.TabIndex = 1;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(56, 78);
            this.btnDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(153, 27);
            this.btnDocente.TabIndex = 2;
            this.btnDocente.Text = "Docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnUnidadeCurricular
            // 
            this.btnUnidadeCurricular.Location = new System.Drawing.Point(56, 111);
            this.btnUnidadeCurricular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnidadeCurricular.Name = "btnUnidadeCurricular";
            this.btnUnidadeCurricular.Size = new System.Drawing.Size(153, 27);
            this.btnUnidadeCurricular.TabIndex = 3;
            this.btnUnidadeCurricular.Text = "Unidade Curricular";
            this.btnUnidadeCurricular.UseVisualStyleBackColor = true;
            this.btnUnidadeCurricular.Click += new System.EventHandler(this.btnUnidadeCurricular_Click);
            // 
            // btnAnoLetivo
            // 
            this.btnAnoLetivo.Location = new System.Drawing.Point(56, 143);
            this.btnAnoLetivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnoLetivo.Name = "btnAnoLetivo";
            this.btnAnoLetivo.Size = new System.Drawing.Size(153, 27);
            this.btnAnoLetivo.TabIndex = 4;
            this.btnAnoLetivo.Text = "Ano Letivo";
            this.btnAnoLetivo.UseVisualStyleBackColor = true;
            this.btnAnoLetivo.Click += new System.EventHandler(this.btnAnoLetivo_Click);
            // 
            // btnEpocaAvaliacao
            // 
            this.btnEpocaAvaliacao.Location = new System.Drawing.Point(56, 176);
            this.btnEpocaAvaliacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEpocaAvaliacao.Name = "btnEpocaAvaliacao";
            this.btnEpocaAvaliacao.Size = new System.Drawing.Size(153, 27);
            this.btnEpocaAvaliacao.TabIndex = 5;
            this.btnEpocaAvaliacao.Text = "Época de Avaliação";
            this.btnEpocaAvaliacao.UseVisualStyleBackColor = true;
            this.btnEpocaAvaliacao.Click += new System.EventHandler(this.btnEpocaAvaliacao_Click);
            // 
            // btnEstadoEpoca
            // 
            this.btnEstadoEpoca.Location = new System.Drawing.Point(56, 208);
            this.btnEstadoEpoca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEstadoEpoca.Name = "btnEstadoEpoca";
            this.btnEstadoEpoca.Size = new System.Drawing.Size(153, 27);
            this.btnEstadoEpoca.TabIndex = 6;
            this.btnEstadoEpoca.Text = "Estado de Época";
            this.btnEstadoEpoca.UseVisualStyleBackColor = true;
            this.btnEstadoEpoca.Click += new System.EventHandler(this.btnEstadoEpoca_Click);
            // 
            // btnInscricao
            // 
            this.btnInscricao.Location = new System.Drawing.Point(56, 241);
            this.btnInscricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInscricao.Name = "btnInscricao";
            this.btnInscricao.Size = new System.Drawing.Size(153, 27);
            this.btnInscricao.TabIndex = 7;
            this.btnInscricao.Text = "Inscrição";
            this.btnInscricao.UseVisualStyleBackColor = true;
            this.btnInscricao.Click += new System.EventHandler(this.btnInscricao_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 284);
            this.Controls.Add(this.btnInscricao);
            this.Controls.Add(this.btnEstadoEpoca);
            this.Controls.Add(this.btnEpocaAvaliacao);
            this.Controls.Add(this.btnAnoLetivo);
            this.Controls.Add(this.btnUnidadeCurricular);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnAluno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnUnidadeCurricular;
        private System.Windows.Forms.Button btnAnoLetivo;
        private System.Windows.Forms.Button btnEpocaAvaliacao;
        private System.Windows.Forms.Button btnEstadoEpoca;
        private System.Windows.Forms.Button btnInscricao;
    }
}