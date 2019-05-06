using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Users
    {
        public int Id { get; set; } // ID (Primary key)
        public decimal? Cedula { get; set; } // CEDULA
        public string Nombre { get; set; } // NOMBRE (length: 100)
        public string Contrasena { get; set; } // CONTRASENA (length: 300)
        public string Genero { get; set; } // GENERO (length: 1)
        public string Correo { get; set; } // CORREO (length: 200)
        public System.DateTime? FechaNacimiento { get; set; } // FECHA_NACIMIENTO
        public decimal? Telefono { get; set; } // TELEFONO
        public System.DateTime? FechaContrasena { get; set; } // FECHA_CONTRASENA
        public bool? Capacitado { get; set; } // Capacitado
        public int? IdLinea { get; set; } // ID_LINEA 
    }
}
