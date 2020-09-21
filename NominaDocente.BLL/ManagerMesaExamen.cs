using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NominaDocente.Entidades;
using NominaDocente.DAL;
using System.Collections;

namespace NominaDocente.BLL
{
    public class ManagerMesaExamen
    {
        public void InsertMesaExamen(string año,string id_materia,string dni_doc1,string dni_doc2,string dni_doc3,string fecha,string horario)
        {
            MesaExamenDAL mesaExamDal = new MesaExamenDAL();
            mesaExamDal.InsertMesaExamen(año,id_materia,dni_doc1,dni_doc2,dni_doc3,fecha,horario);
        }
        public ArrayList ConsultaMesaExamen(int tipoBus,string fecha)
        {
            MesaExamenDAL mesaDal = new MesaExamenDAL();
            ArrayList mesas = new ArrayList();

            mesas = mesaDal.ConsultaMesaExamen(tipoBus,fecha);

            return mesas;
            
        }
        public ArrayList VerfMesa(string año,string id_materia)
        {
            MesaExamenDAL mesaDal = new MesaExamenDAL();
            ArrayList mesas = new ArrayList();

            mesas = mesaDal.VerfMesa(año,id_materia);

            return mesas;
        }
    }
}
