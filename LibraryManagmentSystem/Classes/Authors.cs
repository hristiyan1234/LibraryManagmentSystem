using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;

namespace LibraryManagmentSystem.Classes
{
    partial class Authors
    {
        Database.LibraryDB db = new Database.LibraryDB();
        //функция, която ще добавя авторите:
        public Boolean AddAuthor(string fName, string lName, string biography, byte[] photo)
        {
            string insert = "INSERT INTO `authors`(`firstName`, `lastName`, `biography`, `photo`) VALUES (@firstN, @lastN, @bio, @photo)";
            MySqlParameter[] mySqlParameter = new MySqlParameter[4];

            mySqlParameter[0] = new MySqlParameter("@firstN", MySqlDbType.VarChar);
            mySqlParameter[0].Value = fName;

            mySqlParameter[1] = new MySqlParameter("@lastN", MySqlDbType.VarChar);
            mySqlParameter[1].Value = lName;

            mySqlParameter[2] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            mySqlParameter[2].Value = biography;
            
            mySqlParameter[3] = new MySqlParameter("@photo", MySqlDbType.Blob);
            mySqlParameter[3].Value = photo;

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
        public Boolean EditAuthor(int id, string fName, string lName, string biography, byte[] photo)
        {
            string update = "UPDATE `authors` SET `firstName`= @firstN,`lastName`=@lastN,`biography`=@bio, `photo`=@photo WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[5];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;
            
            mySqlParameter[1] = new MySqlParameter("@firstN", MySqlDbType.VarChar);
            mySqlParameter[1].Value = fName;

            mySqlParameter[2] = new MySqlParameter("@lastN", MySqlDbType.VarChar);
            mySqlParameter[2].Value = lName;

            mySqlParameter[3] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            mySqlParameter[3].Value = biography;
            
            mySqlParameter[4] = new MySqlParameter("@photo", MySqlDbType.Blob);
            mySqlParameter[4].Value = photo;

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
        public Boolean deleteAuthors(int id)
        {
            string delete = "DELETE FROM `authors` WHERE `id` = @id";
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
        public DataTable AuthorList(Boolean mergeName)//ще направя така, че когато по-късно се създава книга да се избира цялото име на авторът, без да се променя таблицата
        {
            string merge = "SELECT `id` as 'ID' ,`firstName`AS 'Име', `lastName` AS 'Фамилия', `biography`as 'Инфо', `photo`as 'Снимка' FROM `authors`";
            if (mergeName)
            {
                merge = "SELECT `id` ,Concat(`firstName`, ' ', `lastName`) AS name, `biography`, `photo` FROM `authors`";
            }

            DataTable dt = new DataTable();
            dt = db.getData(merge, null);
            return dt;

            
        }
    }
}
