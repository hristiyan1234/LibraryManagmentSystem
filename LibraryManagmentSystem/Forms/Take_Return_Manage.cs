using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
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


        private void Take_Return_Manage_Load(object sender, EventArgs e)
        {

        }

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
        private void button_books_Click(object sender, EventArgs e)
        {
            dataGridView_all.DataSource = currentBooks.BooksList(); //изобразява се таблицата с данните на книгите, запазени в базата данни
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_all.Columns[9];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        Classes.Users currentUsers = new Classes.Users();
        private void button_users_Click(object sender, EventArgs e)
        {
            currentBooks.BooksList().Clear();
            dataGridView_all.DataSource = currentUsers.UserList();
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_all.Columns[11];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button_AuthorBooks_Click(object sender, EventArgs e)
        {
            Publish_Manage_Form publish_Manage_Form = new Publish_Manage_Form();//..
            publish_Manage_Form.StartPosition = FormStartPosition.CenterParent;
            publish_Manage_Form.Show();
        }

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
            string searchValue = textBox_search.Text;//Column Number of Search
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


        private void button_download_Click(object sender, EventArgs e)
        {
            Forms.HowToDownload howDownload = new Forms.HowToDownload();
            howDownload.Show();            
        }

        private void button_print_Click(object sender, EventArgs e)
        {

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("omg.bg.library@gmail.com");
            mailMessage.To.Add(new MailAddress("hristiyantashev03@schoolmath.eu"));
            mailMessage.Subject = "Просрочена книга!";
            mailMessage.Body = "Здравейте, на дата 22.02.2022г. е трябвало да върнете книгата \"" + "Железният светилник" + "\", която сте заели от училищната библиотека на МГ \"Академик Кирил Попов\", " +
                            "гр.Пловдив. Каним Ви, в най-скоро време да я върнете, или да я презапишете. Благодарим!";
            using (SmtpClient MailClient = new SmtpClient())
            {
                MailClient.Host = "smtp.gmail.com";
                MailClient.Port = 587;

                MailClient.EnableSsl = true;
                MailClient.UseDefaultCredentials = false;
                MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailClient.Credentials = new System.Net.NetworkCredential("omg.bg.library@gmail.com", "library2022");
                MailClient.Send(mailMessage);
                MessageBox.Show("Имейлът е изпратен!", "готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


    }
}
