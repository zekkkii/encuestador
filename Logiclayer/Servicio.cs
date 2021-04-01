﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.db;
using System.Data.SqlClient;
using DataBase.models;
using System.Data;

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

        public DataTable cargarPreguntas()
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicioEncuesta.cargarPreguntas();
            return data;
        }
        public bool añadirPregunta(string pregunta)
        {
          bool fueExitoso =  iniciarServicioEncuesta.añadirPregunta(pregunta);
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


        #region
        #endregion
    }
}
