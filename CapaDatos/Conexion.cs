using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string conexionString;
        public Conexion()
        {
            conexionString = "Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true";
        }
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(conexionString);
        }
    }
}
