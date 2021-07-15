using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public partial class PuntoCarga
    {
        public String TipoCarga
        {
            get
            {
                String tipoCarga = "";
                switch (Tipo)
                {
                    case 1: tipoCarga = "Electrico";
                        break;
                    case 2: tipoCarga = "Dual";
                        break;
                }
                return tipoCarga;
            }
        }

    }
}
