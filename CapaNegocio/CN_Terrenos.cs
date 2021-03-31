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

        public void EditarTerrenos(decimal Dimension, string Matricula,
            string Catastral, decimal Valor, string TipoActivo, int ID_Terreno)
        {
            objectTerrenos.EditarTerrenos(
                Dimension,
                Matricula,
                Catastral,
                Valor,
                TipoActivo,
                ID_Terreno
                );
        }

        public void EliminarTerrenos(int ID_Terreno)
        {
            objectTerrenos.EliminarTerrenos(
                ID_Terreno
                );
        }

        public DataTable Cantidad()
        {
            DataTable TablaTerrenos = new DataTable();
            TablaTerrenos = objectTerrenos.Cantidad();
            return TablaTerrenos;
        }

        public DataTable Valor()
        {
            DataTable TablaTerrenos = new DataTable();
            TablaTerrenos = objectTerrenos.Valor();
            return TablaTerrenos;
        }

    }
}
