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
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void ingresarPuntoBtn_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                String idPuntoCarga = idPc.Text.Trim();
                Int32 tipo = Convert.ToInt32(tipoRbl.SelectedValue);
                Int32 CapacidadMax = Convert.ToInt32(capMax.Text.Trim());
                String fechaCaducidad = TextBoxRecibeFecha.Text.Trim();


                PuntoCarga pc = new PuntoCarga();
                pc.IdPuntoCarga = idPuntoCarga;
                pc.Tipo = tipo;
                pc.CapacidadMaxVehiculos = CapacidadMax;
                pc.FechaReemplazo = fechaCaducidad;

                new PuntoCargaDAL().Add(pc);
                alertRegistroPuntos.Text = "Punto de Carga Agregado con exito!";
                limpiarFormulario();
            }
        }

        private void limpiarFormulario()
        {
            idPc.Text = "";
            tipoRbl.SelectedIndex = 0;
            capMax.Text = "";
            TextBoxRecibeFecha.Text = "";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxRecibeFecha.Text = Calendar1.SelectedDate.ToLongDateString();
            Calendar1.Visible = false;
        }

        protected void ImageButtonCalendario_Click(object sender, ImageClickEventArgs e)
        {
            // (IMG) Al hacer Click el calendario se muestra
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }   
        }

    }
}