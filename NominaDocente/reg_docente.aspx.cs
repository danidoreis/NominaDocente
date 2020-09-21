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
    public partial class reg_docente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void enviar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Value;
            string apellido = txtApellido.Value;
            string dni = txtDni.Value;
            string fechaNacimiento = dateFechaNacimiento.Text;
            string nroLegajo = txtNroLej.Value;
            string telefono = txtTel.Text;
            string domicilio = txtDomicilio.Value;
            string eMail = mail.Text;
            string fechaIngDocencia = dateFechaIngDocencia.Text;
            string fechaIngEst = dateFechaIngEst.Text;

            
            ManagerDocente mangDocente = new ManagerDocente();
            ArrayList verf_dni=new ArrayList();
            verf_dni=mangDocente.VerfDniDoc(dni);

            if (verf_dni.Count == 0)
            {
                DocenteSinCH docente = new DocenteSinCH(nombre, apellido, dni, fechaNacimiento, nroLegajo, telefono, domicilio, eMail, fechaIngDocencia, fechaIngEst);
                mangDocente.InsertDocente(docente);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('El docente fue registrado con exito','reg_docente.aspx','0 0 4px rgba(50,255,50,.5)','rgba(50,255,50,.5)');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "mostrarPopup('El docente ya esta registrado.<br>Intentelo de nuevo','reg_docente.aspx','0 0 4px rgba(255,50,50,.5)','rgba(255,50,50,.5');", true);
            }
            

        }

    }
}