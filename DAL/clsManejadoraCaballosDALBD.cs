using ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraCaballosDALBD
    {
        /// <summary>
        /// Función que devuelve un listado de caballos de la base de datos de azure.
        /// Pre: Ninguna
        /// Post: Puede devolver un listado vacío, por algún error con la BD
        /// </summary>
        /// <returns>Listado de caballos</returns>
        public static List<clsCaballo> listadoCompletoCaballosDAL()
        {
            List<clsCaballo> listadoCaballos = new List<clsCaballo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsCaballo caballo;



            try
            {
                conexion = clsConexionBD.getConexion();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.CommandText = "SELECT * FROM Caballo";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            //caballo = new clsCaballo();
                            //caballo.IdCaballo = (int)miLector["IdCaballo"];

                            clsCaballo nuevoCaballo = new clsCaballo((int)miLector["IdCaballo"]);

                            nuevoCaballo.NombreCaballo = (string)miLector["NombreCaballo"];
                            

                            if (miLector["IdRaza"] != DBNull.Value)
                            {
                                nuevoCaballo.IdRaza = (int)miLector["IdRaza"];
                            }

                            
                            listadoCaballos.Add(nuevoCaballo);
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

            return listadoCaballos;
        }

        /// <summary>
        /// Función que actualiza los campos de un caballo, según su id
        /// Pre: caballo con idCaballo y idRaza rellenos, los demás campos opcionales
        /// Post: Ninguno
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static int   actualizarRazaCaballoDAL(int idCaballo, int idRaza)
        {
            int numeroFilasAfectadas = 0;
            SqlConnection conexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = clsConexionBD.getConexion();

                miComando.Connection = conexion;

                miComando.CommandText = "UPDATE Caballo " +
                    "SET idRaza = @IdRaza " +
                    "WHERE idCaballo = @IdCaballo";

                miComando.Parameters.Add("@IdCaballo", System.Data.SqlDbType.Int).Value = idCaballo;
                miComando.Parameters.Add("@IdRaza", System.Data.SqlDbType.Int).Value = idRaza;

                numeroFilasAfectadas = miComando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (miComando.Connection.State == System.Data.ConnectionState.Open)
                {
                    miComando.Connection.Close();
                }
            }

            return numeroFilasAfectadas;
        }
    }
}
