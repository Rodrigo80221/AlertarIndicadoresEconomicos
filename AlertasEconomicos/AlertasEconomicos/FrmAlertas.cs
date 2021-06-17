using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using HtmlAgilityPack;
using System.Threading;

namespace AlertasEconomicos
{
    public partial class FrmAlertas : Form
    {

        public FrmAlertas()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            
        }


        private void CarregarCotacoesFrame(string endereco,
            Label lblCotacao,
            Label lblVar,
            Label lblStatus,
            Label lblAnalise,
            Label lblLog)
        {

            var web = new HtmlWeb();
            var html = web.Load(endereco);

            lblCotacao.Tag = lblCotacao.Text;

            // cotação
            lblCotacao.Text = html.DocumentNode.SelectSingleNode("//*[@id='last_last']").InnerHtml;

            // variação
            lblVar.Text = html.DocumentNode.SelectSingleNode("//*[@id='quotes_summary_current_data']/div[1]/div[1]/div[1]/div[2]/span[4]/text()").InnerHtml;
                                                            
            AtualizarCorVariacaoPercentual(lblVar);

            // status
            lblStatus.Text = html.DocumentNode.SelectSingleNode("//*[@id='quotes_summary_current_data']/div[1]/div[1]/div[2]/span[2]").InnerHtml;

            try
            {
                // analise técnica
                if (lblAnalise.Equals(lblOuro_Analise) || lblAnalise.Equals(lblPetroleoWTI_Analise) || lblAnalise.Equals(lblMinerio_Analise))
                {
                    //Commodities
                    lblAnalise.Text = html.DocumentNode.SelectSingleNode("//*[@id='leftColumn']/table[2]/tbody/tr[3]/td[4]").InnerHtml;
                }
                else
                    lblAnalise.Text = html.DocumentNode.SelectSingleNode("//*[@id='leftColumn']/table[1]/tbody/tr[3]/td[4]").InnerHtml;
            }
            catch (Exception)
            {

                lblAnalise.Text = "Sem dados";
            }


            // log atualização         
            AtualizarLog(lblCotacao,lblLog);

        }


        private void AtualizarCorVariacaoPercentual(Label label)
        {
            if (Convert.ToDecimal(label.Text.Replace("%", "").Replace(" ", "").ToString()) > 0)
                label.ForeColor = System.Drawing.Color.Lime;
            else
                label.ForeColor = System.Drawing.Color.Red;
        }

        private void AtualizarLog(Label lblCotacao, Label lblLog)
        {
            if (!lblCotacao.Tag.Equals(lblCotacao.Text))
                lblLog.Text = "Últ Atu. " + lblHora.Text;
        }

        private void CarregarCalendario()
        {
            var diretorio = System.IO.Directory.GetCurrentDirectory();

            wbCalendario.ScriptErrorsSuppressed = true;

            wbCalendario.Navigate(diretorio + "\\Calendario.html");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               // this.TopMost = true;

               Thread t = new Thread(new ThreadStart(CarregarCalendario));
                t.Start();                                                             

                trmCotacoes_Tick(null, null);

                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

                mtbHoraBovespa.Text = ConfigurationManager.AppSettings["HoraBovespa"];
                mtbHoraSP500.Text = ConfigurationManager.AppSettings["HoraSP500"];

                var width = ConfigurationManager.AppSettings["FormWidth"];
                var Height = ConfigurationManager.AppSettings["FormHeight"];
                var locationX = ConfigurationManager.AppSettings["LocationX"];
                var locationY = ConfigurationManager.AppSettings["LocationY"];


                this.Size = new Size(Convert.ToInt16(width), Convert.ToInt16(Height));

                var posicao = new System.Drawing.Point();
                posicao.X = Convert.ToInt16(locationX);
                posicao.Y = Convert.ToInt16(locationY);

                this.Location = posicao;

                this.BackColor = System.Drawing.Color.DimGray;

                FrmAlertas_ResizeEnd(null, null);

            }
            catch (Exception)
            {


            }

        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            var hora = new DateTime();
            hora = DateTime.Now;

            var emAlerta = false;

            foreach (Control c in this.Controls)
            {
      
                if (c is MaskedTextBox)
                {
                    try
                    {
                        if ((DateTime.Parse(c.Text) >= hora.AddMinutes(-2)) && (DateTime.Parse(c.Text) <= hora.AddMinutes(2)))
                            emAlerta = true;
                    }
                    catch (Exception)
                    { }

                }

            }

