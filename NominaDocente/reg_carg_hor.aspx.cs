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
    public partial class reg_materia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 

            foreach (GridViewRow row in resConsSinCH.Rows)
            {
                RadioButton box = (RadioButton)row.Cells[0].FindControl("dniDoc");
                if (box.Checked)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "quitarRequiredTabla", "quitarRequiredTabla();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "agregarRequiredTabla", "agregarRequiredTabla();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
                }
            }
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
            if (txtDni.Value == "")
            {
                dni = "null";
            }
    
            docentesSinCH = managerDocente.ConsultaDocenteSinCH(nombre,apellido,dni);
            


            if ( docentesSinCH.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridViewVacio", "verGridViewVacio();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridView", "verGridView();", true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);


                resConsSinCH.DataSource = docentesSinCH;
                resConsSinCH.DataBind();

                
            }
            
            
        }
        private void verfTabla()
        {
            foreach (GridViewRow row in resConsSinCH.Rows)
            {
                RadioButton box = (RadioButton)row.Cells[0].FindControl("dniDoc");
                if (box.Checked)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "quitarRequiredTabla", "quitarRequiredTabla();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridView", "verGridView();", true);
                    fondo_pantalla.Focus();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "agregarRequiredTabla", "agregarRequiredTabla();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridView", "verGridView();", true);
                    fondo_pantalla.Focus();
                }
            }
        }
        public void curso(string esp)
        {
            ManagerCurso manCur = new ManagerCurso();
            ArrayList cursos = new ArrayList();
            

            cursos=manCur.ConsultaCurso(esp);
            cursos.Insert(0, new Curso("", "Eliga una opcion"));
            selCur.DataSource = cursos;
            selCur.DataTextField = "NomCurso";
            selCur.DataValueField = "Id";

            selCur.DataBind();
        }
        protected void cargaCurso(object sender, EventArgs e)
        {
            verfTabla();

            

            curso(string.Format(selEsp.SelectedValue));
            
        }
        public void materia(int curso)
        {
            
            ManagerMateria managerMateria = new ManagerMateria();
            ArrayList materias = new ArrayList();

            materias=managerMateria.ConsultaMateria(curso);
            materias.Insert(0, new Materia("", "Eliga una opcion"));

            selMat.DataSource = materias;
            selMat.DataTextField = "nombreMateria";
            selMat.DataValueField = "id";

            selMat.DataBind();
        }
        protected void cargaMateria(object sender, EventArgs e)
        {
            verfTabla();

            materia(int.Parse(selCur.SelectedValue));   
        }

        protected void enviar_horarios_Click(object sender, EventArgs e)
        {
            string dni="null";
            string curso = selCur.Text;
            string materia = selMat.Text;

            verfTabla();

            foreach (GridViewRow row in resConsSinCH.Rows)
            {
                RadioButton box = (RadioButton)row.Cells[0].FindControl("dniDoc");
                if (box.Checked)
                {
                    dni = row.Cells[3].Text;
                }
            }

            ArrayList verf_carg_hor=new ArrayList();
            ManagerDocente manDoc = new ManagerDocente();
            verf_carg_hor = manDoc.VerfCargaHoraria(int.Parse(curso), int.Parse(materia));
            if (verf_carg_hor.Count == 0)
            {
                manDoc.InsertCargaHoraria(dni, curso, materia);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridView", "verGridView();", true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('La carga horaria del docente fue registrada con exito','reg_carg_hor.aspx','0 0 4px rgba(50,255,50,.5)','rgba(50,255,50,.5)');", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "verGridView", "verGridView();", true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('La materia de ese curso ya tiene a un docente a cargo.<br>Intentelo de nuevo','reg_carg_hor.aspx','0 0 4px rgba(255,50,50,.5)','rgba(255,50,50,.5');", true);

            }

        }

    }
}