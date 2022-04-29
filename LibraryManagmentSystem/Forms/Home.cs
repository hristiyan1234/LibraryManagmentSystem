using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagmentSystem.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        Classes.Users users = new Classes.Users();

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
        Classes.TakeBook takeBook = new Classes.TakeBook();

        private void Home_Load(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString();
            if (role == "Админ" || role == "Библиотекар")
            {
                label_home.Text = "Здравейте, " + Classes.Globals.usernameH.ToString() + " вашият профил е със статут на " + role + ".\n" +
                "Имате достъп до цялата система за управление на библиотеката!"; //достъпвам името при влизане за да го визуаизирам тук
                label_home.AutoSize = true;
            }
            else
            {
                label_home.Text = "Здравейте, " + Classes.Globals.usernameH.ToString() + " вашият профил е със статут на " + role + ".\n" +
                "Имате достъп само до част от данните в раздел \"Справки\" \nв системата за управление на библиотеката!";
            }

            string colName = "Потребител";
            string searchValue = Classes.Globals.usernameH.ToString();


            dataGridView_takedBooks.DataSource = takeBook.TakeBooksList(); //изобразява се таблицата с данните на книгите, запазени в базата данни

            if (dataGridView_takedBooks.Rows.Count.Equals(0) && searchValue != "")
            {
                MessageBox.Show("Tаблицата няма елементи/Няма таблица", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ((DataTable)dataGridView_takedBooks.DataSource).DefaultView.RowFilter = string.Format(colName + " like '%{0}%'", searchValue.Trim().Replace("'", "''"));
            }


        }

    }
}
