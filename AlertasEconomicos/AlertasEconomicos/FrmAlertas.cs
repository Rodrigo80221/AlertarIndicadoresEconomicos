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

namespace AlertasEconomicos
{
    public partial class FrmAlertas : Form
    {

        private string WEB_IndicesMundiais { get; set; }
        private string WEB_IndicesFuturos { get; set; }

        private string XPATH_SP500Fut_pts { get; set; }
        private string XPATH_SP500Fut_var { get; set; }

        public FrmAlertas()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarPropriedades()
        {
            WEB_IndicesMundiais = "https://br.investing.com/indices/major-indices";
            WEB_IndicesFuturos = "https://br.investing.com/indices/indices-futures";

            XPATH_SP500Fut_pts = "//*[@id='__next']/div/div/div[2]/main/div[3]/div[2]/table/tbody/tr[4]/td[4]";
            XPATH_SP500Fut_var = "//*[@id='__next']/div/div/div[2]/main/div[3]/div[2]/table/tbody/tr[4]/td[8]";
        }

        private void CarregarCotacoes()
        {

            var web = new HtmlWeb();
            var html = web.Load(WEB_IndicesFuturos);

            lblSP500Fut_pts.Tag = lblSP500Fut_pts.Text;
            lblSP500Fut_var.Tag = lblSP500Fut_var.Text;

            lblSP500Fut_pts.Text = html.DocumentNode.SelectSingleNode(XPATH_SP500Fut_pts).InnerHtml; 
            lblSP500Fut_var.Text = html.DocumentNode.SelectSingleNode(XPATH_SP500Fut_var).InnerHtml;

            if (!lblSP500Fut_pts.Tag.Equals(lblSP500Fut_pts.Text))
                lblLog.Text = lblHora.Text + " " + lblSP500Fut_pts.Tag + " " + lblSP500Fut_var.Tag; 

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarPropriedades();

            CarregarCotacoes();

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            mtbHoraBovespa.Text = ConfigurationManager.AppSettings["HoraBovespa"];
            mtbHoraSP500.Text = ConfigurationManager.AppSettings["HoraSP500"];

            var width = ConfigurationManager.AppSettings["FormWidth"];
            var Height = ConfigurationManager.AppSettings["FormHeight"];
            var locationX = ConfigurationManager.AppSettings["LocationX"];
            var locationY = ConfigurationManager.AppSettings["LocationY"];


            this.Size = new Size(Convert.ToInt16(width) , Convert.ToInt16(Height));

            var posicao = new System.Drawing.Point();
            posicao.X = Convert.ToInt16(locationX);
            posicao.Y = Convert.ToInt16(locationY);

            this.Location = posicao;
        
            this.BackColor = System.Drawing.Color.DimGray;

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

                    System.Media.SystemSounds.Hand.Play();

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
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trmCotacoes_Tick(object sender, EventArgs e)
        {
            CarregarCotacoes();
        }
    }
}
