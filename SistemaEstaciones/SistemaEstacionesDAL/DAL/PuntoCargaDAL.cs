using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class PuntoCargaDAL
    {
        private static List<PuntoCarga> puntoCargas = new List<PuntoCarga>();

        public void Add(PuntoCarga pc) //agrega pc
        {
            puntoCargas.Add(pc);
        }

        public List<PuntoCarga> GetAll() //mostrar puntos
        {
            return puntoCargas;
        }

        public void Remove(String idPuntoCarga) //remover punto
        {
            PuntoCarga puntoCarga = puntoCargas.Find(pc => pc.IdPuntoCarga == idPuntoCarga);
            puntoCargas.Remove(puntoCarga);
        }


        public PuntoCarga Update(String idPuntoCarga) //actualizar punto
        {
            return puntoCargas.Find(pc => pc.IdPuntoCarga == idPuntoCarga);
        }

        public List<PuntoCarga> GetAll(int tipo) //filtro
        {
            return puntoCargas.FindAll(pc => pc.Tipo == tipo);
        }




    }
}
