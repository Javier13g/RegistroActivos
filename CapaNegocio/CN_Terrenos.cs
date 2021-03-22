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
    public class CN_Terrenos
    {
        private CD_Terrenos objectTerrenos = new CD_Terrenos();
        public DataTable MostrarTerrenos()
        {
            DataTable TablaTerrenos = new DataTable();
            TablaTerrenos = objectTerrenos.MostrarTerrenos();
            return TablaTerrenos;
        }

        public void AgregarTerrenos(decimal Dimension, string Matricula,
            string Catastral, decimal Valor, string TipoActivo)
        {
            objectTerrenos.AgregarTerrenos(
                Dimension,
                Matricula,
                Catastral,
                Valor,
                TipoActivo
                );
        }
    }
}
