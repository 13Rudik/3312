using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3312.Classes
{
    class DdConnector
    {
        public static DataTable Select(string sql)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.201.12";
            builder.Port = 3306;
            builder.UserID = "ISP232_RudenkoAA";
            builder.Password = "ISP232_RudenkoAA";
            builder.Database = "ISP232_RudenkoAA_prodaji";
            builder.CharacterSet = "utf8";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
            DataTable table = new DataTable();

            connection.Open();
            table.Load(command.ExecuteReader());
            connection.Close();

            return table;
        }
    }
}
