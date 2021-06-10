namespace AlertasEconomicos
{
    partial class FrmAlertas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertas));
            this.tmrHorario = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbHoraBovespa = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraSP500 = new System.Windows.Forms.MaskedTextBox();
            this.mtbIndicador1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbIndicador2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbIndicdor3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbIndicador4 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.wbCotacoes = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tmrHorario
            // 
            this.tmrHorario.Enabled = true;
            this.tmrHorario.Interval = 1000;
            this.tmrHorario.Tick += new System.EventHandler(this.tmrHorario_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Abertura Bovespa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Abertura SP 500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Indicador 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indicador 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(433, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Indicador 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Indicador 4";
            // 
            // mtbHoraBovespa
            // 
            this.mtbHoraBovespa.Location = new System.Drawing.Point(12, 21);
            this.mtbHoraBovespa.Mask = "90:00";
            this.mtbHoraBovespa.Name = "mtbHoraBovespa";
            this.mtbHoraBovespa.Size = new System.Drawing.Size(100, 20);
            this.mtbHoraBovespa.TabIndex = 14;
            this.mtbHoraBovespa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraBovespa.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraSP500
            // 
            this.mtbHoraSP500.Location = new System.Drawing.Point(118, 21);
            this.mtbHoraSP500.Mask = "90:00";
            this.mtbHoraSP500.Name = "mtbHoraSP500";
            this.mtbHoraSP500.Size = new System.Drawing.Size(100, 20);
            this.mtbHoraSP500.TabIndex = 15;
            this.mtbHoraSP500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraSP500.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador1
            // 
            this.mtbIndicador1.Location = new System.Drawing.Point(224, 21);
            this.mtbIndicador1.Mask = "90:00";
            this.mtbIndicador1.Name = "mtbIndicador1";
            this.mtbIndicador1.Size = new System.Drawing.Size(100, 20);
            this.mtbIndicador1.TabIndex = 16;
            this.mtbIndicador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador2
            // 
            this.mtbIndicador2.Location = new System.Drawing.Point(330, 21);
            this.mtbIndicador2.Mask = "90:00";
            this.mtbIndicador2.Name = "mtbIndicador2";
            this.mtbIndicador2.Size = new System.Drawing.Size(100, 20);
            this.mtbIndicador2.TabIndex = 17;
            this.mtbIndicador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador2.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicdor3
            // 
            this.mtbIndicdor3.Location = new System.Drawing.Point(436, 21);
            this.mtbIndicdor3.Mask = "90:00";
            this.mtbIndicdor3.Name = "mtbIndicdor3";
            this.mtbIndicdor3.Size = new System.Drawing.Size(100, 20);
            this.mtbIndicdor3.TabIndex = 18;
            this.mtbIndicdor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicdor3.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador4
            // 
            this.mtbIndicador4.Location = new System.Drawing.Point(542, 21);
            this.mtbIndicador4.Mask = "90:00";
            this.mtbIndicador4.Name = "mtbIndicador4";
            this.mtbIndicador4.Size = new System.Drawing.Size(100, 20);
            this.mtbIndicador4.TabIndex = 19;
            this.mtbIndicador4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador4.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(647, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 20);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "00:00:00";
            // 
            // wbCotacoes
            // 
            this.wbCotacoes.Location = new System.Drawing.Point(732, 5);
            this.wbCotacoes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbCotacoes.Name = "wbCotacoes";
            this.wbCotacoes.Size = new System.Drawing.Size(434, 243);
            this.wbCotacoes.TabIndex = 26;
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1207, 323);
            this.Controls.Add(this.wbCotacoes);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtbIndicador4);
            this.Controls.Add(this.mtbIndicdor3);
            this.Controls.Add(this.mtbIndicador2);
            this.Controls.Add(this.mtbIndicador1);
            this.Controls.Add(this.mtbHoraSP500);
            this.Controls.Add(this.mtbHoraBovespa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlertas";
            this.Text = "Alertas de indicadores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlertas_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmAlertas_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbHoraBovespa;
        private System.Windows.Forms.MaskedTextBox mtbHoraSP500;
        private System.Windows.Forms.MaskedTextBox mtbIndicador1;
        private System.Windows.Forms.MaskedTextBox mtbIndicador2;
        private System.Windows.Forms.MaskedTextBox mtbIndicdor3;
        private System.Windows.Forms.MaskedTextBox mtbIndicador4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.WebBrowser wbCotacoes;
    }
}

