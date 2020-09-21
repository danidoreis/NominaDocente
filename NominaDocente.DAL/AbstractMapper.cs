using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace NominaDocente.DAL
{
    public abstract class AbstractMapper : IDisposable
    {
        public void Dispose()
        { }

        #region A T R I B U T O S

        /// <summary>
        /// String que indica el nombre del Stored Procedure a ejecutar
        /// </summary>
        protected string commandText;

        /// <summary>
        /// String que indica la clave de web.config para obtener el ConnectionString 
        /// </summary>
        protected string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        /// <summary>
        ///  Metodo generico para obtener, mediante la ejecucion de un stored
        ///  Procedure, una colección del Tipo TEntidad
        /// </summary>
        /// <param name="parameters">Colección de parametros</param>
        /// <returns></returns>
        protected ArrayList AbstractFindAll()
        {
            IDataReader dataReader = null;
            ArrayList list = new ArrayList();

            try
            {
                MySqlConnection conn = new MySqlConnection("Address=localhost;User=root;Database=nomina_docente;");
                //Password=2324;Port=3307;
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = commandText;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                dataReader = cmd.ExecuteReader();
                list = LoadAll(dataReader);
                dataReader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ClearDataReader(dataReader);
            }
            return list;
        }


        protected int AbstractSave()
        {
            int ID = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection("Address=localhost;User=root;Database=nomina_docente;");
                //Password=2324;Port=3307;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = commandText;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                ID = (int)cmd.ExecuteScalar();

                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return ID;
        }


        protected object AbstractFind()
        {
            IDataReader dataReader = null;

            object result=null;
            try
            {
                MySqlConnection conn = new MySqlConnection("Address=localhost;User=root;Database=nomina_docente;");
                //Password=2324;Port=3307;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = commandText;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                    result = DoLoad(dataReader);

                dataReader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ClearDataReader(dataReader);
            }
            return result;
        }

        protected void ClearDataReader(IDataReader dataReader)
        {
            if (dataReader != null)
            {
                dataReader.Close();
                dataReader.Dispose();
                dataReader = null;
            }
        }

        /// <summary>
        /// Metodo generico para la carga de una coleccion del tipo TEntidad
        /// </summary>
        /// <param name="registers">DataReader con los registros recuperados de la base de datos</param>
        /// <returns></returns>
        protected ArrayList LoadAll(IDataReader registers)
        {
            ArrayList list = new ArrayList();
            while (registers.Read())
            {
                list.Add(DoLoad(registers));
            }
            return list;
        }

        /// <summary>
        /// Metodo Abstracto para realizar la carga de un objeto del tipo TEntidad
        /// </summary>
        /// <param name="registers">Un registro de la coreccion recuperada de la base de datos</param>
        /// <returns></returns>
        public abstract object DoLoad(IDataReader registers);
    }
}