            if (emAlerta)
                {
                    var corFundo = this.BackColor;

                    if (corFundo == System.Drawing.Color.DimGray)
                        this.BackColor = System.Drawing.Color.Red;

                    else if (corFundo == System.Drawing.Color.Red)
                        this.BackColor = System.Drawing.Color.DimGray;

                Thread t = new Thread(new ThreadStart(System.Media.SystemSounds.Hand.Play));
                t.Start();

                }
                else
                    this.BackColor = System.Drawing.Color.DimGray;

        }

        private void txtHoraBovespa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAlertas_FormClosed(object sender, FormClosedEventArgs e)
        {

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            settings["HoraBovespa"].Value = mtbHoraBovespa.Text;
            settings["HoraSP500"].Value = mtbHoraSP500.Text;
            settings["FormWidth"].Value = this.Width.ToString();
            settings["FormHeight"].Value = this.Height.ToString();
            settings["LocationX"].Value = this.Location.X.ToString();
            settings["LocationY"].Value = this.Location.Y.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

        }

        private void FrmAlertas_ResizeEnd(object sender, EventArgs e)
        {

            wbCalendario.Size = new Size(714, this.Size.Height - 100);
            this.wbCalendario.Location = new System.Drawing.Point(12, 110);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarCotacaoSP500()
        {
            CarregarCotacoesFrame("https://br.investing.com/indices/us-spx-500-futures",
                lblSP500Fut_pts,
                lblSP500Fut_var,
                lblSP500Fut_status,
                lblSP500Fut_Analise,
                lblSP500Fut_log);
        }

        private void AtualizarCotacaoDX()
        {
            CarregarCotacoesFrame("https://br.investing.com/currencies/us-dollar-index",
                lblDX_pts,
                lblDX_var,
                lblDX_status,
                lblDX_Analise,
                lblDX_Log);
        }

        private void AtualizarCotacao10Anos()
        {
            CarregarCotacoesFrame("https://br.investing.com/rates-bonds/u.s.-10-year-bond-yield",
                lbl10Anos_Pts,
                lbl10Anos_Var,
                lbl10Anos_Status,
                lbl10Anos_Analise,
                lbl10Anos_Log);
        }

        private void AtualizarCotacaosp500vix()
        {
            CarregarCotacoesFrame("https://br.investing.com/indices/volatility-s-p-500",
                lblSP500Vix_Pts,
                lblSP500Vix_Var,
                lblSP500Vix_Status,
                lblSP500Vix_Analise,
                lblSP500Vix_Log);
        }

        private void AtualizarCotacaoPetroleoWTI()
        {
            CarregarCotacoesFrame("https://br.investing.com/commodities/crude-oil",
                lblPetroleoWTI_Pts,
                lblPetroleoWTI_Var,
                lblPetroleoWTI_Status,
                lblPetroleoWTI_Analise,
                lblPetroleoWTI_Log);
        }

        private void AtualizarCotacaoOuro()
        {
            CarregarCotacoesFrame("https://br.investing.com/commodities/gold",
                lblOuro_Pts,
                lblOuro_Var,
                lblOuro_Status,
                lblOuro_Analise,
                lblOuro_Log);
        }

        private void AtualizarCotacaoMinerio()
        {
            CarregarCotacoesFrame("https://br.investing.com/commodities/iron-ore-62-cfr-futures",
                lblMinerio_Pts,
                lblMinerio_Var,
                lblMinerio_Status,
                lblMinerio_Analise,
                lblMinerio_Log);
        }


        private void trmCotacoes_Tick(object sender, EventArgs e)
        {
            Thread threadSP500 = new Thread(new ThreadStart(AtualizarCotacaoSP500));
            threadSP500.Start();

            Thread threadDX = new Thread(new ThreadStart(AtualizarCotacaoDX));
            threadDX.Start();

            Thread thread = new Thread(new ThreadStart(AtualizarCotacao10Anos));
            thread.Start();

            Thread threadSP500vix = new Thread(new ThreadStart(AtualizarCotacaosp500vix));
            threadSP500vix.Start();

            Thread threadPetroleoWTI = new Thread(new ThreadStart(AtualizarCotacaoPetroleoWTI));
            threadPetroleoWTI.Start();

            Thread threadOuro = new Thread(new ThreadStart(AtualizarCotacaoOuro));
            threadOuro.Start();

            Thread threadMinerio = new Thread(new ThreadStart(AtualizarCotacaoMinerio));
            threadMinerio.Start();

                                                                            
        }


        private void FrmAlertas_LocationChanged(object sender, EventArgs e)
        {
            FrmAlertas_ResizeEnd(null, null);
        }
    }
}
