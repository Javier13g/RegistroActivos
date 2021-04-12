using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroActivos
{
    public partial class FormAcerdaDe : Form
    {
        public FormAcerdaDe()
        {
            InitializeComponent();
        }

        private void btn911_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://911.gob.do"); 
        }

        private void btnDominicanaGob_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dominicana.gob.do");
        }

        private void btnAtencionCiudadana_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://311.gob.do");
        }

        private void btnPolicia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.policianacional.gob.do");
        }

        private void FormAcerdaDe_Load(object sender, EventArgs e)
        {

        }
    }
}
