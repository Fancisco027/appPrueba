using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace appPrueba
{
    class dbAccess
    {

        public MySqlConnection conectar( string cadCon )
        {
            MySqlConnection databaseConnection = new MySqlConnection( cadCon );
            
            return databaseConnection;
        }
        public static String consulta( string query)
        {

            //MySqlCommand commandDatabase = new MySqlCommand( query, conectar("") );

            return "0";
        }
    }
}
