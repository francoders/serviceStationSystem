using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class EstacionServicioDAL
    {

        private static List<EstacionServicio> estaciones = new List<EstacionServicio>()
        {
            new EstacionServicio()
            {
                Region = "Región de Arica y Parinacota",
                CodRegion = "Re-01"
            },
            new EstacionServicio()
            {
                Region = "Región de Tarapacá",
                CodRegion = "Re-02"
            },
            new EstacionServicio()
            {
                Region = "Región de Antofagasta",
                CodRegion = "Re-03"
            },
            new EstacionServicio()
            {
                Region = "Región de Atacama",
                CodRegion = "Re-04"
            },
            new EstacionServicio()
            {
                Region = "Región de Coquimbo",
                CodRegion = "Re-05"
            },
            new EstacionServicio()
            {
                Region = "Región de Valparaíso",
                CodRegion = "Re-06"
            },
            new EstacionServicio()
            {
                Region = "Región Metropolitana de Santiago",
                CodRegion = "Re-07"
            },
            new EstacionServicio()
            {
                Region = "Región del Libertador General Bernardo O’Higgins",
                CodRegion = "Re-08"
            },
            new EstacionServicio()
            {
                Region = "Región del Maule",
                CodRegion = "Re-09"
            },
            new EstacionServicio()
            {
                Region = "Región del Ñuble",
                CodRegion = "Re-10"
            },
            new EstacionServicio()
            {
                Region = "Región del Biobío",
                CodRegion = "Re-11"
            },
            new EstacionServicio()
            {
                Region = "Región de La Araucanía",
                CodRegion = "Re-12"
            },
            new EstacionServicio()
            {
                Region = "Región de Los Ríos",
                CodRegion = "Re-13"
            },
            new EstacionServicio()
            {
                Region = "Región de Los Lagos",
                CodRegion = "Re-14"
            },
            new EstacionServicio()
            {
                Region = "Región de Aysén del General Carlos Ibáñez del Campo",
                CodRegion = "Re-15"
            },
        };

        public void Add(EstacionServicio es) //Agregar Estacion
        {
            estaciones.Add(es);
        }

        public List<EstacionServicio> GetAll() //Mostrar Estacion
        {
            return estaciones;
        }

        public void Remove(String idEstacionServicio) //Remover Estacion
        {
            EstacionServicio estacionServicio = estaciones.Find(es => es.IdEstacionServicio == idEstacionServicio);
            estaciones.Remove(estacionServicio);
        }


        public List<EstacionServicio> GetAll(String idEstacionServicio) //Filtro
        {
            return estaciones.FindAll(es => es.IdEstacionServicio == idEstacionServicio);
        }

    }
}
