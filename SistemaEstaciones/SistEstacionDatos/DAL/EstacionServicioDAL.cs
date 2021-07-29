using SistEstacionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class EstacionServicioDAL
    {

        //conexion a BD 
        public BDsistEstacionesEntities dbEntites = new BDsistEstacionesEntities();

        public void Add(EstacionServicio es) //Agregar Estacion
        {
            dbEntites.EstacionServicio.Add(es);
            dbEntites.SaveChanges(); // equivalente a commit para guardar
        }

        public List<EstacionServicio> GetAll() //Mostrar Estacion
        {
            return dbEntites.EstacionServicio.ToList();
        }

        public void Remove(String idEstacionServicio) //Remover Estacion
        {
            EstacionServicio es = dbEntites.EstacionServicio.Find(idEstacionServicio);
            dbEntites.EstacionServicio.Remove(es);
            dbEntites.SaveChanges();
        }

    }
}
