using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Collection
{
    public class DatabaseLogic
    {
        
        const string connStr = "Server=studmysql01.fhict.local;Database=dbi461148;Uid=dbi461148;Pwd=P@ssw0rd;";
        MySqlConnection mysqlcon;

        public DatabaseLogic()
        {
            mysqlcon = new MySqlConnection(connStr);
        }

        public void InsertScore(double Score, string Name)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connection established");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Code == 0)
            {
                Console.WriteLine("Can't connect to database");
                return;
            }
            

            conn.Close();
        }

        public void getLogin()
        {
            
        }

    }
}
