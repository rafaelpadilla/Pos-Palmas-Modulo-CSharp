namespace Code_17
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
            this.btnCaminhoJSON = new System.Windows.Forms.Button();
            this.txbCaminhoJSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaminhoJSON
            // 
            this.btnCaminhoJSON.Location = new System.Drawing.Point(393, 9);
            this.btnCaminhoJSON.Name = "btnCaminhoJSON";
            this.btnCaminhoJSON.Size = new System.Drawing.Size(39, 23);
            this.btnCaminhoJSON.TabIndex = 3;
            this.btnCaminhoJSON.Text = "...";
            this.btnCaminhoJSON.UseVisualStyleBackColor = true;
            this.btnCaminhoJSON.Click += new System.EventHandler(this.btnCaminhoJSON_Click);
            // 
            // txbCaminhoJSON
            // 
            this.txbCaminhoJSON.Location = new System.Drawing.Point(95, 12);
            this.txbCaminhoJSON.Name = "txbCaminhoJSON";
            this.txbCaminhoJSON.Size = new System.Drawing.Size(293, 20);
            this.txbCaminhoJSON.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho JSON:";
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(10, 43);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializar.TabIndex = 5;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 77);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaminhoJSON);
            this.Controls.Add(this.txbCaminhoJSON);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Code 17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaminhoJSON;
        private System.Windows.Forms.TextBox txbCaminhoJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeserializar;
    }
}

