using SistEstacionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class PuntoCargaDAL
    {
        //conexion a BD 
        public BDsistEstacionesEntities dbEntites = new BDsistEstacionesEntities();

        public void Add(Puntocarga pc) //agrega pc
        {
            dbEntites.Puntocarga.Add(pc);
            dbEntites.SaveChanges();
        }

        public List<Puntocarga> GetAll() //mostrar puntos
        {
            return dbEntites.Puntocarga.ToList();
        }

        public void Remove(String idPuntoCarga) //remover punto
        {
            Puntocarga pc = dbEntites.Puntocarga.Find(idPuntoCarga);
            dbEntites.Puntocarga.Remove(pc);
            dbEntites.SaveChanges();
        }


        public Puntocarga Update(String idPuntoCarga) //actualizar punto
        {
            return dbEntites.Puntocarga.Find(idPuntoCarga);
        }

        public List<Puntocarga> GetAll(int tipo) //filtro
        {
            //LINQ generar query personalizada
            //Filtro 
            var query = from p in dbEntites.Puntocarga
                        where p.Tipo == tipo
                        select p;
            return query.ToList();
        }




    }
}
