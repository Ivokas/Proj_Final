namespace Proj_Final
{
    partial class FormCurso
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(30, 20);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(70, 15);
            this.lblReferencia.TabIndex = 0;
            this.lblReferencia.Text = "Referência:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(110, 17);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(150, 20);
            this.txtReferencia.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(30, 80);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(38, 15);
            this.lblSigla.TabIndex = 4;
            this.lblSigla.Text = "Sigla:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(110, 77);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(150, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(30, 110);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(85, 15);
            this.lblDataInicio.TabIndex = 6;
            this.lblDataInicio.Text = "Data de Início:";
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(110, 107);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDataInicio.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionar.Location = new System.Drawing.Point(300, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemover.Location = new System.Drawing.Point(300, 47);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(300, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(30, 150);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.Size = new System.Drawing.Size(370, 200);
            this.dataGridViewCursos.TabIndex = 11;
            // 
            // FormCurso
            // 
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.lblReferencia);
            this.Name = "FormCurso";
            this.Text = "Gerenciamento de Cursos";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
    }
}
