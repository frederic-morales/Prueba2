using System;
using Microsoft.Data.SqlClient;

namespace Prueba2_Con_GITyGITHUB
{
    internal class ConeccionDB
    {
        public void ExecuteConeccionDB()
        {
            // Cadena de conexión
            string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";
            //string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; User Id=FredericAdm; Password=Toko_2005; TrustServerCertificate=True";
            //localhost

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir conexión
                    connection.Open();

                    // Ejemplo de consulta
                    string query = "SELECT * FROM Personas";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Ejecutar la consulta
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       Console.WriteLine($"Id:{reader.GetInt32(0)} Nombre:{reader.GetString(1)} Apellidos:{reader.GetString(2)}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }

        }
    }
}