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
    public partial class AgregarPuntoCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarPuntoBtn_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                String idPuntos = idPc.Text.Trim();
                int tipo = Convert.ToInt32(tipoRbl.SelectedValue);

                int capMax = '0';
                int CapacidadM = Convert.ToInt32(capMax);

                PuntoCarga pc = new PuntoCarga();
                pc.IdPuntoCarga = idPuntos;
                pc.Tipo = tipo;
                pc.CapacidadMaxVehiculos = CapacidadM;

                new PuntoCargaDAL().Add(pc);

                limpiarFormulario();
            }
        }

        private void limpiarFormulario()
        {
            idPc.Text = "";
            tipoRbl.SelectedIndex = 0;
            capMax.Text = "";
        }
    }
}