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
using System.Data.SqlClient;

namespace RegistroActivos
{
    public partial class FormPatente : Form
    {
        CN_Patentes objectoPa = new CN_Patentes();
        private string id_patente = null;
        private bool editar = false;

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
            if (editar == false)
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
            if (editar == true)
            {
                try
                {
                    objectoPa.EditarPatentes(
                        txtNombrePatente.Text,
                        txtDescripcionPatente.Text,
                        Convert.ToInt32(txtValorPatente.Text),
                        TipoActivoPa.Text,
                        Convert.ToInt32(id_patente.ToString())
                        );
                    MessageBox.Show("Se edito la patente correspondiente al ID "
                        + id_patente);
                    MostrarPatentes();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
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
            exportPDF(dataGridView1, "Pantentes");
        }

        private void btnEditarPa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtNombrePatente.Text = dataGridView1.CurrentRow.Cells["Nombre"]
                        .Value.ToString();
                    txtDescripcionPatente.Text = dataGridView1.CurrentRow.Cells["Descripción"]
                        .Value.ToString();
                    TipoActivoPa.Text = dataGridView1.CurrentRow.Cells["Tipo_Activo"]
                        .Value.ToString();
                    txtValorPatente.Text = dataGridView1.CurrentRow.Cells["Valor"]
                        .Value.ToString();
                    id_patente = dataGridView1.CurrentRow.Cells["ID_Patente"]
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_patente = dataGridView1.CurrentRow.Cells["ID_Patente"]
                        .Value.ToString();
                objectoPa.EliminarPatentes(Convert.ToInt32(id_patente.ToString()));
                MessageBox.Show("patente eliminado");
                MostrarPatentes();
            }
            else
                MessageBox.Show("Seleccione la patente");
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true");
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PATENTE where Nombre like ('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
