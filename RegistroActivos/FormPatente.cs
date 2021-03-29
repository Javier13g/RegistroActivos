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
    public partial class FormPatente : Form
    {
        CN_Patentes objectoPa = new CN_Patentes();

        public FormPatente()
        {
            InitializeComponent();
        }

        private void FormPatente_Load(object sender, EventArgs e)
        {
            MostrarPatentes();
        }

        private void MostrarPatentes()
        {
            CN_Patentes objecto = new CN_Patentes();
            dataGridView1.DataSource = objecto.MostrarPatentes();

        }

        private void btnAgregarPa_Click(object sender, EventArgs e)
        {
            try
            {
                objectoPa.AgregarPatentes(
                    txtNombrePatente.Text,
                    txtDescripcionPatente.Text,
                    Convert.ToInt32(txtValorPatente.Text),
                    TipoActivoPa.Text
                    );
                MessageBox.Show("Se guardo bien jasjdajs");
                MostrarPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }

        private void txtValorPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
