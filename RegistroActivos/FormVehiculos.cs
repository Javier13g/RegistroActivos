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
    public partial class FormVehiculos : Form
    {
        CN_Vehiculo objectoVehiculo = new CN_Vehiculo();

        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }

        private void MostrarVehiculos()
        {
            CN_Vehiculo objecto = new CN_Vehiculo();
            dataGridView1.DataSource = objecto.MostrarVehiculos();

        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                objectoVehiculo.AgregarVehiculos(
                    txtMarca.Text,
                    txtModelo.Text,
                    txtAño.Text,
                    comboBoxTipo.Text,
                    comboBoxComb.Text,
                    Convert.ToInt32(txtValorVehiculo.Text),
                    TipoActivoVeh.Text
                    );
                MessageBox.Show("Se guardo bien jasjdajs");
                MostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }
    }
}
