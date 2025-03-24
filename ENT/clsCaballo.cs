namespace ENT
{
    public class clsCaballo
    {
        #region Atributos

        private int idCaballo;

        private string nombreCaballo;

        private int idRaza;

        #endregion

        #region Propiedades


        // Propiedad autoimplementada
        public int IdCaballo {
        
            get 
            {  return idCaballo; 
            } 
            set 
            {
                if(value > 0)
                {
                    idCaballo = value;
                }
                
            }
        }

        public string NombreCaballo {
            get 
            { 
                return nombreCaballo; 
            } 
            set 
            {
                if (!string.IsNullOrEmpty(value) && idRaza > -1)
                {
                    nombreCaballo = value;
                }
            } 
        }

        public int IdRaza { 
            get 
            { 
                return idRaza; 
            } 
            set 
            {
                if(value > -1)
                {
                    idRaza = value;
                }
            } 
        }

        #endregion

        #region Constructores

        public clsCaballo() { }

        public clsCaballo(int idCaballo, String nombreCaballo, int idRaza)
        {

            if(idCaballo > -1)
            {
                this.IdCaballo = idCaballo;
            }

            if (!string.IsNullOrEmpty(nombreCaballo))
            {
                this.nombreCaballo = nombreCaballo;
            }

            if(idRaza > -1)
            {
                this.idRaza = idRaza;
            }
            
            
        }

        #endregion

    }
}
