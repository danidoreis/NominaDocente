using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NominaDocente.Entidades;
using NominaDocente.DAL;
using System.Collections;


namespace NominaDocente.BLL
{
    public class ManagerDocente
    {
        public void InsertDocente(DocenteSinCH docente)
        {
            DocenteSinCHDAL docenteDal = new DocenteSinCHDAL();
            docenteDal.InsertDocente(docente);
        }
        public ArrayList VerfDniDoc(string dni)
        {
            DocenteSinCHDAL docSinCHDal = new DocenteSinCHDAL();
            ArrayList verf_dni = new ArrayList();
            verf_dni=docSinCHDal.VerfDniDoc(dni);

            return verf_dni;
        }
        public void InsertCargaHoraria(string dni ,string id_curso,string id_materia){
            DocenteConCHDAL docDal = new DocenteConCHDAL();
            docDal.InsertCargaHoraria(dni, id_curso, id_materia);
        }
        public ArrayList VerfCargaHoraria(int curso,int materia)
        {
            DocenteConCHDAL docDal = new DocenteConCHDAL();
            ArrayList verf_carga_horaria=new ArrayList();
            verf_carga_horaria=docDal.VerfCargaHoraria(curso,materia);

            return verf_carga_horaria;
        }
        public ArrayList ConsultaDocenteSinCH(string nombre,string apellido,string dni)
        {
            DocenteSinCHDAL docenteDal = new DocenteSinCHDAL();
            ArrayList docentes = docenteDal.ConsultaDocenteSinCH(nombre,apellido,dni);
            return docentes;
        }
        public ArrayList ConsultaDocenteConCH(string nombre,string apellido,string especialidad,string curso,string materia)
        {

            DocenteConCHDAL docenteDal = new DocenteConCHDAL();
            ArrayList docentes = docenteDal.ConsultaDocenteConCH(nombre,apellido,especialidad,curso,materia);
            return docentes;
        }

    }
}
