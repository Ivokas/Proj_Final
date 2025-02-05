namespace Proj_Final
{
    partial class FormAnoLetivo
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAnoInicial = new System.Windows.Forms.Label();
            this.txtAnoInicial = new System.Windows.Forms.TextBox();
            this.lblAnoFinal = new System.Windows.Forms.Label();
            this.txtAnoFinal = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridViewAnoLetivo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnoLetivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblAnoInicial
            // 
            this.lblAnoInicial.AutoSize = true;
            this.lblAnoInicial.Location = new System.Drawing.Point(30, 50);
            this.lblAnoInicial.Name = "lblAnoInicial";
            this.lblAnoInicial.Size = new System.Drawing.Size(66, 15);
            this.lblAnoInicial.TabIndex = 2;
            this.lblAnoInicial.Text = "Ano Inicial:";
            // 
            // txtAnoInicial
            // 
            this.txtAnoInicial.Location = new System.Drawing.Point(100, 47);
            this.txtAnoInicial.Name = "txtAnoInicial";
            this.txtAnoInicial.Size = new System.Drawing.Size(150, 20);
            this.txtAnoInicial.TabIndex = 3;
            // 
            // lblAnoFinal
            // 
            this.lblAnoFinal.AutoSize = true;
            this.lblAnoFinal.Location = new System.Drawing.Point(30, 80);
            this.lblAnoFinal.Name = "lblAnoFinal";
            this.lblAnoFinal.Size = new System.Drawing.Size(61, 15);
            this.lblAnoFinal.TabIndex = 4;
            this.lblAnoFinal.Text = "Ano Final:";
            // 
            // txtAnoFinal
            // 
            this.txtAnoFinal.Location = new System.Drawing.Point(100, 77);
            this.txtAnoFinal.Name = "txtAnoFinal";
            this.txtAnoFinal.Size = new System.Drawing.Size(150, 20);
            this.txtAnoFinal.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionar.Location = new System.Drawing.Point(280, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemover.Location = new System.Drawing.Point(280, 47);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(280, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridViewAnoLetivo
            // 
            this.dataGridViewAnoLetivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnoLetivo.Location = new System.Drawing.Point(30, 120);
            this.dataGridViewAnoLetivo.Name = "dataGridViewAnoLetivo";
            this.dataGridViewAnoLetivo.RowHeadersWidth = 51;
            this.dataGridViewAnoLetivo.Size = new System.Drawing.Size(350, 200);
            this.dataGridViewAnoLetivo.TabIndex = 9;
            // 
            // FormAnoLetivo
            // 
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.dataGridViewAnoLetivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAnoFinal);
            this.Controls.Add(this.lblAnoFinal);
            this.Controls.Add(this.txtAnoInicial);
            this.Controls.Add(this.lblAnoInicial);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "FormAnoLetivo";
            this.Text = "Gerenciamento de Anos Letivos";
            this.Load += new System.EventHandler(this.FormAnoLetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnoLetivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAnoInicial;
        private System.Windows.Forms.TextBox txtAnoInicial;
        private System.Windows.Forms.Label lblAnoFinal;
        private System.Windows.Forms.TextBox txtAnoFinal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridViewAnoLetivo;
    }
}
