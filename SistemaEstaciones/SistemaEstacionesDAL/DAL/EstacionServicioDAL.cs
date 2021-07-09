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
                Region = "Región de Arica y Parinacota"
            },
            new EstacionServicio()
            {
                Region = "Región de Tarapacá"
            },
            new EstacionServicio()
            {
                Region = "Región de Antofagasta"
            },
            new EstacionServicio()
            {
                Region = "Región de Atacama"
            },
            new EstacionServicio()
            {
                Region = "Región de Coquimbo"
            },
            new EstacionServicio()
            {
                Region = "Región de Valparaíso"
            },
            new EstacionServicio()
            {
                Region = "Región Metropolitana de Santiago"
            },
            new EstacionServicio()
            {
                Region = "Región del Libertador General Bernardo O’Higgins"
            },
            new EstacionServicio()
            {
                Region = "Región del Maule"
            },
            new EstacionServicio()
            {
                Region = "Región del Ñuble"
            },
            new EstacionServicio()
            {
                Region = "Región del Biobío"
            },
            new EstacionServicio()
            {
                Region = "Región de La Araucanía"
            },
            new EstacionServicio()
            {
                Region = "Región de Los Ríos"
            },
            new EstacionServicio()
            {
                Region = "Región de Los Lagos"
            },
            new EstacionServicio()
            {
                Region = "Región de Aysén del General Carlos Ibáñez del Campo"
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
