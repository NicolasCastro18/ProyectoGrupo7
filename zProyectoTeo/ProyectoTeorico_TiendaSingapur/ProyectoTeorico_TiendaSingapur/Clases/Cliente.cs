using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeorico_TiendaSingapur.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public int CUIL { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Telefono { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
