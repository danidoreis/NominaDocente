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
    public class MesaExamenDAL : AbstractMapper
    {
        public void InsertMesaExamen(string año, string id_materia, string dni_doc1, string dni_doc2, string dni_doc3, string fecha, string horario)
        {
            commandText = string.Format("insert into mesa_examen(año,id_materia,dni_docente1,dni_docente2,dni_docente3,fecha,horario)values('{0}',{1},{2},{3},{4},'{5}','{6}')", año, id_materia, dni_doc1, dni_doc2, dni_doc3, fecha, horario);
            AbstractSave();
        }

        public ArrayList ConsultaMesaExamen(int tipoBus,string fecha)
        {
            ArrayList mesas = new ArrayList();
            switch(tipoBus){
                case 0:
                    commandText = string.Format("select año as anio,nombre_materia as materia, concat_ws(' ',doce1.nombre,doce1.apellido) as doc1,concat_ws(' ',doce2.nombre,doce2.apellido) as doc2,concat_ws(' ',doce3.nombre,doce3.apellido)as doc3,fecha,horario from mesa_examen inner join docentes as doce1 on doce1.dni=mesa_examen.dni_docente1  inner join docentes as doce2 on doce2.dni=mesa_examen.dni_docente2  inner join docentes as doce3 on doce3.dni=mesa_examen.dni_docente3 inner join materia on materia.id=mesa_examen.id_materia where fecha = '{0}'",fecha);
                    mesas = AbstractFindAll();
                    break;
                case 1:
                    commandText = string.Format("select año as anio,nombre_materia as materia, concat_ws(' ',doce1.nombre,doce1.apellido) as doc1,concat_ws(' ',doce2.nombre,doce2.apellido) as doc2,concat_ws(' ',doce3.nombre,doce3.apellido)as doc3,fecha,horario from mesa_examen inner join docentes as doce1 on doce1.dni=mesa_examen.dni_docente1  inner join docentes as doce2 on doce2.dni=mesa_examen.dni_docente2  inner join docentes as doce3 on doce3.dni=mesa_examen.dni_docente3 inner join materia on materia.id=mesa_examen.id_materia where fecha >= '{0}'",fecha);
                    mesas = AbstractFindAll();
                    break;
                case 2:
                    commandText = string.Format("select año as anio,nombre_materia as materia, concat_ws(' ',doce1.nombre,doce1.apellido) as doc1,concat_ws(' ',doce2.nombre,doce2.apellido) as doc2,concat_ws(' ',doce3.nombre,doce3.apellido)as doc3,fecha,horario from mesa_examen inner join docentes as doce1 on doce1.dni=mesa_examen.dni_docente1  inner join docentes as doce2 on doce2.dni=mesa_examen.dni_docente2  inner join docentes as doce3 on doce3.dni=mesa_examen.dni_docente3 inner join materia on materia.id=mesa_examen.id_materia where fecha <= '{0}'",fecha);
                    mesas = AbstractFindAll();
                    break;

            }
            return mesas;
        }
        public ArrayList VerfMesa(string año,string id_materia)
        {
            ArrayList mesas = new ArrayList();
            commandText = string.Format("select año as anio,nombre_materia as materia, concat_ws(' ',doce1.nombre,doce1.apellido) as doc1,concat_ws(' ',doce2.nombre,doce2.apellido) as doc2,concat_ws(' ',doce3.nombre,doce3.apellido)as doc3,fecha,horario from mesa_examen inner join docentes as doce1 on doce1.dni=mesa_examen.dni_docente1  inner join docentes as doce2 on doce2.dni=mesa_examen.dni_docente2  inner join docentes as doce3 on doce3.dni=mesa_examen.dni_docente3 inner join materia on materia.id=mesa_examen.id_materia where año='{0}' and materia.id={1}",año,id_materia);
            mesas = AbstractFindAll();

            return mesas;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
            MesaExamen mesas = new MesaExamen();

            mesas.Año = registers["anio"].ToString();
            mesas.Materia = registers["materia"].ToString();
            mesas.Docente1 = registers["doc1"].ToString();
            mesas.Docente2 = registers["doc2"].ToString();
            mesas.Docente3 = registers["doc3"].ToString();
            mesas.Fecha = registers["fecha"].ToString();
            mesas.Horario = registers["horario"].ToString();

            return mesas;
        }
    }
}
