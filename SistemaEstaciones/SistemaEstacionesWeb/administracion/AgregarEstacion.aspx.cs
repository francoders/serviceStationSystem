using SistemaEstacionesDAL;
using SistemaEstacionesDAL.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEstacionesWeb.administracion
{
    public partial class AgregarEstacion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Region> regiones = new RegionesDAL().GetAll();
                regionDdl.DataSource = regiones;
                //rellena la lista regiones
                regionDdl.DataTextField = "NombreRegion";
                // <option> .... </option>
                regionDdl.DataValueField = "CodigoRegion";
                // <option value='1'> .... </option>
                regionDdl.DataBind();
            }

        }


        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            String idEstacion = idEstacionNumb.Text.Trim();
            String direccion = DireccionTxt.Text.Trim();
            String codigoRegion = regionDdl.SelectedValue;
            Int32 capacidadMax = Convert.ToInt32(capNumb.Text);
            
            EstacionServicio es = new EstacionServicio();

            es.IdEstacionServicio = idEstacion;
            es.Direccion = direccion;
            es.CodRegion = codigoRegion;
            es.CapacidadMax = capacidadMax;

            new EstacionServicioDAL().Add(es);

            alertIngreso.Text = "Estacion Agregada con exito!";
            limpiarFormulario();

        }

        private void onlyNumbers(object sender,EventArgs e)
        {
            //valida solo numeros
            if (System.Text.RegularExpressions.Regex.IsMatch(idEstacionNumb.Text,"[0-1000]"))
            {
                
            }
        }

        private void limpiarFormulario()
        {
            idEstacionNumb.Text = " ";
            DireccionTxt.Text = " ";
            capNumb.Text = " ";
        }

    }
}