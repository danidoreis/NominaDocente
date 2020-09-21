using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Bll;
using Entidades;
namespace NominaDocente
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ManagerUsuario managerUsuario = new ManagerUsuario();
            Usuario usuario = managerUsuario.getUsuario(txtUserName.Value, txtUserPass.Value);

            if (usuario != null)
            {
                Session.Add("USER" + Session.SessionID, usuario);
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Value, false);
            }
            else
            {
                lblMsg.Text = "Usuario o clave incorrecto";
            }
        }


        private bool ValidateUser(string nombreUsuario, string clave)
        {
            ManagerUsuario managerUsuario = new ManagerUsuario();
            Usuario usuario = managerUsuario.getUsuario(nombreUsuario, clave);

            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void Anonimo_Click(object sender, EventArgs e)
        {
            ManagerUsuario managerUsuario = new ManagerUsuario();
            Usuario usuario = managerUsuario.getUsuario("Usuario", "Anonimo");

            Session.Add("USER" + Session.SessionID, usuario);
            FormsAuthentication.RedirectFromLoginPage("Usuario", false);
        }

}
}