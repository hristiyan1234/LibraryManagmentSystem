using System;
using System.Net;
using System.Net.Mail;
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

        private void button_home_Click(object sender, EventArgs e)
        {
            Dashboard_Form dashboard_Form = new Dashboard_Form();
            dashboard_Form.Show();

        }
        
        private void button_users_Click(object sender, EventArgs e)
        {
            this.panel_view.Controls.Clear();
            ManageUsers_Form manageUsers_Form = new ManageUsers_Form();//..
            manageUsers_Form.TopLevel = false;
            manageUsers_Form.AutoScroll = true;
            manageUsers_Form.StartPosition = FormStartPosition.CenterParent;
            this.panel_view.Controls.Add(manageUsers_Form);
            manageUsers_Form.Show();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            this.panel_view.Controls.Clear();
            Books_Manage_Form booksform = new Books_Manage_Form(); //...
            booksform.TopLevel = false;
            booksform.AutoScroll = true;
            booksform.StartPosition = FormStartPosition.CenterParent;
            this.panel_view.Controls.Add(booksform);
            booksform.Show();
        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            this.panel_view.Controls.Clear();
            Authors_Manage_Form authors_Manage_Form = new Authors_Manage_Form();//..
            authors_Manage_Form.TopLevel = false;
            authors_Manage_Form.AutoScroll = true;
            authors_Manage_Form.StartPosition = FormStartPosition.CenterParent;
            this.panel_view.Controls.Add(authors_Manage_Form);
            authors_Manage_Form.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage("hrischov@gmail.com", textBox3.Text, textBox2.Text, textBox1.Text);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("hrischov@gmail.com", textBox4.Text);//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("Mail Send");
        }
    }
}
