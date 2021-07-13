using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionesDAL.DAL
{
    public class RegionesDAL
    {
        private static List<Region> regiones = new List<Region>()
        {
            new Region()
            {
                NombreRegion = "Región de Arica y Parinacota",
                CodigoRegion = "XV Región"
            },
            new Region()
            {
                NombreRegion = "Región de Tarapacá",
                CodigoRegion = "I Región"
            },
            new Region()
            {
                NombreRegion = "Región de Antofagasta",
                CodigoRegion = "II Región"
            },
            new Region()
            {
                NombreRegion = "Región de Atacama",
                CodigoRegion = "III Región"
            },
            new Region()
            {
                NombreRegion = "Región de Coquimbo",
                CodigoRegion = "IV Región"
            },
            new Region()
            {
                NombreRegion = "Región de Valparaíso",
                CodigoRegion = "V Región"
            },
            new Region()
            {
                NombreRegion = "Región Metropolitana de Santiago",
                CodigoRegion = "RM"
            },
            new Region()
            {
                NombreRegion = "Región del Libertador General Bernardo O’Higgins",
                CodigoRegion = "VI Región"
            },
            new Region()
            {
                NombreRegion = "Región del Maule",
                CodigoRegion = "VII Región"
            },
            new Region()
            {
                NombreRegion = "Región del Biobío",
                CodigoRegion = "VIII Región"
            },
            new Region()
            {
                NombreRegion = "Región de La Araucanía",
                CodigoRegion = "IX Región"
            },
            new Region()
            {
                NombreRegion = "Región de Los Ríos",
                CodigoRegion = "XIV Región"
            },
            new Region()
            {
                NombreRegion = "Región de Los Lagos",
                CodigoRegion = "X Región"
            },
            new Region()
            {
                NombreRegion = "Región de Aysén del General Carlos Ibáñez del Campo",
                CodigoRegion = "XI Región"
            },
            new Region()
            {
                NombreRegion = "Región de Magallanes",
                CodigoRegion = "XII Región"
            },
        };


        public List<Region> GetAll()
        {
            return regiones;
        }

    }
}
