﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.db
{
    public class Encuesta
    {
        SqlConnection connection;
        public Encuesta(SqlConnection connection)
        {
            this.connection = connection;
        }


        #region encuesta
        public DataTable cargarEncuestas()
        {            
            SqlDataAdapter query = new SqlDataAdapter("SELECT id, nombre FROM encuesta ORDER BY id desc", connection);
            return executesqlDataAdapter(query);
        }

        public bool añadirEncuesta(string nombre)
        {
            SqlCommand añadirPregunta = new SqlCommand("INSERT INTO encuesta(nombre) values(@nombre) ", connection);
            añadirPregunta.Parameters.AddWithValue("@nombre", nombre);

            if (executeCommand(añadirPregunta)) return true;

            return false;
        }

        public bool borrarEncuesta(int id)
        {

            SqlCommand borrarPreguntas = new SqlCommand("DELETE FROM preguntas WHERE id_encuesta =@id ", connection);
            borrarPreguntas.Parameters.AddWithValue("@id", id);

            SqlCommand borrarEncuesta = new SqlCommand("DELETE FROM encuesta WHERE id =@ID ", connection);
            borrarEncuesta.Parameters.AddWithValue("@id", id);

            if (executeCommand(borrarPreguntas) && executeCommand(borrarEncuesta)) return true;

            // si los registros son eliminados devuelve true, de lo contrario sera false
            return false;
        }


        #endregion


        #region preguntas de las encuestas

        public DataTable cargarPreguntas()
        {
            DataTable data = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter("SELECT id, pregunta FROM preguntas ORDER BY pregunta desc", connection);

            return executesqlDataAdapter(query);
        }

        public bool añadirPregunta(string pregunta)
        {
            SqlCommand añadirPregunta = new SqlCommand("INSERT INTO preguntas(pregunta) values(@pregunta) ", connection);
            añadirPregunta.Parameters.AddWithValue("@pregunta", pregunta);

            if (executeCommand(añadirPregunta)) return true;

            return false;
        }

        public bool editarPregunta(int id, string pregunta)
        {
            SqlCommand editarPreguntas = new SqlCommand("UPDATE preguntas SET pregunta = @pregunta WHERE id =@id ", connection);
            editarPreguntas.Parameters.AddWithValue("@id", id);
            editarPreguntas.Parameters.AddWithValue("@pregunta", pregunta);

            if (executeCommand(editarPreguntas)) return true;

            return false;
        }

        public bool borrarPregunta(int id)
        {
            SqlCommand borrarPreguntas = new SqlCommand("DELETE FROM preguntas WHERE id =@id ", connection);
            borrarPreguntas.Parameters.AddWithValue("@id", id);

            if (executeCommand(borrarPreguntas)) return true;

            return false;
        }
        #endregion


        #region utilidades
        public bool executeCommand(SqlCommand query)
        {
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable executesqlDataAdapter(SqlDataAdapter query)
        {
                DataTable data = new DataTable();
            try
            {
                connection.Open();
                query.Fill(data);
                connection.Close();
                return data;
            }
            catch
            {
                return data;
            }
        }
        #endregion
    }
}