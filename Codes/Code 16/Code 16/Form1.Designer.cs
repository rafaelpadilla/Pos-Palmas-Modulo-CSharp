namespace Code_16
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
            this.btnCaminhoXML = new System.Windows.Forms.Button();
            this.txbCaminhoXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaminhoXML
            // 
            this.btnCaminhoXML.Location = new System.Drawing.Point(513, 10);
            this.btnCaminhoXML.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaminhoXML.Name = "btnCaminhoXML";
            this.btnCaminhoXML.Size = new System.Drawing.Size(52, 28);
            this.btnCaminhoXML.TabIndex = 3;
            this.btnCaminhoXML.Text = "...";
            this.btnCaminhoXML.UseVisualStyleBackColor = true;
            this.btnCaminhoXML.Click += new System.EventHandler(this.btnCaminhoXML_Click);
            // 
            // txbCaminhoXML
            // 
            this.txbCaminhoXML.Location = new System.Drawing.Point(116, 13);
            this.txbCaminhoXML.Margin = new System.Windows.Forms.Padding(4);
            this.txbCaminhoXML.Name = "txbCaminhoXML";
            this.txbCaminhoXML.Size = new System.Drawing.Size(389, 22);
            this.txbCaminhoXML.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho XML:";
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(13, 53);
            this.btnDeserializar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(100, 28);
            this.btnDeserializar.TabIndex = 5;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 367);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaminhoXML);
            this.Controls.Add(this.txbCaminhoXML);
            this.Name = "Form1";
            this.Text = "Code 16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaminhoXML;
        private System.Windows.Forms.TextBox txbCaminhoXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeserializar;
    }
}

