using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace NominaDocente
{
    public partial class reg_funcion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Funcion> funciones = new List<Funcion>();  

            //funciones.Add(new Funcion("1", "Opcion A", "#", "Opcion A", 0));

            //funciones.Add(new Funcion("4", "Opcion B", "#", "Opcion B", 0));

            //funciones.Add(new Funcion("7", "Opcion C", "#", "Opcion C", 0));


            //funciones.Add(new Funcion("8", "Opcion D", "Inicio.aspx", "Opcion D", 0));

            //funciones.Add(new Funcion("9", "Administrar", "Administrar.aspx", "Administrar", 0));
      
           

            ddlFuncionesPadre.DataSource = funciones;
            ddlFuncionesPadre.DataTextField = "Etiqueta";
            ddlFuncionesPadre.DataValueField = "Id";
            ddlFuncionesPadre.DataBind();

            ddlFuncionesPadre.Items.Add(new ListItem("Ninguno", "0"));
            ddlFuncionesPadre.ClearSelection();
            ddlFuncionesPadre.Items.FindByValue("0").Selected = true;
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            //string idFuncionPadre = Request.Form[ddlFuncionesPadre.UniqueID].ToString();
            string idFuncionPadre = ddlFuncionesPadre.SelectedValue;
        }
    }
}