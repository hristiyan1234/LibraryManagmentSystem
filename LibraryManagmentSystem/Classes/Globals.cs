namespace LibraryManagmentSystem.Classes
{
    internal class Globals
    {
        public static string usernameH = "";

        Database.LibraryDB db = new Database.LibraryDB();


        //public Int32 BookQuan(int id)
        //{
        //    string quantity = "SELECT books.id,(books.quantity - COUNT(*)) AS available FROM books,takebook WHERE takebook.bookId=@id AND books.id=@id GROUP BY takebook.bookId";
        //    DataTable dt = new DataTable();

        //    MySqlParameter[] parameter = new MySqlParameter[1];
        //    parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
        //    parameter[0].Value = id;

        //    dt = db.getData(quantity, parameter);

        //    if (dt.Rows.Count > 0)
        //    {
        //        return id;
        //    }
        //    else
        //    {
        //        return id;
        //    }
        //}


    }
}
