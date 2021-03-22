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
    public partial class FormTerrenos : Form
    {
        CN_Terrenos objectoTerreno = new CN_Terrenos();
        public FormTerrenos()
        {
            InitializeComponent();
        }

        private void FormTerrenos_Load(object sender, EventArgs e)
        {
            MostrarTerrenos();
        }

        private void MostrarTerrenos()
        {
            CN_Terrenos objecto = new CN_Terrenos();
            dataGridView1.DataSource = objecto.MostrarTerrenos();

        }

        private void btnGuardarTerrenos_Click(object sender, EventArgs e)
        {
            try
            {
                objectoTerreno.AgregarTerrenos(
                    Convert.ToDecimal(txtDimension.Text),
                    txtMatricula.Text,
                    txtDesignacion.Text,
                    Convert.ToDecimal(txtValor.Text),
                    comboBoxTipo.Text
                    );
                MessageBox.Show("Se guardo bien jasjdajs");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }
    }
}
