using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traileros
{
    class Variables
    {
        public static string id,Carga,Origen,Destino,Partida,Arribo,Kilo,Peaje,Id,Comision,Viaticos,Vehiculo;
        public static void idx (string ids)
        {
            id = ids;
        }

        public static void carga(string carga, string origen, string destino, string partida, string arribo, string kilo, string peaje)
        {
            Carga = carga;
            Origen = origen;
            Destino = destino;
            Partida = partida;
            Arribo = arribo;
            Kilo = kilo;
            Peaje = peaje;
        }

        public static void operador(string id, string comision, string viaticos)
        {
            Id = id;
            Comision = comision;
            Viaticos = viaticos;
        }

        public static void vehiculo(string vehiculo)
        {
            Vehiculo = vehiculo;
        }

        public static void combustible()
        {

        }
    }
}
