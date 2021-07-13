using SistemaEstacionesDAL;
using SistemaEstacionesDAL.DAL;
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

        private void CargarTabla(List<PuntoCarga> puntos)
        {
            pcGrid.DataSource = puntos;
            pcGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void puntosGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                string idEliminar = e.CommandArgument.ToString();
                puntoCargaDAL.Remove(idEliminar);
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void tipoDdl_SelectedIndexChange(object sender, EventArgs e)
        {
            int tipoSel = Convert.ToInt32(tipoDdl.SelectedValue);

            List<PuntoCarga> filtrar = puntoCargaDAL.GetAll(tipoSel);
            CargarTabla(filtrar);
        }

        protected void tchx_CheckedChanged(object sender, EventArgs e)
        {
            tipoDdl.Enabled = !tchx.Checked;
            if (tchx.Checked)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }
    }
}