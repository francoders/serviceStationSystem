using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public class EstacionServicio
    {
        private Int32 idEstacionServicio;
        private String direccion;
        private String region;
        private Int32 capacidadMax;
        private String horarioAtencion;

        public int IdEstacionServicio { get => idEstacionServicio; set => idEstacionServicio = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Region { get => region; set => region = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
    }
}