using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Dato
{
    public class ClOperacion
    {
        ClConexion conectar = new ClConexion();

        // Método para la inserción de la tabla huesped


        public bool insertar_huesped(ClEntidadades.Huesped huesped)
        {

            bool inserto = false;
            string consulta = "INSERT INTO Huesped (Ci, nombres, apellidos, correo, telefono, contrasena) " +
                           "VALUES (@ci, @nombres, @apellidos, @correo, @telefono, @contrasena)";
            return inserto;
        }
        public bool insertar_Reserva(ClEntidadades.Reserva reserva)
        {
            bool inserto = false;
            string consulta = "INSERT INTO RESERVA (fecha_ingreso, fecha_salida, numero_personas, tipo, ID_huesped, ID_alojamiento) " +
                              "VALUES (@fecha_ingreso, @fecha_salida, @numero_personas, @tipo, @ID_huesped, @ID_alojamiento)";
            return inserto;
        }

        public bool insertar_Alojamiento(ClEntidadades.Alojamiento alojamiento)
        {
            bool inserto = false;
            string consulta = "INSERT INTO ALOJAMIENTO (descripcion, ubicacion, max_huespedes, num_habitaciones, num_banos, ID_administrador) " +
                              "VALUES (@descripcion, @ubicacion, @max_huespedes, @num_habitaciones, @num_banos, @ID_administrador)";
            return inserto;
        }

        public bool insertar_Administrador(ClEntidadades.Administrador administrador)
        {
            bool inserto = false;
            string consulta = "INSERT INTO ADMINISTRADOR (CI, nombres, apellidos, correo, telefono, contrasena, fecha_registro) " +
                              "VALUES (@ci, @nombres, @apellidos, @correo, @telefono, @contrasena, @fecha_registro)";
            return inserto;
        }

        public void insertar_imagen_Alojamiento(ClEntidadades.Imagen imagen)
        {

            string consulta = "INSERT INTO IMAGEN_ALOJAMIENTO (ruta_imagen, ID_alojamiento) " +
                              "VALUES (@ruta_imagen, @ID_alojamiento)";

        }
    }
    }
