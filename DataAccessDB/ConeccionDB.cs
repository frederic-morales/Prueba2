using System;
using Microsoft.Data.SqlClient;
using BusinessEntity;

namespace DataAccessDB
{
    public static class ConeccionDB
    {
        // Cadena de conexión
        private static string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";
        //localhost
        
        public static void ExecuteConeccionDB() //public static string ExecuteConeccionDB() -- para hacer pruebas
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
                       //return reader.GetString(0).ToString();
                    }
                    //return "Mensaje en el try";
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                //return "Hola soy el error1";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                //return "Hola soy un error2";
            }
        }
        public static void InsertUsers()
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