using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Patentes
    {
        private CD_Patente objectPatentes = new CD_Patente();

        public DataTable MostrarPatentes()
        {
            DataTable TablaPatentes = new DataTable();
            TablaPatentes = objectPatentes.MostrarPatentes();
            return TablaPatentes;
        }

        public void AgregarPatentes(string nombre, string descripcion,
            float valor, string tipo)
        {
            objectPatentes.AgregarPatentes(
                nombre,
                descripcion,
                valor,
                tipo
                );
        }
    }
}
