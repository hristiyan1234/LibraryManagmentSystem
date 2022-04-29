using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagmentSystem.Classes
{
    partial class TakeBook
    {
        Database.LibraryDB db = new Database.LibraryDB();
        Classes.Books books = new Classes.Books();

        //функция, която ще добавя книги във ВЗЕТИ КНИГИ:
        public Boolean IssueBook(int bookID, string nick, string statut, DateTime issueD, DateTime returnD)
        {
            string insert = "INSERT INTO `takebook`(`bookID`, `userNick`, `statut`, `takeDate`, `returnDate`) VALUES(@bookID, @nick, @stat, @take, @return)";
            MySqlParameter[] mySqlParameter = new MySqlParameter[5];

            mySqlParameter[0] = new MySqlParameter("@bookID", MySqlDbType.Int32);
            mySqlParameter[0].Value = bookID;

            mySqlParameter[1] = new MySqlParameter("@nick", MySqlDbType.VarChar);
            mySqlParameter[1].Value = nick;

            mySqlParameter[2] = new MySqlParameter("@stat", MySqlDbType.VarChar);
            mySqlParameter[2].Value = statut;

            mySqlParameter[3] = new MySqlParameter("@take", MySqlDbType.Date);
            mySqlParameter[3].Value = issueD;

            mySqlParameter[4] = new MySqlParameter("@return", MySqlDbType.Date);
            mySqlParameter[4].Value = returnD;

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

        //функция, която ще премахва книги от ВЗЕТИ КНИГИ:
        public Boolean ReturnBook(int bookID, string nick)
        {
            string delete = "DELETE FROM `takebook` WHERE `bookID` = @bookID and `userNick` = @nick LIMIT 1 ";
            MySqlParameter[] mySqlParameter = new MySqlParameter[2];

            mySqlParameter[0] = new MySqlParameter("@bookID", MySqlDbType.Int32);
            mySqlParameter[0].Value = bookID;
            
            mySqlParameter[1] = new MySqlParameter("@nick", MySqlDbType.VarChar);
            mySqlParameter[1].Value = nick;

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

        //функция, която брои взетите книги
        public int countTakenBooks(int bookID)
        {
            string query = "SELECT COUNT(*) as total FROM `takebook` WHERE `bookID` = @id and `statut` = 'ВЗЕТА'";
            MySqlParameter[] mySqlParameter = new MySqlParameter[1];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = bookID;

            return db.getData(query, mySqlParameter).Rows.Count;
        }
        //.........................................

        //...........при вземане на книга, количеството ще пада с 1..................//
        public Boolean UpdateQuanTake(int id)
        {
            string update = "UPDATE `books` SET `quantity` = `quantity` - 1 WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[1];
            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;
            if (db.setData(update, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //................................................................................//

        //...........при връщане на книга, количеството ще се качва с 1..................//
        public Boolean UpdateQuanReturn(int id)
        {
            string update = "UPDATE `books` SET `quantity` = `quantity` + 1 WHERE `id` = @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[1];
            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;
            if (db.setData(update, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //................................................................................//

        public DataTable TakeBooksList()
        {
            string book = "SELECT `bookID` as 'ID на книга' ,`userNick` AS 'Потребител', `statut` AS 'Статут', `takeDate`as 'Дата на взимане', `returnDate`as 'Дата на връщане' FROM `takebook`";
            DataTable dt = new DataTable();
            dt = db.getData(book, null);
            return dt;
        }

    }
}
