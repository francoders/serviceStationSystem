using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public class Region
    {
        private String nombreRegion;
        private String codigoRegion;

        public string NombreRegion { get => nombreRegion; set => nombreRegion = value; }
        public string CodigoRegion { get => codigoRegion; set => codigoRegion = value; }
    }
}
