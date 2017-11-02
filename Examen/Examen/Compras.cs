using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Compras
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idArticulo { get; set; }
        public int cantidadComprada { get; set; }

        public Compras(int id, int idUsuario, int idArticulo, int cantidadComprada)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.idArticulo = idArticulo;
            this.cantidadComprada = cantidadComprada;
        }

        public Compras()
        {
         
        }
    }
}
