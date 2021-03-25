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
            comandoMaquinaria.Parameters.Clear();
        }

        public void EditarMaquinaria(string tipoMaquina, float valor, string tipo,
            int ID_Maquinaria )
        {
            comandoMaquinaria.Connection = ConexionMaquinaria.ConexionAbierta();
            comandoMaquinaria.CommandText = "EditarMaquinaria";
            comandoMaquinaria.CommandType = CommandType.StoredProcedure;
            comandoMaquinaria.Parameters.AddWithValue("@tipoM", tipoMaquina);
            comandoMaquinaria.Parameters.AddWithValue("@valor", valor);
            comandoMaquinaria.Parameters.AddWithValue("@tipo", tipo);
            comandoMaquinaria.Parameters.AddWithValue("@id", ID_Maquinaria);
            comandoMaquinaria.ExecuteNonQuery();
            comandoMaquinaria.Parameters.Clear();

        }

        public void EliminarMaquinaria(int ID_Maquinaria)
        {
            comandoMaquinaria.Connection = ConexionMaquinaria.ConexionAbierta();
            comandoMaquinaria.CommandText = "EliminarMaquinaria";
            comandoMaquinaria.CommandType = CommandType.StoredProcedure;
            comandoMaquinaria.Parameters.AddWithValue("@id", ID_Maquinaria);
            comandoMaquinaria.ExecuteNonQuery();
            comandoMaquinaria.Parameters.Clear();

        }
    }
}
