using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public partial class PuntoCarga
    {
        private Int32 idPuntoCarga; //IdentificadorUnico
        private Int32 tipo; //Electrico o Dual
        private Int32 capacidadMaxVehiculos;
        private String estadoSensores; //Vida Util / estado actual

        public int IdPuntoCarga { get => idPuntoCarga; set => idPuntoCarga = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMaxVehiculos { get => capacidadMaxVehiculos; set => capacidadMaxVehiculos = value; }
        public string EstadoSensores { get => estadoSensores; set => estadoSensores = value; }
    }
}
