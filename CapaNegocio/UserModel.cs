using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UserModel
    {
        DatosUsuarios userDat = new DatosUsuarios();
        public bool LoginUser( string Usuario, string Pass)
        {
            return userDat.Login(Usuario,Pass);
        }
    }
}
