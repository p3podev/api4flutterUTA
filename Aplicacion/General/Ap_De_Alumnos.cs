using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.General
{
    public class Ap_De_Alumnos
    {
        public int ID { get; set; }
        public string CI { get; set; }
        public string NOMBRE { get; set; }
        public bool ACTIVO { get; set; } // Nueva propiedad para el estado activo del alumno
    }
}

