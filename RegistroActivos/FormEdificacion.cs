using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace RegistroActivos
{
    public partial class FormEdificacion : Form
    {
        CN_Edificacion objectoED = new CN_Edificacion();

        public FormEdificacion()
        {
            InitializeComponent();
        }

        private void FormEdificacion_Load(object sender, EventArgs e)
        {
            MostrarEdificios();
        }

        private void MostrarEdificios()
        {
            CN_Edificacion objecto = new CN_Edificacion();
            dataGridView1.DataSource = objecto.MostrarEdificaciones();

        }

        private void btnAgregarEd_Click(object sender, EventArgs e)
        {
            try
            {
                objectoED.AgregarEdificios(
                    Convert.ToDecimal(txtDimensionEdi.Text),
                    Convert.ToInt32(txtValorEdificio.Text),
                    TipoActivoEd.Text
                    );
                MessageBox.Show("Se guardo bien jasjdajs");
                MostrarEdificios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }
    }
}
