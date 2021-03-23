using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Edificacion
    {
        private CD_Edificaciones objectEdificacion = new CD_Edificaciones();
        public DataTable MostrarEdificaciones()
        {
            DataTable TablaEdificacion = new DataTable();
            TablaEdificacion = objectEdificacion.MostrarEdificacion();
            return TablaEdificacion;
        }

        public void AgregarEdificios(decimal dimension, float valor, string tipo)
        {
            objectEdificacion.AgregarEdificio(
                dimension,
                valor,
                tipo
                );
        }

    }
}
