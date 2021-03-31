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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        

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
        public void AbrirForms(object formUs) 
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
            Ocultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForms(new INICIAL());

        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormTerrenos());
            Ocultar();
        }

        private void botonVehiculo_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormVehiculos());
            Ocultar();
        }

        private void botonEdificaciones_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormEdificacion());
            Ocultar();
        }

        private void botonPatente_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormPatente());
            Ocultar();
        }

        private void botonMaquinaria_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormMaquinaria());
            Ocultar();
        }

        private void botonAcerdaDe_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAcerdaDe());
            Ocultar();
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAyuda());
            Ocultar();
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
            ValorActivos();

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

        public void ValorActivos()
        {
            ValorTerreno();
            ValorVehiculo();
            ValorEdificios();
            valorMaquinaria();
            valorPatente();
        }

        public void cantidadTerrenos()
        {
            CN_Terrenos objectoTerreno = new CN_Terrenos();
            
            dataGridView1.DataSource = objectoTerreno.Cantidad();
        }

        public void cantidadVeh()
        {
            CN_Vehiculo objectovEH = new CN_Vehiculo();
            dataGridView2.DataSource = objectovEH.Cantidad();
        }

        public void cantidadEdficacion()
        {
            CN_Edificacion objectoED = new CN_Edificacion();
            dataGridView3.DataSource = objectoED.Cantidad();
        }

        public void cantidadMaquinaria()
        {
            CN_Maquinaria objectoMA = new CN_Maquinaria();
            dataGridView5.DataSource = objectoMA.Cantidad();
        }

        public void cantidadPatente()
        {
            CN_Patentes objectoPA = new CN_Patentes();
            dataGridView4.DataSource = objectoPA.Cantidad();
        }

        public void ValorTerreno()
        {
            CN_Terrenos objectoTerrenos = new CN_Terrenos();
            dataGridView10.DataSource = objectoTerrenos.Valor();
        }

        public void ValorVehiculo()
        {
            CN_Vehiculo objectoVE = new CN_Vehiculo();
            dataGridView9.DataSource = objectoVE.Valor();
        }

        public void ValorEdificios()
        {
            CN_Edificacion objectoEDI = new CN_Edificacion();
            dataGridView8.DataSource = objectoEDI.Valor();
        }

        public void valorMaquinaria()
        {
            CN_Maquinaria objectoMAQ = new CN_Maquinaria();
            dataGridView6.DataSource = objectoMAQ.Valor();
        }

        public void valorPatente()
        {
            CN_Patentes objectoPAT = new CN_Patentes();
            dataGridView7.DataSource = objectoPAT.Valor();
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormProfile());
            Ocultar();


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form2());
            Ocultar();
        }

        private void Ocultar()
        {
            labelHora.Visible = false;
            labelFecha.Visible = false;
            LogoRD.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;
            dataGridView10.Visible = false;
        }

       
    }
}
