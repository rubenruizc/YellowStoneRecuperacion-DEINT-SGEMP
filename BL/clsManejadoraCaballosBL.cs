using DAL;
using ENT;

namespace BL
{
    public class clsManejadoraCaballosBL
    {
        /// <summary>
        /// Método que devuelve el listado completo de caballos
        /// Pre: ninguna
        /// Post: ninguna
        /// </summary>
        /// <returns>Listado de caballos completo</returns>
        public static List<clsCaballo> obtenerTodosLosCaballosBL()
        {
            return clsManejadoraCaballosDAL.obtenerTodosLosCaballosDAL();
        }


        /// <summary>
        /// Método que actualiza la raza de un caballo siguiendo las reglas de negocio
        /// Pre: Que los id existan en los listados.El parámetro raza tiene que ser diferente a la raza que tiene ese caballo(si pongo 
        /// esto no hace falta que ponga el if)
        /// Post: que el número que devuelva sea o 0 o 1
        /// </summary>
        /// <param name="idCaballo">Id del caballo a modificar</param>
        /// <param name="idRaza">Id de la raza que vamos a ponerle</param>
        /// <returns>Filas afectadas a la hora de actualizar</returns>
        public static int actualizarRazaCaballoBL(int idCaballo, int idRaza)
        {
            return clsManejadoraCaballosDAL.actualizarRazaCaballoDAL(idCaballo, idRaza); ;
        }
    }
}

