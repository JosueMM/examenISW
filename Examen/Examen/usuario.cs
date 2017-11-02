using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class usuario
    {
       
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string pass { get; set; }
        public string correo { get; set; }
        public Boolean estado { get; set; }

        public usuario( string nombre, string cedula, string pass, string correo, bool estado)
        {
      
            this.nombre = nombre;
            this.cedula = cedula;
            this.pass = pass;
            this.correo = correo;
            this.estado = estado;
        }

        public usuario()
        {

        }

       
    }
}
