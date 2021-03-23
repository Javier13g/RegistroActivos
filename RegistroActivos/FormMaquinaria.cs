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
    public partial class FormMaquinaria : Form
    {
        CN_Maquinaria objectoMaqui = new CN_Maquinaria();

        public FormMaquinaria()
        {
            InitializeComponent();
        }

        private void FormMaquinaria_Load(object sender, EventArgs e)
        {
            MostrarMaquinaria();
        }

        private void MostrarMaquinaria()
        {
            CN_Maquinaria objecto = new CN_Maquinaria();
            dataGridView1.DataSource = objecto.MostrarMaquinaria();

        }

        private void btnAgregarMa_Click(object sender, EventArgs e)
        {
            try
            {
                objectoMaqui.AgregarMaquinaria(
                    txtTipoMaquinaria.Text,
                    Convert.ToInt32(txtValorMaquinaria.Text),
                    TipoActivoMa.Text
                    );
                MessageBox.Show("Se guardo bien jasjdajs");
                MostrarMaquinaria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }
    }
}
