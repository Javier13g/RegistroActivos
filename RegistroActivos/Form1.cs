using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;
using CapaNegocio;

namespace RegistroActivos
{
    public partial class FormPrincipal : Form
    {
        CN_Vehiculos objectoTerreno = new CN_Vehiculos();
        CN_Vehiculo objectovEH = new CN_Vehiculo();
        CN_Edificacion objectoED = new CN_Edificacion();
        CN_Maquinaria objectoMA = new CN_Maquinaria();
        CN_Patentes objectoPA = new CN_Patentes();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de salir?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void BotonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotonMaximizar.Visible = false;
            BotonRestaurar.Visible = true;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotonMaximizar.Visible = true;
            BotonRestaurar.Visible = false;
        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //FUNCION QUE ABRE FORMS 
        private void AbrirForms(object formUs) 
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formUs as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void botonUsuario_Click(object sender, EventArgs e)
        {
            //LLAMADA DE LA FUNCION AbrirFormUsuario
            AbrirForms(new FormUsuario()); 
            labelHora.Visible = false;
            labelFecha.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForms(new INICIAL());
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormTerrenos());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonVehiculo_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormVehiculos());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonEdificaciones_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormEdificacion());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonPatente_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormPatente());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonMaquinaria_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormMaquinaria());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonAcerdaDe_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAcerdaDe());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAyuda());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Estas seguro de cerrar sesion?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        

        private void CargarDatosUsuario()
        {
            labelNombre.Text = CacheUsuario.Nombre;
            labelCorreo.Text = CacheUsuario.Correo;
            labelCargo.Text = CacheUsuario.Cargo;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            FuncionesCantidad();

            //MANEJAR CARGOS

            if (CacheUsuario.Cargo == Cargos.Empleado)
            {
                botonUsuario.Enabled = false;
            }
            
        }

        public void FuncionesCantidad()
        {
            cantidadTerrenos();
            cantidadVeh();
            cantidadEdficacion();
            cantidadMaquinaria();
            cantidadPatente();
        }

        public void cantidadTerrenos()
        {
            dataGridView1.DataSource = objectoTerreno.Cantidad();
        }

        public void cantidadVeh()
        {
            dataGridView2.DataSource = objectovEH.Cantidad();
        }

        public void cantidadEdficacion()
        {
            dataGridView3.DataSource = objectoED.Cantidad();
        }

        public void cantidadMaquinaria()
        {
            dataGridView5.DataSource = objectoMA.Cantidad();
        }

        public void cantidadPatente()
        {
            dataGridView4.DataSource = objectoPA.Cantidad();
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormProfile());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form2());
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }
    }
}
