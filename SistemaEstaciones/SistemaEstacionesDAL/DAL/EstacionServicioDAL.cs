﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL
{
    public class EstacionServicioDAL
    {
        private static List<EstacionServicio> estaciones = new List<EstacionServicio>();

        public void Add(EstacionServicio es) //Agregar Estacion
        {
            estaciones.Add(es);
        }

        public List<EstacionServicio> GetAll() //Mostrar Estacion
        {
            return estaciones;
        }

        public void Remove(int idEstacionServicio) //Remover Estacion
        {
            EstacionServicio estacionServicio = estaciones.Find(es => es.IdEstacionServicio == idEstacionServicio);
            estaciones.Remove(estacionServicio);
        }


        public List<EstacionServicio> GetAll(int idEstacionServicio) //Filtro
        {
            return estaciones.FindAll(es => es.IdEstacionServicio == idEstacionServicio);
        }


    }
}