using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_ConexionRegistro ConexionUsuario = new CD_ConexionRegistro();
        SqlDataReader leerUsuario;
        DataTable tablaUsuario = new DataTable();
        SqlCommand comandoUsuario = new SqlCommand();

        public DataTable MostrarUsuarios()
        {
            comandoUsuario.Connection = ConexionUsuario.ConexionAbierta();
            comandoUsuario.CommandText = "MostrarUsuario";
            comandoUsuario.CommandType = CommandType.StoredProcedure;
            leerUsuario = comandoUsuario.ExecuteReader();
            tablaUsuario.Load(leerUsuario);
            ConexionUsuario.ConexionCerrada();
            return tablaUsuario;
        }

        public void AgregarUsuarios(string nombre, string password,
            string correo, string cargo)
        {
            comandoUsuario.Connection = ConexionUsuario.ConexionAbierta();
            comandoUsuario.CommandText = "AgregaUsuarios";
            comandoUsuario.CommandType = CommandType.StoredProcedure;
            comandoUsuario.Parameters.AddWithValue("@nombre", nombre);
            comandoUsuario.Parameters.AddWithValue("@password", password);
            comandoUsuario.Parameters.AddWithValue("@correo", correo);
            comandoUsuario.Parameters.AddWithValue("@cargo", cargo);
            comandoUsuario.ExecuteNonQuery();
            comandoUsuario.Parameters.Clear();
        }

        public void EditarUsuarios(string nombre, string password,
            string correo, string cargo, int id)
        {
            comandoUsuario.Connection = ConexionUsuario.ConexionAbierta();
            comandoUsuario.CommandText = "EditarUsuarios";
            comandoUsuario.CommandType = CommandType.StoredProcedure;
            comandoUsuario.Parameters.AddWithValue("@nombre", nombre);
            comandoUsuario.Parameters.AddWithValue("@password", password);
            comandoUsuario.Parameters.AddWithValue("@correo", correo);
            comandoUsuario.Parameters.AddWithValue("@cargo", cargo);
            comandoUsuario.Parameters.AddWithValue("@id", id);
            comandoUsuario.ExecuteNonQuery();
            comandoUsuario.Parameters.Clear();
        }

        public void EliminarUsuarios(int id)
        {
            comandoUsuario.Connection = ConexionUsuario.ConexionAbierta();
            comandoUsuario.CommandText = "EliminarUsuarios";
            comandoUsuario.CommandType = CommandType.StoredProcedure;
            comandoUsuario.Parameters.AddWithValue("@id", id);
            comandoUsuario.ExecuteNonQuery();
            comandoUsuario.Parameters.Clear();
        }
    }
}
