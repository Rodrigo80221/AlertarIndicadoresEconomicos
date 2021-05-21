using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\");
            mtbHoraBovespa.Text = Registro.Ler(key, "AlertasEconomicos", "Horarios", "HoraBovespa", "");
            mtbHoraSP500.Text =  Registro.Ler(key, "AlertasEconomicos", "Horarios", "HoraSP500", "");

            var width = Convert.ToInt16(Registro.Ler(key, "AlertasEconomicos", "Horarios", "formWidth", "500"));
            var Height = Convert.ToInt16(Registro.Ler(key, "AlertasEconomicos", "Horarios", "formHeight", "500"));

            this.Size = new Size(width, Height);
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
                            this.BackColor = System.Drawing.Color.Red;
                            return;

                        }
                        else
                        {
                            this.BackColor = System.Drawing.SystemColors.Control;
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
            Registry.LocalMachine.CreateSubKey("Software\\AlertasEconomicos");

            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\");           

            Registro.Gravar(key, "AlertasEconomicos", "Horarios", "HoraBovespa", mtbHoraBovespa.Text);
            Registro.Gravar(key, "AlertasEconomicos", "Horarios", "HoraSP500", mtbHoraSP500.Text);

            Registro.Gravar(key, "AlertasEconomicos", "Horarios", "formWidth", this.Width.ToString());
            Registro.Gravar(key, "AlertasEconomicos", "Horarios", "formHeight", this.Height.ToString());
        }
    }
}
