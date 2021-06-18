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
            this.lblSP500Fut_Analise = new System.Windows.Forms.Label();
            this.lblSP500Fut_status = new System.Windows.Forms.Label();
            this.lblSP500Fut_var = new System.Windows.Forms.Label();
            this.lblSP500Fut_pts = new System.Windows.Forms.Label();
            this.trmCotacoes = new System.Windows.Forms.Timer(this.components);
            this.lblSP500Fut_log = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDX_Analise = new System.Windows.Forms.Label();
            this.lblDX_status = new System.Windows.Forms.Label();
            this.lblDX_var = new System.Windows.Forms.Label();
            this.lblDX_pts = new System.Windows.Forms.Label();
            this.lblDX_Log = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl10Anos_Analise = new System.Windows.Forms.Label();
            this.lbl10Anos_Status = new System.Windows.Forms.Label();
            this.lbl10Anos_Var = new System.Windows.Forms.Label();
            this.lbl10Anos_Pts = new System.Windows.Forms.Label();
            this.lbl10Anos_Log = new System.Windows.Forms.Label();
            this.wbCalendario = new System.Windows.Forms.WebBrowser();
            this.lblSP500Vix_Log = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSP500Vix_Analise = new System.Windows.Forms.Label();
            this.lblSP500Vix_Status = new System.Windows.Forms.Label();
            this.lblSP500Vix_Var = new System.Windows.Forms.Label();
            this.lblSP500Vix_Pts = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Log = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPetroleoWTI_Analise = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Status = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Var = new System.Windows.Forms.Label();
            this.lblPetroleoWTI_Pts = new System.Windows.Forms.Label();
            this.lblOuro_Log = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblOuro_Analise = new System.Windows.Forms.Label();
            this.lblOuro_Status = new System.Windows.Forms.Label();
            this.lblOuro_Var = new System.Windows.Forms.Label();
            this.lblOuro_Pts = new System.Windows.Forms.Label();
            this.lblMinerio_Log = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblMinerio_Analise = new System.Windows.Forms.Label();
            this.lblMinerio_Status = new System.Windows.Forms.Label();
            this.lblMinerio_Var = new System.Windows.Forms.Label();
            this.lblMinerio_Pts = new System.Windows.Forms.Label();
            this.lblHoraTokyo = new System.Windows.Forms.Label();
            this.lblHoraEuropa = new System.Windows.Forms.Label();
            this.lblHoraUSA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbFuturos = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbSP500FUT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bovespa à vista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Abertura SP 500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(348, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Indicador 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(444, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indicador 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(540, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Indicador 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(636, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Indicador 4";
            // 
            // mtbHoraBovespa
            // 
            this.mtbHoraBovespa.Location = new System.Drawing.Point(111, 25);
            this.mtbHoraBovespa.Mask = "90:00";
            this.mtbHoraBovespa.Name = "mtbHoraBovespa";
            this.mtbHoraBovespa.Size = new System.Drawing.Size(90, 20);
            this.mtbHoraBovespa.TabIndex = 14;
            this.mtbHoraBovespa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraBovespa.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraSP500
            // 
            this.mtbHoraSP500.Location = new System.Drawing.Point(207, 25);
            this.mtbHoraSP500.Mask = "90:00";
            this.mtbHoraSP500.Name = "mtbHoraSP500";
            this.mtbHoraSP500.Size = new System.Drawing.Size(90, 20);
            this.mtbHoraSP500.TabIndex = 15;
            this.mtbHoraSP500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbHoraSP500.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador1
            // 
            this.mtbIndicador1.Location = new System.Drawing.Point(351, 25);
            this.mtbIndicador1.Mask = "90:00";
            this.mtbIndicador1.Name = "mtbIndicador1";
            this.mtbIndicador1.Size = new System.Drawing.Size(90, 20);
            this.mtbIndicador1.TabIndex = 16;
            this.mtbIndicador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador1.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador2
            // 
            this.mtbIndicador2.Location = new System.Drawing.Point(447, 25);
            this.mtbIndicador2.Mask = "90:00";
            this.mtbIndicador2.Name = "mtbIndicador2";
            this.mtbIndicador2.Size = new System.Drawing.Size(90, 20);
            this.mtbIndicador2.TabIndex = 17;
            this.mtbIndicador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador2.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicdor3
            // 
            this.mtbIndicdor3.Location = new System.Drawing.Point(543, 25);
            this.mtbIndicdor3.Mask = "90:00";
            this.mtbIndicdor3.Name = "mtbIndicdor3";
            this.mtbIndicdor3.Size = new System.Drawing.Size(90, 20);
            this.mtbIndicdor3.TabIndex = 18;
            this.mtbIndicdor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicdor3.ValidatingType = typeof(System.DateTime);
            // 
            // mtbIndicador4
            // 
            this.mtbIndicador4.Location = new System.Drawing.Point(639, 25);
            this.mtbIndicador4.Mask = "90:00";
            this.mtbIndicador4.Name = "mtbIndicador4";
            this.mtbIndicador4.Size = new System.Drawing.Size(90, 20);
            this.mtbIndicador4.TabIndex = 19;
            this.mtbIndicador4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIndicador4.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(635, 69);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 20);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "00:00:00";
            // 
            // gpbSP500FUT
            // 
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_Analise);
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_status);
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_var);
            this.gpbSP500FUT.Controls.Add(this.lblSP500Fut_pts);
            this.gpbSP500FUT.ForeColor = System.Drawing.Color.White;
            this.gpbSP500FUT.Location = new System.Drawing.Point(752, 0);
            this.gpbSP500FUT.Name = "gpbSP500FUT";
            this.gpbSP500FUT.Size = new System.Drawing.Size(90, 86);
            this.gpbSP500FUT.TabIndex = 28;
            this.gpbSP500FUT.TabStop = false;
            this.gpbSP500FUT.Text = "SP 500 FUT";
            this.gpbSP500FUT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSP500Fut_Analise
            // 
            this.lblSP500Fut_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Fut_Analise.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblSP500Fut_Analise.Name = "lblSP500Fut_Analise";
            this.lblSP500Fut_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblSP500Fut_Analise.TabIndex = 31;
            this.lblSP500Fut_Analise.Text = "Compra Forte";
            this.lblSP500Fut_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Fut_status
            // 
            this.lblSP500Fut_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Fut_status.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_status.Location = new System.Drawing.Point(19, 15);
            this.lblSP500Fut_status.Name = "lblSP500Fut_status";
            this.lblSP500Fut_status.Size = new System.Drawing.Size(60, 13);
            this.lblSP500Fut_status.TabIndex = 30;
            this.lblSP500Fut_status.Text = "Fechado";
            this.lblSP500Fut_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Fut_var
            // 
            this.lblSP500Fut_var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Fut_var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP500Fut_var.ForeColor = System.Drawing.Color.White;
            this.lblSP500Fut_var.Location = new System.Drawing.Point(6, 48);
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
            this.lblSP500Fut_pts.Location = new System.Drawing.Point(6, 28);
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
            this.lblSP500Fut_log.Location = new System.Drawing.Point(749, 87);
            this.lblSP500Fut_log.Name = "lblSP500Fut_log";
            this.lblSP500Fut_log.Size = new System.Drawing.Size(87, 13);
            this.lblSP500Fut_log.TabIndex = 29;
            this.lblSP500Fut_log.Text = "Últ Atu. 00:00:00";
            this.lblSP500Fut_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDX_Analise);
            this.groupBox1.Controls.Add(this.lblDX_status);
            this.groupBox1.Controls.Add(this.lblDX_var);
            this.groupBox1.Controls.Add(this.lblDX_pts);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(870, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 86);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DXY";
            // 
            // lblDX_Analise
            // 
            this.lblDX_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDX_Analise.ForeColor = System.Drawing.Color.White;
            this.lblDX_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblDX_Analise.Name = "lblDX_Analise";
            this.lblDX_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblDX_Analise.TabIndex = 31;
            this.lblDX_Analise.Text = "Compra Forte";
            this.lblDX_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDX_status
            // 
            this.lblDX_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDX_status.ForeColor = System.Drawing.Color.White;
            this.lblDX_status.Location = new System.Drawing.Point(19, 15);
            this.lblDX_status.Name = "lblDX_status";
            this.lblDX_status.Size = new System.Drawing.Size(60, 13);
            this.lblDX_status.TabIndex = 30;
            this.lblDX_status.Text = "Fechado";
            this.lblDX_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDX_var
            // 
            this.lblDX_var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDX_var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDX_var.ForeColor = System.Drawing.Color.White;
            this.lblDX_var.Location = new System.Drawing.Point(6, 48);
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
            this.lblDX_pts.Location = new System.Drawing.Point(6, 28);
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
            this.lblDX_Log.Location = new System.Drawing.Point(868, 87);
            this.lblDX_Log.Name = "lblDX_Log";
            this.lblDX_Log.Size = new System.Drawing.Size(87, 13);
            this.lblDX_Log.TabIndex = 31;
            this.lblDX_Log.Text = "Últ Atu. 00:00:00";
            this.lblDX_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl10Anos_Analise);
            this.groupBox2.Controls.Add(this.lbl10Anos_Status);
            this.groupBox2.Controls.Add(this.lbl10Anos_Var);
            this.groupBox2.Controls.Add(this.lbl10Anos_Pts);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(988, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 86);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EUA 10 anos";
            // 
            // lbl10Anos_Analise
            // 
            this.lbl10Anos_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl10Anos_Analise.ForeColor = System.Drawing.Color.White;
            this.lbl10Anos_Analise.Location = new System.Drawing.Point(10, 69);
            this.lbl10Anos_Analise.Name = "lbl10Anos_Analise";
            this.lbl10Anos_Analise.Size = new System.Drawing.Size(70, 13);
            this.lbl10Anos_Analise.TabIndex = 31;
            this.lbl10Anos_Analise.Text = "Compra Forte";
            this.lbl10Anos_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl10Anos_Status
            // 
            this.lbl10Anos_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl10Anos_Status.ForeColor = System.Drawing.Color.White;
            this.lbl10Anos_Status.Location = new System.Drawing.Point(19, 15);
            this.lbl10Anos_Status.Name = "lbl10Anos_Status";
            this.lbl10Anos_Status.Size = new System.Drawing.Size(60, 13);
            this.lbl10Anos_Status.TabIndex = 30;
            this.lbl10Anos_Status.Text = "Fechado";
            this.lbl10Anos_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl10Anos_Var
            // 
            this.lbl10Anos_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl10Anos_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10Anos_Var.ForeColor = System.Drawing.Color.White;
            this.lbl10Anos_Var.Location = new System.Drawing.Point(6, 48);
            this.lbl10Anos_Var.Name = "lbl10Anos_Var";
            this.lbl10Anos_Var.Size = new System.Drawing.Size(79, 20);
            this.lbl10Anos_Var.TabIndex = 29;
            this.lbl10Anos_Var.Text = "00:00:00";
            this.lbl10Anos_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl10Anos_Pts
            // 
            this.lbl10Anos_Pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl10Anos_Pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10Anos_Pts.ForeColor = System.Drawing.Color.White;
            this.lbl10Anos_Pts.Location = new System.Drawing.Point(6, 28);
            this.lbl10Anos_Pts.Name = "lbl10Anos_Pts";
            this.lbl10Anos_Pts.Size = new System.Drawing.Size(79, 20);
            this.lbl10Anos_Pts.TabIndex = 28;
            this.lbl10Anos_Pts.Text = "00:00:00";
            this.lbl10Anos_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl10Anos_Log
            // 
            this.lbl10Anos_Log.AutoSize = true;
            this.lbl10Anos_Log.ForeColor = System.Drawing.Color.White;
            this.lbl10Anos_Log.Location = new System.Drawing.Point(986, 87);
            this.lbl10Anos_Log.Name = "lbl10Anos_Log";
            this.lbl10Anos_Log.Size = new System.Drawing.Size(87, 13);
            this.lbl10Anos_Log.TabIndex = 33;
            this.lbl10Anos_Log.Text = "Últ Atu. 00:00:00";
            this.lbl10Anos_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wbCalendario
            // 
            this.wbCalendario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wbCalendario.Location = new System.Drawing.Point(15, 109);
            this.wbCalendario.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbCalendario.Name = "wbCalendario";
            this.wbCalendario.ScrollBarsEnabled = false;
            this.wbCalendario.Size = new System.Drawing.Size(714, 470);
            this.wbCalendario.TabIndex = 36;
            // 
            // lblSP500Vix_Log
            // 
            this.lblSP500Vix_Log.AutoSize = true;
            this.lblSP500Vix_Log.ForeColor = System.Drawing.Color.White;
            this.lblSP500Vix_Log.Location = new System.Drawing.Point(1102, 87);
            this.lblSP500Vix_Log.Name = "lblSP500Vix_Log";
            this.lblSP500Vix_Log.Size = new System.Drawing.Size(87, 13);
            this.lblSP500Vix_Log.TabIndex = 38;
            this.lblSP500Vix_Log.Text = "Últ Atu. 00:00:00";
            this.lblSP500Vix_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSP500Vix_Analise);
            this.groupBox3.Controls.Add(this.lblSP500Vix_Status);
            this.groupBox3.Controls.Add(this.lblSP500Vix_Var);
            this.groupBox3.Controls.Add(this.lblSP500Vix_Pts);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1104, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 86);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SP 500 VIX";
            // 
            // lblSP500Vix_Analise
            // 
            this.lblSP500Vix_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Vix_Analise.ForeColor = System.Drawing.Color.White;
            this.lblSP500Vix_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblSP500Vix_Analise.Name = "lblSP500Vix_Analise";
            this.lblSP500Vix_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblSP500Vix_Analise.TabIndex = 31;
            this.lblSP500Vix_Analise.Text = "Compra Forte";
            this.lblSP500Vix_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Vix_Status
            // 
            this.lblSP500Vix_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Vix_Status.ForeColor = System.Drawing.Color.White;
            this.lblSP500Vix_Status.Location = new System.Drawing.Point(19, 15);
            this.lblSP500Vix_Status.Name = "lblSP500Vix_Status";
            this.lblSP500Vix_Status.Size = new System.Drawing.Size(60, 13);
            this.lblSP500Vix_Status.TabIndex = 30;
            this.lblSP500Vix_Status.Text = "Fechado";
            this.lblSP500Vix_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Vix_Var
            // 
            this.lblSP500Vix_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Vix_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP500Vix_Var.ForeColor = System.Drawing.Color.White;
            this.lblSP500Vix_Var.Location = new System.Drawing.Point(6, 48);
            this.lblSP500Vix_Var.Name = "lblSP500Vix_Var";
            this.lblSP500Vix_Var.Size = new System.Drawing.Size(79, 20);
            this.lblSP500Vix_Var.TabIndex = 29;
            this.lblSP500Vix_Var.Text = "00:00:00";
            this.lblSP500Vix_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSP500Vix_Pts
            // 
            this.lblSP500Vix_Pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP500Vix_Pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP500Vix_Pts.ForeColor = System.Drawing.Color.White;
            this.lblSP500Vix_Pts.Location = new System.Drawing.Point(6, 28);
            this.lblSP500Vix_Pts.Name = "lblSP500Vix_Pts";
            this.lblSP500Vix_Pts.Size = new System.Drawing.Size(79, 20);
            this.lblSP500Vix_Pts.TabIndex = 28;
            this.lblSP500Vix_Pts.Text = "00:00:00";
            this.lblSP500Vix_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetroleoWTI_Log
            // 
            this.lblPetroleoWTI_Log.AutoSize = true;
            this.lblPetroleoWTI_Log.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Log.Location = new System.Drawing.Point(1218, 87);
            this.lblPetroleoWTI_Log.Name = "lblPetroleoWTI_Log";
            this.lblPetroleoWTI_Log.Size = new System.Drawing.Size(87, 13);
            this.lblPetroleoWTI_Log.TabIndex = 40;
            this.lblPetroleoWTI_Log.Text = "Últ Atu. 00:00:00";
            this.lblPetroleoWTI_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Analise);
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Status);
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Var);
            this.groupBox4.Controls.Add(this.lblPetroleoWTI_Pts);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1220, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 86);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Petróleo WTI";
            // 
            // lblPetroleoWTI_Analise
            // 
            this.lblPetroleoWTI_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetroleoWTI_Analise.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblPetroleoWTI_Analise.Name = "lblPetroleoWTI_Analise";
            this.lblPetroleoWTI_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblPetroleoWTI_Analise.TabIndex = 31;
            this.lblPetroleoWTI_Analise.Text = "Compra Forte";
            this.lblPetroleoWTI_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetroleoWTI_Status
            // 
            this.lblPetroleoWTI_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetroleoWTI_Status.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Status.Location = new System.Drawing.Point(19, 15);
            this.lblPetroleoWTI_Status.Name = "lblPetroleoWTI_Status";
            this.lblPetroleoWTI_Status.Size = new System.Drawing.Size(60, 13);
            this.lblPetroleoWTI_Status.TabIndex = 30;
            this.lblPetroleoWTI_Status.Text = "Fechado";
            this.lblPetroleoWTI_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetroleoWTI_Var
            // 
            this.lblPetroleoWTI_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetroleoWTI_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetroleoWTI_Var.ForeColor = System.Drawing.Color.White;
            this.lblPetroleoWTI_Var.Location = new System.Drawing.Point(6, 48);
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
            this.lblPetroleoWTI_Pts.Location = new System.Drawing.Point(6, 28);
            this.lblPetroleoWTI_Pts.Name = "lblPetroleoWTI_Pts";
            this.lblPetroleoWTI_Pts.Size = new System.Drawing.Size(79, 20);
            this.lblPetroleoWTI_Pts.TabIndex = 28;
            this.lblPetroleoWTI_Pts.Text = "00:00:00";
            this.lblPetroleoWTI_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOuro_Log
            // 
            this.lblOuro_Log.AutoSize = true;
            this.lblOuro_Log.ForeColor = System.Drawing.Color.White;
            this.lblOuro_Log.Location = new System.Drawing.Point(1335, 87);
            this.lblOuro_Log.Name = "lblOuro_Log";
            this.lblOuro_Log.Size = new System.Drawing.Size(87, 13);
            this.lblOuro_Log.TabIndex = 42;
            this.lblOuro_Log.Text = "Últ Atu. 00:00:00";
            this.lblOuro_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblOuro_Analise);
            this.groupBox5.Controls.Add(this.lblOuro_Status);
            this.groupBox5.Controls.Add(this.lblOuro_Var);
            this.groupBox5.Controls.Add(this.lblOuro_Pts);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(1337, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(90, 86);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ouro";
            // 
            // lblOuro_Analise
            // 
            this.lblOuro_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOuro_Analise.ForeColor = System.Drawing.Color.White;
            this.lblOuro_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblOuro_Analise.Name = "lblOuro_Analise";
            this.lblOuro_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblOuro_Analise.TabIndex = 31;
            this.lblOuro_Analise.Text = "Compra Forte";
            this.lblOuro_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOuro_Status
            // 
            this.lblOuro_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOuro_Status.ForeColor = System.Drawing.Color.White;
            this.lblOuro_Status.Location = new System.Drawing.Point(19, 15);
            this.lblOuro_Status.Name = "lblOuro_Status";
            this.lblOuro_Status.Size = new System.Drawing.Size(60, 13);
            this.lblOuro_Status.TabIndex = 30;
            this.lblOuro_Status.Text = "Fechado";
            this.lblOuro_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOuro_Var
            // 
            this.lblOuro_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOuro_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuro_Var.ForeColor = System.Drawing.Color.White;
            this.lblOuro_Var.Location = new System.Drawing.Point(6, 48);
            this.lblOuro_Var.Name = "lblOuro_Var";
            this.lblOuro_Var.Size = new System.Drawing.Size(79, 20);
            this.lblOuro_Var.TabIndex = 29;
            this.lblOuro_Var.Text = "00:00:00";
            this.lblOuro_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOuro_Pts
            // 
            this.lblOuro_Pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOuro_Pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuro_Pts.ForeColor = System.Drawing.Color.White;
            this.lblOuro_Pts.Location = new System.Drawing.Point(6, 28);
            this.lblOuro_Pts.Name = "lblOuro_Pts";
            this.lblOuro_Pts.Size = new System.Drawing.Size(79, 20);
            this.lblOuro_Pts.TabIndex = 28;
            this.lblOuro_Pts.Text = "00:00:00";
            this.lblOuro_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinerio_Log
            // 
            this.lblMinerio_Log.AutoSize = true;
            this.lblMinerio_Log.ForeColor = System.Drawing.Color.White;
            this.lblMinerio_Log.Location = new System.Drawing.Point(1451, 87);
            this.lblMinerio_Log.Name = "lblMinerio_Log";
            this.lblMinerio_Log.Size = new System.Drawing.Size(87, 13);
            this.lblMinerio_Log.TabIndex = 44;
            this.lblMinerio_Log.Text = "Últ Atu. 00:00:00";
            this.lblMinerio_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblMinerio_Analise);
            this.groupBox6.Controls.Add(this.lblMinerio_Status);
            this.groupBox6.Controls.Add(this.lblMinerio_Var);
            this.groupBox6.Controls.Add(this.lblMinerio_Pts);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(1453, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(90, 86);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Minério Ferro";
            // 
            // lblMinerio_Analise
            // 
            this.lblMinerio_Analise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinerio_Analise.ForeColor = System.Drawing.Color.White;
            this.lblMinerio_Analise.Location = new System.Drawing.Point(10, 69);
            this.lblMinerio_Analise.Name = "lblMinerio_Analise";
            this.lblMinerio_Analise.Size = new System.Drawing.Size(70, 13);
            this.lblMinerio_Analise.TabIndex = 31;
            this.lblMinerio_Analise.Text = "Compra Forte";
            this.lblMinerio_Analise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinerio_Status
            // 
            this.lblMinerio_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinerio_Status.ForeColor = System.Drawing.Color.White;
            this.lblMinerio_Status.Location = new System.Drawing.Point(19, 15);
            this.lblMinerio_Status.Name = "lblMinerio_Status";
            this.lblMinerio_Status.Size = new System.Drawing.Size(60, 13);
            this.lblMinerio_Status.TabIndex = 30;
            this.lblMinerio_Status.Text = "Fechado";
            this.lblMinerio_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinerio_Var
            // 
            this.lblMinerio_Var.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinerio_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinerio_Var.ForeColor = System.Drawing.Color.White;
            this.lblMinerio_Var.Location = new System.Drawing.Point(6, 48);
            this.lblMinerio_Var.Name = "lblMinerio_Var";
            this.lblMinerio_Var.Size = new System.Drawing.Size(79, 20);
            this.lblMinerio_Var.TabIndex = 29;
            this.lblMinerio_Var.Text = "00:00:00";
            this.lblMinerio_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinerio_Pts
            // 
            this.lblMinerio_Pts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinerio_Pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinerio_Pts.ForeColor = System.Drawing.Color.White;
            this.lblMinerio_Pts.Location = new System.Drawing.Point(6, 28);
            this.lblMinerio_Pts.Name = "lblMinerio_Pts";
            this.lblMinerio_Pts.Size = new System.Drawing.Size(79, 20);
            this.lblMinerio_Pts.TabIndex = 28;
            this.lblMinerio_Pts.Text = "00:00:00";
            this.lblMinerio_Pts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraTokyo
            // 
            this.lblHoraTokyo.AutoSize = true;
            this.lblHoraTokyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraTokyo.ForeColor = System.Drawing.Color.White;
            this.lblHoraTokyo.Location = new System.Drawing.Point(203, 69);
            this.lblHoraTokyo.Name = "lblHoraTokyo";
            this.lblHoraTokyo.Size = new System.Drawing.Size(79, 20);
            this.lblHoraTokyo.TabIndex = 45;
            this.lblHoraTokyo.Text = "00:00:00";
            // 
            // lblHoraEuropa
            // 
            this.lblHoraEuropa.AutoSize = true;
            this.lblHoraEuropa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEuropa.ForeColor = System.Drawing.Color.White;
            this.lblHoraEuropa.Location = new System.Drawing.Point(107, 69);
            this.lblHoraEuropa.Name = "lblHoraEuropa";
            this.lblHoraEuropa.Size = new System.Drawing.Size(79, 20);
            this.lblHoraEuropa.TabIndex = 46;
            this.lblHoraEuropa.Text = "00:00:00";
            // 
            // lblHoraUSA
            // 
            this.lblHoraUSA.AutoSize = true;
            this.lblHoraUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraUSA.ForeColor = System.Drawing.Color.White;
            this.lblHoraUSA.Location = new System.Drawing.Point(11, 69);
            this.lblHoraUSA.Name = "lblHoraUSA";
            this.lblHoraUSA.Size = new System.Drawing.Size(79, 20);
            this.lblHoraUSA.TabIndex = 47;
            this.lblHoraUSA.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nova York";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(108, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Londres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(204, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tokyo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(636, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Brasil";
            // 
            // mtbFuturos
            // 
            this.mtbFuturos.Location = new System.Drawing.Point(15, 25);
            this.mtbFuturos.Mask = "90:00";
            this.mtbFuturos.Name = "mtbFuturos";
            this.mtbFuturos.Size = new System.Drawing.Size(90, 20);
            this.mtbFuturos.TabIndex = 52;
            this.mtbFuturos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbFuturos.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Bovespa Futuros";
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1608, 621);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtbFuturos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHoraUSA);
            this.Controls.Add(this.lblHoraEuropa);
            this.Controls.Add(this.lblHoraTokyo);
            this.Controls.Add(this.lblMinerio_Log);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lblOuro_Log);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblPetroleoWTI_Log);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblSP500Vix_Log);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.wbCalendario);
            this.Controls.Add(this.lbl10Anos_Log);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSP500Fut_status;
        private System.Windows.Forms.Label lblSP500Fut_Analise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDX_Analise;
        private System.Windows.Forms.Label lblDX_status;
        private System.Windows.Forms.Label lblDX_var;
        private System.Windows.Forms.Label lblDX_pts;
        private System.Windows.Forms.Label lblDX_Log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl10Anos_Analise;
        private System.Windows.Forms.Label lbl10Anos_Status;
        private System.Windows.Forms.Label lbl10Anos_Var;
        private System.Windows.Forms.Label lbl10Anos_Pts;
        private System.Windows.Forms.Label lbl10Anos_Log;
        private System.Windows.Forms.WebBrowser wbCalendario;
        private System.Windows.Forms.Label lblSP500Vix_Log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSP500Vix_Analise;
        private System.Windows.Forms.Label lblSP500Vix_Status;
        private System.Windows.Forms.Label lblSP500Vix_Var;
        private System.Windows.Forms.Label lblSP500Vix_Pts;
        private System.Windows.Forms.Label lblPetroleoWTI_Log;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPetroleoWTI_Analise;
        private System.Windows.Forms.Label lblPetroleoWTI_Status;
        private System.Windows.Forms.Label lblPetroleoWTI_Var;
        private System.Windows.Forms.Label lblPetroleoWTI_Pts;
        private System.Windows.Forms.Label lblOuro_Log;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblOuro_Analise;
        private System.Windows.Forms.Label lblOuro_Status;
        private System.Windows.Forms.Label lblOuro_Var;
        private System.Windows.Forms.Label lblOuro_Pts;
        private System.Windows.Forms.Label lblMinerio_Log;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblMinerio_Analise;
        private System.Windows.Forms.Label lblMinerio_Status;
        private System.Windows.Forms.Label lblMinerio_Var;
        private System.Windows.Forms.Label lblMinerio_Pts;
        private System.Windows.Forms.Label lblHoraTokyo;
        private System.Windows.Forms.Label lblHoraEuropa;
        private System.Windows.Forms.Label lblHoraUSA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbFuturos;
        private System.Windows.Forms.Label label11;
    }
}

