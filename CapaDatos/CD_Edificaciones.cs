using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Edificaciones
    {
        private CD_ConexionRegistro ConexionEdificacion = new CD_ConexionRegistro();
        SqlDataReader leerEdificacion;
        DataTable tablaEdificacion = new DataTable();
        SqlCommand comandoEdificacion = new SqlCommand();

        public DataTable MostrarEdificacion()
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "MostrarEdificacion";
            comandoEdificacion.CommandType = CommandType.StoredProcedure;
            leerEdificacion = comandoEdificacion.ExecuteReader();
            tablaEdificacion.Load(leerEdificacion);
            ConexionEdificacion.ConexionCerrada();
            return tablaEdificacion;
        }

        public void AgregarEdificio(decimal dimension, float valor, string tipo)
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "AgregarEdificacion";
            comandoEdificacion.CommandType = CommandType.StoredProcedure;
            comandoEdificacion.Parameters.AddWithValue("@tamaño", dimension);
            comandoEdificacion.Parameters.AddWithValue("@valor", valor);
            comandoEdificacion.Parameters.AddWithValue("@tipo", tipo);
            comandoEdificacion.ExecuteNonQuery();
        }
    }
}
