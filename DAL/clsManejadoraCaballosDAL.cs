using ENT;

namespace DAL
{
    public class clsManejadoraCaballosDAL
    {

        private static List<clsCaballo> listaCaballos = new List<clsCaballo>
        {
            new clsCaballo(1,"Blue Note",0),
            new clsCaballo(2,"Star",0),
            new clsCaballo(3,"Brandy",0),
            new clsCaballo(4,"Lucky",0),
            new clsCaballo(5,"Apollo",0),
            new clsCaballo(6,"Scout",0),
            new clsCaballo(7,"Dakota",0),
            new clsCaballo(8,"Cash",0),
        };

        public static List<clsCaballo> obtenerTodosLosCaballosDAL()
        {
            return listaCaballos;
        }

        public static int actualizarRazaCaballoDAL(int idCaballo, int idRaza)
        {
            int filasAfectadas = 0;

            // Buscar el caballo en la lista
            clsCaballo caballo = listaCaballos.FirstOrDefault(c => c.IdCaballo == idCaballo);

            if (caballo != null)
            {
                // Actualzizar la raza
                caballo.IdRaza = idRaza;
                filasAfectadas = 1;
            }

            return filasAfectadas;
        }
    }



}

