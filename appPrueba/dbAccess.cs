using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace appPrueba
{
    class dbAccess
    {

        public MySqlConnection conectar(  )
        {
            string cadCon = "server=localhost;database=jarcieria;user=root;pwd=;";

            MySqlConnection databaseConnection = new MySqlConnection(cadCon);

            return databaseConnection;

        }
        public int consulta(string query)
        {

            int resultado = 0;
            
            string cadcon = "server=localhost;database=dblagaceroprocess;user=root;pwd=;";
            MySqlConnection conexion = new MySqlConnection(cadcon);
            try
            {
                conexion.Open();
                MySqlCommand com = new MySqlCommand(query, conexion);
                resultado = com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return resultado;

        }
    }
}
