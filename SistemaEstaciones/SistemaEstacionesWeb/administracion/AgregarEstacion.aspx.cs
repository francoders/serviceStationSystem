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
    public partial class AgregarEstacion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<EstacionServicio> estaciones = new EstacionServicioDAL().GetAll();
                regionDdl.DataSource = estaciones;
                regionDdl.DataTextField = "Region";
                regionDdl.DataBind();
            }

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                String idEstacion = idEstacionNumb.Text.Trim();
                String direccion = DireccionTxt.Text.Trim();
                String region = regionDdl.Text;

                int capNumb = '0';
                int capacidadMax = Convert.ToInt32(capNumb);
            

            EstacionServicio es = new EstacionServicio();

            es.IdEstacionServicio = idEstacion;
            es.Direccion = direccion;
            es.Region = region;
            es.CapacidadMax = capacidadMax;

            new EstacionServicioDAL().Add(es);

            alertIngreso.Text = "Estacion Agregada con exito!";
            limpiarFormulario();
                
            }
          

        }

        private void onlyNumbers(object sender, ConsoleKey e)
        {
            //valida solo numeros
            if (System.Text.RegularExpressions.Regex.IsMatch(idEstacionNumb.Text,"[0-1000]"))
            {
                idEstacionNumb.Text = "";
            }
        }

        private void limpiarFormulario()
        {
            idEstacionNumb.Text = " ";
            DireccionTxt.Text = " ";

        }

    }
}