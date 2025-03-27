using ENT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class clsCaballoConRazas : clsCaballo
    {

        #region Atributos

        private List<clsRaza> listadoRazas;

        private clsRaza razaSeleccionada;

        #endregion

        #region Propiedades

        public List<clsRaza> ListadoRazas
        {
            get
            {
                return listadoRazas;
            }
        }

        public clsRaza RazaSeleccionada
        {
            get
            {
                return razaSeleccionada;
            }
            set
            {
                if( value != null)
                {
                    razaSeleccionada = value;
                }
            }
        }


            #endregion

        #region Constructores

        public clsCaballoConRazas(clsCaballo caballo, List<clsRaza> razasCaballoParam)
            :base(caballo.IdCaballo,caballo.NombreCaballo,caballo.IdRaza)
        {
            //(Añadir un constructor que reciba como parámetros un listado de razas, para rellenar la lista listadoRazas
            this.NombreCaballo = caballo.NombreCaballo;
            this.listadoRazas = razasCaballoParam;

            if(caballo.IdRaza == 0)
            {
                this.RazaSeleccionada = listadoRazas[0];
            } else
            {
                this.razaSeleccionada = razasCaballoParam.Find(r => r.IdRaza == caballo.IdRaza);
            }
            
        }   


        #endregion

    }
}
