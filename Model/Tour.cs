using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
      public class Tour
    {
        public int Id { get; set; }
        public String Fecha { get; set; }
        public string Hora { get; set; }
        public List<ObraArte> ListadoObrasTour {  get; set; }
        public String ProfesorCargo { get; set; }
        public String AdultoCargo { get; set; }
        public int CantidadNiños { get; set; }
        public String  Estado { get; set; }
        public List<Guia> ListadoGuias { get; set; }
        public String NombreExpo { get; set; }
        public List<Insumo> ListadoInsumos { get; set; }
        public Tour(int id, String fecha, String hora, String profesorCargo, String adultoCargo, int cantidadNiños, String estado, List<Guia> listadoGuias, String nombreExpo, List<Insumo> listadoInsumos, List<ObraArte> listadoObrasTour)
        
        {
            Id = id;
            Fecha = fecha;
            Hora = hora;
            ProfesorCargo = profesorCargo;
            AdultoCargo = adultoCargo;
            CantidadNiños = cantidadNiños;
            Estado = estado;
            ListadoObrasTour = listadoObrasTour;
            ListadoGuias = listadoGuias;
            NombreExpo = nombreExpo;
            ListadoInsumos = listadoInsumos;
        }
    }
}

