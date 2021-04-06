using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace RegistroActivos
{
    public partial class FormUsuario : Form
    {
        CN_Usuario objectous = new CN_Usuario();
        private string id_usuario = null;
        private bool editar = false;

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            CN_Usuario objecto = new CN_Usuario();
            dataGridView1.DataSource = objecto.MostrarUsuarios();


        }

        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (txtNombreUsuario.Text == "" || txtCorreo.Text == ""
                    || txtContraseña.Text == "" || txtCargo.Text == "")
                {
                    MessageBox.Show("Algun campo esta vacio, revise", "Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        objectous.AgregarUsuarios(
                            txtNombreUsuario.Text,
                            txtContraseña.Text,
                            txtCorreo.Text,
                            txtCargo.Text
                            );
                        MessageBox.Show("Usuario guardado");
                        MostrarUsuarios();
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
                    objectous.EditarUsuarios(
                        txtNombreUsuario.Text,
                        txtContraseña.Text,
                        txtCorreo.Text,
                        txtCargo.Text,
                        Convert.ToInt32(id_usuario.ToString())
                        );
                    MessageBox.Show("Se edito la patente correspondiente al ID "
                        + id_usuario);
                    MostrarUsuarios();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error debido a: " + ex);
                }
            }
        }

        private void btnEditarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtNombreUsuario.Text = dataGridView1.CurrentRow.Cells["Nombre_Usuario"]
                        .Value.ToString();
                    txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"]
                        .Value.ToString();
                    txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"]
                        .Value.ToString();
                    txtCargo.Text = dataGridView1.CurrentRow.Cells["Cargo"]
                        .Value.ToString();
                    id_usuario = dataGridView1.CurrentRow.Cells["ID_Usuario"]
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

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_usuario = dataGridView1.CurrentRow.Cells["ID_Usuario"]
                        .Value.ToString();
                objectous.EliminarUsuarios(Convert.ToInt32(id_usuario.ToString()));
                MessageBox.Show("Usuario eliminado");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("Seleccione usuario");
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true");
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM USUARIOS where Nombre_Usuario like ('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
