using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataBase.models;

namespace DataBase.db
{
    public class Login
    {
        private SqlConnection connection;

        public Login(SqlConnection connection)
        {
            this.connection = connection;
        }

        public Credenciales login(Credenciales user)
        {

            try
            {
                connection.Open();

                SqlCommand finduser =
                    new SqlCommand("SELECT usuario, user_password FROM usuarios WHERE usuario = @usuario  AND user_password =@password", connection);
                finduser.Parameters.AddWithValue("@usuario", user.usuario);
                finduser.Parameters.AddWithValue("@password", user.password);

                SqlDataReader reader = finduser.ExecuteReader();

                Credenciales datos = new Credenciales();

                while (reader.Read())
                {
                    datos.usuario = reader.IsDBNull(0) ? null : reader.GetString(0);
                    datos.password = reader.IsDBNull(1) ? null : reader.GetString(1);
                }

                reader.Close();
                reader.Dispose();

                connection.Close();
                return datos;
            }
            catch
            {
                return new Credenciales() { usuario = null, password = null};
            }
        }    
    }
}
