using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaSoporte.Cache;

namespace CapaDatos
{
    public class DatosUsuarios:Conexion
    {
        public bool Login(string Usuario, string Pass)
        {
            using (var conexion = GetConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from USUARIOS where Nombre_Usuario=@usuario and Contraseña=@contraseña";
                    comando.Parameters.AddWithValue("@usuario", Usuario);
                    comando.Parameters.AddWithValue("@contraseña", Pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IdUsuario = reader.GetInt32(0);
                            CacheUsuario.Nombre = reader.GetString(1);
                            CacheUsuario.Correo = reader.GetString(3);
                            CacheUsuario.Cargo = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
    }
}
