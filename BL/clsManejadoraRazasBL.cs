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

        public static List<clsRaza> obtenerTodasLasRazasBL()
        {
            return clsManejadoraRazasDAL.obtenerTodasLasRazasDAL();
        }

    }
}
