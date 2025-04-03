using ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraRazasDALBD
    {
        /// <summary>
        /// Función que devuelve un listado de caballos de la base de datos de azure.
        /// Pre: Ninguna
        /// Post: Puede devolver un listado vacío, por algún error con la BD
        /// </summary>
        /// <returns>Listado de caballos</returns>
        public static List<clsRaza> listadoCompletoRazasDAL()
        {
            List<clsRaza> listadoRazas = new List<clsRaza>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsRaza raza;



            try
            {
                conexion = clsConexionBD.getConexion();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.CommandText = "SELECT * FROM Raza";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                           

                            clsRaza nuevaRaza = new clsRaza((int)miLector["IdRaza"]);

                            nuevaRaza.NombreRaza = (string)miLector["Nombre"];

                            listadoRazas.Add(nuevaRaza);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return listadoRazas;
        }
    }
}
