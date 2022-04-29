using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagmentSystem.Forms
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            //таблото се деактивира, докато не се осъществи успешно влизане в системата
            this.Enabled = false;
            // при стартиране на кода в program.cs е зададено да се отваря таблото, сега ще се отваря логин панела заедно с таблото
            Login_Panel login = new Login_Panel(this);
            login.Show();
        }

        Classes.Users users = new Classes.Users();

        //..............................УПРАВЛЕНИЕ НА МЕНЮТО............................................//
        private void button_home_Click(object sender, EventArgs e)
        {

            this.panel_view.Controls.Clear();
            Home home = new Home();//..
            home.TopLevel = false;
            home.AutoScroll = true;
            home.StartPosition = FormStartPosition.CenterParent;
            this.panel_view.Controls.Add(home);
            home.Show();

        }

        private void button_users_Click(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString(); // ще пази userType на потребителя
            if (role == "Ученик" || role == "Гост" || role == "Учител") // ако ролята е тази , то потребителя няма привилегии
            {
                button_users.Enabled = false;
                button_books.Enabled = false;
                button_authors.Enabled = false;
                MessageBox.Show("Този профил няма достъп до това меню!", "Нямате правомощия!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение

            }
            else
            {
                this.panel_view.Controls.Clear();
                ManageUsers_Form manageUsers_Form = new ManageUsers_Form();
                manageUsers_Form.TopLevel = false;
                manageUsers_Form.AutoScroll = true;
                manageUsers_Form.StartPosition = FormStartPosition.CenterParent;
                this.panel_view.Controls.Add(manageUsers_Form);
                manageUsers_Form.Show();
            }
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString();
            if (role == "Ученик" || role == "Гост" || role == "Учител")
            {

                button_users.Enabled = false;
                button_books.Enabled = false;
                button_authors.Enabled = false;
                MessageBox.Show("Този профил няма достъп до това меню!", "Нямате правомощия!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.panel_view.Controls.Clear();
                Books_Manage_Form booksform = new Books_Manage_Form();
                booksform.TopLevel = false;
                booksform.AutoScroll = true;
                booksform.StartPosition = FormStartPosition.CenterParent;
                this.panel_view.Controls.Add(booksform);
                booksform.Show();
            }
        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            string username = Classes.Globals.usernameH.Trim().ToString();
            DataTable table = users.searchUser(username);
            string role = table.Rows[0][8].ToString();

            if (role == "Ученик" || role == "Гост" || role == "Учител")
            {
                button_users.Enabled = false;
                button_books.Enabled = false;
                button_authors.Enabled = false;
                MessageBox.Show("Този профил няма достъп до това меню!", "Нямате правомощия!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.panel_view.Controls.Clear();
                Authors_Manage_Form authors_Manage_Form = new Authors_Manage_Form();//..
                authors_Manage_Form.TopLevel = false;
                authors_Manage_Form.AutoScroll = true;
                authors_Manage_Form.StartPosition = FormStartPosition.CenterParent;
                this.panel_view.Controls.Add(authors_Manage_Form);
                authors_Manage_Form.Show();
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            this.panel_view.Controls.Clear();
            Take_Return_Manage take_Return_Manage = new Take_Return_Manage();//..
            take_Return_Manage.TopLevel = false;
            take_Return_Manage.AutoScroll = true;
            take_Return_Manage.StartPosition = FormStartPosition.CenterParent;
            this.panel_view.Controls.Add(take_Return_Manage);
            take_Return_Manage.Show();
        }

        //..........................КРАЙ НА УПРАВЛЕНИЕ НА МЕНЮТО......................................................//


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

        private void panel_view_MouseEnter(object sender, EventArgs e)
        {
            dataGridView_takedBooks.Visible = true;
            label_books.Visible = true;
            panel_TakedBooks.Visible = true;

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

