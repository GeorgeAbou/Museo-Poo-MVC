using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class RelacionPublica : Empleado
    {
         
        public RelacionPublica(int id, String nombre, String usuario, String apellido, String password)
        {
            Id = id;
            Nombre = nombre;
            Usuario = usuario;
            Apellido = apellido;
            Password = password;

        }
    }
}

