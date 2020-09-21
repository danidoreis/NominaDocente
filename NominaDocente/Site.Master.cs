using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bll;
using System.Web.UI.HtmlControls;
using NominaDocente.DAL;
namespace NominaDocente
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Usuario user= new Usuario();


           Texte.InnerText = user.Nombre;
           Texte.DataBind();


            
                       //ManagerUsuario managerUsuario = new ManagerUsuario();

                       // // Usuario usuario =managerUsuario.getUsuario(Usuario)Session["USER" + Session.SessionID];
                       // //   usuarioDAL usuario = new usuarioDAL();
                       //      Perfil perfil = new Perfil();
                       // //perfil.Funciones;

                       //List<Funcion> funcionesPadre = /*usuario.*/perfil.Funciones.Where(f => f.FuncionPadre == "0").ToList();

                       //List<Funcion> funcionesHija = new List<Funcion>();

                       //foreach (Funcion funcion in funcionesPadre)
                       //{
                       //    HtmlGenericControl li = new HtmlGenericControl("li");
                       //    menu.Controls.Add(li);
                       //    HtmlGenericControl anchor = new HtmlGenericControl("a");
                       //    anchor.Attributes.Add("href", funcion.Url);
                       //    HtmlGenericControl span = new HtmlGenericControl("span");
                       //    span.Attributes.Add("class", "flecha_abajo");

                       //    anchor.InnerText = funcion.Etiqueta;
                       //    anchor.Controls.Add(span);
                       //    li.Controls.Add(anchor);

                       //    funcionesHija = /*usuario.*/perfil.Funciones.Where(f => f.FuncionPadre == funcion.Id).ToList();

                       //    if (funcionesHija.Count() > 0)
                       //    {
                       //        HtmlGenericControl ul = new HtmlGenericControl("ul");

                       //        foreach (Funcion funcionHija in funcionesHija)
                       //        {
                       //            HtmlGenericControl ili = new HtmlGenericControl("li");
                       //            ul.Controls.Add(ili);
                       //            HtmlGenericControl a = new HtmlGenericControl("a");
                       //            a.Attributes.Add("href", funcionHija.Url);
                       //            a.InnerText = funcionHija.Etiqueta;
                       //            ili.Controls.Add(a);
                       //        }

                       //        li.Controls.Add(ul);
                       // }
                     //  }


                         











        }


     }
}
