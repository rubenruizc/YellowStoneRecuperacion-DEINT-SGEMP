using DAL;
using ENT;

namespace BL
{
    public class clsManejadoraCaballosBL
    {
        public static List<clsCaballo> obtenerTodosLosCaballosBL()
        {
            return clsManejadoraCaballosDAL.obtenerTodosLosCaballosDAL();
        }

        public static int actualizarRazaCaballoBL(int idCaballo, int idRaza)
        {

            // Call DAL method and handle the result
            int filasAfectadas = clsManejadoraCaballosDAL.actualizarRazaCaballoDAL(idCaballo, idRaza);

            return filasAfectadas;
        }
    }
}

