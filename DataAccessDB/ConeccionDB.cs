using System;
using Microsoft.Data.SqlClient;
using BusinessEntity;
using System.Text;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessDB
{
    public static class ConeccionDB
    {
        // Cadena de conexión
        private static string connectionString = "Server=LAPTOPDELL\\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";
        
        
        //METODOS DE SELECT
        public static void SelectUsuarios() // TRAER LOS USUARIOS
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM USUARIOS";
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
        public static List<string> obtenerPlato(string nombrePlato) 
        {
            List<string> datosPlato = new List<string>(); 
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Nombre, Detalle_Plato, Precio FROM Platos WHERE Nombre = @NombrePlato";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombrePlato", nombrePlato);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine($"Id:{reader.GetInt32(0)} Nombre:{reader.GetString(1)} Apellidos:{reader.GetString(2)}");
                        int id = Convert.ToInt32(reader["ID"]); 
                        datosPlato.Add(Convert.ToString(id));
                        datosPlato.Add(reader.GetString(1));
                        datosPlato.Add(reader.GetString(2));
                        decimal precio = reader.GetDecimal(3);
                        datosPlato.Add(Convert.ToString(precio));
                    }
                }
                return datosPlato;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                datosPlato.Add("Plato no encontrado");
                return datosPlato;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                datosPlato.Add("Plato no encontrado");
                return datosPlato;
            }
        }
        public static int obtenerIdCliente(int NitIngresado)
        {
            int IdCliente = 0;  
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id FROM CLIENTES WHERE nit = @NitIngresado";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NitIngresado", NitIngresado);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine($"Id:{reader.GetInt32(0)} Nombre:{reader.GetString(1)} Apellidos:{reader.GetString(2)}");
                        IdCliente = reader.GetInt32(0); 
                    }
                }
                return IdCliente;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return IdCliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return IdCliente;
            }
        }


        //METODOS DE INSERCIÓN
        public static string InsertUsuarios(string NombreUsuario, string Contraseña, string Nombre)
        {
            try
            {
                bool userNameDiferente = false;
                string mensaje = " ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string querySELECT = "SELECT NombreUsuario From USUARIOS";
                    connection.Open();
                    SqlCommand command = new SqlCommand(querySELECT, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string userNameDB = reader.GetString((0));
                        if (userNameDB != NombreUsuario)
                        {
                            userNameDiferente = true;
                            mensaje = "User Diferente";
                        }
                        else
                        {
                            userNameDiferente = false;
                            mensaje = "Nombre de usuario ya existe";
                        }
                    }
                }

                if (userNameDiferente)
                {
                    string query = "INSERT INTO USUARIOS (NombreUsuario, Contraseña, Nombre) VALUES (@NombreUsuario, @Contraseña, @Nombre);";
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
                        mensaje = "Usuario agregado con exito";
                    }
                }

                return mensaje;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return "Error" + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return "Error" + ex.Message;
            }
        } 
        public static string InsertPlatos(string Nombre, string Detalle_Plato, double Precio)
        {
            try
            {
                bool nombreDiferente = false;
                string mensaje = " ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string querySELECT = "SELECT Nombre From PLATOS";
                    connection.Open();
                    SqlCommand command = new SqlCommand(querySELECT, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string NombreDB = reader.GetString((0));
                        if (NombreDB != Nombre)
                        {
                            nombreDiferente = true;
                            mensaje = "Nombre Diferente";
                        }
                        else
                        {
                            nombreDiferente = false;
                            mensaje = "Nombre de plato ya existe";
                        }
                    }
                }
                if (nombreDiferente)
                {
                    string query = "INSERT INTO PLATOS (Detalle_Plato, Precio, Nombre) VALUES (@Detalle_Plato, @Precio, @Nombre);";
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
                        mensaje = "Plato agregado con exito";
                    }
                }
                return mensaje;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return "Error" + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return "Error" + ex.Message;
            }
        }
        public static string InsertClientes(string Nombre, string Nit)
        {
            try
            {
                bool nitDiferente = false;
                string mensaje = " ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string querySELECT = "SELECT Nit From CLIENTES";
                    connection.Open();
                    SqlCommand command = new SqlCommand(querySELECT, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string NitDB = reader.GetString((0));
                        if (NitDB != Nit)
                        {
                            nitDiferente = true;
                            mensaje = "NIT Diferente";
                        }
                        else
                        {
                            nitDiferente = false;
                            mensaje = "NIT ya existe";
                        }
                    }
                }

                if (nitDiferente)
                {
                    string query = "INSERT INTO CLIENTES (Nombre, Nit) VALUES (@Nombre, @Nit);";
                    using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                    {
                        connection.Open(); // Abre la conexión
                        using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                        {
                            command.Parameters.AddWithValue("@Nombre", Nombre);
                            command.Parameters.AddWithValue("@Nit", Nit);
                            command.ExecuteNonQuery();
                        }
                        mensaje = "Cliente agregado con exito";
                    }
                }
                return mensaje;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return "Error" + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return "Error" + ex.Message;
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

        public static string InsertFacturas(int IdOrden, string Detalle_Factura)
        {
            try
            {
                bool ordenNoEcontrada = false;
                string mensaje = "Nada de nada";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id FROM ORDENES WHERE Id = @IdOrden";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdOrden", IdOrden);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mensaje = "Orden Econtrada";
                                ordenNoEcontrada = true;
                            }

                            else
                            {
                                mensaje = "Orden no encontrada";
                                ordenNoEcontrada = false;
                            }
                        }
                    }
                }

                if (ordenNoEcontrada)
                {
                    string query = "INSERT INTO FACTURAS (IdOrden, Detalle_Factura, Fecha) VALUES (@IdOrden, @Detalle_Factura, @Fecha);";
                    using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                    {
                        connection.Open(); // Abre la conexión
                        using (SqlCommand command = new SqlCommand(query, connection)) // Preparar el comando con la consulta y la conexión
                        {
                            DateTime dateTime = DateTime.Now;
                            command.Parameters.AddWithValue("@IdOrden", IdOrden);
                            command.Parameters.AddWithValue("@Detalle_Factura", Detalle_Factura);
                            command.Parameters.AddWithValue("@Fecha", dateTime.Date);
                            command.ExecuteNonQuery();
                        }
                        mensaje = "Cliente agregado con exito";
                    }
                }
                return mensaje;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return "SQlException" + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return "Exception" + ex.Message;
            }
        }


        //INSERCION EN ORDENES Y DETALLES ORDENES
        public static int InsertOrden(int IdCliente, int Mesa, string Detalle_Orden, DateTime Fecha)
        {
            int IdOrdenGenerada = 0;
            try
            {
                string query = @"INSERT INTO ORDENES (IdCliente, Mesa, Detalle_Orden, Fecha) 
                                VALUES (@IdCliente, @Mesa, @Detalle_Orden, @Fecha);
                                SELECT SCOPE_IDENTITY();";
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", IdCliente);
                        command.Parameters.AddWithValue("@Mesa", Mesa);
                        command.Parameters.AddWithValue("@Detalle_Orden", Detalle_Orden);
                        command.Parameters.AddWithValue("@Fecha", Fecha.Date);

                        object result = command.ExecuteScalar();    
                        int IdGenerado = Convert.ToInt32(result);
                        IdOrdenGenerada = IdGenerado;
                        //command.ExecuteNonQuery();
                    }
                }

                return IdOrdenGenerada;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                //return "Error" + ex.Message;
                return IdOrdenGenerada;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                //return "Error" + ex.Message;
                return IdOrdenGenerada;
            }
        }
        public static int InsertDetalleOrdenes(int IdOrden, int IdPlato, int Cantidad)
        {
            try
            {
                string query = @"INSERT INTO DETALLES_ORDEN (IdOrden, IdPlato, Cantidad) 
                                VALUES (@IdOrden, @IdPlato, @Cantidad);";
                using (SqlConnection connection = new SqlConnection(connectionString)) // Uso de 'using' para manejar la conexión y liberar recursos automáticamente
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdOrden", IdOrden);
                        command.Parameters.AddWithValue("@IdPlato", IdPlato);
                        command.Parameters.AddWithValue("@Cantidad", Cantidad);
                        
                        object result = command.ExecuteScalar();

                    }
                }
                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQlException" + ex.Message);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
                return 1;
            }
        }
    }

}