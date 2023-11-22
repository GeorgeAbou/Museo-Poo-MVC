using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class ControllerGuia
    {
        //Lista privada
        private static List<Guia> listadoGuias = new List<Guia>();
        //private static List<Guia> listadoGuias1 = new List<Guia>();
        //private static List<Guia> listadoGuias2 = new List<Guia>();
        //private static List<Guia> listadoGuias3 = new List<Guia>();


        //Inicializador
        public static void InicializarGuias()
        {
            listadoGuias.Add(new Guia(1, "luis", "luis23", "Perez", "12345"));
            listadoGuias.Add(new Guia(2, "fernando", "ferbachir", "Piñeda", "12345"));
            listadoGuias.Add(new Guia(3, "karim", "karim123", "Perez", "0000"));
            listadoGuias.Add(new Guia(4, "guiaGuille", "Guillermo","Lopez","12345"));
            
        }

        //Obtener listado
        public static List<Guia> ObtenerGuias()
        {
            return listadoGuias;
        }
    }
}
