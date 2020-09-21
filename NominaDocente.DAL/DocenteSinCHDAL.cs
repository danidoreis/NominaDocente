using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;
using NominaDocente.Entidades;

namespace NominaDocente.DAL
{
    public class DocenteSinCHDAL:AbstractMapper
    {
        public void InsertDocente(DocenteSinCH docente)
        {
            commandText = string.Format("insert into docentes(nombre,apellido,dni,fecha_nac,nro_legajo,telefono,domicilio,mail,fecha_de_ingreso_docente,fecha_de_ingreso_establecimiento)values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}')", docente.Nombre, docente.Apellido, docente.Dni, docente.FechaNacimiento, docente.NroLegajo, docente.Telefono, docente.Domicilio, docente.EMail, docente.FechaIngDocencia, docente.FechaIngEst);
            AbstractSave();
        }

        public ArrayList ConsultaDocenteSinCH(string nombre,string apellido, string dni)
        {
            ArrayList docentes = new ArrayList();
            commandText = string.Format("select nombre,apellido,dni,fecha_nac,nro_legajo,telefono,domicilio,mail,fecha_de_ingreso_docente,fecha_de_ingreso_establecimiento from docentes where nombre like concat('%',{0},'%') or apellido like concat('%',{1},'%') or dni={2}", nombre,apellido, dni);
            docentes = AbstractFindAll();

            return docentes;
        }
        public ArrayList VerfDniDoc(string dni)
        {
            ArrayList verf_dni = new ArrayList();
            commandText = string.Format("select nombre,apellido,dni,fecha_nac,nro_legajo,telefono,domicilio,mail,fecha_de_ingreso_docente,fecha_de_ingreso_establecimiento from docentes where dni={0}",dni);
            verf_dni = AbstractFindAll();

            return verf_dni;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
            DocenteSinCH docentes = new DocenteSinCH();

            docentes.Nombre = registers["nombre"].ToString();
            docentes.Apellido = registers["apellido"].ToString();
            docentes.Dni = registers["dni"].ToString();
            docentes.FechaNacimiento = registers["fecha_nac"].ToString();
            docentes.NroLegajo = registers["nro_legajo"].ToString();
            docentes.Telefono = registers["telefono"].ToString();
            docentes.Domicilio = registers["domicilio"].ToString();
            docentes.EMail = registers["mail"].ToString();
            docentes.FechaIngDocencia = registers["fecha_de_ingreso_docente"].ToString();
            docentes.FechaIngEst = registers["fecha_de_ingreso_establecimiento"].ToString();

            return docentes;
        }
    }
}
