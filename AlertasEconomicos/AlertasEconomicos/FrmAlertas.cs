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
using System.Runtime.InteropServices;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web.UI.DataVisualization.Charting;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Microsoft.Web.WebView2.Core;

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

        private List<double> _valoresPercentuaisApple = new List<double>();
        private List<double> _valoresPercentuaisMicrosoft = new List<double>();
        private List<double> _valoresPercentuaisAmazon = new List<double>();
        private List<double> _valoresPercentuaisT10 = new List<double>();

        private List<double> _valoresPercentuaisVale = new List<double>();
        private List<double> _valoresPercentuaisPetro = new List<double>();
        private List<double> _valoresPercentuaisItau = new List<double>();
        private List<double> _valoresPercentuaisEWZ = new List<double>();

        private Color _corDoFundo = Color.FromArgb(51, 51, 51);

        private HtmlAgilityPack.HtmlDocument _paginaApple = null;
        private HtmlAgilityPack.HtmlDocument _paginaMicrosoft = null;
        private HtmlAgilityPack.HtmlDocument _paginaAmazon = null;
        private HtmlAgilityPack.HtmlDocument _paginaT10 = null;

        private HtmlAgilityPack.HtmlDocument _paginaVale = null;
        private HtmlAgilityPack.HtmlDocument _paginaPetro = null;
        private HtmlAgilityPack.HtmlDocument _paginaItau = null;
        private HtmlAgilityPack.HtmlDocument _paginaEWZ = null;

        private string _linkApple;
        private string _fullPathCotacaoApple;
        private string _fullPathVariacaoApple;

        private string _linkMicrosoft;
        private string _fullPathCotacaoMicrosoft;
        private string _fullPathVariacaoMicrosoft;

        private string _linkAmazon;
        private string _fullPathCotacaoAmazon;
        private string _fullPathVariacaoAmazon;

        private string _linkT10;
        private string _fullPathCotacaoT10;
        private string _fullPathVariacaoT10;


        private string _linkVale;
        private string _fullPathCotacaoVale;
        private string _fullPathVariacaoVale;

        private string _linkPetro;
        private string _fullPathCotacaoPetro;
        private string _fullPathVariacaoPetro;

        private string _linkItau;
        private string _fullPathCotacaoItau;
        private string _fullPathVariacaoItau;

        private string _linkEWZ;
        private string _fullPathCotacaoEWZ;
        private string _fullPathVariacaoEWZ;

        private bool _rodouThreadsNesteMinuto = false;

        public FrmAlertas()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
        }

        public enum TamanhoForm
        {
            Altura = 768,
            Largura = 590,
        }

        private void CarregarCotacoesFrame(HtmlAgilityPack.HtmlDocument paginaCarregada,
            Label lblCotacao,
            Label lblVar,
            Label lblLog,
            string fullPathVariacao,
            string fullPathCotacao)
        {

            try
            {
                var html = paginaCarregada;

                lblCotacao.Tag = lblCotacao.Text;

                // cotação
                lblCotacao.Text = BuscarCotacao(html, fullPathCotacao);

                // variação
                lblVar.Text = BuscarVariacao(html, fullPathVariacao);

                AtualizarCorVariacaoPercentual(lblVar);

            }
            catch (Exception)
            {

            }


            // log atualização         
            AtualizarLog(lblCotacao, lblLog);

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

                return "0";
            }

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


        private void DesenharGraficoLinha(Chart chart, List<double> valores)
        {
            if (valores.Count == 0)
                return;

            try
            {
                // Cria uma nova série para o gráfico de linha
                System.Windows.Forms.DataVisualization.Charting.Series serie = new System.Windows.Forms.DataVisualization.Charting.Series();
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                // Adiciona valores à série
                for (int i = 0; i < valores.Count; i++)
                {
                    serie.Points.AddXY(i + 1, valores[i]); // Adiciona pontos (x, y) à série
                }

                // Define a cor da linha da série baseada no último valor
                if (valores.Count > 0)
                {
                    if (valores[valores.Count - 1] > 0)
                        serie.Color = System.Drawing.Color.LightGreen;
                    else
                        serie.Color = System.Drawing.Color.Red;
                }

                // Define a largura da linha da série
                serie.BorderWidth = 3;

                // Adiciona a série ao gráfico
                chart.Series.Clear();
                chart.Series.Add(serie);

                chart.ResetAutoValues();

            }
            catch (Exception ex)
            {

            }
        }

        private void FormatarGrafico(Chart chart)
        {
            chart.Series.Clear();
            chart.Legends.Clear();
            chart.BackColor = _corDoFundo;

            // Itera sobre cada ChartArea no gráfico
            foreach (System.Windows.Forms.DataVisualization.Charting.ChartArea area in chart.ChartAreas)
            {
                area.BackColor = _corDoFundo;
                area.AxisX.LineColor = System.Drawing.Color.White;
                area.AxisY.LineColor = System.Drawing.Color.White;
                area.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
                area.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
                area.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;

                area.AxisX.LabelStyle.Enabled = false;
            }
        }

        private async void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                await webView21.EnsureCoreWebView2Async(null);

                // Carregar o site desejado
                webView21.CoreWebView2.Navigate("https://tradingeconomics.com/united-states/government-bond-yield");

                // Aguardar até que a página esteja completamente carregada
                webView21.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
            }
            else
            {
                MessageBox.Show("Falha ao inicializar o CoreWebView2.");
            }
        }

        private async void CoreWebView2_DocumentTitleChanged(object sender, object e)
        {
            // Página completamente carregada, remova o manipulador do evento DocumentTitleChanged
            webView21.CoreWebView2.DocumentTitleChanged -= CoreWebView2_DocumentTitleChanged;

            // Simular um clique no elemento usando o XPath
            string script = "var element = document.evaluate('/html/body/form/div[5]/div/div[1]/div[3]/div[1]/div/div/div[1]/div/div[6]/svg', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue; if (element) { element.click(); }";

            // Executar o script para simular o clique
            await webView21.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                
                if (!System.Diagnostics.Debugger.IsAttached)
                    this.TopMost = true;

                FormatarGrafico(chrApple);
                FormatarGrafico(chrMicrosoft);
                FormatarGrafico(chrAmazon);
                FormatarGrafico(chrT10);

                FormatarGrafico(chrVale);
                FormatarGrafico(chrPetro);
                FormatarGrafico(chrItau);
                FormatarGrafico(chrEWZ);

                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

                mtbFuturos.Text = ConfigurationManager.AppSettings["HoraBovespaFuturos"];
                mtbHoraBovespa.Text = ConfigurationManager.AppSettings["HoraBovespa"];
                mtbHoraSP500.Text = ConfigurationManager.AppSettings["HoraSP500"];

                bool.TryParse(ConfigurationManager.AppSettings["chkBip1m"], out var bip);
                chkBip1m.Checked = bip;

                CarregarLinks();

                var width = (int)TamanhoForm.Largura;
                var Height = (int)TamanhoForm.Altura;
                var locationX = ConfigurationManager.AppSettings["LocationX"];
                var locationY = ConfigurationManager.AppSettings["LocationY"];

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

        private void CarregarLinks()
        {
            _linkApple = "https://www.marketwatch.com/investing/stock/aapl?mod=watchlist_ticker";
            _fullPathCotacaoApple = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoApple = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkMicrosoft = "https://www.marketwatch.com/investing/stock/msft?mod=search_symbol";
            _fullPathCotacaoMicrosoft = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoMicrosoft = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkAmazon = "https://www.marketwatch.com/investing/stock/amzn?mod=search_symbol";
            _fullPathCotacaoAmazon = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoAmazon = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkT10 = "https://www.marketwatch.com/investing/bond/tmubmusd10y?countrycode=bx&mod=search_symbol";
            _fullPathCotacaoT10 = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span/bg-quote";
            _fullPathVariacaoT10 = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";

            _linkVale = "https://www.marketwatch.com/investing/stock/vale?mod=search_symbol";
            _fullPathCotacaoVale = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoVale = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkPetro = "https://www.marketwatch.com/investing/stock/pbr?mod=search_symbol";
            _fullPathCotacaoPetro = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoPetro = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkItau = "https://www.marketwatch.com/investing/stock/itub?mod=search_symbol";
            _fullPathCotacaoItau = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoItau = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";

            _linkEWZ = "https://www.marketwatch.com/investing/fund/ewz?mod=search_symbol";
            _fullPathCotacaoEWZ = "/html/body/div[3]/div[2]/div[3]/div/div[2]/h2/bg-quote";
            _fullPathVariacaoEWZ = "/html/body/div[3]/div[2]/div[3]/div/div[2]/bg-quote/span[2]/bg-quote";
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
                        if ((DateTime.Parse(c.Text) >= hora.AddMinutes(-1)) && (DateTime.Parse(c.Text) <= hora.AddMinutes(1)))
                            emAlerta = true;
                    }
                    catch (Exception)
                    { }

                }

            }

            BiparNoFinalDo1Minuto();

            if (emAlerta)
            {
                if (btnStop.Enabled == true)
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
                {
                    this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
                }

            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
                btnStop.Enabled = true;
            }

        }

        private void BiparNoFinalDo1Minuto()
        {
            try
            {

                if (chkBip1m.Checked == true && DateTime.Now.Second >= 55)
                {
                    Console.Beep();
                }

            }
            catch
            {

            }
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

            string valor = chkBip1m.Checked == true ? "true" : "false";

            settings["chkBip1m"].Value = valor;

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

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void FrmAlertas_ResizeEnd(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarCotacaoApple()
        {
            try
            {
                _paginaApple = CarregarPagina(_paginaApple, _linkApple);

                CarregarCotacoesFrame(_paginaApple,
                    lblCotacaoApple,
                    lblVariacaoApple,
                    lblAtuApple,
                    _fullPathVariacaoApple,
                    _fullPathCotacaoApple);

                CarregarList(_valoresPercentuaisApple, lblVariacaoApple.Text);

                DesenharGraficoLinha(chrApple, _valoresPercentuaisApple);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoMicrosoft()
        {
            try
            {
                _paginaMicrosoft = CarregarPagina(_paginaMicrosoft, _linkMicrosoft);

                CarregarCotacoesFrame(_paginaMicrosoft,
                    lblCotacaoMicrosoft,
                    lblVariacaoMicrosoft,
                    lblAtuMicrosoft,
                    _fullPathVariacaoAmazon,
                    _fullPathCotacaoMicrosoft);

                CarregarList(_valoresPercentuaisMicrosoft, lblVariacaoMicrosoft.Text);

                DesenharGraficoLinha(chrMicrosoft, _valoresPercentuaisMicrosoft);
            }
            catch (Exception)
            {

            }

        }

        private void AtualizarCotacaoAmazon()
        {
            try
            {
                _paginaAmazon = CarregarPagina(_paginaAmazon, _linkAmazon);

                CarregarCotacoesFrame(_paginaAmazon,
                    lblCotacaoAmazon,
                    lblVariacaoAmazon,
                    lblAtuAmazon,
                    _fullPathVariacaoAmazon,
                    _fullPathCotacaoAmazon);

                CarregarList(_valoresPercentuaisAmazon, lblVariacaoAmazon.Text);

                DesenharGraficoLinha(chrAmazon, _valoresPercentuaisAmazon);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoT10()
        {
            try
            {
                _paginaT10 = CarregarPagina(_paginaT10, _linkT10);

                CarregarCotacoesFrame(_paginaT10,
                    lblCotacaoT10,
                    lblVariacaoT10,
                    lblAtuT10,
                    _fullPathVariacaoT10,
                    _fullPathCotacaoT10);

                string valor = lblVariacaoT10.Text.Split('.').Last();

                valor = valor.Substring(1, 2);

                CarregarList(_valoresPercentuaisT10, valor);

                DesenharGraficoLinha(chrT10, _valoresPercentuaisT10);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoVale()
        {
            try
            {
                _paginaVale = CarregarPagina(_paginaVale, _linkVale);

                CarregarCotacoesFrame(_paginaVale,
                    lblCotacaoVale,
                    lblVariacaoVale,
                    lblAtuVale,
                    _fullPathVariacaoVale,
                    _fullPathCotacaoVale);

                CarregarList(_valoresPercentuaisVale, lblVariacaoVale.Text);

                DesenharGraficoLinha(chrVale, _valoresPercentuaisVale);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoPetro()
        {
            try
            {
                _paginaPetro = CarregarPagina(_paginaPetro, _linkPetro);

                CarregarCotacoesFrame(_paginaPetro,
                    lblCotacaoPetro,
                    lblVariacaoPetro,
                    lblAtuPetro,
                    _fullPathVariacaoPetro,
                    _fullPathCotacaoPetro);

                CarregarList(_valoresPercentuaisPetro, lblVariacaoPetro.Text);

                DesenharGraficoLinha(chrPetro, _valoresPercentuaisPetro);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoItau()
        {
            try
            {
                _paginaItau = CarregarPagina(_paginaItau, _linkItau);

                CarregarCotacoesFrame(_paginaItau,
                    lblCotacaoItau,
                    lblVariacaoItau,
                    lblAtuItau,
                    _fullPathVariacaoItau,
                    _fullPathCotacaoItau);

                CarregarList(_valoresPercentuaisItau, lblVariacaoItau.Text);

                DesenharGraficoLinha(chrItau, _valoresPercentuaisItau);
            }
            catch (Exception)
            {


            }
        }

        private void AtualizarCotacaoEWZ()
        {
            try
            {
                _paginaEWZ = CarregarPagina(_paginaEWZ, _linkEWZ);

                CarregarCotacoesFrame(_paginaEWZ,
                    lblCotacaoEWZ,
                    lblVariacaoEWZ,
                    lblAtuEWZ,
                    _fullPathVariacaoEWZ,
                    _fullPathCotacaoEWZ);

                CarregarList(_valoresPercentuaisEWZ, lblVariacaoEWZ.Text);

                DesenharGraficoLinha(chrEWZ, _valoresPercentuaisEWZ);
            }
            catch (Exception)
            {


            }
        }

        private HtmlAgilityPack.HtmlDocument CarregarPagina(HtmlAgilityPack.HtmlDocument pagina, string link)
        {
            try
            {
                //if (pagina == null)
                {
                    var web = new HtmlWeb();
                    pagina = web.Load(link);
                }

                return pagina;
            }
            catch (Exception)
            {
                return null;

            }
        }

        private void CarregarList(List<double> lista, string variacao)
        {
            try
            {
                if (lista.Count == 0)
                {
                    lista.Add(0);
                }

                variacao = variacao.Replace("%", "").Replace(".", ",");

                double.TryParse(variacao, out var cotacao);
                lista.Add(cotacao);

                if (lista.Count > 15)
                {
                    lista.Remove(lista.First());
                }
            }
            catch (Exception)
            {


            }
        }

        private void trmCotacoes_Tick(object sender, EventArgs e)
        {
            try
            {

                if (_rodouThreadsNesteMinuto == false)
                {

                    Thread threadAppe = new Thread(new ThreadStart(AtualizarCotacaoApple));
                    threadAppe.Start();

                    Thread threadMicrosoft = new Thread(new ThreadStart(AtualizarCotacaoMicrosoft));
                    threadMicrosoft.Start();

                    Thread threadAmazon = new Thread(new ThreadStart(AtualizarCotacaoAmazon));
                    threadAmazon.Start();

                    Thread threadT10 = new Thread(new ThreadStart(AtualizarCotacaoT10));
                    threadT10.Start();


                    Thread threadVale = new Thread(new ThreadStart(AtualizarCotacaoVale));
                    threadVale.Start();

                    Thread threadPetro = new Thread(new ThreadStart(AtualizarCotacaoPetro));
                    threadPetro.Start();

                    Thread threadItau = new Thread(new ThreadStart(AtualizarCotacaoItau));
                    threadItau.Start();

                    Thread threadEWZ = new Thread(new ThreadStart(AtualizarCotacaoEWZ));
                    threadEWZ.Start();

                    _rodouThreadsNesteMinuto = true;
                }

                if (DateTime.Now.Second == 55)
                {
                    _rodouThreadsNesteMinuto = false;
                }

            }
            catch (Exception)
            {


            }
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
            
        }

        private void lblHoraTokyo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormatarGrafico(chrApple);
            FormatarGrafico(chrMicrosoft);
            FormatarGrafico(chrAmazon);
            FormatarGrafico(chrT10);

            FormatarGrafico(chrVale);
            FormatarGrafico(chrPetro);
            FormatarGrafico(chrItau);
            FormatarGrafico(chrEWZ);

            _paginaApple = null;
            _paginaMicrosoft = null;
            _paginaAmazon = null;

            List<Label> labels = new List<Label>();
            labels.Add(lblCotacaoApple);
            labels.Add(lblCotacaoMicrosoft);
            labels.Add(lblCotacaoAmazon);

            labels.Add(lblVariacaoApple);
            labels.Add(lblVariacaoMicrosoft);
            labels.Add(lblVariacaoAmazon);

            labels.Add(lblAtuApple);
            labels.Add(lblAtuMicrosoft);
            labels.Add(lblAtuAmazon);

            foreach (var label in labels)
            {
                label.Text = "";
            }

            trmCotacoes_Tick(null, null);

            SalvarSettings();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FrmCalendario();
            form.Show();
        }
    }
}
