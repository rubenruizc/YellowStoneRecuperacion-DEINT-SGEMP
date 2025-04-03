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
        public static List<clsRaza> listadoCompletoRazasBL()
        {
            return DAL.clsManejadoraRazasDALBD.listadoCompletoRazasDAL();
        }
    }
}
