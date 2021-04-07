using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.db;
using System.Data.SqlClient;
using DataBase.models;
using System.Data;
using Logiclayer;

namespace Logiclayer
{
    public class Servicio
    {
        public SqlConnection connection { get; set; }
        public Registro iniciarServicioRegistro { get; set; }
        public Encuesta iniciarServicioEncuesta { get; set; }

        public Servicio(SqlConnection connection)
        {
            this.connection = connection;
            //registro
            iniciarServicioRegistro = new Registro(connection);
            //encuesta
            iniciarServicioEncuesta = new Encuesta(connection);
        }
        
        #region credenciales
        public bool login(Credenciales usuariopassword)
        {
            Login iniciarServiciologin = new Login(connection);
            Credenciales datos= iniciarServiciologin.login(usuariopassword);
            if (usuariopassword.usuario == datos.usuario)
            {
                if (usuariopassword.password == datos.password)
                {
                    //datos encontrados e iguales
                    return true;
                } 
            }
            
            return false;
        }

        public bool registro( Usuario user)
        {
            bool registrar= iniciarServicioRegistro.registrar(user);

            if (registrar)
            {
                // se creo el usuario
                return true;
            }
            // no se creo el usuario
            return false;
        }


        #endregion

        #region encuesta
        public DataTable cargarEncuestas()
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicioEncuesta.cargarEncuestas();
            return data;
        }

        public void introducirPersonaEncuestada(int id, int id_encuesta)
        {
            iniciarServicioEncuesta.introducirPersonaEncuestada(id, id_encuesta);
        }

        public DataTable verPersonasEncuestadas(int id)
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicioEncuesta.verPersonasEncuestadas(id);
            return data;
        }

        public bool añadirEncuesta(string nombre)
        {

            bool fueExitoso = iniciarServicioEncuesta.añadirEncuesta(nombre);

            if (fueExitoso) return true;
            //si no fue exitoso devuelve false
            return false;
        }

        public bool borrarEncuesta(int id)
        {

          bool fueExitoso =  iniciarServicioEncuesta.borrarEncuesta(id);

            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
        #endregion


        #region preguntas de las encuestas

        public DataTable cargarPreguntas(int id)
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicioEncuesta.cargarPreguntas(id);
            return data;
        }

        public bool añadirPregunta(int id,string pregunta)
        {
          bool fueExitoso =  iniciarServicioEncuesta.añadirPregunta(id, pregunta);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }


        public bool asignarPreguntaAEncuesta(string pregunta)
        {
            bool fueExitoso = iniciarServicioEncuesta.asignarPreguntaAEncuesta(pregunta);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }


        public bool editarPregunta(int id, string pregunta)
        {
          bool fueExitoso =  iniciarServicioEncuesta.editarPregunta(id, pregunta);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }

        public bool borrarPregunta(int id)
        {
            bool fueExitoso = iniciarServicioEncuesta.borrarPregunta(id);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
        #endregion


        #region respuestas de las encuestas

        public DataTable verRespuestasPersonasEncuestadas(int id, int id_encuesta)
        {
            DataTable data = iniciarServicioEncuesta.verRespuestasPersonasEncuestadas(id, id_encuesta);
            return data;
        }

        public bool introducirRespuestaPregunta(int idpersona, List<Respuesta> respuestas, int id_encuesta)
        {
            try
            {

                for (int i = 0; i < respuestas.Count; i++)
                {// pregunta, persona,respuesta

                    bool fueInsertado = iniciarServicioEncuesta.introducirRespuestaPregunta(respuestas[i].idPregunta, idpersona, respuestas[i].respuesta, id_encuesta);
                    if (fueInsertado)
                    {
                        continue;
                    }
                    else
                    {
                        break;

                    }

                }

                return true;
            }
            catch
            {
                return false;
            }
        
        }
        #endregion

        #region utilidades

        public int existeUsuario(string nombre)
        {
           int personaID = iniciarServicioRegistro.verificarNombre(nombre);
            if (personaID >= 0)
            { 
                return personaID;
            }
            return -1;
        }

       
        #endregion
    }
}
