using System;
using Microsoft.Data.SqlClient;
using BusinessEntity;
using System.Diagnostics.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba2_Con_GITyGITHUB
{
    public class ConeccionDB
    {

        // Cadena de conexión
        string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";
        //string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; User Id=FredericAdm; Password=Toko_2005; TrustServerCertificate=True";
        //localhost

        string nombreUsuario = "Frede_24";
        string contra = "Fre23";
        string nombre = "Frederic";

        public void ExecuteConeccionDB()
        {
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
        
        public void InsertUsers()
        {
            string query = "INSERT INTO USUARIOS (NombreUsuario, Contraseña, Nombre) VALUES (@NombreUsuario, @Contraseña, @Nombre);";

            try
            {
                // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre la conexión
                    connection.Open();

                    // Preparar el comando con la consulta y la conexión
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar los parámetros para evitar inyecciones SQL
                        command.Parameters.AddWithValue("@NombreUsuario", "Frede_SM");
                        command.Parameters.AddWithValue("@Contraseña", "Frede_205");
                        command.Parameters.AddWithValue("@Nombre", "Frederic");

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar si la inserción fue exitosa
                        Console.WriteLine($"{rowsAffected} fila(s) insertada(s) correctamente.");
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