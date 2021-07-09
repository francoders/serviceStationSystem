﻿using SistemaEstacionesDAL;
using SistemaEstacionesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEstacionesWeb.administracion
{
    public partial class VerEstaciones : System.Web.UI.Page
    {
        EstacionServicioDAL estacionServicioDAL = new EstacionServicioDAL();

        private void CargarTabla(List<EstacionServicio> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                String idEliminar = e.CommandArgument.ToString();
                estacionServicioDAL.Remove(idEliminar);
                CargarTabla(estacionServicioDAL.GetAll());
            }

        }
    }
}