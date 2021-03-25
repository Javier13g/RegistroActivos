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
        private string id_edificacion = null;
        private bool editar = false;

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
            //SI EDITAR ES FALSO, GUARDA DE MANERA NORMAL
            if (editar == false)
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
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }

            if (editar == true)
            {
                try
                {
                    objectoED.EditarEdificios(
                        Convert.ToDecimal(txtDimensionEdi.Text),
                        Convert.ToInt32(txtValorEdificio.Text),
                        TipoActivoEd.Text,
                        Convert.ToInt32(id_edificacion.ToString())
                        );
                    MessageBox.Show("Se edito el terreno correspondiente al ID " + id_edificacion);
                    MostrarEdificios();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }
        }

        private void btnEditarEd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtDimensionEdi.Text = dataGridView1.CurrentRow.Cells["Tamaño"]
                        .Value.ToString();
                    TipoActivoEd.Text = dataGridView1.CurrentRow.Cells["Tipo_Activo"]
                        .Value.ToString();
                    txtValorEdificio.Text = dataGridView1.CurrentRow.Cells["Valor"]
                        .Value.ToString();
                    id_edificacion = dataGridView1.CurrentRow.Cells["ID_Edificacion"]
                        .Value.ToString();
                }
                else
                    MessageBox.Show("Seleccione el edificio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }

        private void btnEliminarEd_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_edificacion = dataGridView1.CurrentRow.Cells["ID_Edificacion"]
                        .Value.ToString();
                objectoED.EliminarEdificios(Convert.ToInt32(id_edificacion.ToString()));
                MessageBox.Show("Edificio eliminado");
                MostrarEdificios();
            }
            else
                MessageBox.Show("Seleccione el edificio");
        }

        private void limpiar()
        {
            txtDimensionEdi.Clear();
            txtValorEdificio.Clear();
            TipoActivoEd.Items.Clear();
        }
    }
}
