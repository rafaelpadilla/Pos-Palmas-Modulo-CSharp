namespace Code_15
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
            this.txbCEPDestino = new System.Windows.Forms.TextBox();
            this.txbCEPOrigem = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cmbServicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCEPDestino
            // 
            this.txbCEPDestino.Location = new System.Drawing.Point(102, 92);
            this.txbCEPDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txbCEPDestino.Name = "txbCEPDestino";
            this.txbCEPDestino.Size = new System.Drawing.Size(132, 22);
            this.txbCEPDestino.TabIndex = 5;
            // 
            // txbCEPOrigem
            // 
            this.txbCEPOrigem.Location = new System.Drawing.Point(102, 62);
            this.txbCEPOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txbCEPOrigem.Name = "txbCEPOrigem";
            this.txbCEPOrigem.Size = new System.Drawing.Size(132, 22);
            this.txbCEPOrigem.TabIndex = 6;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(102, 122);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(100, 28);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cmbServicos
            // 
            this.cmbServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicos.FormattingEnabled = true;
            this.cmbServicos.Location = new System.Drawing.Point(102, 28);
            this.cmbServicos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServicos.Name = "cmbServicos";
            this.cmbServicos.Size = new System.Drawing.Size(160, 24);
            this.cmbServicos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serviços:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbServicos);
            this.groupBox1.Controls.Add(this.txbCEPDestino);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.txbCEPOrigem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webservice Correios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CEP Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CEP Origem:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Code 15";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbCEPDestino;
        private System.Windows.Forms.TextBox txbCEPOrigem;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cmbServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

