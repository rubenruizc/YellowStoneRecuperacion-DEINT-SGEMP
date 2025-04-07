using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsManejadoraCaballosBLBD
    {
        /// <summary>
        /// Función que devuelve un listado de caballos de la base de datos de azure.
        /// Pre: Ninguna
        /// Post: Puede devolver un listado vacío, por algún error con la BD
        /// </summary>
        /// <returns>Listado de caballos</returns>
        public static List<clsCaballo> listadoCompletoCaballosBL()
        {
            return DAL.clsManejadoraCaballosDALBD.listadoCompletoCaballosDAL();
        }

        /// <summary>
        /// Función que actualiza los campos de un caballo, según su id
        /// Pre: caballo con idCaballo y idRaza rellenos, los demás campos opcionales
        /// Post: Ninguno
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static int actualizarRazaCaballoBL(int idCaballo, int idRaza)
        {
            return DAL.clsManejadoraCaballosDALBD.actualizarRazaCaballoDAL(idCaballo, idRaza);
        }
    }
}
