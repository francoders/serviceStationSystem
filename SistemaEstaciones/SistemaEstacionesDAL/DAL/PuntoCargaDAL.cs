using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class PuntoCargaDAL
    {
        private static List<PuntoCarga> puntos = new List<PuntoCarga>();

        public void Add(PuntoCarga pc) //agrega pc
        {
            puntos.Add(pc);
        }

        public List<PuntoCarga> GetAll() //mostrar puntos
        {
            return puntos;
        }

        public void Remove(String idPuntoCarga) //remover punto
        {
            PuntoCarga puntoCarga = puntos.Find(pc => pc.IdPuntoCarga == idPuntoCarga);
            puntos.Remove(puntoCarga);
        }

        public void Update(String idPuntoCarga) //actualizar punto
        {

        }

        public List<PuntoCarga> GetAll(int tipo) //filtro
        {
            return puntos.FindAll(pc => pc.Tipo == tipo);
        }
    }
}
