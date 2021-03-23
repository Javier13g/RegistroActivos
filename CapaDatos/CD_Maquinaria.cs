using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Maquinaria
    {
        private CD_ConexionRegistro ConexionMaquinaria = new CD_ConexionRegistro();
        SqlDataReader leerMaquinaria;
        DataTable tablaMaquinaria = new DataTable();
        SqlCommand comandoMaquinaria = new SqlCommand();

        public DataTable MostrarEdificacion()
        {
            comandoMaquinaria.Connection = ConexionMaquinaria.ConexionAbierta();
            comandoMaquinaria.CommandText = "MostrarMaquinaria";
            comandoMaquinaria.CommandType = CommandType.StoredProcedure;
            leerMaquinaria = comandoMaquinaria.ExecuteReader();
            tablaMaquinaria.Load(leerMaquinaria);
            ConexionMaquinaria.ConexionCerrada();
            return tablaMaquinaria;
        }

        public void AgregarMaquinaria(string tipoMaquina, float valor, string tipo)
        {
            comandoMaquinaria.Connection = ConexionMaquinaria.ConexionAbierta();
            comandoMaquinaria.CommandText = "AgregaMaquinaria";
            comandoMaquinaria.CommandType = CommandType.StoredProcedure;
            comandoMaquinaria.Parameters.AddWithValue("@tipoM", tipoMaquina);
            comandoMaquinaria.Parameters.AddWithValue("@valor", valor);
            comandoMaquinaria.Parameters.AddWithValue("@tipo", tipo);
            comandoMaquinaria.ExecuteNonQuery();
        }
    }
}
