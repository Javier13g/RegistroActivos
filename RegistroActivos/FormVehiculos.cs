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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
            this.Hide();
        }

        private void MostrarVehiculos()
        {
            CN_Vehiculo objecto = new CN_Vehiculo();
            dataGridView1.DataSource = objecto.MostrarVehiculos();

        }


        //FUNCION QUE SELECCIONA LOS DATOS PARA EDITARLOS
       

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

        private void exportPDF(DataGridView DGW, String nombreArchivo)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,
                BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(DGW.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10,
                iTextSharp.text.Font.NORMAL);

            //HEADER//
            foreach (DataGridViewColumn column in DGW.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //ADD DATAROW
            foreach (DataGridViewRow row in DGW.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));

                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = nombreArchivo;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(
                    savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            exportPDF(dataGridView1, "Vehiculos");
        }

        private void btnGuardarVehiculo_Click_1(object sender, EventArgs e)
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

        private void btnEditarVe_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
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

        private void btnEliminarVeh_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_vehiculo = dataGridView1.CurrentRow.Cells["ID_Vehiculo"]
                        .Value.ToString();
                objectoVehiculo.EliminarVehiculos(Convert.ToInt32(id_vehiculo.ToString()));
                MessageBox.Show("Vehiculo " + txtModelo + " Eliminado");
                MostrarVehiculos();
            }
        }

       
    }
}
