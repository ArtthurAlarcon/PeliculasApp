using System;
using System.Data;
using System.Data.SqlClient;
using PeliculasApp.Clases;

namespace PeliculasApp.Procedimientos
{
    public static class SPHelper
    {
        public static void InsertarPelicula(Pelicula peli) {

            string connString = "Data Source=ARTTHUR;Initial Catalog=test_db;Integrated Security=True;";

            SqlConnection connSQL = new SqlConnection(connString);

            try
            {
                connSQL.Open();

                SqlCommand cmdProcedimiento = new SqlCommand("InsertarPelicula", connSQL)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmdProcedimiento.Parameters.AddWithValue("nombrePelicula", peli.NombrePelicula);
                cmdProcedimiento.Parameters.AddWithValue("año", peli.Año);
                cmdProcedimiento.Parameters.AddWithValue("genero", peli.Genero);

                cmdProcedimiento.ExecuteNonQuery();
            }
            catch(SqlException sqlEx){
                if (sqlEx.Source != null)
                    
                    Console.WriteLine("IOException source: {0}", sqlEx.Source);
                throw;
            }
            finally{
                connSQL.Close();
            }
        }
    }
}
