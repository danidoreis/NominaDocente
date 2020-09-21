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
    public partial class reporte_curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridView();", true);

            string especilidad = selEsp.Text;
            string curso = selCur.Text;

            ManagerHorarioCurso manHorarioCurso = new ManagerHorarioCurso();
            ArrayList lunes = new ArrayList();
            ArrayList martes = new ArrayList();
            ArrayList miercoles = new ArrayList();
            ArrayList jueves = new ArrayList();
            ArrayList viernes= new ArrayList();

            
            lunes = manHorarioCurso.Lunes();
            martes = manHorarioCurso.Martes(); ;
            miercoles = manHorarioCurso.Miercoles() ;
            jueves = manHorarioCurso.Jueves();
            viernes = manHorarioCurso.Viernes();

            horLunes.DataSource = lunes;
            horMartes.DataSource = martes;
            horMiercoles.DataSource = miercoles;
            horJueves.DataSource = jueves;
            horViernes.DataSource = viernes;

            horLunes.DataBind();
            horMartes.DataBind();
            horMiercoles.DataBind();
            horJueves.DataBind();
            horViernes.DataBind();
           

        }

        public void curso(string esp)
        {
            ManagerCurso manCur = new ManagerCurso();
            ArrayList cursos = new ArrayList();

            cursos = manCur.ConsultaCurso(esp);
            cursos.Insert(0, new Curso("", "Eliga una opcion"));

            

            selCur.DataSource = cursos;
            selCur.DataTextField = "NomCurso";
            selCur.DataValueField = "Id";



            selCur.DataBind();
        }
        protected void cargaCurso(object sender, EventArgs e)
        {
            curso(string.Format(selEsp.SelectedValue));

        }


    }
}