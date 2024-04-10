using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa
{
    internal class Conexionbd
    {
        string cadena = "Data Source=DESKTOP-LG5K25L\\SQLEXPRESS;Initail Catalog=Empresa;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public Conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }
        public void abrir()
        {
            try 
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error  al abrir la BD + "ex.Message);
            }
        }
    }
}
