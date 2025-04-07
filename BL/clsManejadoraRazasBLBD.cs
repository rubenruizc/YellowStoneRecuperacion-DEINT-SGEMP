using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsManejadoraRazasBLBD
    {
        /// <summary>
        /// Función que devuelve un listado de razas de la base de datos de azure.
        /// Pre: Ninguna
        /// Post: Puede devolver un listado vacío, por algún error con la BD
        /// </summary>
        /// <returns>Listado de razas</returns>
        public static List<clsRaza> listadoCompletoRazasBL()
        {
            return DAL.clsManejadoraRazasDALBD.listadoCompletoRazasDAL();
        }
    }
}
