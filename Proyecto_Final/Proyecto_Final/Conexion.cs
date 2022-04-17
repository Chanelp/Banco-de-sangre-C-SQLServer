using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    class Conexion
    {
        public void Iniciar(string sentencia)
        {
            SqlConnection conexion = new SqlConnection("Data Source=CHANEL;Initial Catalog=BD_20211120;Integrated Security=True");

            conexion.Open();

            SqlCommand comand = new SqlCommand(sentencia, conexion);

            comand.ExecuteNonQuery();

            conexion.Close();

        }
    }
}
