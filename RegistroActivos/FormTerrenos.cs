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
        private string id_Terreno = null;
        private bool editar = false;

        public FormTerrenos()
        {
            InitializeComponent();
        }

        private void FormTerrenos_Load(object sender, EventArgs e)
        {
            MostrarTerrenos();
            
        }

        
        //METODO QUE MUESTRA LOS TERRENOS DE LA DB
        private void MostrarTerrenos()
        {
            CN_Vehiculos objecto = new CN_Vehiculos();
            dataGridView1.DataSource = objecto.MostrarTerrenos();

        }

        //BTN GUARDAR TERRENOS
        private void btnGuardarTerrenos_Click(object sender, EventArgs e)
        {
            //SI EDITAR ES FALSO, GUARDA DE MANERA NORMAL
            if (editar == false)
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
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            } 

            //SI EDITAR ES VERDADERO, EDITA EL TERRENO CORRESPONDIENTE
            if(editar == true)
            {
                try
                {
                    objectoTerreno.EditarTerrenos(
                        Convert.ToDecimal(txtDimension.Text),
                        txtMatricula.Text,
                        txtDesignacion.Text,
                        Convert.ToDecimal(txtValor.Text),
                        comboBoxTipo.Text,
                        Convert.ToInt32(id_Terreno.ToString())
                        );
                    MessageBox.Show("Se edito el terreno correspondiente al ID " + id_Terreno);
                    MostrarTerrenos();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }
        }

        //FUNCION QUE SELECCIONA LOS DATOS PARA EDITARLOS
        private void btnEditarTer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtDimension.Text = dataGridView1.CurrentRow.Cells["Tamaño"]
                        .Value.ToString();
                    txtMatricula.Text = dataGridView1.CurrentRow.Cells["Matricula_Titulo"]
                        .Value.ToString();
                    txtDesignacion.Text = dataGridView1.CurrentRow.Cells["Designacion_Catastral"]
                        .Value.ToString();
                    txtValor.Text = dataGridView1.CurrentRow.Cells["Valor"]
                        .Value.ToString();
                    comboBoxTipo.Text = dataGridView1.CurrentRow.Cells["Tipo_Activo"]
                        .Value.ToString();
                    id_Terreno = dataGridView1.CurrentRow.Cells["ID_Terreno"]
                        .Value.ToString();
                }
                else
                    MessageBox.Show("Seleccione el Terreno");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a:  " + ex);
            }
        }

        //METODO QUE LIMPIA LOS FORM
        private void limpiar()
        {
            txtDimension.Clear();
            txtDesignacion.Clear();
            txtMatricula.Clear();
            comboBoxTipo.Items.Clear();
            txtValor.Clear();
        }

        //FUNCION QUE ELIMINA TERRENOS
        private void btnEliminarTe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_Terreno = dataGridView1.CurrentRow.Cells["ID_Terreno"]
                        .Value.ToString();
                objectoTerreno.EliminarTerrenos(Convert.ToInt32(id_Terreno.ToString()));
                MessageBox.Show("Terreno Eliminado");
                MostrarTerrenos();
            }
            else
                MessageBox.Show("Seleccione el terreno");
        }
    }
}
