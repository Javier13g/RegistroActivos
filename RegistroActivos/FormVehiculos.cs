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
        private string id_vehiculo = null;
        private bool editar = false;

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
            //SI EDITAR ES FALSO, GUARDA DE MANERA NORMAL
            if (editar == false)
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
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }

            //SI EDITAR ES VERDADERO, EDITA EL TERRENO CORRESPONDIENTE
            if (editar == true)
            {
                try
                {
                    objectoVehiculo.EditarVehiculos(
                        txtMarca.Text,
                        txtModelo.Text,
                        txtAño.Text,
                        comboBoxTipo.Text,
                        comboBoxComb.Text,
                        Convert.ToInt32(txtValorVehiculo.Text),
                        TipoActivoVeh.Text,
                        Convert.ToInt32(id_vehiculo.ToString())
                        );
                    MessageBox.Show("Se edito el vehiculo correspondiente al ID " + id_vehiculo);
                    MostrarVehiculos();
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
        private void btnEditarVe_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"]
                        .Value.ToString();
                    txtModelo.Text = dataGridView1.CurrentRow.Cells["Modelo"]
                        .Value.ToString();
                    txtAño.Text = dataGridView1.CurrentRow.Cells["Año"]
                        .Value.ToString();
                    comboBoxTipo.Text = dataGridView1.CurrentRow.Cells["Tipo"]
                        .Value.ToString();
                    comboBoxComb.Text = dataGridView1.CurrentRow.Cells["Combustible"]
                        .Value.ToString();
                    txtValorVehiculo.Text = dataGridView1.CurrentRow.Cells["Valor"]
                        .Value.ToString();
                    id_vehiculo = dataGridView1.CurrentRow.Cells["ID_Vehiculo"]
                        .Value.ToString();

                }
                else
                    MessageBox.Show("Seleccione el vehiculo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a:  " + ex);
            }
        }

        //METODO QUE LIMPIA LOS FORM
        private void limpiar()
        {
            txtAño.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            comboBoxTipo.Items.Clear();
            comboBoxComb.Items.Clear();
            txtValorVehiculo.Clear();
        }

        //FUNCION QUE ELIMINA
        private void btnEliminarVeh_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_vehiculo = dataGridView1.CurrentRow.Cells["ID_Vehiculo"]
                        .Value.ToString();
                objectoVehiculo.EliminarVehiculos(Convert.ToInt32(id_vehiculo.ToString()));
                MessageBox.Show("Vehiculo "+txtModelo+ " Eliminado");
                MostrarVehiculos();
            }
        }

        private void AlertSoloNumeros()
        {
            MessageBox.Show("No es permitido el uso de letras");
        }


        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
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
                AlertSoloNumeros();
            }
        }

        private void txtValorVehiculo_KeyPress(object sender, KeyPressEventArgs e)
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
                AlertSoloNumeros();
            }
        }
    }
}
