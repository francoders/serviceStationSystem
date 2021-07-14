using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public partial class PuntoCarga
    {
        private String idPuntoCarga; //IdentificadorUnico
        private Int32 tipo; //Electrico o Dual
        private Int32 capacidadMaxVehiculos;
        private String fechaReemplazo; //Vida Util

        public string IdPuntoCarga { get => idPuntoCarga; set => idPuntoCarga = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMaxVehiculos { get => capacidadMaxVehiculos; set => capacidadMaxVehiculos = value; }
        public string FechaReemplazo { get => fechaReemplazo; set => fechaReemplazo = value; }
    }
}
