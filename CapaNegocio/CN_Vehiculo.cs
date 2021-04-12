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
    public class CN_Vehiculo
    {
        private CD_Vehiculos objectVehiculos = new CD_Vehiculos();
        public DataTable MostrarVehiculos()
        {
            DataTable TablaVehiculos = new DataTable();
            TablaVehiculos = objectVehiculos.MostrarVehiculos();
            return TablaVehiculos;
        }

        public void AgregarVehiculos(string marca, string modelo,
            string year, string matricula, string tipo, string tipo2, string color,
            string combustible, float valor, string activo)
        {
            objectVehiculos.AgregarVehiculos(
                marca,
                modelo,
                year,
                matricula,
                tipo,
                tipo2,
                color,
                combustible,
                valor,
                activo
                );
        }

        public void EditarVehiculos(string marca, string modelo,
            string year, string matricula, string tipo, string tipo2, string color,
            string combustible, float valor, string activo, int ID_Vehiculo)
        {
            objectVehiculos.EditarVehiculos(
                marca,
                modelo,
                year,
                matricula,
                tipo,
                tipo2,
                color,
                combustible,
                valor,
                activo,
                ID_Vehiculo
                );
        }

        public void EliminarVehiculos(int ID_Vehiculo)
        {
            objectVehiculos.EliminarVehiculos(
                ID_Vehiculo
                );
        }

        public DataTable Cantidad()
        {
            DataTable TablaVehiculos = new DataTable();
            TablaVehiculos = objectVehiculos.Cantidad();
            return TablaVehiculos;
        }

        public DataTable Valor()
        {
            DataTable TablaVehiculos = new DataTable();
            TablaVehiculos = objectVehiculos.Valor();
            return TablaVehiculos;
        }
    }
}
