using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class Login_Panel : Form
    {
        public Login_Panel()
        {
            InitializeComponent();
        }
        private void label_close_MouseEnter(object sender, EventArgs e) //  когато мишката е в/у хикса да светне хикса в червено
        {
            label_close.ForeColor = Color.Red;
        }
        private void label_close_MouseLeave(object sender, EventArgs e) //съответно после пак си е в бяло
        {
            label_close.ForeColor = Color.Ivory;
        }
        private void label_close_Click(object sender, EventArgs e) //като се натисне хикса се излиза от апликацията
        {
            Application.Exit();
        }
        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_password.Focus(); // курсорът отива на полето за парола
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                button_login.PerformClick(); // бутонът се води натиснат и започва проверката за login
            }
        }

        private Dashboard_Form dashboard_Form = null;
        public Login_Panel(Dashboard_Form dashboard)
        {
            dashboard_Form = dashboard as Dashboard_Form;
            InitializeComponent();
        }

        //при натискане на логин бутона се проверява дали в базата данни съществува такъв потребител
        private void button_login_Click(object sender, EventArgs e)
        {
            Database.LibraryDB db = new Database.LibraryDB();
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //задавам кои колони да сравнява софтуера
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@user AND `password`=@pass", db.getConnection());

            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0) //ако данните в панела съвпадат със съответните колони в базата данни и потребителят е админ
            {
                Classes.Globals.usernameH = dt.Rows[0]["username"].ToString();
                dashboard_Form.Enabled = true; // при натискане на логин бутона панела се 'отключва'
                this.Hide();// и логин формата се затваря


            }
            else //иначе......
            {
                //if (!dt.Columns[8].DataType.Equals("Админ"))
                //{
                //    MessageBox.Show("Този потребител не е администратор! Моля влезте с админ акаунт!", "Неупълномощено лице", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                if (username.Trim().Equals(""))// aко полето за потребителско име е празно
                {
                    MessageBox.Show("Въведете потребителско име!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (password.Trim().Equals(""))// aко полето за парола е празно
                {
                    MessageBox.Show("Въведете парола", "Липсват данни!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // aко данните не присъстват в базата данни
                {
                    MessageBox.Show("Грешно потребителско име или парола!", "Грешни данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
                string homeUsername = "";
                textBox_username.Text = homeUsername;
        }
    }
}
