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

        //provincias

        //comunas


        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
             String idEstacion = idEstacionNumb.Text.Trim();
             String direccion = DireccionTxt.Text.Trim();
             String codigoRegion = regionDdl.SelectedValue;
                        
             int capNumb = '0';
             int capacidadMax = Convert.ToInt32(capNumb);

            string sMensaje = 
                "Se detectaron los siguientes errores:" + "<br>";
            bool bError = false;

            if (string.IsNullOrWhiteSpace(idEstacionNumb.Text))
            {
                sMensaje += "Id vacio" + "<br>";
                bError = true;
            }
            
            if (string.IsNullOrWhiteSpace(DireccionTxt.Text))
            {
                sMensaje += "Direccion vacia" + "<br>";
                bError = true;
            }

            if (capNumb <= '0')
            {
                sMensaje += "la capacidad minima es 1" +
                    "\n";
                bError = true;
            }

            // if (string.IsNullOrWhiteSpace(dateFecha.Text))
            // {
            //    sMensaje += "Fecha vacia\n";
            //    bError = true;
            // }


            if (bError)
            {
                alertIngreso.Text = (sMensaje);
            }
            else
            {
          
                EstacionServicio es = new EstacionServicio();

                es.IdEstacionServicio = idEstacion;
                es.Direccion = direccion;
                es.CodRegion = codigoRegion;
                es.CapacidadMax = capacidadMax;

                new EstacionServicioDAL().Add(es);

                alertIngreso.Text = "Estacion Agregada con exito!";
                limpiarFormulario();
            }
            
        }

        private void onlyNumbers(object sender,EventArgs e)
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