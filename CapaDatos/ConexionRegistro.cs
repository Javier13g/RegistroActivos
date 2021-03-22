using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CD_ConexionRegistro
    {
        private SqlConnection ConexionSQL = new SqlConnection("Server=DESKTOP-ABURFAM; DataBase= RegistroActivos; integrated security= true");

        public SqlConnection ConexionAbierta()
        {
            if (ConexionSQL.State == ConnectionState.Closed)
                ConexionSQL.Open();
            return ConexionSQL;
        }

        public SqlConnection ConexionCerrada()
        {
            if (ConexionSQL.State == ConnectionState.Open)
                ConexionSQL.Close();
            return ConexionSQL;
        }

    }
}
