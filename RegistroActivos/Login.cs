using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;


namespace RegistroActivos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        //BOTON QUE CIERRA LOGIN
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //BOTON QUE MINIMIZA LOGIN
        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDA QUE EL CAMPO USUARIO NO ESTE VACIO
                if (txtUsuario.Text != "USUARIO")
                {
                    //VALIDA QUE EL CAMPO CONTRASENA NO ESTE VACIO
                    if (txtContraseña.Text != "CONTRASEÑA")
                    {
                        UserModel usuario = new UserModel();
                        var validarLogin = usuario.LoginUser(txtUsuario.Text, txtContraseña.Text);
                        //SI LOS DATOS DE LOS CAMPOS SON VERDADEROS,INICIARA EL PROGRAMA
                        if (validarLogin == true)
                        {
                            this.Hide();
                            FormBienvenida fm = new FormBienvenida();
                            fm.ShowDialog();
                            FormPrincipal mainmenu = new FormPrincipal();
                            mainmenu.Show();
                            mainmenu.FormClosed += CerrarSesion;
                        }
                        //SI ES FALSO, MARCARA ERROR
                        else
                        {
                            msgError("Usuario o Contraseña incorrecta");
                            txtUsuario.Clear();
                            txtUsuario.Focus();
                        }
                    }
                    //SI EL CAMPO CONTRASENA ESTA VACIO, RETORNA EL AVISO
                    else msgError("Por favor, digite contraseña");
                }
                //SI EL CAMPO USUARIO ESTA VACIO, RETORNA EL AVISO
                else msgError(" Por favor, digite su usuario");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //FUNCION PARA EL MENSAJE DE ERROR
        private void msgError(string msg)
        {
            labelError.Text = "       " + msg;
            labelError.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            labelError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoveryPass = new FormRecovery();
            recoveryPass.ShowDialog();
        }
    }
}
