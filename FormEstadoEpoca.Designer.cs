namespace Proj_Final
{
    partial class FormEstadoEpoca
    {
        /// <summary>
        /// Variável necessária para o designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos usados.
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
            this.dataGridViewEstados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstados
            // 
            this.dataGridViewEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstados.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewEstados.Name = "dataGridViewEstados";
            this.dataGridViewEstados.RowHeadersWidth = 51;
            this.dataGridViewEstados.Size = new System.Drawing.Size(360, 200);
            this.dataGridViewEstados.TabIndex = 0;
            // 
            // FormEstadoEpoca
            // 
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.dataGridViewEstados);
            this.Name = "FormEstadoEpoca";
            this.Text = "Gerenciamento de Estados de Época";
            this.Load += new System.EventHandler(this.FormEstadoEpoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEstados;
    }
}
