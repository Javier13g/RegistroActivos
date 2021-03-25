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
        private string id_maquinaria = null;
        private bool editar = false;

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
            //SI EDITAR ES FALSO, GUARDA DE MANERA NORMAL
            if (editar == false)
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
                    objectoMaqui.EditarMaquinaria(
                        txtTipoMaquinaria.Text,
                        Convert.ToInt32(txtValorMaquinaria.Text),
                        TipoActivoMa.Text,
                        Convert.ToInt32(id_maquinaria.ToString())
                        );
                    MessageBox.Show("Se edito la maquinaria correspondiente al ID "
                        + id_maquinaria);
                    MostrarMaquinaria();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }
        }

        private void btnEliminarMa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_maquinaria = dataGridView1.CurrentRow.Cells["ID_Maquinaria"]
                        .Value.ToString();
                objectoMaqui.EliminarMaquinaria(Convert.ToInt32(id_maquinaria.ToString()));
                MessageBox.Show("Maquina eliminado");
                MostrarMaquinaria();
            }
            else
                MessageBox.Show("Seleccione la maquina");
        }

        private void btnEditarMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtTipoMaquinaria.Text = dataGridView1.CurrentRow.Cells["Tipo_Maquinaria"]
                        .Value.ToString();
                    TipoActivoMa.Text = dataGridView1.CurrentRow.Cells["Tipo_Activo"]
                        .Value.ToString();
                    txtValorMaquinaria.Text = dataGridView1.CurrentRow.Cells["Valor"]
                        .Value.ToString();
                    id_maquinaria = dataGridView1.CurrentRow.Cells["ID_Maquinaria"]
                        .Value.ToString();
                }
                else
                    MessageBox.Show("Seleccione la maquina");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a: " + ex);
            }
        }

        private void limpiar()
        {
            txtValorMaquinaria.Clear();
            txtTipoMaquinaria.Clear();
            TipoActivoMa.Items.Clear();
        }
    }
}
