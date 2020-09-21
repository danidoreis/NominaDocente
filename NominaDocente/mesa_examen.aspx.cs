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
    public partial class mesa_examen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(txtDoc3.Text != "Eliga un Docente"){
                ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
            }
        }

        protected void envConsDoc_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "verTabla", "verGridView();", true);

            string especialidad = "'"+selEsp.Text+"'";
            string curso = selCur.Text;
            string materia = selMat.Text;


            ManagerDocente manDoc = new ManagerDocente();
            ArrayList docentes = new ArrayList();

            if (selCur.Text == "")
            {
                curso = "null";
            }
            if (selMat.Text == "")
            {
                materia = "null";
            }


            docentes = manDoc.ConsultaDocenteConCH("null","null",especialidad,curso,materia);

            resConsConCH.DataSource = docentes;
            resConsConCH.DataBind();

            año();


        }
        public void año()
        {
            ManagerCurso manCur = new ManagerCurso();
            ArrayList años = new ArrayList();

            años = manCur.ConsultaAño();
            años.Insert(0,new Curso("","Eliga una opcion"));

            selAñoMesa.DataSource = años;
            selAñoMesa.DataTextField = "NomCurso";
            selAñoMesa.DataValueField = "Id";

            selAñoMesa.DataBind();
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
        public void materiaAño(string año)
        {
            ManagerMateria managerMateria = new ManagerMateria();
            ArrayList materias = new ArrayList();

            materias = managerMateria.ConsultaMateriaAño(año);
            materias.Insert(0, new Materia("", "Eliga una opcion"));

            selMatMesa.DataSource = materias;
            selMatMesa.DataTextField = "nombreMateria";
            selMatMesa.DataValueField = "id";

            selMatMesa.DataBind();
        }
        public void cargaMateriaAño(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "verTabla", "verGridView();", true);
            materiaAño(selAñoMesa.SelectedValue);
            enviarMesaExamen.Focus();
        }

        protected void agregarDoc_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "verTabla", "verGridView();", true);
            enviarMesaExamen.Focus();

            string dni = "Eliga un Docente";
            string nombre="Eliga un Docente";

            foreach (GridViewRow row in resConsConCH.Rows)
            {
                RadioButton box = (RadioButton)row.Cells[0].FindControl("dniDoc");
                if (box.Checked)
                {
                    dni = row.Cells[3].Text;
                    nombre=row.Cells[2].Text +" "+ row.Cells[1].Text;

                }
            }
            if (txtDoc1.Text == "Eliga un Docente" && txtDoc2.Text == "Eliga un Docente" && txtDoc3.Text == "Eliga un Docente" && dni != "Eliga un Docente" && nombre != "Eliga un Docente")
            {
                txtDoc1.Text = nombre;
                dniDoc1.Text = dni;
            }
            else
            {
                if (txtDoc2.Text == "Eliga un Docente" && txtDoc3.Text == "Eliga un Docente" && dni != "Eliga un Docente" && nombre != "Eliga un Docente")
                {
                    txtDoc2.Text = nombre;
                    dniDoc2.Text = dni;

                }
                else
                {
                    if (txtDoc3.Text == "Eliga un Docente" && dni != "Eliga un Docente" && nombre != "Eliga un Docente")
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "required", "agregarRequired();", true);
                        txtDoc3.Text = nombre;
                        dniDoc3.Text = dni;
                        
                    }
                }
            }
            
        }

        protected void enviarMesaExamen_Click(object sender, EventArgs e)
        {
            string año = selAñoMesa.SelectedValue;
            string id_materia = selMatMesa.SelectedValue;
            string dni_doc1 = dniDoc1.Text;
            string dni_doc2 = dniDoc2.Text;
            string dni_doc3 = dniDoc3.Text;
            string fecha = dateFecha.Text;
            string horario = dateHor.Text;

            if (dni_doc1 == "" || dni_doc2 == "" || dni_doc3 == "")
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "verTabla", "verGridView();", true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('Elige al menos tres docentes','#','0 0 4px rgba(255,50,50,.5)','rgba(255,50,50,.5');", true);
                enviarMesaExamen.Focus();
            }
            else{
                ManagerMesaExamen manMesaExam = new ManagerMesaExamen();
                ArrayList verf_mesa=new ArrayList();
                verf_mesa=manMesaExam.VerfMesa(año,id_materia);

                if (verf_mesa.Count == 0)
                {
                    manMesaExam.InsertMesaExamen(año, id_materia, dni_doc1, dni_doc2, dni_doc3, fecha, horario);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('La mesa de examen fue registrada con exito','mesa_examen.aspx','0 0 4px rgba(50,255,50,.5)','rgba(50,255,50,.5)');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('La mesa de examen ya se encuentra registrada. <br> Intentelo de nuevo','mesa_examen.aspx','0 0 4px rgba(255,50,50,.5)','rgba(255,50,50,.5');", true);
                }
            }
        }

        protected void borrar_agr_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "verTabla", "verGridView();", true);
            ScriptManager.RegisterStartupScript(this, typeof(Page), "quitarRequired", "quitarRequired();", true);
            txtDoc1.Text = "Eliga un Docente";
            dniDoc1.Text = "";

            txtDoc2.Text = "Eliga un Docente";
            dniDoc2.Text = "";

            txtDoc3.Text = "Eliga un Docente";
            dniDoc3.Text = "";

            enviarMesaExamen.Focus();
        }
    }
}