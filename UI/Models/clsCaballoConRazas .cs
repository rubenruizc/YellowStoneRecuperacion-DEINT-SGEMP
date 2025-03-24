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

        public List<clsRaza> ListaRazas
        {
            get
            {
                return listadoRazas;
            }

            set 
            {
                if (value != null)
                {
                    listadoRazas = value;
                }
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
        {
            //(Añadir un constructor que reciba como parámetros un listado de razas, para rellenar la lista listadoRazas
            this.NombreCaballo = caballo.NombreCaballo;
            this.IdCaballo = caballo.IdCaballo;
            this.ListaRazas = razasCaballoParam;
        }   


        #endregion

    }
}
