using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;
using CapaNegocio;


namespace RegistroActivos
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            initializePassEdit();
        }

        private void CargarDatosUsuario()
        {
            labelNombre.Text = CacheUsuario.Nombre;
            labelCorreo.Text = CacheUsuario.Correo;
            labelPosicion.Text = CacheUsuario.Cargo;

            //panelEditar
            txtUser.Text = CacheUsuario.Nombre;
            txtEmail.Text = CacheUsuario.Correo;
            txtPass.Text = CacheUsuario.Password;
            txtConfirmarPass.Text = CacheUsuario.Password;
            txtPassActual.Text = "";

        }

        private void initializePassEdit()
        {
            linkEditPass.Text = "Edit";
            txtPass.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
            txtConfirmarPass.Enabled = false;
            txtConfirmarPass.UseSystemPasswordChar = true;
        }

        private void reset()
        {
            CargarDatosUsuario();
            initializePassEdit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            CargarDatosUsuario();
        }

        private void linkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkEditPass.Text == "Edit")
            {
                linkEditPass.Text = "Cancel";
                txtPass.Enabled = true;
                txtPass.Text = "";
                txtConfirmarPass.Enabled = true;
                txtConfirmarPass.Text = "";
            }
            else if( linkEditPass.Text == "Cancel")
            {
                reset();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConfirmarPass.Text)
            {
                if (txtPassActual.Text == CacheUsuario.Password)
                {
                    var userModel = new UserModel(idUser: CacheUsuario.IdUsuario,
                        username: txtUser.Text,
                        contra: txtPass.Text,
                        mail: txtEmail.Text);
                    var result = userModel.editarProfile();
                    MessageBox.Show(result);
                    reset();
                    panel1.Visible = false;
                }
            }
            else
                MessageBox.Show("Las contraseñas no coinciden");
        }
    }
}
