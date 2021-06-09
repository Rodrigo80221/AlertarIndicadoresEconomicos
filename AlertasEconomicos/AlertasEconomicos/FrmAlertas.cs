using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

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

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {

            var hora = new DateTime();
            hora = DateTime.Now;

            foreach (Control c in this.Controls)
            {              
                if (c is MaskedTextBox)
                {
                    try
                    {
                        if ((DateTime.Parse(c.Text) >= hora.AddMinutes(-2)) && (DateTime.Parse(c.Text) <= hora.AddMinutes(2)))
                        {
                            if (this.BackColor == System.Drawing.Color.DimGray)
                                this.BackColor = System.Drawing.Color.Red;

                            else if (this.BackColor == System.Drawing.Color.Red)
                                this.BackColor = System.Drawing.Color.DimGray;

                            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

                            System.Media.SystemSounds.Asterisk.Play();

                            return;

                        }
                        else
                        {
                            this.BackColor = System.Drawing.Color.DimGray;
                        }

                    }
                    catch (Exception)
                    {


                    }

                }
            }

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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
    }
}
