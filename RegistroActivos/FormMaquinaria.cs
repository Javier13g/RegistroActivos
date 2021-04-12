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
                if (txtTipoMaquinaria.Text == "" || txtValorMaquinaria.Text == ""
                    || TipoActivoMa.Text == "" || txtMatricula.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Algun campo esta vacio, revise", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        objectoMaqui.AgregarMaquinaria(
                            txtTipoMaquinaria.Text,
                            Convert.ToInt32(txtValorMaquinaria.Text),
                            TipoActivoMa.Text,
                            txtMatricula.Text,
                            txtDescripcion.Text
                            );
                        MessageBox.Show("Maquinaria guardada");
                        MostrarMaquinaria();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error debido a: " + ex);
                    }
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
                        txtMatricula.Text,
                        txtDescripcion.Text,
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
                    txtMatricula.Text = dataGridView1.CurrentRow.Cells["Matricula"]
                        .Value.ToString();
                    txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"]
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
            TipoActivoMa.ResetText();
            txtMatricula.Clear();
        }

        private void txtValorMaquinaria_KeyPress(object sender, KeyPressEventArgs e)
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
            exportPDF(dataGridView1, "Maquinaria");
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true");
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM MAQUINARIA where Tipo_Maquinaria like ('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
