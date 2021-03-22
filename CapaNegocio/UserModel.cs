using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSoporte.Cache;

namespace CapaNegocio
{
    public class UserModel
    {
        DatosUsuarios userDat = new DatosUsuarios();
        public bool LoginUser( string Usuario, string Pass)
        {
            return userDat.Login(Usuario,Pass);
        }
        public string recoveryPass(string userRequesting )
        {
            return userDat.RecuperarContra(userRequesting);
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
