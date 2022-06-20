using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeorico_TiendaSingapur.Clases
{
    public class Articulos
    {
        public int Id_articulo { get; set; }
        public TipoPrenda TipoPrenda { get; set; }
        public Color Color { get; set; }
        public Marca Marca { get; set; }
        public Temporada Temporada { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }

    }
}
