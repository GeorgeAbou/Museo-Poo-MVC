using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Insumo
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadRequerida {  get; set; } 
        
        public Insumo(int id, string nombre,int cantidadRequerida )
        {
            Id = id;
            Nombre = nombre;
            CantidadRequerida = cantidadRequerida;
           
        }
    }
}

