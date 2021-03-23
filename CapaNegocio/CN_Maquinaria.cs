﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Maquinaria
    {
        private CD_Maquinaria objectMaquinaria = new CD_Maquinaria();

        public DataTable MostrarMaquinaria()
        {
            DataTable TablaMaquinaria = new DataTable();
            TablaMaquinaria = objectMaquinaria.MostrarEdificacion();
            return TablaMaquinaria;
        }

        public void AgregarMaquinaria(string tipoMaquina, float valor, string tipo)
        {
            objectMaquinaria.AgregarMaquinaria(
                tipoMaquina,
                valor,
                tipo
                );
        }
    }
}
