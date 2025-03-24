using ENT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsManejadoraRazasBL
    {

        /// <summary>
        /// Método que devuelve el listado completo de razas
        /// Pre: ninguna
        /// Post: ninguna
        /// </summary>
        /// <returns>Listado de razas completo</returns>
        public static List<clsRaza> obtenerTodasLasRazasBL()
        {
            return clsManejadoraRazasDAL.obtenerTodasLasRazasDAL();
        }

    }
}
