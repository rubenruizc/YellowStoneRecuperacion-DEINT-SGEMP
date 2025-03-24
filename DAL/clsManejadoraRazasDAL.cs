using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraRazasDAL
    {

        private static List<clsRaza> listaRazas = new List<clsRaza> 
        {
            new clsRaza(1,"Mustang"),
            new clsRaza(2,"Paint Horse"),
            new clsRaza(3,"Rocky Mountain"),
            new clsRaza(4,"Appaloosa"),
            new clsRaza(5,"Pinto"),
            new clsRaza(6,"Cortador"),

        };

        /// <summary>
        /// Método que devuelve el listado completo de razas
        /// Pre: ninguna
        /// Post: ninguna
        /// </summary>
        /// <returns>Listado de razas completo</returns>
        public static List<clsRaza> obtenerTodasLasRazasDAL()
        {
            return listaRazas;
        }

    }
}
