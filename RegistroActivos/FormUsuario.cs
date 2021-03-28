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
    }
}
