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

        private void txtDimensionEdi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorEdificio_KeyPress(object sender, KeyPressEventArgs e)
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
            exportPDF(dataGridView1, "Edificios");
        }
    }
}
