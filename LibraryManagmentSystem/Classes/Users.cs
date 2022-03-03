using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagmentSystem.Classes
{
    internal class Users
    {
        Database.LibraryDB db = new Database.LibraryDB();
        //функция, която ще добавя потребители:
        public Boolean AddUser(string fName, string mName, string lName, string user, string phone, string mail, string pass, string userType, string userClass, DateTime date, byte[] photo)
        {
            string insert = "INSERT INTO `users`(`firstName`, `midName`, `lastName`, `username`, `phone`, `email`, `password`, `userType`, `userClass`, `addDate`, `photo`) " +
                            "VALUES (@firstN, @midName, @lastN, @userN, @phone, @mail, @pass, @type, @class, @date, @photo)";
            MySqlParameter[] mySqlParameter = new MySqlParameter[11];

            mySqlParameter[0] = new MySqlParameter("@firstN", MySqlDbType.VarChar);
            mySqlParameter[0].Value = fName;

            mySqlParameter[1] = new MySqlParameter("@midName", MySqlDbType.VarChar);
            mySqlParameter[1].Value = mName;

            mySqlParameter[2] = new MySqlParameter("@lastN", MySqlDbType.VarChar);
            mySqlParameter[2].Value = lName;

            mySqlParameter[3] = new MySqlParameter("@userN", MySqlDbType.VarChar);
            mySqlParameter[3].Value = user;

            mySqlParameter[4] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            mySqlParameter[4].Value = phone;

            mySqlParameter[5] = new MySqlParameter("@mail", MySqlDbType.VarChar);
            mySqlParameter[5].Value = mail;

            mySqlParameter[6] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            mySqlParameter[6].Value = pass;

            mySqlParameter[7] = new MySqlParameter("@type", MySqlDbType.VarChar);
            mySqlParameter[7].Value = userType;

            mySqlParameter[8] = new MySqlParameter("@class", MySqlDbType.VarChar);
            mySqlParameter[8].Value = userClass;

            mySqlParameter[9] = new MySqlParameter("@date", MySqlDbType.Date);
            mySqlParameter[9].Value = date;

            mySqlParameter[10] = new MySqlParameter("@photo", MySqlDbType.LongBlob);
            mySqlParameter[10].Value = photo;

            if (db.setData(insert, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //.....................................................................................

        //функция, която ще aктуализира промени в данните на авторите:
        public Boolean EditUser(int id, string fName, string mName, string lName, string user, string phone,
                                string mail, string pass, string userType, string userClass, DateTime date, byte[] photo)
        {
            string update = "UPDATE `users` SET `firstName`= @firstN, `midName`= @midName, " +
                "`lastName`=@lastN, `username`=@userN, `phone`=@phone, `email`= @mail, `password` = @pass, " +
                "`userType`=@type,`userClass` = @class, `addDate` = @date, `photo`= @photo WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[12];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;

            mySqlParameter[1] = new MySqlParameter("@firstN", MySqlDbType.VarChar);
            mySqlParameter[1].Value = fName;

            mySqlParameter[2] = new MySqlParameter("@midName", MySqlDbType.VarChar);
            mySqlParameter[2].Value = mName;

            mySqlParameter[3] = new MySqlParameter("@lastN", MySqlDbType.VarChar);
            mySqlParameter[3].Value = lName;

            mySqlParameter[4] = new MySqlParameter("@userN", MySqlDbType.VarChar);
            mySqlParameter[4].Value = user;

            mySqlParameter[5] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            mySqlParameter[5].Value = phone;

            mySqlParameter[6] = new MySqlParameter("@mail", MySqlDbType.VarChar);
            mySqlParameter[6].Value = mail;

            mySqlParameter[7] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            mySqlParameter[7].Value = pass;

            mySqlParameter[8] = new MySqlParameter("@type", MySqlDbType.VarChar);
            mySqlParameter[8].Value = userType;

            mySqlParameter[9] = new MySqlParameter("@class", MySqlDbType.VarChar);
            mySqlParameter[9].Value = userClass;

            mySqlParameter[10] = new MySqlParameter("@date", MySqlDbType.Date);
            mySqlParameter[10].Value = date;

            mySqlParameter[11] = new MySqlParameter("@photo", MySqlDbType.LongBlob);
            mySqlParameter[11].Value = photo;

            if (db.setData(update, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //......................................................................................

        //функция, която ще премахва автори от базата данни
        public Boolean DeleteUser(int id)
        {
            string delete = "DELETE FROM `users` WHERE `id` = @id";
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
        //..................................................................

        //проверка дали се повтаря id на потербителя
        public Boolean UniqID(string id)
        {
            string uniq = "SELECT * FROM `users` WHERE `id` = @id";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.VarChar);
            parameter[0].Value = id;

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
        //проверка дали се повтаря username на потербителя
        public Boolean UniqUsername(string username)
        {
            string uniq = "SELECT * FROM `users` WHERE `username` = @userN";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@userN", MySqlDbType.VarChar);
            parameter[0].Value = username;

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

        //проверка дали се повтаря username на потербителя
        public Boolean UniqPhone(string phone)
        {
            string uniq = "SELECT * FROM `users` WHERE `phone` = @phone";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameter[0].Value = phone;

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

        //проверка дали се повтаря имейла на потербителя
        public Boolean UniqMail(string mail)
        {
            string uniq = "SELECT * FROM `users` WHERE `email` = @mail";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@mail", MySqlDbType.VarChar);
            parameter[0].Value = mail;

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

        

        public DataTable UserList()
        {
            string user = "SELECT * FROM `users`";
            DataTable dt = new DataTable();
            dt = db.getData(user, null);
            return dt;
        }
    }
}
