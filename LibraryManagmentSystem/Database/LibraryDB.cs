using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagmentSystem.Database
{
    class LibraryDB
    {
        // свързване с базата
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_system_db");

        // отваряне на втъзката
        public void openConection() 
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //.......................//

        // затваряне на връзката 
        public void closeConection() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //.........................//


        //връща се връзката
        public MySqlConnection getConnection()
        {
            return connection;
        }
        //......................//

        //
        internal int setData(string addData, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand cmd = new MySqlCommand(addData, connection);
            if (mySqlParameter != null)
            {
                cmd.Parameters.AddRange(mySqlParameter);
            }
            openConection();         
            int cmdState = cmd.ExecuteNonQuery();
            closeConection();
            return cmdState;
        }

        internal DataTable getData(string addData, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand cmd = new MySqlCommand(addData, connection);
            if (mySqlParameter != null)
            {
                cmd.Parameters.AddRange(mySqlParameter);
            }
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }
    }
}
