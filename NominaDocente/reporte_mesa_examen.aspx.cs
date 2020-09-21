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
    public partial class reporte_mesa_examen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void bus_mesa_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridView();", true);
            ManagerMesaExamen manMesExm = new ManagerMesaExamen();
            ArrayList mesas = new ArrayList();

            int tipoBus = int.Parse(selTipoBus.SelectedValue);
            string fecha = dateFecha.Text;


            mesas = manMesExm.ConsultaMesaExamen(tipoBus,fecha);

            if (mesas.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "vacio", "verGridViewVacio();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridView();", true);
                tbl_rpt_mes_exm.DataSource = mesas;
                tbl_rpt_mes_exm.DataBind();
            }
        }

        


    }
}