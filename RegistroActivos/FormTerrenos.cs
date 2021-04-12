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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace RegistroActivos
{
    public partial class FormTerrenos : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 18.735693;
        double LogInicial = -70.162651;

        CN_Terrenos objectoTerreno = new CN_Terrenos();
        private string id_Terreno = null;
        private bool editar = false;
        

        public FormTerrenos()
        {
            InitializeComponent();
        }

        private void FormTerrenos_Load(object sender, EventArgs e)
        {
            MostrarTerrenos();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LogInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //MARCADOR
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(
                LatInicial, LogInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            //agregar tooltip
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud" +
                "{0} \n Longitud: {1}",LatInicial, LogInicial);
            gMapControl1.Overlays.Add(markerOverlay);
        }

        
        //METODO QUE MUESTRA LOS TERRENOS DE LA DB
        private void MostrarTerrenos()
        {
            CN_Terrenos objecto = new CN_Terrenos();
            dataGridView1.DataSource = objecto.MostrarTerrenos();

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


        private void AlertSoloNumeros()
        {
            MessageBox.Show("No es permitido el uso de letras");
        }

        private void AlertSoloLetras()
        {
            MessageBox.Show("No es permitido el uso de numeros");
        }

        //EVENTOS PARA VALIDAR LETRAS O NUMEROS
        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,text));
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

            if(savefiledialoge.ShowDialog() == DialogResult.OK)
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
            exportPDF(dataGridView1, "terrenos");
        }

       

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           /* try
            {
                Matricula = int.Parse(txtBuscar.Text);
                dataGridView1.DataSource = obj.Buscar(Matricula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debido a:  " + ex);
            }*/
        }

        private void btnGuardarTerrenos_Click_1(object sender, EventArgs e)
        {
            //SI EDITAR ES FALSO, GUARDA DE MANERA NORMAL
            if (editar == false)
            {
                if (txtDimension.Text == "" || txtMatricula.Text == "" || txtDesignacion.Text == ""
                    || txtValor.Text == "" || comboBoxTipo.Text == "" || txtLatitud.Text == ""
                    || txtLongitud.Text == "" || txtProvincia.Text == "")
                {
                    MessageBox.Show("Algun campo esta vacio, revise", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        objectoTerreno.AgregarTerrenos(
                            Convert.ToDecimal(txtDimension.Text),
                            txtMatricula.Text,
                            txtDesignacion.Text,
                            Convert.ToDouble(txtLatitud.Text),
                            Convert.ToDouble(txtLongitud.Text),
                            txtProvincia.Text,
                            Convert.ToDecimal(txtValor.Text),
                            comboBoxTipo.Text
                            );
                        MessageBox.Show("Terreno guardado");
                        MostrarTerrenos();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error debido a: " + ex);
                    }
                }
            }

            //SI EDITAR ES VERDADERO, EDITA EL TERRENO CORRESPONDIENTE
            if (editar == true)
            {
                try
                {
                    objectoTerreno.EditarTerrenos(
                        Convert.ToDecimal(txtDimension.Text),
                        txtMatricula.Text,
                        txtDesignacion.Text,
                        Convert.ToDouble(txtLatitud.Text),
                        Convert.ToDouble(txtLongitud.Text),
                        txtProvincia.Text,
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

        private void btnEditarTer_Click_1(object sender, EventArgs e)
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
                    txtLatitud.Text = dataGridView1.CurrentRow.Cells["Latitud"]
                        .Value.ToString();
                    txtLongitud.Text = dataGridView1.CurrentRow.Cells["Longitud"]
                        .Value.ToString();
                    txtProvincia.Text = dataGridView1.CurrentRow.Cells["Provincia"]
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

        private void btnEliminarTe_Click_1(object sender, EventArgs e)
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

        SqlConnection con = new SqlConnection("Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true");
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TERRENOS where Matricula_Titulo like ('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void SeleccionarUbicacion(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                filaSeleccionada = e.RowIndex;

                txtMatricula.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();
                txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[4].Value.ToString();
                txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[5].Value.ToString();
                marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text),
                    Convert.ToDouble(txtLongitud.Text));

                gMapControl1.Position = marker.Position;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error debido a "+ex);
            }
        }
    }
}
