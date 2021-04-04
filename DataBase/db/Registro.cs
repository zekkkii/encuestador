using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataBase.models;

namespace DataBase.db
{
    public class Registro
    {
        private SqlConnection connection;

        public Registro(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(Usuario user )
        {
               
            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {
                if (verificarUser(user.usuario))
                {
                    connection.Open();

                    SqlCommand introducirUser =
                       new SqlCommand("INSERT INTO usuarios(nombre, apellido, usuario, user_password) values(@nombre, @apellido, @usuario, @password)", connection);
                    introducirUser.Parameters.AddWithValue("@nombre", user.nombre);
                    introducirUser.Parameters.AddWithValue("@apellido", user.apellido);
                    introducirUser.Parameters.AddWithValue("@usuario", user.usuario);
                    introducirUser.Parameters.AddWithValue("@password", user.password);


                    introducirUser.ExecuteNonQuery();
                    connection.Close();
                    return true;
               }

                return false;
            }
            catch 
            {
                return false;
            }
        }


        public bool verificarUser(string user)
        {
            try
            {
                connection.Open();

                SqlCommand verificarusuario = new SqlCommand("SELECT usuario FROM usuarios WHERE usuario = @usuario", connection);
                verificarusuario.Parameters.AddWithValue("@usuario", user);
                SqlDataReader reader = verificarusuario.ExecuteReader();

                while (reader.Read())
                {
                    if ((string)reader.GetValue(0)== user)
                    {
                        // si retorna true quiere decir que  existe el usuario
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        return false;

                    }
                }
                // si retorna true quiere decir que no existe el usuario
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

        public int verificarNombre(string nombre)
        {
            try
            {
                connection.Open();

                SqlCommand verificarusuario = new SqlCommand("SELECT id, nombre FROM usuarios WHERE nombre = @nombre", connection);
                verificarusuario.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader reader = verificarusuario.ExecuteReader();

                while (reader.Read())
                {
                    if ((string)reader.GetValue(1) == nombre)
                    {
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        //  existe el usuario
                        return (int)reader.GetValue(0);

                    }
                }
                reader.Close();
                reader.Dispose();
                connection.Close();
                // no existe el usuario
                return -1;
            }
            catch
            {
                return -1;
            }


        }


    }
}
