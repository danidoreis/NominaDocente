using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Bll;
namespace NominaDocente
{
    public partial class reg_perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Funcion> funciones = obtenerFunciones();

            //****************************ALTA********************************//
            //SI ES UN ALTA SE BUSCAN TODAS LAS FUNCIONES DISPONIBLES Y SOLO SE COMPLETA EL LISTBOXDE LA IZQUIERDA.

            lstLeft.DataSource = funciones;
            lstLeft.DataTextField = "Etiqueta";
            lstLeft.DataValueField = "Id";
            lstLeft.DataBind();

            //****************************************************************//

            //****************************EDICION********************************//
            //SI ES UN EDICION SE DEBEN BUSCAR LAS FUNCIONES ASIGNADAS A EL PERFIL QUE SE ESTA EDITANDO
            List<Funcion> funcionesAsignadas = obtenerFuncionesPerfil(1);

            // CON LA LISTA DE FUNCIONES TOTALES Y DE LAS FUNCIONES ASIGNADAS SE DEBE HACER UNA CONSULTA 
            // PARA GENERAR UNA NUEVA LISTA CON LAS FUNCIONES QUE FALTAN ASIGNAR, ES DECIR  A LA LISTA DE FUNCIONES DISPONIBLES 
            // SE LE QUITA LAS FUNCIONES QUE YA ESTAN ASIGNADAS
            var fncionesSinAsignar = (from eee in funciones
                                      where !(from ppp in funcionesAsignadas select ppp.Id).ToList().Contains(eee.Id)
                                      select eee).ToList();

            // CON LA LISTA RESULTANTE DE ESA CONSULTA SE COMPLETARA EL LISTBOX DE LA IZQUIERDA
            lstLeft.DataSource = fncionesSinAsignar;
            lstLeft.DataTextField = "Etiqueta";
            lstLeft.DataValueField = "Id";
            lstLeft.DataBind();

            // CON LA LISTA DE FUNCIONES ASIGNADAS SE COMPLETARA EL LISTBOX DE LA DERECHA
            lstRight.DataSource = funcionesAsignadas;
            lstRight.DataTextField = "Etiqueta";
            lstRight.DataValueField = "Id";
            lstRight.DataBind();

            //*****************************************************************//

        }

        private List<Funcion> obtenerFuncionesPerfil(int idPerfil)
        {
            //Deben ir a buscarse a la base de datos las funciones qe tiene asignadas el perfil.
            List<Funcion> funciones = new List<Funcion>();

            funciones.Add(new Funcion("1", "Opcion A", "#", "Opcion A", 0));
            funciones.Add(new Funcion("2", "Opcion 1", "Default.aspx", "Opcion 1", 1));

            funciones.Add(new Funcion("4", "Opcion B", "#", "Opcion B", 0));
            funciones.Add(new Funcion("6", "Opcion 4", "Default.aspx", "Opcion 4", 4));

            return funciones;
        }

        private List<Funcion> obtenerFunciones()
        {
            //Las Funciones deben ir a buscarse a la base de datos.
            List<Funcion> funciones = new List<Funcion>();

            funciones.Add(new Funcion("1", "Opcion A", "#", "Opcion A", 0));
            funciones.Add(new Funcion("2", "Opcion 1", "Default.aspx", "Opcion 1", 1));
            funciones.Add(new Funcion("3", "Opcion 2", "Default.aspx", "Opcion 2", 1));

            funciones.Add(new Funcion("4", "Opcion B", "#", "Opcion B", 0));
            funciones.Add(new Funcion("5", "Opcion 3", "Default.aspx", "Opcion 3", 4));
            funciones.Add(new Funcion("6", "Opcion 4", "Default.aspx", "Opcion 4", 4));

            funciones.Add(new Funcion("7", "Opcion C", "#", "Opcion C", 0));

            funciones.Add(new Funcion("8", "Opcion D", "Inicio.aspx", "Opcion D", 0));

            return funciones;
        }

        protected void Guardar(object sender, EventArgs e)
        {
            try
            {
                //Crea una instancia de perfil pasandole como parametro al constructor lo cargado en el textbox de Nombre
                Perfil perfil = new Perfil();

                //Por cada funcion agregada agrega una instancia de Funcion a la lista de funciones de perfil
                // Solo complete el ID de la funcion que es el unico dato que necesitara pra grabar en la relacion PerfilFuncion
                string rightSelectedItems = hidAsignados.Value;
                List<int> contratistas = new List<int>();
                if (!string.IsNullOrEmpty(rightSelectedItems))
                {
                    foreach (string item in rightSelectedItems.Split(','))
                    {
                   //     perfil.Funciones.Add(new Funcion(int.Parse(item)));
                    }
                }

                //Invoca a un metodo de bll pasandole la instacia de perfil completa 
                ManagerUsuario managerUsuario = new ManagerUsuario();
                managerUsuario.grabarPerfil(perfil);
            }
            catch (Exception ex)
            {

            }
        }
    }
}