using SistEstacionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEstacionDatos
{
    public class RegionesDAL
    {
        //conexion a BD 
        public BDsistEstacionesEntities dbEntites = new BDsistEstacionesEntities();

        public List<Region> GetAll()
        {
            //retorna todas las regiones existentes
            return dbEntites.Region.ToList(); // == SELECT * FROM REGION
        }

    }
}
