using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Articulo
    {

        public int id { get; set; }
        public string nombre { get; set; }
       public string autor { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public int existencias { get; set; }

        public Articulo(int id,string nombre, string autor, string categoria, double precio, int existencias)
        {
            this.id = id;
            this.nombre = nombre;
            this.autor = autor;
            this.categoria = categoria;
            this.precio = precio;
            this.existencias = existencias;
        }


        public Articulo()
        {
            
        }



    }
}
