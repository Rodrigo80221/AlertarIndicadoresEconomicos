using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertasEconomicos
{
    public partial class FrmCalendario : Form
    {
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            // Carregar o site desejado
            string nomeArquivo = "Calendario.html";
            string caminhoCompleto = Path.Combine(Application.StartupPath, nomeArquivo);

            if (File.Exists(caminhoCompleto))
            {
                Uri uri = new Uri(caminhoCompleto);
                webView21.Source = uri;
            }
            else
            {
                MessageBox.Show("O arquivo HTML não foi encontrado.");
            }
        }
    }
}
