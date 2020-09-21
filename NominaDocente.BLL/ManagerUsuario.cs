using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using NominaDocente.DAL;
using System.Collections;
namespace Bll
{
    public class ManagerUsuario
    {
        public Usuario getUsuario(string nombreUsuario, string clave)
        {
            usuarioDAL usuarioDal = new usuarioDAL();
            Usuario usuario = usuarioDal.ConsultarUsuarios(nombreUsuario, clave);
            if (usuario!=null)
            {

                Perfil perfil = new Perfil();
                PerfilDAL perfilDal = new PerfilDAL();

                perfil= perfilDal.ConsultarPerfil(int.Parse(usuario.Id));

                FuncionDAL funcionDAL  = new FuncionDAL();
                 ArrayList funciones = funcionDAL.ConsultarFunciones(int.Parse(perfil.Id));
                perfil.Funciones = funciones.OfType<Funcion>().ToList();
                usuario.Perfil = perfil;
            }
            return usuario;
        }

        public bool validaPermisosPagina(Usuario usuario, string pagina)
        {
            bool tienePermisos = false;

            
              Funcion funcion = usuario.Perfil.Funciones.SingleOrDefault(f => f.Etiqueta == pagina);

               if (funcion != null)
               {
                   tienePermisos = true;
               }

               return tienePermisos;
             
        }
        public void grabarPerfil(Perfil perfil)
        {
            //Envia a grabar el perfil y recupera el ID dado de alta para usarlo al grabar en la relacion.

            PerfilDAL perfilDAL = new PerfilDAL();
            int Id = perfilDAL.grabaPerfil(perfil);

            foreach (Funcion funcion in perfil.Funciones)
            {
                perfilDAL.grabaFuncionPerfil(funcion.Codigo, Id.ToString());
            }
        }

        public string nombre { get; set; }
    }
}
