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
        public enum Site
        {
            Investing = 0,
            MarketWach,
            Sino
        }

        public FrmAlertas()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;    
        }

        public enum TamanhoForm
        {
            Normal = 200,
            Configuracoes = 670
        }

        private void CarregarCotacoesFrame(string endereco,
            Label lblCotacao,
            Label lblVar,
            Label lblLog,
            string fullPathVariacao,
            string fullPathCotacao)
        {

            try
            {
                var web = new HtmlWeb();
                var html = web.Load(endereco);

                lblCotacao.Tag = lblCotacao.Text;

                // cotação
                lblCotacao.Text = BuscarCotacao(html,fullPathCotacao);

                // variação
                lblVar.Text = BuscarVariacao(html, fullPathVariacao);

                AtualizarCorVariacaoPercentual(lblVar);

            }
            catch (Exception)
            {

            }


            // log atualização         
            AtualizarLog(lblCotacao,lblLog);

        }



        private string BuscarCotacao(HtmlAgilityPack.HtmlDocument html, string fullPath)
        {
            try
            {
                return html.DocumentNode.SelectSingleNode(fullPath).InnerHtml;
            }
            catch (Exception)
            {
                return "0";
            }
           
        }

        private string BuscarVariacao(HtmlAgilityPack.HtmlDocument html, string fullPathVariacao)
        {

            string cotacao = "";

            try
            {                
                cotacao = BuscarInnerHtml(html, fullPathVariacao);

                cotacao = cotacao.Replace("<!-- -->", "");

                cotacao = cotacao.Replace(")", "");

                cotacao = cotacao.Replace("(", "");

                if (!string.IsNullOrEmpty(cotacao) && cotacao.Length < 15 && cotacao != "+" && cotacao != "-" && cotacao != "%)")
                    return (cotacao.Contains("%") ? cotacao : cotacao + "%");                

                return "0";
            }
            catch (Exception e)
            {
    
                //lblError.Text += Environment.NewLine + e.Message + " " + cotacao;
                throw;
            }
     
        }

        private string BuscarStatus(HtmlAgilityPack.HtmlDocument html)
        {
            string status = "";

            List<string> possiveisXPath = new List<string>();
            possiveisXPath.Add("//*[@id='quotes_summary_current_data']/div[1]/div[1]/div[2]/span[2]");
            possiveisXPath.Add("//*[@id='__next']/div/div/div[2]/main/div/div[1]/div[2]/div[2]/div[2]/time");

            foreach (var xPath in possiveisXPath)
            {
                status = BuscarInnerHtml(html, xPath);

                if (status != "" && status.Length < 15)
                    return status;
            }

            return "";
        }

        private string BuscarAnaliseTecnica(HtmlAgilityPack.HtmlDocument html)
        {
            string analiseTecnica = "";

            List<string> possiveisXPath = new List<string>();
            possiveisXPath.Add("//*[@id='leftColumn']/table[2]/tbody/tr[3]/td[4]");
            possiveisXPath.Add("//*[@id='leftColumn']/table[1]/tbody/tr[3]/td[4]");
            possiveisXPath.Add("//*[@id='__next']/div/div/div[2]/main/div/div[5]/div/div[7]/div/div/div/table/tbody/tr[3]/td[5]");
            possiveisXPath.Add("//*[@id='__next']/div/div/div[2]/main/div/div[5]/div/div[9]/div/div/div/table/tbody/tr[3]/td[5]");


            foreach (var xPath in possiveisXPath)
            {
                analiseTecnica = BuscarInnerHtml(html, xPath);

                if (analiseTecnica != "" && analiseTecnica.Length < 15)
                    return analiseTecnica;                
            }
                
            return "";

        }

        public static string BuscarInnerHtml(HtmlAgilityPack.HtmlDocument html, string xPath)
        {
            try
            {
                return html.DocumentNode.SelectSingleNode(xPath).InnerHtml;
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void AtualizarCorVariacaoPercentual(Label label)
        {
            if (string.IsNullOrEmpty(label.Text))
                return;

            if (Convert.ToDecimal(label.Text.Replace("%", "").Replace(" ", "").ToString()) > 0)
                label.ForeColor = System.Drawing.Color.Lime;
            else
                label.ForeColor = System.Drawing.Color.Red;
        }

        private void AtualizarLog(Label lblCotacao, Label lblLog)
        {
            try
            {
                if (!lblCotacao.Tag.Equals(lblCotacao.Text))
                    lblLog.Text = "Últ Atu. " + lblHora.Text;
            }
            catch (Exception)
            {

            
            }

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                if (!System.Diagnostics.Debugger.IsAttached)
                    this.TopMost = true;                                                                          

                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

                mtbFuturos.Text = ConfigurationManager.AppSettings["HoraBovespaFuturos"];
                mtbHoraBovespa.Text = ConfigurationManager.AppSettings["HoraBovespa"];
                mtbHoraSP500.Text = ConfigurationManager.AppSettings["HoraSP500"];

                txtLinkSP500.Text = ConfigurationManager.AppSettings["txtLinkSP500"];
                txtLinkDX.Text = ConfigurationManager.AppSettings["txtLinkDX"];
                txtLinkWTI.Text = ConfigurationManager.AppSettings["txtLinkWTI"];

                txtFullPathCotacaoSP500.Text = ConfigurationManager.AppSettings["txtFullPathCotacaoSP500"];
                txtFullPathCotacaoDX.Text = ConfigurationManager.AppSettings["txtFullPathCotacaoDX"];
                txtFullPathCotacaoWTI.Text = ConfigurationManager.AppSettings["txtFullPathCotacaoWTI"];

                txtFullPathVariacaoSP500.Text = ConfigurationManager.AppSettings["txtFullPathVariacaoSP500"];
                txtFullPathVariacaoWTI.Text = ConfigurationManager.AppSettings["txtFullPathVariacaoWTI"];
                txtFullPathVariacaoDX.Text = ConfigurationManager.AppSettings["txtFullPathVariacaoDX"];

                if (string.IsNullOrEmpty(txtLinkDX.Text))
                    txtLinkDX.Text = "https://br.investing.com/currencies/us-dollar-index";

                if (string.IsNullOrEmpty(txtLinkSP500.Text))
                    txtLinkSP500.Text = "https://br.investing.com/indices/us-spx-500-futures";

                if (string.IsNullOrEmpty(txtLinkWTI.Text))
                    txtLinkWTI.Text = "https://br.investing.com/commodities/crude-oil";

                if (string.IsNullOrEmpty(txtFullPathCotacaoDX.Text))
                    txtFullPathCotacaoSP500.Text = "/html/body/div[5]/section/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]";

                if (string.IsNullOrEmpty(txtFullPathCotacaoSP500.Text))
                    txtFullPathCotacaoDX.Text = "/html/body/div[1]/div/div/div/div[2]/main/div/div[1]/div[2]/div[1]/span";

                if (string.IsNullOrEmpty(txtFullPathCotacaoWTI.Text))
                    txtFullPathCotacaoWTI.Text = "/html/body/div[1]/div/div/div/div[2]/main/div/div[1]/div[2]/div[1]/span";

                if (string.IsNullOrEmpty(txtFullPathVariacaoDX.Text))
                    txtFullPathVariacaoDX.Text = "/html/body/div[5]/section/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/span[4]";

                if (string.IsNullOrEmpty(txtFullPathVariacaoSP500.Text))
                    txtFullPathVariacaoSP500.Text = "/html/body/div[1]/div/div/div/div[2]/main/div/div[1]/div[2]/div[1]/div[2]/span[2]";

                if (string.IsNullOrEmpty(txtFullPathVariacaoWTI.Text))
                    txtFullPathVariacaoWTI.Text = "/html/body/div[1]/div/div/div/div[2]/main/div/div[1]/div[2]/div[1]/div[2]/span[2]";

                var width = ConfigurationManager.AppSettings["FormWidth"];
                var Height = (int)TamanhoForm.Normal; // ConfigurationManager.AppSettings["FormHeight"];
                var locationX = ConfigurationManager.AppSettings["LocationX"];
                var locationY = ConfigurationManager.AppSettings["LocationY"];

                this.Size = new Size(Convert.ToInt16(width), Convert.ToInt16(Height));

                var posicao = new System.Drawing.Point();
                posicao.X = Convert.ToInt16(locationX);
                posicao.Y = Convert.ToInt16(locationY);

                this.Location = posicao;

                this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

                trmCotacoes_Tick(null, null);

                FrmAlertas_ResizeEnd(null, null);

            }
            catch (Exception)
            {


            }

        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {

            DateTime timeUtc = DateTime.UtcNow;

            var kstZoneUS = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            lblHoraUSA.Text = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, kstZoneUS).ToString("HH:mm:ss");

            var kstZoneEuropa = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            lblHoraEuropa.Text = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, kstZoneEuropa).ToString("HH:mm:ss");

            var kstZoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            lblHoraTokyo.Text = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, kstZoneTokyo).ToString("HH:mm:ss");


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

                    if (corFundo == System.Drawing.Color.FromArgb(51, 51, 51))
                        this.BackColor = System.Drawing.Color.Red;

                    else if (corFundo == System.Drawing.Color.Red)
                        this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

                Thread t = new Thread(new ThreadStart(System.Media.SystemSounds.Hand.Play));
                t.Start();

                }
                else
                    this.BackColor = System.Drawing.Color.FromArgb(51,51,51);          

        }

        private void txtHoraBovespa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAlertas_FormClosed(object sender, FormClosedEventArgs e)
        {

            SalvarSettings();

        }

        private void SalvarSettings()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            settings["HoraBovespa"].Value = mtbHoraBovespa.Text;
            settings["HoraSP500"].Value = mtbHoraSP500.Text;
            settings["HoraBovespaFuturos"].Value = mtbFuturos.Text;

            settings["FormWidth"].Value = this.Width.ToString();
            settings["FormHeight"].Value = this.Height.ToString();

            if (this.Location.X > 0)
                settings["LocationX"].Value = this.Location.X.ToString();
            else
                settings["LocationX"].Value = "0";

            if (this.Location.Y > 0)
                settings["LocationY"].Value = this.Location.Y.ToString();
            else
                settings["LocationY"].Value = "0";

            settings["txtLinkSP500"].Value = txtLinkSP500.Text;
            settings["txtLinkDX"].Value = txtLinkDX.Text;
            settings["txtLinkWTI"].Value = txtLinkWTI.Text;

            settings["txtFullPathCotacaoSP500"].Value = txtFullPathCotacaoSP500.Text;
            settings["txtFullPathCotacaoDX"].Value = txtFullPathCotacaoDX.Text;
            settings["txtFullPathCotacaoWTI"].Value = txtFullPathCotacaoWTI.Text;

            settings["txtFullPathVariacaoSP500"].Value = txtFullPathVariacaoSP500.Text;
            settings["txtFullPathVariacaoWTI"].Value = txtFullPathVariacaoWTI.Text;
            settings["txtFullPathVariacaoDX"].Value = txtFullPathVariacaoDX.Text;

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void FrmAlertas_ResizeEnd(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarCotacaoSP500()
        {
            
            CarregarCotacoesFrame(txtLinkSP500.Text,
                lblSP500Fut_pts,
                lblSP500Fut_var,
                lblSP500Fut_log,
                txtFullPathVariacaoSP500.Text,
                txtFullPathCotacaoSP500.Text);
        }

        private void AtualizarCotacaoDX()
        {
            CarregarCotacoesFrame(txtLinkDX.Text,
                lblDX_pts,
                lblDX_var,
                lblDX_Log,
                txtFullPathVariacaoDX.Text,
                txtFullPathCotacaoDX.Text);
        }

        private void AtualizarCotacaoPetroleoWTI()
        {
            CarregarCotacoesFrame(txtLinkWTI.Text,
                lblPetroleoWTI_Pts,
                lblPetroleoWTI_Var,
                lblPetroleoWTI_Log,
                txtFullPathVariacaoWTI.Text,
                txtFullPathCotacaoWTI.Text);
        }

        private void trmCotacoes_Tick(object sender, EventArgs e)
        {
            Thread threadSP500FUT = new Thread(new ThreadStart(AtualizarCotacaoSP500));
            threadSP500FUT.Start();
                        
            Thread threadDX = new Thread(new ThreadStart(AtualizarCotacaoDX));
            threadDX.Start();

            Thread threadPetroleoWTI = new Thread(new ThreadStart(AtualizarCotacaoPetroleoWTI));
            threadPetroleoWTI.Start();
            
          }


        private void FrmAlertas_LocationChanged(object sender, EventArgs e)
        {
            FrmAlertas_ResizeEnd(null, null);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var texto = "6,49	10,22	3,56	20,53%	7,42%	1,95";

     
            foreach (char c in texto)
            {
                MessageBox.Show(c + ": " + (int)c);
            }
        }

        private void txtEnderecoStatusInvest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnderecoStatusInvest_MouseClick(object sender, MouseEventArgs e)
        {
            txtEnderecoStatusInvest.Text = "";
        }

        private void lblHoraTokyo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            List<Label> labels = new List<Label>();
            labels.Add(lblDX_pts);
            labels.Add(lblPetroleoWTI_Pts);
            labels.Add(lblSP500Fut_pts);

            labels.Add(lblDX_var);
            labels.Add(lblPetroleoWTI_Var);
            labels.Add(lblSP500Fut_var);

            labels.Add(lblDX_Log);
            labels.Add(lblPetroleoWTI_Log);
            labels.Add(lblSP500Fut_log);

            foreach (var label in labels)
            {
                label.Text = "";
            }


            trmCotacoes_Tick(null, null);

            SalvarSettings();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            if (this.Height == (int)TamanhoForm.Normal)
                this.Height = (int)TamanhoForm.Configuracoes;

            else if (this.Height == (int)TamanhoForm.Configuracoes)
                this.Height = (int)TamanhoForm.Normal;
        }
    }
}
