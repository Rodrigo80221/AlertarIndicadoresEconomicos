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
            this.gpbSP500FUT = new System.Windows.Forms.GroupBox();
            this.lblSP500Fut_var = new System.Windows.Forms.Label();
            this.lblSP500Fut_pts = new System.Windows.Forms.Label();
            this.trmCotacoes = new System.Windows.Forms.Timer(this.components);
            this.lblSP500Fut_log = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDX_var = new System.Windows.Forms.Label();
            this.lblDX_pts = new System.Windows.Forms.Label();
            this.lblDX_Log = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Log = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPetroleoWTI_Var = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Pts = new System.Windows.Forms.Label();
            this.lblHoraTokyo = new System.Windows.Forms.Label();
            this.lblHoraEuropa = new System.Windows.Forms.Label();
            this.lblHoraUSA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbFuturos = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdStatusInvest = new System.Windows.Forms.Button();
            this.txtEnderecoStatusInvest = new System.Windows.Forms.TextBox();
            this.txtdados = new System.Windows.Forms.TextBox();
            this.txtLinkSP500 = new System.Windows.Forms.TextBox();
            this.txtFullPathCotacaoSP500 = new System.Windows.Forms.TextBox();
            this.txtFullPathVariacaoSP500 = new System.Windows.Forms.TextBox();
            this.lblLinkSP500 = new System.Windows.Forms.Label();
            this.lblFullPathCotacaoSP500 = new System.Windows.Forms.Label();
            this.lblFullPathVariacaoSP500 = new System.Windows.Forms.Label();
            this.lblFullPathVariacaoDX = new System.Windows.Forms.Label();
            this.lblFullPathCotacaoDX = new System.Windows.Forms.Label();
            this.lblLinkDX = new System.Windows.Forms.Label();
            this.txtFullPathVariacaoDX = new System.Windows.Forms.TextBox();
            this.txtFullPathCotacaoDX = new System.Windows.Forms.TextBox();
            this.txtLinkDX = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLinkWTI = new System.Windows.Forms.Label();
            this.txtFullPathVariacaoWTI = new System.Windows.Forms.TextBox();
            this.txtFullPathCotacaoWTI = new System.Windows.Forms.TextBox();
            this.txtLinkWTI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gpbSP500FUT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(96, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bovespa à vista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Abertura SP 500";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Indicador 1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indicador 2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Indicador 3";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(475, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Indicador 4";
            // 
            // mtbHoraBovespa
            // 
            this.mtbHoraBovespa.Location = new System.Drawing.Point(97, 137);
            this.mtbHoraBovespa.Mask = "90:00";
            this.mtbHoraBovespa.Name = "mtbHoraBovespa";
            this.mtbHoraBovespa.Size = new System.Drawing.Size(81, 20);
            this.mtbHoraBovespa.TabIndex = 14;
            this.mtbHoraBovespa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraBovespa.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraSP500
            // 
            this.mtbHoraSP500.Location = new System.Drawing.Point(184, 137);
            this.mtbHoraSP500.Mask = "90:00";
            this.mtbHoraSP500.Name = "mtbHoraSP500";
            this.mtbHoraSP500.Size = new System.Drawing.Size(81, 20);
            this.mtbHoraSP500.TabIndex = 15;
            this.mtbHoraSP500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraSP500.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador1
            // 
            this.mtbIndicador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbIndicador1.Location = new System.Drawing.Point(276, 137);
            this.mtbIndicador1.Mask = "90:00";
            this.mtbIndicador1.Name = "mtbIndicador1";
            this.mtbIndicador1.Size = new System.Drawing.Size(61, 20);
            this.mtbIndicador1.TabIndex = 16;
            this.mtbIndicador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador2
            // 
            this.mtbIndicador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbIndicador2.Location = new System.Drawing.Point(343, 137);
            this.mtbIndicador2.Mask = "90:00";
            this.mtbIndicador2.Name = "mtbIndicador2";
            this.mtbIndicador2.Size = new System.Drawing.Size(60, 20);
            this.mtbIndicador2.TabIndex = 17;
            this.mtbIndicador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador2.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicdor3
            // 
            this.mtbIndicdor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbIndicdor3.Location = new System.Drawing.Point(409, 137);
            this.mtbIndicdor3.Mask = "90:00";
            this.mtbIndicdor3.Name = "mtbIndicdor3";
            this.mtbIndicdor3.Size = new System.Drawing.Size(60, 20);
            this.mtbIndicdor3.TabIndex = 18;
            this.mtbIndicdor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicdor3.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador4
            // 
            this.mtbIndicador4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbIndicador4.Location = new System.Drawing.Point(475, 137);
            this.mtbIndicador4.Mask = "90:00";
            this.mtbIndicador4.Name = "mtbIndicador4";
            this.mtbIndicador4.Size = new System.Drawing.Size(60, 20);
            this.mtbIndicador4.TabIndex = 19;
            this.mtbIndicador4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador4.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(403, 87);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 17);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "00:00:00";
            // 
            // gpbSP500FUT
            // 
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_var);
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_pts);
            this.gpbSP500FUT.ForeColor = System.Drawing.Color.White;
            this.gpbSP500FUT.Location = new System.Drawing.Point(106, 33);
            this.gpbSP500FUT.Name = "gpbSP500FUT";
            this.gpbSP500FUT.Size = new System.Drawing.Size(90, 63);
            this.gpbSP500FUT.TabIndex = 28;
            this.gpbSP500FUT.TabStop = false;
            this.gpbSP500FUT.Text = "SP 500 FUT";
            this.gpbSP500FUT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSP500Fut_var
            // 
            this.lblSP500Fut_var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Fut_var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP500Fut_var.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_var.Location = new System.Drawing.Point(6, 37);
            this.lblSP500Fut_var.Name = "lblSP500Fut_var";
            this.lblSP500Fut_var.Size = new System.Drawing.Size(79, 20);
            this.lblSP500Fut_var.TabIndex = 29;
            this.lblSP500Fut_var.Text = "00:00:00";
            this.lblSP500Fut_var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Fut_pts
            // 
            this.lblSP500Fut_pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Fut_pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP500Fut_pts.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_pts.Location = new System.Drawing.Point(6, 17);
            this.lblSP500Fut_pts.Name = "lblSP500Fut_pts";
            this.lblSP500Fut_pts.Size = new System.Drawing.Size(79, 20);
            this.lblSP500Fut_pts.TabIndex = 28;
            this.lblSP500Fut_pts.Text = "00:00:00";
            this.lblSP500Fut_pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trmCotacoes
            // 
            this.trmCotacoes.Enabled = true;
            this.trmCotacoes.Interval = 60000;
            this.trmCotacoes.Tick += new System.EventHandler(this.trmCotacoes_Tick);
            // 
            // lblSP500Fut_log
            // 
            this.lblSP500Fut_log.AutoSize = true;
            this.lblSP500Fut_log.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_log.Location = new System.Drawing.Point(103, 99);
            this.lblSP500Fut_log.Name = "lblSP500Fut_log";
            this.lblSP500Fut_log.Size = new System.Drawing.Size(87, 13);
            this.lblSP500Fut_log.TabIndex = 29;
            this.lblSP500Fut_log.Text = "Últ Atu. 00:00:00";
            this.lblSP500Fut_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDX_var);
            this.groupBox1.Controls.Add(this.lblDX_pts);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 63);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DXY";
            // 
            // lblDX_var
            // 
            this.lblDX_var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDX_var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDX_var.ForeColor = System.Drawing.Color.White;
            this.lblDX_var.Location = new System.Drawing.Point(5, 37);
            this.lblDX_var.Name = "lblDX_var";
            this.lblDX_var.Size = new System.Drawing.Size(79, 20);
            this.lblDX_var.TabIndex = 29;
            this.lblDX_var.Text = "00:00:00";
            this.lblDX_var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDX_pts
            // 
            this.lblDX_pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDX_pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDX_pts.ForeColor = System.Drawing.Color.White;
            this.lblDX_pts.Location = new System.Drawing.Point(5, 17);
            this.lblDX_pts.Name = "lblDX_pts";
            this.lblDX_pts.Size = new System.Drawing.Size(79, 20);
            this.lblDX_pts.TabIndex = 28;
            this.lblDX_pts.Text = "00:00:00";
            this.lblDX_pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDX_Log
            // 
            this.lblDX_Log.AutoSize = true;
            this.lblDX_Log.ForeColor = System.Drawing.Color.White;
            this.lblDX_Log.Location = new System.Drawing.Point(8, 99);
            this.lblDX_Log.Name = "lblDX_Log";
            this.lblDX_Log.Size = new System.Drawing.Size(87, 13);
            this.lblDX_Log.TabIndex = 31;
            this.lblDX_Log.Text = "Últ Atu. 00:00:00";
            this.lblDX_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetroleoWTI_Log
            // 
            this.lblPetroleoWTI_Log.AutoSize = true;
            this.lblPetroleoWTI_Log.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Log.Location = new System.Drawing.Point(201, 99);
            this.lblPetroleoWTI_Log.Name = "lblPetroleoWTI_Log";
            this.lblPetroleoWTI_Log.Size = new System.Drawing.Size(87, 13);
            this.lblPetroleoWTI_Log.TabIndex = 40;
            this.lblPetroleoWTI_Log.Text = "Últ Atu. 00:00:00";
            this.lblPetroleoWTI_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Var);
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Pts);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(203, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 63);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Petróleo WTI";
            // 
            // lblPetroleoWTI_Var
            // 
            this.lblPetroleoWTI_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetroleoWTI_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetroleoWTI_Var.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Var.Location = new System.Drawing.Point(5, 37);
            this.lblPetroleoWTI_Var.Name = "lblPetroleoWTI_Var";
            this.lblPetroleoWTI_Var.Size = new System.Drawing.Size(79, 20);
            this.lblPetroleoWTI_Var.TabIndex = 29;
            this.lblPetroleoWTI_Var.Text = "00:00:00";
            this.lblPetroleoWTI_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetroleoWTI_Pts
            // 
            this.lblPetroleoWTI_Pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetroleoWTI_Pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetroleoWTI_Pts.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Pts.Location = new System.Drawing.Point(5, 17);
            this.lblPetroleoWTI_Pts.Name = "lblPetroleoWTI_Pts";
            this.lblPetroleoWTI_Pts.Size = new System.Drawing.Size(79, 20);
            this.lblPetroleoWTI_Pts.TabIndex = 28;
            this.lblPetroleoWTI_Pts.Text = "00:00:00";
            this.lblPetroleoWTI_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraTokyo
            // 
            this.lblHoraTokyo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraTokyo.AutoSize = true;
            this.lblHoraTokyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraTokyo.ForeColor = System.Drawing.Color.White;
            this.lblHoraTokyo.Location = new System.Drawing.Point(315, 87);
            this.lblHoraTokyo.Name = "lblHoraTokyo";
            this.lblHoraTokyo.Size = new System.Drawing.Size(64, 17);
            this.lblHoraTokyo.TabIndex = 45;
            this.lblHoraTokyo.Text = "00:00:00";
            this.lblHoraTokyo.Click += new System.EventHandler(this.lblHoraTokyo_Click);
            // 
            // lblHoraEuropa
            // 
            this.lblHoraEuropa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraEuropa.AutoSize = true;
            this.lblHoraEuropa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEuropa.ForeColor = System.Drawing.Color.White;
            this.lblHoraEuropa.Location = new System.Drawing.Point(403, 39);
            this.lblHoraEuropa.Name = "lblHoraEuropa";
            this.lblHoraEuropa.Size = new System.Drawing.Size(64, 17);
            this.lblHoraEuropa.TabIndex = 46;
            this.lblHoraEuropa.Text = "00:00:00";
            // 
            // lblHoraUSA
            // 
            this.lblHoraUSA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraUSA.AutoSize = true;
            this.lblHoraUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraUSA.ForeColor = System.Drawing.Color.White;
            this.lblHoraUSA.Location = new System.Drawing.Point(315, 39);
            this.lblHoraUSA.Name = "lblHoraUSA";
            this.lblHoraUSA.Size = new System.Drawing.Size(64, 17);
            this.lblHoraUSA.TabIndex = 47;
            this.lblHoraUSA.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(305, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nova York";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(402, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Londres";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(319, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tokyo";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(409, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Brasil";
            // 
            // mtbFuturos
            // 
            this.mtbFuturos.Location = new System.Drawing.Point(10, 137);
            this.mtbFuturos.Mask = "90:00";
            this.mtbFuturos.Name = "mtbFuturos";
            this.mtbFuturos.Size = new System.Drawing.Size(81, 20);
            this.mtbFuturos.TabIndex = 52;
            this.mtbFuturos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbFuturos.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Bovespa Futuros";
            // 
            // cmdStatusInvest
            // 
            this.cmdStatusInvest.Location = new System.Drawing.Point(16, 813);
            this.cmdStatusInvest.Name = "cmdStatusInvest";
            this.cmdStatusInvest.Size = new System.Drawing.Size(234, 39);
            this.cmdStatusInvest.TabIndex = 80;
            this.cmdStatusInvest.Text = "Ler Status Invest";
            this.cmdStatusInvest.UseVisualStyleBackColor = true;
            // 
            // txtEnderecoStatusInvest
            // 
            this.txtEnderecoStatusInvest.Location = new System.Drawing.Point(16, 787);
            this.txtEnderecoStatusInvest.Name = "txtEnderecoStatusInvest";
            this.txtEnderecoStatusInvest.Size = new System.Drawing.Size(386, 20);
            this.txtEnderecoStatusInvest.TabIndex = 81;
            this.txtEnderecoStatusInvest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnderecoStatusInvest_MouseClick);
            this.txtEnderecoStatusInvest.TextChanged += new System.EventHandler(this.txtEnderecoStatusInvest_TextChanged);
            // 
            // txtdados
            // 
            this.txtdados.Location = new System.Drawing.Point(16, 858);
            this.txtdados.Multiline = true;
            this.txtdados.Name = "txtdados";
            this.txtdados.Size = new System.Drawing.Size(386, 285);
            this.txtdados.TabIndex = 82;
            // 
            // txtLinkSP500
            // 
            this.txtLinkSP500.Location = new System.Drawing.Point(13, 216);
            this.txtLinkSP500.Name = "txtLinkSP500";
            this.txtLinkSP500.Size = new System.Drawing.Size(600, 20);
            this.txtLinkSP500.TabIndex = 83;
            // 
            // txtFullPathCotacaoSP500
            // 
            this.txtFullPathCotacaoSP500.Location = new System.Drawing.Point(12, 255);
            this.txtFullPathCotacaoSP500.Name = "txtFullPathCotacaoSP500";
            this.txtFullPathCotacaoSP500.Size = new System.Drawing.Size(601, 20);
            this.txtFullPathCotacaoSP500.TabIndex = 84;
            // 
            // txtFullPathVariacaoSP500
            // 
            this.txtFullPathVariacaoSP500.Location = new System.Drawing.Point(11, 294);
            this.txtFullPathVariacaoSP500.Name = "txtFullPathVariacaoSP500";
            this.txtFullPathVariacaoSP500.Size = new System.Drawing.Size(602, 20);
            this.txtFullPathVariacaoSP500.TabIndex = 85;
            // 
            // lblLinkSP500
            // 
            this.lblLinkSP500.AutoSize = true;
            this.lblLinkSP500.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLinkSP500.Location = new System.Drawing.Point(12, 200);
            this.lblLinkSP500.Name = "lblLinkSP500";
            this.lblLinkSP500.Size = new System.Drawing.Size(62, 13);
            this.lblLinkSP500.TabIndex = 86;
            this.lblLinkSP500.Text = "Link SP500";
            // 
            // lblFullPathCotacaoSP500
            // 
            this.lblFullPathCotacaoSP500.AutoSize = true;
            this.lblFullPathCotacaoSP500.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullPathCotacaoSP500.Location = new System.Drawing.Point(10, 239);
            this.lblFullPathCotacaoSP500.Name = "lblFullPathCotacaoSP500";
            this.lblFullPathCotacaoSP500.Size = new System.Drawing.Size(91, 13);
            this.lblFullPathCotacaoSP500.TabIndex = 87;
            this.lblFullPathCotacaoSP500.Text = "Full Path Cotação";
            // 
            // lblFullPathVariacaoSP500
            // 
            this.lblFullPathVariacaoSP500.AutoSize = true;
            this.lblFullPathVariacaoSP500.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullPathVariacaoSP500.Location = new System.Drawing.Point(10, 278);
            this.lblFullPathVariacaoSP500.Name = "lblFullPathVariacaoSP500";
            this.lblFullPathVariacaoSP500.Size = new System.Drawing.Size(93, 13);
            this.lblFullPathVariacaoSP500.TabIndex = 88;
            this.lblFullPathVariacaoSP500.Text = "Full Path Variação";
            // 
            // lblFullPathVariacaoDX
            // 
            this.lblFullPathVariacaoDX.AutoSize = true;
            this.lblFullPathVariacaoDX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullPathVariacaoDX.Location = new System.Drawing.Point(11, 422);
            this.lblFullPathVariacaoDX.Name = "lblFullPathVariacaoDX";
            this.lblFullPathVariacaoDX.Size = new System.Drawing.Size(93, 13);
            this.lblFullPathVariacaoDX.TabIndex = 94;
            this.lblFullPathVariacaoDX.Text = "Full Path Variação";
            // 
            // lblFullPathCotacaoDX
            // 
            this.lblFullPathCotacaoDX.AutoSize = true;
            this.lblFullPathCotacaoDX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullPathCotacaoDX.Location = new System.Drawing.Point(11, 383);
            this.lblFullPathCotacaoDX.Name = "lblFullPathCotacaoDX";
            this.lblFullPathCotacaoDX.Size = new System.Drawing.Size(91, 13);
            this.lblFullPathCotacaoDX.TabIndex = 93;
            this.lblFullPathCotacaoDX.Text = "Full Path Cotação";
            // 
            // lblLinkDX
            // 
            this.lblLinkDX.AutoSize = true;
            this.lblLinkDX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLinkDX.Location = new System.Drawing.Point(13, 344);
            this.lblLinkDX.Name = "lblLinkDX";
            this.lblLinkDX.Size = new System.Drawing.Size(45, 13);
            this.lblLinkDX.TabIndex = 92;
            this.lblLinkDX.Text = "Link DX";
            // 
            // txtFullPathVariacaoDX
            // 
            this.txtFullPathVariacaoDX.Location = new System.Drawing.Point(12, 438);
            this.txtFullPathVariacaoDX.Name = "txtFullPathVariacaoDX";
            this.txtFullPathVariacaoDX.Size = new System.Drawing.Size(602, 20);
            this.txtFullPathVariacaoDX.TabIndex = 91;
            // 
            // txtFullPathCotacaoDX
            // 
            this.txtFullPathCotacaoDX.Location = new System.Drawing.Point(13, 399);
            this.txtFullPathCotacaoDX.Name = "txtFullPathCotacaoDX";
            this.txtFullPathCotacaoDX.Size = new System.Drawing.Size(601, 20);
            this.txtFullPathCotacaoDX.TabIndex = 90;
            // 
            // txtLinkDX
            // 
            this.txtLinkDX.Location = new System.Drawing.Point(14, 360);
            this.txtLinkDX.Name = "txtLinkDX";
            this.txtLinkDX.Size = new System.Drawing.Size(600, 20);
            this.txtLinkDX.TabIndex = 89;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(11, 576);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 100;
            this.label15.Text = "Full Path Variação";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(11, 537);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 99;
            this.label16.Text = "Full Path Cotação";
            // 
            // lblLinkWTI
            // 
            this.lblLinkWTI.AutoSize = true;
            this.lblLinkWTI.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLinkWTI.Location = new System.Drawing.Point(13, 498);
            this.lblLinkWTI.Name = "lblLinkWTI";
            this.lblLinkWTI.Size = new System.Drawing.Size(51, 13);
            this.lblLinkWTI.TabIndex = 98;
            this.lblLinkWTI.Text = "Link WTI";
            // 
            // txtFullPathVariacaoWTI
            // 
            this.txtFullPathVariacaoWTI.Location = new System.Drawing.Point(12, 592);
            this.txtFullPathVariacaoWTI.Name = "txtFullPathVariacaoWTI";
            this.txtFullPathVariacaoWTI.Size = new System.Drawing.Size(602, 20);
            this.txtFullPathVariacaoWTI.TabIndex = 97;
            // 
            // txtFullPathCotacaoWTI
            // 
            this.txtFullPathCotacaoWTI.Location = new System.Drawing.Point(13, 553);
            this.txtFullPathCotacaoWTI.Name = "txtFullPathCotacaoWTI";
            this.txtFullPathCotacaoWTI.Size = new System.Drawing.Size(601, 20);
            this.txtFullPathCotacaoWTI.TabIndex = 96;
            // 
            // txtLinkWTI
            // 
            this.txtLinkWTI.Location = new System.Drawing.Point(14, 514);
            this.txtLinkWTI.Name = "txtLinkWTI";
            this.txtLinkWTI.Size = new System.Drawing.Size(600, 20);
            this.txtLinkWTI.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 101;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(493, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Config";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(478, 91);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 23);
            this.btnStop.TabIndex = 103;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LimeGreen;
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 104;
            this.label13.Text = "Real Trade";
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(542, 163);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblLinkWTI);
            this.Controls.Add(this.txtFullPathVariacaoWTI);
            this.Controls.Add(this.txtFullPathCotacaoWTI);
            this.Controls.Add(this.txtLinkWTI);
            this.Controls.Add(this.lblFullPathVariacaoDX);
            this.Controls.Add(this.lblFullPathCotacaoDX);
            this.Controls.Add(this.lblLinkDX);
            this.Controls.Add(this.txtFullPathVariacaoDX);
            this.Controls.Add(this.txtFullPathCotacaoDX);
            this.Controls.Add(this.txtLinkDX);
            this.Controls.Add(this.lblFullPathVariacaoSP500);
            this.Controls.Add(this.lblFullPathCotacaoSP500);
            this.Controls.Add(this.lblLinkSP500);
            this.Controls.Add(this.txtFullPathVariacaoSP500);
            this.Controls.Add(this.txtFullPathCotacaoSP500);
            this.Controls.Add(this.txtLinkSP500);
            this.Controls.Add(this.txtdados);
            this.Controls.Add(this.txtEnderecoStatusInvest);
            this.Controls.Add(this.cmdStatusInvest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtbFuturos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHoraUSA);
            this.Controls.Add(this.lblHoraEuropa);
            this.Controls.Add(this.lblHoraTokyo);
            this.Controls.Add(this.lblPetroleoWTI_Log);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblDX_Log);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSP500Fut_log);
            this.Controls.Add(this.gpbSP500FUT);
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
            this.LocationChanged += new System.EventHandler(this.FrmAlertas_LocationChanged);
            this.gpbSP500FUT.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gpbSP500FUT;
        private System.Windows.Forms.Label lblSP500Fut_var;
        private System.Windows.Forms.Label lblSP500Fut_pts;
        private System.Windows.Forms.Timer trmCotacoes;
        private System.Windows.Forms.Label lblSP500Fut_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDX_var;
        private System.Windows.Forms.Label lblDX_pts;
        private System.Windows.Forms.Label lblDX_Log;
        private System.Windows.Forms.Label lblPetroleoWTI_Log;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPetroleoWTI_Var;
        private System.Windows.Forms.Label lblPetroleoWTI_Pts;
        private System.Windows.Forms.Label lblHoraTokyo;
        private System.Windows.Forms.Label lblHoraEuropa;
        private System.Windows.Forms.Label lblHoraUSA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbFuturos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdStatusInvest;
        private System.Windows.Forms.TextBox txtEnderecoStatusInvest;
        private System.Windows.Forms.TextBox txtdados;
        private System.Windows.Forms.TextBox txtLinkSP500;
        private System.Windows.Forms.TextBox txtFullPathCotacaoSP500;
        private System.Windows.Forms.TextBox txtFullPathVariacaoSP500;
        private System.Windows.Forms.Label lblLinkSP500;
        private System.Windows.Forms.Label lblFullPathCotacaoSP500;
        private System.Windows.Forms.Label lblFullPathVariacaoSP500;
        private System.Windows.Forms.Label lblFullPathVariacaoDX;
        private System.Windows.Forms.Label lblFullPathCotacaoDX;
        private System.Windows.Forms.Label lblLinkDX;
        private System.Windows.Forms.TextBox txtFullPathVariacaoDX;
        private System.Windows.Forms.TextBox txtFullPathCotacaoDX;
        private System.Windows.Forms.TextBox txtLinkDX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLinkWTI;
        private System.Windows.Forms.TextBox txtFullPathVariacaoWTI;
        private System.Windows.Forms.TextBox txtFullPathCotacaoWTI;
        private System.Windows.Forms.TextBox txtLinkWTI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label13;
    }
}

