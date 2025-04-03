using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsRaza
    {

        #region Atributos

        private int idRaza;

        private string nombreRaza;

        #endregion

        #region Propiedades

        public int IdRaza { 
            get 
            { 
                return idRaza; 
            } 
        }

        public string NombreRaza { 
            get 
            { 
                return nombreRaza; 
            } 
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombreRaza = value;
                }
                 
            }
        }

        #endregion

        #region Constructores


        public clsRaza() { }

        public clsRaza(int idRaza, String nombreRaza)
        {
            if (idRaza > 0)
            {
                this.idRaza = idRaza;
            }

            if (!string.IsNullOrEmpty(nombreRaza))
            {
                this.nombreRaza = nombreRaza;
            }
            
        }

        public clsRaza(int idRaza)
        {
            this.idRaza= idRaza;
        }

        #endregion

    }
}
