using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Patente
    {
        private CD_ConexionRegistro ConexionPatente = new CD_ConexionRegistro();
        SqlDataReader leerPatente;
        DataTable tablaPatentes = new DataTable();
        SqlCommand comandoPatentes = new SqlCommand();

        public DataTable MostrarPatentes()
        {
            comandoPatentes.Connection = ConexionPatente.ConexionAbierta();
            comandoPatentes.CommandText = "MostrarPatente";
            comandoPatentes.CommandType = CommandType.StoredProcedure;
            leerPatente = comandoPatentes.ExecuteReader();
            tablaPatentes.Load(leerPatente);
            ConexionPatente.ConexionCerrada();
            return tablaPatentes;
        }

        public void AgregarPatentes(string nombre, string descripcion, 
            float valor, string tipo)
        {
            comandoPatentes.Connection = ConexionPatente.ConexionAbierta();
            comandoPatentes.CommandText = "AgregaPantentes";
            comandoPatentes.CommandType = CommandType.StoredProcedure;
            comandoPatentes.Parameters.AddWithValue("@nombre", nombre);
            comandoPatentes.Parameters.AddWithValue("@descripcion", descripcion);
            comandoPatentes.Parameters.AddWithValue("@valor", valor);
            comandoPatentes.Parameters.AddWithValue("@tipo", tipo);
            comandoPatentes.ExecuteNonQuery();
        }

        public DataTable Cantidad()
        {
            comandoPatentes.Connection = ConexionPatente.ConexionAbierta();
            comandoPatentes.CommandText = "select count(*) as Cantidad_Patentes from PATENTE";
            leerPatente = comandoPatentes.ExecuteReader();
            tablaPatentes.Load(leerPatente);
            ConexionPatente.ConexionCerrada();
            return tablaPatentes;
        }

        public DataTable Valor()
        {
            comandoPatentes.Connection = ConexionPatente.ConexionAbierta();
            comandoPatentes.CommandText = "SELECT SUM(Valor) AS ValorPatentes FROM PATENTE";
            leerPatente = comandoPatentes.ExecuteReader();
            tablaPatentes.Load(leerPatente);
            ConexionPatente.ConexionCerrada();
            return tablaPatentes;
        }
    }
}
