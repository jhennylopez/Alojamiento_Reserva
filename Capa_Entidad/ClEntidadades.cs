using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClEntidadades
    {
        // atributos de la tabla huesped
        public class Huesped
        {
            public int Id_Huesped { get; set; }
            public string Ci { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Contrasena { get; set; }
        }

        public class Reserva
        {
            public int Id_Reserva { get; set; }
            public DateTime Fecha_Ingreso { get; set; }
            public DateTime Fecha_Salida { get; set; }
            public int Numero_Personas { get; set; }
            public string Tipo { get; set; }
            public int Id_Huesped { get; set; }
            public int Id_Alojamiento { get; set; }
        } 
        public class Alojamiento
        {
            public int Id_Alojamiento { get; set; }
            public string Descripcion { get; set; }
            public string Ubicacion { get; set; }
            public int Max_Huespedes { get; set; }
            public int Num_Habitaciones { get; set; }
            public int Num_Banos { get; set; }
            public int Id_Administrador { get; set; }
        }

        public class Administrador
        {
            public int Id_Administrador { get; set; }
            public string Ci { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Contrasena { get; set; }
            public DateTime Fecha_Registro { get; set; }
        }

        public class Imagen
        {
            public int Id_Imagen { get; set; }
            public string Ruta_Imagen { get; set; }
            public int Id_Alojamiento { get; set; }
        }

    }
}
