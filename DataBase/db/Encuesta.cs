﻿

using System;
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

        public DataTable verPersonasEncuestadas(int id)
        {
            SqlDataAdapter query = new SqlDataAdapter("select id_persona, U.nombre from personas_encuestadas PE inner join usuarios U on U.id = PE.id_persona where id_pregunta =@id ", connection);
            query.SelectCommand.Parameters.AddWithValue("@id",id);
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

        public void introducirPersonaEncuestada(int id)
        {
            SqlCommand introducirPersona = new SqlCommand("INSERT INTO personas_encuestadas(id_persona) VALUES(@id)", connection);
            introducirPersona.Parameters.AddWithValue("@id", id);

            //si esta funcione devuelve true, quiere decir que ya la persona existe en la tabla y que ya tomo la encuesta... De lo contrario, se inserta el id del usuario encuestado
            bool ExsisteUsuarioEnTabla = verificarPersonaEstaEnuestada(id);
           if (ExsisteUsuarioEnTabla)
            {
                executeCommand(introducirPersona); 
            }
        }
        #endregion


        #region preguntas de las encuestas

        public DataTable cargarPreguntas(int id)
        {
            DataTable data = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter("SELECT id, pregunta FROM preguntas where id_encuesta = @id ORDER BY pregunta desc", connection);
            query.SelectCommand.Parameters.AddWithValue("@id", id);
            return executesqlDataAdapter(query);
        }

        public bool añadirPregunta(int id, string pregunta)
        {
            SqlCommand añadirPregunta = new SqlCommand("INSERT INTO preguntas(pregunta,id_encuesta) values(@pregunta,@id) ", connection);
            añadirPregunta.Parameters.AddWithValue("@pregunta", pregunta);
            añadirPregunta.Parameters.AddWithValue("@id", id);


            if (executeCommand(añadirPregunta)) return true;

            return false;
        }
        public bool asignarPreguntaAEncuesta(string pregunta)
        {
            SqlCommand añadirPregunta = new SqlCommand("INSERT INTO preguntas(pregunta,id_encuesta) values(@pregunta,(SELECT IDENT_CURRENT('encuesta'))) ", connection);
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


        #region respuestas de las encuestas

        public DataTable verRespuestasPersonasEncuestadas( int id)
        {
            SqlDataAdapter query = new SqlDataAdapter("select P.pregunta as pregunta, respuesta from respuestas R inner join preguntas P on P.id = R.id_pregunta inner join usuarios U  on U.id = R.id_persona where id_persona = @id", connection);
            query.SelectCommand.Parameters.AddWithValue("@id", id);
            return executesqlDataAdapter(query);
        }


        public bool introducirRespuestaPregunta(int idPregunta,int idpersona, string respuesta)
        {

            SqlCommand introducirRespuesta = new SqlCommand("INSERT INTO respuestas(respuesta, id_pregunta, id_persona) values(@respuesta, @idPregunta, @idPersona) ", connection);
            introducirRespuesta.Parameters.AddWithValue("@idPersona", idpersona);
            introducirRespuesta.Parameters.AddWithValue("@idPregunta", idPregunta);
            introducirRespuesta.Parameters.AddWithValue("@respuesta", respuesta);

            if (executeCommand(introducirRespuesta)) return true;

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



        public bool verificarPersonaEstaEnuestada(int id)
        {
            try
            {
                connection.Open();

                SqlCommand verificarusuario = new SqlCommand("SELECT id_persona FROM personas_encuestadas WHERE id_persona = @id", connection);
                verificarusuario.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = verificarusuario.ExecuteReader();

                while (reader.Read())
                {
                    //  no existe el usuario

                    if ((int)reader.GetValue(0) == id)
                    {
                        return false;
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                    }
                }
                reader.Close();
                reader.Dispose();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }


        }
        #endregion
    }
}
