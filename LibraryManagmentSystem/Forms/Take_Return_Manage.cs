using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class Take_Return_Manage : Form
    {

        public Take_Return_Manage()
        {
            InitializeComponent();
        }

        Database.LibraryDB db = new Database.LibraryDB();
        Classes.Books currentBooks = new Classes.Books();
        Classes.TakeBook takeBook = new Classes.TakeBook();
        Classes.Users users = new Classes.Users();
        Classes.Users currentUsers = new Classes.Users();

        private void Take_Return_Manage_Load(object sender, EventArgs e)
        {

        }

        //.........................................Бутонът за изход........................................................//
        private void label_close_MouseEnter(object sender, EventArgs e) // когато мишката е в/у хикса да светне хикса
        {
            label_close.ForeColor = Color.Red; // X става червен
        }

        private void label_close_MouseLeave(object sender, EventArgs e) // когато мишката се отдръне
        {
            label_close.ForeColor = Color.Ivory; //цветът се връща
        }

        private void label_close_Click(object sender, EventArgs e) // като се натисне хикса се излиза от апликацията
        {
            if (MessageBox.Show("Изкате ли да излезете от приложението?", "Излизане", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //.............................................................................................................................


        private void button_books_Click(object sender, EventArgs e)
        {
            dataGridView_all.DataSource = currentBooks.BooksList(); //изобразява се таблицата с данните на книгите, запазени в базата данни
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_all.Columns[9];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button_takenBooks_Click(object sender, EventArgs e)
        {
            dataGridView_all.DataSource = takeBook.TakeBooksList(); //изобразява се таблицата с данните на книгите, запазени в базата данни
        }

        //...............При натискане на бутон ВЗЕМАНЕ се прави оторизация и ако е успешна се отваря формата за вземане.........//
        private void button_take_Click(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString();
            if (role == "Ученик" || role == "Гост" || role == "Учител")
            {
                button_take.Enabled = false;
                button_return.Enabled = false;
                MessageBox.Show("Този профил няма достъп до това меню!", "Нямате правомощия!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Forms.TakeBook_Form takeBook_Form = new TakeBook_Form();
                takeBook_Form.Show();
            }

        }
        //..............................................................................................................................//

        //...............При натискане на бутон ВРЪЩАНЕ се прави оторизация и ако е успешна се отваря формата за връщане...............//
        private void button_return_Click(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString();

            if (role == "Ученик" || role == "Гост" || role == "Учител")
            {
                button_take.Enabled = false;
                button_return.Enabled = false;
                MessageBox.Show("Този профил няма достъп до това меню!", "Нямате правомощия!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ReturnBook_Form returnBook_Form = new ReturnBook_Form();
                returnBook_Form.Show();
            }

        }
        //..............................................................................................................................//

        //...............................Частта, в която ще се извършва филтрирането на таблицата.......................................//

        string colName;
        private void radioButton_title_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_all.Rows.Count.Equals(0))
            {
                if (radioButton_title.Checked && MessageBox.Show("Няма данни за търсене/ Не сте избрали таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    radioButton_title.Checked = false;
                }
                return;
            }
            colName = dataGridView_all.Columns[1].Name;//Column Number of Search
        }

        private void radioButton_author_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_all.Rows.Count.Equals(0))
            {
                if (radioButton_author.Checked && MessageBox.Show("Няма данни за търсене/ Не сте избрали таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    radioButton_author.Checked = false;
                }
                return;
            }
            colName = dataGridView_all.Columns[2].Name;//Column Number of Search
        }

        private void radioButton_isbn_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_all.Rows.Count.Equals(0))
            {
                if (radioButton_isbn.Checked && MessageBox.Show("Няма данни за търсене/ Не сте избрали таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    radioButton_isbn.Checked = false;
                }
                return;
            }
            colName = dataGridView_all.Columns[3].Name;//Column Number of Search
        }

        private void radioButton_pub_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_all.Rows.Count.Equals(0))
            {
                if (radioButton_pub.Checked && MessageBox.Show("Няма данни за търсене/ Не сте избрали таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    radioButton_pub.Checked = false;
                }
                return;
            }
            colName = dataGridView_all.Columns[5].Name;//Column Number of Search
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox_search.Text; // търсената стойност се присвоява от текста в текстовата кутия
            try
            {
                if (dataGridView_all.Rows.Count.Equals(0) && searchValue != "")
                {
                    MessageBox.Show("Tаблицата няма елементи/Няма таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_search.Text = "";
                }
                else
                {
                    ((DataTable)dataGridView_all.DataSource).DefaultView.RowFilter = string.Format(colName + " like '%{0}%'", searchValue.Trim().Replace("'", "''"));
                }
            }
            catch (Exception)
            {
                if (searchValue != "" && MessageBox.Show("Изберете по какво да търсите", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox_search.Text = "";
                }
            }

        }
        //................................................край на фрагмента за филтриране на дани.................................//

        //...при натискане на бутон за изтегляне, ще се извика прозорец за избор на директория за изтегляне на ексел формат на datagridview-то...//
        private void button_download_Click(object sender, EventArgs e)
        {
            if (dataGridView_all.Rows.Count > 0) //ако има данни в таблицата
            {
                // отваря се ексел   
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // създавам нов документn  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // нов лист за данните
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // получаваме рефернция към първия лист. съхранява референция към втория лист 
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Tаблица с книги";
                // съхраняване стойността на името на колоните
                for (int i = 1; i < dataGridView_all.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView_all.Columns[i - 1].HeaderText;
                }
                //съхраняване на стойността на всеки ред и колона в Excel лист  
                for (int i = 0; i < dataGridView_all.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView_all.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_all.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // приложението се затваря и пита за запазване
                app.GetSaveAsFilename("Book");
            }
            else
            {
                MessageBox.Show("Няма данни в таблицата!", "Info");
            }
        }
        //........................................................................................................................//

    }
}
