using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using NominaDocente.DAL;
namespace NominaDocente
{
    public partial class reg_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Perfil> perfiles = new List<Perfil>();  

         //   PerfilDAL perfiles = new PerfilDAL();

        //    Perfiles.Items= perfiles;
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            Exito.Visible = true;
        }
    }
}