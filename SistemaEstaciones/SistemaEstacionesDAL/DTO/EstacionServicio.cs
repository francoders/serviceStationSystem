using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public class EstacionServicio
    {
        private String idEstacionServicio;
        private String direccion;
        private String codRegion;
        private Int32 capacidadMax;
        private String horarioAtencion;

        //Editar fecha

        public string IdEstacionServicio { get => idEstacionServicio; set => idEstacionServicio = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CodRegion { get => codRegion; set => codRegion = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
    }
}