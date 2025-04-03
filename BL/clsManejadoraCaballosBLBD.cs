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
        public static List<clsCaballo> listadoCompletoCaballosBL()
        {
            return DAL.clsManejadoraCaballosDALBD.listadoCompletoCaballosDAL();
        }

        public static int actualizarRazaCaballoBL(int idCaballo, int idRaza)
        {
            return DAL.clsManejadoraCaballosDALBD.actualizarRazaCaballoDAL(idCaballo, idRaza);
        }
    }
}
