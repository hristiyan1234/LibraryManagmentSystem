using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagmentSystem.Classes
{
    internal class Publish
    {
        Database.LibraryDB db = new Database.LibraryDB();

        //Добавяне на издаелска къща
        public Boolean AddPub(string pub)
        {
            string insert = "INSERT INTO `publish`(`publishHouse`) VALUES (@pub)";
            MySqlParameter[] mySqlParameter = new MySqlParameter[1];

            mySqlParameter[0] = new MySqlParameter("@pub", MySqlDbType.VarChar);
            mySqlParameter[0].Value = pub;

            if (db.setData(insert, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Промяна на данните на издаелска къща
        public Boolean EditPub(int id, string pub)
        {
            string update = "UPDATE `publish` SET `publishHouse`= @pub WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[2];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;

            mySqlParameter[1] = new MySqlParameter("@pub", MySqlDbType.Int32);
            mySqlParameter[1].Value = pub;

            if (db.setData(update, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Премахване на издаелска къща
        public Boolean DeletePub(int id)
        {
            string delete = "DELETE FROM `publish` WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[1];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;

            if (db.setData(delete, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //проверка дали се повтаря името на издателството
        public Boolean UniqPub(string publishHouse)
        {
            string uniq = "SELECT * FROM `publish` WHERE `publishHouse` = @pub";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@pub", MySqlDbType.VarChar);
            parameter[0].Value = publishHouse;

            dt = db.getData(uniq, parameter);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //...................................................

        public DataTable PubList()
        {
            string pub = "SELECT * FROM `publish`";
            DataTable dt = new DataTable();
            dt = db.getData(pub, null);
            return dt;
        }
    }
}
