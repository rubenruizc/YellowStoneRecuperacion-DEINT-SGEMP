using ENT;

namespace DAL
{
    public class clsManejadoraCaballosDAL
    {

        private static List<clsCaballo> listaCaballos = new List<clsCaballo>
        {
            new clsCaballo(1,"Blue Note",0),
            new clsCaballo(2,"Star",0),
            new clsCaballo(3,"Brandy",0),
            new clsCaballo(4,"Lucky",0),
            new clsCaballo(5,"Apollo",0),
            new clsCaballo(6,"Scout",0),
            new clsCaballo(7,"Dakota",0),
            new clsCaballo(8,"Cash",0),
        };

        /// <summary>
        /// Método que devuelve el listado completo de caballos
        /// Pre: ninguna
        /// Post: ninguna
        /// </summary>
        /// <returns>Listado de caballos completo</returns>
        public static List<clsCaballo> obtenerTodosLosCaballosDAL()
        {
            return listaCaballos;
        }

        /// <summary>
        /// Método que actualiza la raza de un caballo
        /// Pre: Que los id existan en los listados.El parámetro raza tiene que ser diferente a la raza que tiene ese caballo(si pongo 
        /// esto no hace falta que ponga el if)
        /// Post: que el número que devuelva sea o 0 o 1
        /// </summary>
        /// <param name="idCaballo">Id del caballo a modificar</param>
        /// <param name="idRaza">Id de la raza que vamos a ponerle</param>
        /// <returns>Filas afectadas a la hora de actualizar</returns>
        public static int actualizarRazaCaballoDAL(int idCaballo, int idRaza)
        {
            int filasAfectadas = 0;

            // Buscar el caballo en la lista
            clsCaballo caballo = listaCaballos.FirstOrDefault(c => c.IdCaballo == idCaballo);

            if (caballo.IdRaza != idRaza && caballo != null)
            {
                // Actualzizar la raza
                caballo.IdRaza = idRaza;
                filasAfectadas = 1;
            }

            return filasAfectadas;
        }
    }

}

