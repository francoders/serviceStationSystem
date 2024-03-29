﻿
using SistEstacionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEstacionesWeb.administracion
{
    public partial class VerPuntoCargas : System.Web.UI.Page
    {
        PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();

        private void CargarTabla(List<Puntocarga> puntoCargas)
        {
            pcGrid.DataSource = puntoCargas;
            pcGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void puntoCargasGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                string idPuntoCarga = e.CommandArgument.ToString();
                puntoCargaDAL.Remove(idPuntoCarga);
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void tipoDdl_SelectedIndexChange(object sender, EventArgs e)
        {
            String tipoSel = tipoDdl.SelectedValue;

            List<Puntocarga> filtrar = puntoCargaDAL.GetAll(tipoSel);
            CargarTabla(filtrar);
        }

        protected void TiposCheckedChanged(object sender, EventArgs e)
        {
            tipoDdl.Enabled = !tchx.Checked;
            if (tchx.Checked)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void actualizarBtn_Click(object sender, EventArgs e)
        {
                Response.Redirect("AgregarPuntoCarga.aspx");
        }

    }
}