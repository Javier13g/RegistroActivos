using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_ConexionRegistro ConexionUsuario = new CD_ConexionRegistro();
        SqlDataReader leerUsuario;
        DataTable tablaUsuario = new DataTable();
        SqlCommand comandoUsuario = new SqlCommand();

        public DataTable MostrarUsuarios()
        {
            comandoUsuario.Connection = ConexionUsuario.ConexionAbierta();
            comandoUsuario.CommandText = "MostrarUsuario";
            comandoUsuario.CommandType = CommandType.StoredProcedure;
            leerUsuario = comandoUsuario.ExecuteReader();
            tablaUsuario.Load(leerUsuario);
            ConexionUsuario.ConexionCerrada();
            return tablaUsuario;
        }
    }
}
