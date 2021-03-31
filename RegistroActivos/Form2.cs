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

namespace RegistroActivos
{
    public partial class Form2 : Form
    {
        CN_Terrenos objectoTerreno = new CN_Terrenos();
        CN_Vehiculo objectovEH = new CN_Vehiculo();
        CN_Edificacion objectoED = new CN_Edificacion();
        CN_Maquinaria objectoMA = new CN_Maquinaria();
        CN_Patentes objectoPA = new CN_Patentes();

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FuncionesCantidad();
        }

        public void FuncionesCantidad()
        {
            cantidadTerrenos();
            cantidadVeh();
            cantidadEdficacion();
            cantidadMaquinaria();
            cantidadPatente();
        }

        public void ValoresActivos()
        {

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

    }
}
