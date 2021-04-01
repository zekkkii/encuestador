using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.models
{
   public  class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Usuario(string nombre,string apellido,string usuario,string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.password = password;
        }

    }
}
