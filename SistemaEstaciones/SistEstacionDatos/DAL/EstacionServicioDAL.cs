using SistEstacionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEstacionDatos
{
    public class EstacionServicioDAL
    {

        //conexion a BD 
        public BDsistEstacionesEntities dbEntites = new BDsistEstacionesEntities();

        public void Add(Estacionservicio es) //Agregar Estacion
        {
            dbEntites.Estacionservicio.Add(es);
            dbEntites.SaveChanges(); // equivalente a commit para guardar
        }

        public List<Estacionservicio> GetAll() //Mostrar Estacion
        {
            return dbEntites.Estacionservicio.ToList();
        }

        public void Remove(String idEstacionServicio) //Remover Estacion
        {
            Estacionservicio es = dbEntites.Estacionservicio.Find(idEstacionServicio);
            dbEntites.Estacionservicio.Remove(es);
            dbEntites.SaveChanges();
        }

    }
}
