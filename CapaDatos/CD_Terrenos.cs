using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Terrenos
    {
        private CD_ConexionRegistro ConexionTerrenos = new CD_ConexionRegistro();
        SqlDataReader leerTerrenos;
        DataTable tablaTerrenos = new DataTable();
        SqlCommand comandoTerrenos = new SqlCommand();

        public DataTable MostrarTerrenos()
        {
            comandoTerrenos.Connection = ConexionTerrenos.ConexionAbierta();
            comandoTerrenos.CommandText = "MostrarTerrenos";
            comandoTerrenos.CommandType = CommandType.StoredProcedure;
            leerTerrenos = comandoTerrenos.ExecuteReader();
            tablaTerrenos.Load(leerTerrenos);
            ConexionTerrenos.ConexionCerrada();
            return tablaTerrenos;
        }

        public void AgregarTerrenos(decimal Dimension, string Matricula,
            string Catastral, decimal Valor, string TipoActivo)
        {
            comandoTerrenos.Connection = ConexionTerrenos.ConexionAbierta();
            comandoTerrenos.CommandText = "AgregarTerreno";
            comandoTerrenos.CommandType = CommandType.StoredProcedure;
            comandoTerrenos.Parameters.AddWithValue("@tamaño", Dimension);
            comandoTerrenos.Parameters.AddWithValue("@matricula", Matricula);
            comandoTerrenos.Parameters.AddWithValue("@catastral", Catastral);
            comandoTerrenos.Parameters.AddWithValue("@valor", Valor);
            comandoTerrenos.Parameters.AddWithValue("@tipo", TipoActivo);
            comandoTerrenos.ExecuteNonQuery();
        }

        public DataTable Cantidad()
        {
            comandoTerrenos.Connection = ConexionTerrenos.ConexionAbierta();
            comandoTerrenos.CommandText = "select count(*) as Cantidad_Terrenos from TERRENOS";
            leerTerrenos = comandoTerrenos.ExecuteReader();
            tablaTerrenos.Load(leerTerrenos);
            ConexionTerrenos.ConexionCerrada();
            return tablaTerrenos;
        }
    }
}
