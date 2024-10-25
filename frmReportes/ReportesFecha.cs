using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace frmReportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar los tipos de reporte al ComboBox
            comboBox1.Items.Add("Ventas por Día");
            comboBox1.Items.Add("Ventas por Mesa");
            comboBox1.Items.Add("Platos más Vendidos");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=LAPTOPDELL\MSSQLSERVER01; Database=FredericDB; Integrated Security=True; TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Obtener el tipo de reporte seleccionado
                    string tipoReporte = comboBox1.SelectedItem.ToString();
                    string query = "";

                    // Seleccionar la consulta SQL según el tipo de reporte
                    if (tipoReporte == "Ventas por Día")
                    {
                        query = @"
                        SELECT Facturas.Fecha, SUM(Platos.Precio * Detalles_Orden.Cantidad) AS TotalVentas
                        FROM Facturas
                        JOIN Ordenes ON Facturas.IdOrden = Ordenes.Id
                        JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.IdOrden
                        JOIN Platos ON Detalles_Orden.IdPlato = Platos.Id
                        WHERE Facturas.Fecha BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY Facturas.Fecha";
                    }
                    else if (tipoReporte == "Ventas por Mesa")
                    {
                        query = @"
                        SELECT Ordenes.Mesa AS Mesa, SUM(Platos.Precio * Detalles_Orden.Cantidad) AS TotalVentas
                        FROM Facturas
                        JOIN Ordenes ON Facturas.IdOrden = Ordenes.Id
                        JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.IdOrden
                        JOIN Platos ON Detalles_Orden.IdPlato = Platos.Id
                        WHERE Facturas.Fecha BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY Ordenes.Mesa";
                    }
                    else if (tipoReporte == "Platos más Vendidos")
                    {
                        query = @"
                        SELECT Platos.Nombre AS Plato, COUNT(Detalles_Orden.IdPlato) AS CantidadVendida
                        FROM Detalles_Orden
                        JOIN Platos ON Detalles_Orden.IdPlato = Platos.Id
                        JOIN Ordenes ON Detalles_Orden.IdOrden = Ordenes.Id
                        WHERE Ordenes.Fecha BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY Platos.Nombre
                        ORDER BY CantidadVendida DESC";
                    }

                    // Crear el comando SQL
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicial.Value.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFinal.Value.Date); // Uso correcto de @fechaFin

                    // Ejecutar y llenar los datos en el DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el reporte: " + ex.Message);
                }
            }
        }

        // Eventos vacíos que puedes eliminar si no los necesitas
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void fechaInicial_ValueChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
