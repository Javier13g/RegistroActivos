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
        //ATRIBUTOS
        private int idUser;
        private string username;
        private string contra;
        private string mail;

        public string editarProfile()
        {
            try
            {
                userDat.editarPerfil(idUser, username, contra, mail);
                LoginUser(username, contra);
                return "Perfil actualizado";
            }
            catch (Exception ex)
            {
                return "Nombre de usuario existente, intente con otro";
            }
        }

        DatosUsuarios userDat = new DatosUsuarios();

        public UserModel(int idUser, string username, string contra, string mail)
        {
            this.idUser = idUser;
            this.username = username;
            this.contra = contra;
            this.mail = mail;
        }

        public UserModel()
        {

        }

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
