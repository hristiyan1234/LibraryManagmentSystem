using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LibraryManagmentSystem.Classes
{
    partial class Books
    {
        Database.LibraryDB db = new Database.LibraryDB();

        //функция, която ще добавя книги:
        public Boolean AddBook(string title, int authorID, string isbn, string genre, string pub, int quantity, DateTime date, string annotation, byte[] cover)
        {
            string insert = "INSERT INTO `books`(`title`, `author_id`, `isbn`, `genre`, `publish`, `quantity`, `addDate`, `annotation`, `coverPhoto`) " +
                            "VALUES ( @title, @authID, @isbn, @genre, @pub, @quan, @date, @annt, @cover)";
            MySqlParameter[] mySqlParameter = new MySqlParameter[9];

            mySqlParameter[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            mySqlParameter[0].Value = title;

            mySqlParameter[1] = new MySqlParameter("@authID", MySqlDbType.Int32);
            mySqlParameter[1].Value = authorID;

            mySqlParameter[2] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            mySqlParameter[2].Value = isbn;

            mySqlParameter[3] = new MySqlParameter("@genre", MySqlDbType.VarChar);
            mySqlParameter[3].Value = genre;

            mySqlParameter[4] = new MySqlParameter("@pub", MySqlDbType.VarChar);
            mySqlParameter[4].Value = pub;

            mySqlParameter[5] = new MySqlParameter("@quan", MySqlDbType.Int32);
            mySqlParameter[5].Value = quantity;

            mySqlParameter[6] = new MySqlParameter("@date", MySqlDbType.Date);
            mySqlParameter[6].Value = date;

            mySqlParameter[7] = new MySqlParameter("@annt", MySqlDbType.VarChar);
            mySqlParameter[7].Value = annotation;

            mySqlParameter[8] = new MySqlParameter("@cover", MySqlDbType.LongBlob);
            mySqlParameter[8].Value = cover;

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


        public Boolean UpdateBook(int id, string title, int authorID, string isbn, string genre, string pub, int quantity, DateTime date, string annotation, byte[] cover)
        {
            string update = "UPDATE `books` SET `title` = @title, `author_id` = @authID, `isbn` = @isbn, `genre` = @genre, `publish` = @pub, `quantity` = @quan, `addDate` = @date, `annotation` = @annt, `coverPhoto` = @cover WHERE `id`= @id";
            MySqlParameter[] mySqlParameter = new MySqlParameter[10];

            mySqlParameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            mySqlParameter[0].Value = id;

            mySqlParameter[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            mySqlParameter[1].Value = title;

            mySqlParameter[2] = new MySqlParameter("@authID", MySqlDbType.Int32);
            mySqlParameter[2].Value = authorID;

            mySqlParameter[3] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            mySqlParameter[3].Value = isbn;

            mySqlParameter[4] = new MySqlParameter("@genre", MySqlDbType.VarChar);
            mySqlParameter[4].Value = genre;

            mySqlParameter[5] = new MySqlParameter("@pub", MySqlDbType.VarChar);
            mySqlParameter[5].Value = pub;

            mySqlParameter[6] = new MySqlParameter("@quan", MySqlDbType.Int32);
            mySqlParameter[6].Value = quantity;

            mySqlParameter[7] = new MySqlParameter("@date", MySqlDbType.Date);
            mySqlParameter[7].Value = date;

            mySqlParameter[8] = new MySqlParameter("@annt", MySqlDbType.VarChar);
            mySqlParameter[8].Value = annotation;

            mySqlParameter[9] = new MySqlParameter("@cover", MySqlDbType.LongBlob);
            mySqlParameter[9].Value = cover;

            if (db.setData(update, mySqlParameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //.....................................................................................

        public Boolean DeleteBook(int id)
        {
            string delete = "DELETE FROM `books` WHERE `id` = @id";
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

        //проверка дали се повтаря уникалния код на книгата
        public Boolean UniqISBN(string isbn)
        {
            string uniq = "SELECT * FROM `books` WHERE `isbn` = @isbn";
            DataTable dt = new DataTable();

            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameter[0].Value = isbn;

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

        //търсене на книга по нейния ИД & ISBN
        public DataTable searchByIDorISBN(string searchID, int id, string isbn)
        {
            string query;
            MySqlParameter[] parameters = new MySqlParameter[1];
            if (searchID.Equals("id"))
            {
                query = "SELECT * FROM `books` WHERE `id` = @id";
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM `books` WHERE `isbn` = @isbn";
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
            }

            DataTable dt = new DataTable();
            dt = db.getData(query, parameters);
            return dt;
        }
        //...................................................

       

        //BOOK INFO за данните при обращение
        public DataRow bookInfo(int bookID)
            {
                string book = "select b.id,`title`,concat(a.firstName, ' ', a.lastName) as author, `isbn`," +
                                          "`genre`, `publish`, `quantity`,`addDate`, `annotation`, `coverPhoto` from books b, authors a where b.author_id = a.id and b.id = @id";

                MySqlParameter[] parameters = new MySqlParameter[1];
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = bookID;
                DataTable dt = new DataTable();
                dt = db.getData(book, parameters);
                return dt.Rows[0];
            }

            //................................
            public DataTable BooksList()
            {
                string book = "select books.id as 'ID',books.title as 'Заглавие',concat(authors.firstName, ' ', authors.lastName) as 'Автор'," +
                              "books.isbn as 'ISBN',books.genre as 'Жанр', books.publish as 'Издателство',books.quantity as 'Количество',books.addDate as 'Дата'" +
                              ",books.annotation as 'Анотация',books.coverPhoto as 'Корица' from books, authors where authors.id = books.author_id";
                DataTable dt = new DataTable();
                dt = db.getData(book, null);
                return dt;
            }
        }
    }

