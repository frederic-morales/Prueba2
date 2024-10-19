using System;
using Microsoft.Data.SqlClient;
using BusinessEntity;
using System.Text;
using System.Security.Cryptography;

namespace DataAccessDB
{
    public static class ConeccionDB
    {
        // Cadena de conexión
        private static string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";
        
        public static void SelectUsuarios() // METODO DE SELECT
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Personas";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader(); // Ejecuta la consulta
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
        public static void InsertUsuarios(string NombreUsuario, string Contraseña, string Nombre)
        {
            string query = "INSERT INTO USUARIOS (NombreUsuario, Contraseña, Nombre) VALUES (@NombreUsuario, @Contraseña, @Nombre);";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open(); // Abre la conexión
                    using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", Contraseña);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.ExecuteNonQuery();
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
        public static void InsertPlatos(string Nombre, string Detalle_Plato, double Precio)
        {
            string query = "INSERT INTO PLATOS (Detalle_Plato, Precio, Nombre) VALUES (@Detalle_Plato, @Precio, @Nombre);";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open(); // Abre la conexión
                    using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                    {
                        command.Parameters.AddWithValue("@Detalle_Plato", Detalle_Plato);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.ExecuteNonQuery();
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
        public static void InsertClientes(string Nombre, int Nit)
        {
            string query = "INSERT INTO CLIENTES (Nombre, Nit) VALUES (@Nombre, @Nit);";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open(); // Abre la conexión
                    using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                    {
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Nit", Nit);
                        command.ExecuteNonQuery();
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
        public static void InsertOrdenes(string Nombre, int Nit)
        {
            string query = "INSERT INTO CLIENTES (Nombre, Nit) VALUES (@Nombre, @Nit);";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open(); // Abre la conexión
                    using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                    {
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Nit", Nit);
                        command.ExecuteNonQuery();
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
        public static bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Contraseña FROM Usuarios WHERE NombreUsuario = @nombreUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string contraseñaDB = reader["Contraseña"].ToString();

                                if (contraseñaDB == contraseña)
                                {
                                    Console.WriteLine("Login exitoso.");
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine("Contraseña incorrecta.");
                                    return false;
                                }
                            } 

                            else
                            {
                                Console.WriteLine("Usuario no encontrado.");
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

    }

}