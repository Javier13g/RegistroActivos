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

        public void AgregarEdificios(decimal dimension, double latitud, double longitud,
            float valor, string tipo)
        {
            objectEdificacion.AgregarEdificio(
                dimension,
                latitud,
                longitud,
                valor,
                tipo
                );
        }

        public void EditarEdificios(decimal dimension, double latitud, double longitud,
            float valor, string tipo, int ID_Edificacion)
        {
            objectEdificacion.EditarEdificio(
                dimension,
                longitud,
                valor,
                valor,
                tipo,
                ID_Edificacion
                );
        }

        public void EliminarEdificios(int ID_Edificacion)
        {
            objectEdificacion.EiminarEdificio(
                ID_Edificacion
                );
        }

        public DataTable Cantidad()
        {
            DataTable TablaEdificacion = new DataTable();
            TablaEdificacion = objectEdificacion.Cantidad();
            return TablaEdificacion;
        }

        public DataTable Valor()
        {
            DataTable TablaEdificacion = new DataTable();
            TablaEdificacion = objectEdificacion.Valor();
            return TablaEdificacion;
        }

    }
}
