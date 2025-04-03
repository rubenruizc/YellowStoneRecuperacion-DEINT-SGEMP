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


        // Propiedad autoimplementada (si no quiero poner codigo, es decir ningún if por ejemplo)
        public int IdCaballo {
        
            get 
            {  return idCaballo; 
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
                this.idCaballo = idCaballo;
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

        public clsCaballo(int idCaballo)
        {
            this.idCaballo = idCaballo ;
        }

        #endregion

    }
}
