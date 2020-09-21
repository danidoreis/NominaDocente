using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NominaDocente.Entidades;
using NominaDocente.BLL;
using System.Collections;

namespace NominaDocente
{
    public partial class cons_docente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            string nombre = "'"+txtNombre.Value+"'";
            string apellido = "'"+txtApellido.Value+"'";
            string dni = "'"+txtDni.Value+"'";

            ManagerDocente managerDocente = new ManagerDocente();
            ArrayList docentesSinCH = new ArrayList();

            if (txtApellido.Value == "")
            {
                apellido = "null";
            }
            if(txtDni.Value==""){
                dni = "null";
            }

            docentesSinCH = managerDocente.ConsultaDocenteSinCH(nombre, apellido, dni);

            if (docentesSinCH.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridViewVacio();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridView();", true);

                resConsSinCH.DataSource = docentesSinCH;
                resConsSinCH.DataBind();
            }
        }

    }
}