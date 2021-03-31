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
            comandoEdificacion.Parameters.Clear();
        }

        public void EditarEdificio(decimal dimension, float valor, string tipo, int ID_Edificio)
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "EditarEdificios";
            comandoEdificacion.CommandType = CommandType.StoredProcedure;
            comandoEdificacion.Parameters.AddWithValue("@tamaño", dimension);
            comandoEdificacion.Parameters.AddWithValue("@valor", valor);
            comandoEdificacion.Parameters.AddWithValue("@tipo", tipo);
            comandoEdificacion.Parameters.AddWithValue("@id", ID_Edificio);
            comandoEdificacion.ExecuteNonQuery();
            comandoEdificacion.Parameters.Clear();
        }

        public void EiminarEdificio(int ID_Edificio)
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "EliminarEdificacion";
            comandoEdificacion.CommandType = CommandType.StoredProcedure;
            comandoEdificacion.Parameters.AddWithValue("@id", ID_Edificio);
            comandoEdificacion.ExecuteNonQuery();
            comandoEdificacion.Parameters.Clear();
        }

        public DataTable Cantidad()
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "select count(*) as Cantidad_Edificaciones from EDIFICACIONES";
            leerEdificacion = comandoEdificacion.ExecuteReader();
            tablaEdificacion.Load(leerEdificacion);
            ConexionEdificacion.ConexionCerrada();
            return tablaEdificacion;
        }

        public DataTable Valor()
        {
            comandoEdificacion.Connection = ConexionEdificacion.ConexionAbierta();
            comandoEdificacion.CommandText = "SELECT SUM(Valor) AS ValorEdificios FROM EDIFICACIONES";
            leerEdificacion = comandoEdificacion.ExecuteReader();
            tablaEdificacion.Load(leerEdificacion);
            ConexionEdificacion.ConexionCerrada();
            return tablaEdificacion;
        }
    }
}
