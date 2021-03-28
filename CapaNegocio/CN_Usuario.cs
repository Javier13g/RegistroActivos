using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objectUsu = new CD_Usuario();

        public DataTable MostrarUsuarios()
        {
            DataTable TablaUsuario = new DataTable();
            TablaUsuario = objectUsu.MostrarUsuarios();
            return TablaUsuario;
        }
    }
}

    
