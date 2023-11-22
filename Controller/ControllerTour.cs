using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerTour
    {
        private static List<Tour> listadoTours = new List<Tour>();

        public static void InicializarTour()
        {
            List<Guia> guias = new List<Guia>();
            List<Insumo> Insumos = new List<Insumo>();
            List<Exposicion> listadoExposicionesTour = ControllerExposicion.ObtenerExposiciones();


            
            listadoTours.Add(new Tour(1, "24/12/2023", "12:30 AM", "LUIS SALCEDO", "ANA ALVARADO", 10, "SOLICITADO", guias, listadoExposicionesTour[0].Nombre, Insumos, listadoExposicionesTour[0].ListadoObras));
            listadoTours.Add(new Tour(2, "24/12/2023", "11:30 AM", "KARIM ABOU CHANAB", "CARMEN CRACAMONTE", 10, "SOLICITADO", guias, listadoExposicionesTour[1].Nombre, Insumos, listadoExposicionesTour[1].ListadoObras));
            listadoTours.Add(new Tour(3, "24/12/2023", "13:30 PM", "JOSE PEREZ", "LUIS CARBAJAL", 10, "SOLICITADO", guias, listadoExposicionesTour[1].Nombre, Insumos, listadoExposicionesTour[1].ListadoObras));
            listadoTours.Add(new Tour(4, "24/12/2023", "15:30 PM", "CARLOS QUERO", "SAIDY ESTER", 10, "SOLICITADO", guias, listadoExposicionesTour[0].Nombre, Insumos, listadoExposicionesTour[0].ListadoObras));
        }
        public static List<Tour> ObtenerListadoTours()
        {
            return listadoTours;
        }
        public static Tour BuscarTour(int idBuscar)
        {
            foreach (var tour in listadoTours)
            {
                if (tour.Id == idBuscar)
                {
                    return tour;
                }
            }
            return null;
        }
        public static bool AgregarGuia(int idBuscado, List<Guia> guia)
        {
            foreach (Tour item in listadoTours)
            {
                if (idBuscado == item.Id)
                {
                    item.ListadoGuias = guia;
                    return true;
                }
            }
            return false;
        }
        public static bool CambiarEstadoTour(int idBuscador, String estado)
        {
            foreach (Tour tour in listadoTours)
            {
                if (idBuscador == tour.Id)
                {
                    tour.Estado = estado;
                    return true;
                }
            }
            return false;
            
        }
        public static bool AgregarInsumotour(int idInsumo, List<Insumo> listadoInsumos, String estado)
        {
            foreach (Tour item in listadoTours)
            {
                if (idInsumo == item.Id)
                {
                    item.ListadoInsumos = listadoInsumos;
                    item.Estado = estado;
                    return true;
                }
            }
            return false;
        }
        
    }

}


