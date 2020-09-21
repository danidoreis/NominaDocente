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
    public partial class reporte_docente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            string nombre = "'"+txtNombre.Value+"'";
            string apellido = "'"+txtApellido.Value+"'";
            string especialidad = "'"+selEsp.Text+"'";
            string curso = selCur.Text;
            string materia = selMat.Text;

            ManagerDocente managerDocente = new ManagerDocente();
            ArrayList docentesConCH = new ArrayList();

            if(txtApellido.Value==""){
                apellido="null";
            }
            if(selEsp.Text==""){
                especialidad="null";
            }
            if(selCur.Text==""){
                curso="null";
            }
            if(selMat.Text==""){
                materia = "null";
            }

            docentesConCH = managerDocente.ConsultaDocenteConCH(nombre, apellido, especialidad, curso, materia);

            if (docentesConCH.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridViewVacio();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "verGridView();", true);

                resConsConCH.DataSource = docentesConCH;
                resConsConCH.DataBind();
            }
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
        public void materia(int curso)
        {
            ManagerMateria managerMateria = new ManagerMateria();
            ArrayList materias = new ArrayList();

            materias = managerMateria.ConsultaMateria(curso);
            materias.Insert(0, new Materia("", "Eliga una opcion"));

            selMat.DataSource = materias;
            selMat.DataTextField = "nombreMateria";
            selMat.DataValueField = "id";

            selMat.DataBind();
        }
        protected void cargaMateria(object sender, EventArgs e)
        {

            materia(int.Parse(selCur.SelectedValue));
        }
    }
}