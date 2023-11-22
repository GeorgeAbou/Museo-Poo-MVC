using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class ControllerInsumo
    {

        private static List<Insumo> listaInsumos = new List<Insumo>();

        //crear una lista con varios 4 insumos
        public static void InicializarInsumo()
        {
            listaInsumos.Add(new Insumo(1, "Megáfono", 50));
            listaInsumos.Add(new Insumo(2, "Follero",  20));
            listaInsumos.Add(new Insumo(3, "Puntero Lasser", 35));
            listaInsumos.Add(new Insumo(4, "Alcohol Spray", 100));
        }
        public static List<Insumo> ObterneInsumos()
        {
            return listaInsumos;
        }
        public static Insumo BuscarInsumo(int idBuscar)
        {
            foreach (var insumo in listaInsumos)
            {
                if (insumo.Id == idBuscar)
                {
                    return insumo;
                }
            }
            return null;
        }
    }
}

