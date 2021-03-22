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
        //
        public string RecuperarContra(string userRequesting)
        {
            using (var conexionForRecovery = GetConexion())
            {
                conexionForRecovery.Open();
                using (var comandoRecovery = new SqlCommand())
                {
                    comandoRecovery.Connection = conexionForRecovery;
                    comandoRecovery.CommandText = "select * from USUARIOS where Nombre_Usuario=@usuario or Correo=@email";
                    comandoRecovery.Parameters.AddWithValue("@usuario", userRequesting);
                    comandoRecovery.Parameters.AddWithValue("@email", userRequesting);
                    comandoRecovery.CommandType = CommandType.Text;
                    SqlDataReader reader = comandoRecovery.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(3);
                        string password = reader.GetString(2);

                        var mailService = new ServiciosCorreo.SoporteSystem();
                        mailService.sendMail(
                            subject: "Sistema: Pedido de recuperacion de contrasena",
                            body: "Hola, "+userName+ "\n You requested to recover you password.\n"+
                            "your current password is: "+password+
                            "\nCambie su contrasena una vez inicie en el sistema",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hi, " + userName + "\nYou Requested to recover your password.\n" +
                            "\nCambie su contrasena una vez inicie en el sistema";
                    }
                    else
                        return "Sorry, you do not have an account with that mail or username";
                }
            }
        }



        public void AnyMethod()
        {
            if (CacheUsuario.Cargo == Cargos.Administrador)
            {

            }
            if (CacheUsuario.Cargo == Cargos.Empleado)
            {

            }
        }
    }
}
