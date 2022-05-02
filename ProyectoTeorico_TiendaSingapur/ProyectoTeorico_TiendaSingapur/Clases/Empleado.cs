using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeorico_TiendaSingapur.Clases
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int telefono { get; set; }
        public string mail { get; set; }
        public string Calle { get; set; }
        public int nroCalle { get; set; }
        public int id_barrio { get; set; }

        public Empleado()
        {

        }
    }
}
