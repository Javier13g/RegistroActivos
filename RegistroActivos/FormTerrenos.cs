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
        CN_Vehiculos objectoTerreno = new CN_Vehiculos();
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
            CN_Vehiculos objecto = new CN_Vehiculos();
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
                MostrarTerrenos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }

        
    }
}
