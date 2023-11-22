using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Controller
{
    public class ControllerRelacionesPublicas
    {
        private static   List<RelacionPublica> listadoRelacionesPublicas = new List<RelacionPublica>();
        public static void InicializarRelacionesPublicas()
        {
            listadoRelacionesPublicas.Add(new RelacionPublica(1,"rodrigo","rodri2", "Meneses", "12345"));
            listadoRelacionesPublicas.Add(new RelacionPublica(2,"jorge", "jorge123", "Perez", "12345"));
        }
        public static List<RelacionPublica> ObtenerRp()
        {
            return listadoRelacionesPublicas;
        }

    }
    
}



