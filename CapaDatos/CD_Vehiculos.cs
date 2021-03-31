using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Vehiculos
    {
        private CD_ConexionRegistro ConexionVehiculos = new CD_ConexionRegistro();
        SqlDataReader leerVehiculos;
        DataTable tablaVehiculos = new DataTable();
        SqlCommand comandoVehiculos = new SqlCommand();

        public DataTable MostrarVehiculos()
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "MostrarVehiculos";
            comandoVehiculos.CommandType = CommandType.StoredProcedure;
            leerVehiculos = comandoVehiculos.ExecuteReader();
            tablaVehiculos.Load(leerVehiculos);
            ConexionVehiculos.ConexionCerrada();
            return tablaVehiculos;
        }

        public void AgregarVehiculos(string marca, string modelo,
            string year, string tipo, string combustible, float valor, string activo)
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "AgregarVehiculos";
            comandoVehiculos.CommandType = CommandType.StoredProcedure;
            comandoVehiculos.Parameters.AddWithValue("@marca", marca);
            comandoVehiculos.Parameters.AddWithValue("@modelo", modelo);
            comandoVehiculos.Parameters.AddWithValue("@year", year);
            comandoVehiculos.Parameters.AddWithValue("@tipo", tipo);
            comandoVehiculos.Parameters.AddWithValue("@combustible", combustible);
            comandoVehiculos.Parameters.AddWithValue("@valor", valor);
            comandoVehiculos.Parameters.AddWithValue("@tipoActivo", activo);
            comandoVehiculos.ExecuteNonQuery();
            comandoVehiculos.Parameters.Clear();
        }

        public void EditarVehiculos(string marca, string modelo,
            string year, string tipo, string combustible, float valor, string activo,
            int ID_Vehiculo)
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "EditarVehiculos";
            comandoVehiculos.CommandType = CommandType.StoredProcedure;
            comandoVehiculos.Parameters.AddWithValue("@marca", marca);
            comandoVehiculos.Parameters.AddWithValue("@modelo", modelo);
            comandoVehiculos.Parameters.AddWithValue("@year", year);
            comandoVehiculos.Parameters.AddWithValue("@tipo", tipo);
            comandoVehiculos.Parameters.AddWithValue("@combustible", combustible);
            comandoVehiculos.Parameters.AddWithValue("@valor", valor);
            comandoVehiculos.Parameters.AddWithValue("@tipoActivo", activo);
            comandoVehiculos.Parameters.AddWithValue("@id", ID_Vehiculo);
            comandoVehiculos.ExecuteNonQuery();
            comandoVehiculos.Parameters.Clear();
        }

        public void EliminarVehiculos(int ID_Vehiculo)
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "EliminarVehiculo";
            comandoVehiculos.CommandType = CommandType.StoredProcedure;
            comandoVehiculos.Parameters.AddWithValue("@id", ID_Vehiculo);
            comandoVehiculos.ExecuteNonQuery();
            comandoVehiculos.Parameters.Clear();
        }

        public DataTable Cantidad()
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "select count(*) as Cantidad_Vehiculos from VEHICULOS";
            leerVehiculos = comandoVehiculos.ExecuteReader();
            tablaVehiculos.Load(leerVehiculos);
            ConexionVehiculos.ConexionCerrada();
            return tablaVehiculos;
        }

        public DataTable Valor()
        {
            comandoVehiculos.Connection = ConexionVehiculos.ConexionAbierta();
            comandoVehiculos.CommandText = "SELECT SUM(Valor) AS ValorVehiculos FROM VEHICULOS";
            leerVehiculos = comandoVehiculos.ExecuteReader();
            tablaVehiculos.Load(leerVehiculos);
            ConexionVehiculos.ConexionCerrada();
            return tablaVehiculos;
        }

    }
}
