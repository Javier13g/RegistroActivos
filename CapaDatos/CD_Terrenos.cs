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
            comandoTerrenos.Parameters.Clear();
        }

        public void EditarTerrenos(decimal Dimension, string Matricula,
            string Catastral, decimal Valor, string TipoActivo, int ID_Terreno)
        {
            comandoTerrenos.Connection = ConexionTerrenos.ConexionAbierta();
            comandoTerrenos.CommandText = "EditarTerreno";
            comandoTerrenos.CommandType = CommandType.StoredProcedure;
            comandoTerrenos.Parameters.AddWithValue("@tamaño", Dimension);
            comandoTerrenos.Parameters.AddWithValue("@matricula", Matricula);
            comandoTerrenos.Parameters.AddWithValue("@catastral", Catastral);
            comandoTerrenos.Parameters.AddWithValue("@valor", Valor);
            comandoTerrenos.Parameters.AddWithValue("@tipo", TipoActivo);
            comandoTerrenos.Parameters.AddWithValue("@id", ID_Terreno);
            comandoTerrenos.ExecuteNonQuery();
            comandoTerrenos.Parameters.Clear();
        }

        public void EliminarTerrenos(int ID_Terreno)
        {
            comandoTerrenos.Connection = ConexionTerrenos.ConexionAbierta();
            comandoTerrenos.CommandText = "EliminarTerreno";
            comandoTerrenos.CommandType = CommandType.StoredProcedure;
            comandoTerrenos.Parameters.AddWithValue("@id", ID_Terreno);
            comandoTerrenos.ExecuteNonQuery();
            comandoTerrenos.Parameters.Clear();
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
