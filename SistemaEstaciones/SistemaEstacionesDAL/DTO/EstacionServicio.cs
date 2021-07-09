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

        private String region;
        private String codRegion;
        private String Provincia;
        private String codProvin;
        private String Comuna;
        private String codComuna;

        private int capacidadMax;
        private String horarioAtencion;

        public String IdEstacionServicio { get => idEstacionServicio; set => idEstacionServicio = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Region { get => region; set => region = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
        public string CodRegion { get => codRegion; set => codRegion = value; }
        public string Provincia1 { get => Provincia; set => Provincia = value; }
        public string CodProvin { get => codProvin; set => codProvin = value; }
        public string Comuna1 { get => Comuna; set => Comuna = value; }
        public string CodComuna { get => codComuna; set => codComuna = value; }
    }
}