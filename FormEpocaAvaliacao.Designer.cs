namespace Proj_Final
{
    partial class FormEpocaAvaliacao
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
            this.dataGridViewEpocas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpocas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEpocas
            // 
            this.dataGridViewEpocas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEpocas.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewEpocas.Name = "dataGridViewEpocas";
            this.dataGridViewEpocas.RowHeadersWidth = 51;
            this.dataGridViewEpocas.Size = new System.Drawing.Size(360, 200);
            this.dataGridViewEpocas.TabIndex = 0;
            // 
            // FormEpocaAvaliacao
            // 
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.dataGridViewEpocas);
            this.Name = "FormEpocaAvaliacao";
            this.Text = "Gerenciamento de Épocas de Avaliação";
            this.Load += new System.EventHandler(this.FormEpocaAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpocas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEpocas;
    }
}
