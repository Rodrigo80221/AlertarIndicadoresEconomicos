﻿using Microsoft.Win32;
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

        public FrmAlertas()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            // analise técnica
            lblAnalise.Text = html.DocumentNode.SelectSingleNode("//*[@id='leftColumn']/table[1]/tbody/tr[3]/td[4]").InnerHtml;

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


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                wbCalendario.ScriptErrorsSuppressed = true;
                wbCalendario.Navigate("file:///C:/alertas.html");
                
            }
            catch (Exception)
            {

 
            }
            

            trmCotacoes_Tick(null,null);

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
            CarregarCotacoesFrame("https://br.investing.com/indices/us-spx-500-futures",
                lblSP500Fut_pts,
                lblSP500Fut_var,
                lblSP500Fut_status,
                lblSP500Fut_Analise,
                lblSP500Fut_log);

            CarregarCotacoesFrame("https://br.investing.com/currencies/us-dollar-index",
                lblDX_pts,
                lblDX_var,
                lblDX_status,
                lblDX_Analise,
                lblDX_Log);

            CarregarCotacoesFrame("https://br.investing.com/rates-bonds/u.s.-10-year-bond-yield",
                lbl10Anos_Pts,
                lbl10Anos_Var,
                lbl10Anos_Status,
                lbl10Anos_Analise,
                lbl10Anos_Log);
        }

        private void lblLog_Click(object sender, EventArgs e)
        {

        }
    }
}
