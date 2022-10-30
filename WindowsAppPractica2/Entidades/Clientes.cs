using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppPractica2.Entidades
{
    public class Clientes
    {
        public string nombre { get; set; }
        public string apellido { get; set; }    
        public int DNI { get; set; }    
        public string direccion { get; set; }   
        public DateTime FechaNacimiento { get; set; }
    }
}
