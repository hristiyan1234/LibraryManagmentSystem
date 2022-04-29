using System;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class TakeBook_Form : Form
    {
        public TakeBook_Form()
        {
            InitializeComponent();
        }

        //.......събития при поставяне, махане, кликане с мишката върху хикса, с цел затваряне на прозореца...........//
        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red; // X става червен
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Ivory; //цветът се връща
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //.................................КРАЙ на събитията управляващи хикса.....................................//

        Classes.Books books = new Classes.Books();
        Classes.Users users = new Classes.Users();
        Classes.TakeBook takeBook = new Classes.TakeBook();
        Classes.Globals globals = new Classes.Globals();

        //..............при смяна на стойността на числовия контрол се проверява съответния id на книгата...//
        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            //проверка на книгата след въвеждането на нейния ИД
            int id = Convert.ToInt32(numericUpDown_id.Value);
            DataTable table = books.searchByIDorISBN("id", id, "");

            if (table.Rows.Count > 0) //ako съществува такава книга
            {
                textBox_title.Text = table.Rows[0][1].ToString(); //се показва заглавието в съответното поле
                textBox_title.ForeColor = Color.Black;
                DataRow data = books.bookInfo(id); // показва данните за книгата, тук ще я ползвам за показване ИМЕТО вместо ИД на автора
                textBox_author.Text = data["author"].ToString();
                textBox_publish.Text = data["publish"].ToString();

                //показва наличността на книгата
                int qnty = Convert.ToInt32(table.Rows[0][6].ToString());
                if (qnty <= 0)
                {
                    label_qty.Text = "❌";
                    label_qty.ForeColor = Color.Red;
                }
                else
                {
                    label_qty.Text = qnty.ToString();
                    label_qty.ForeColor = Color.LimeGreen;
                }
            }
            else
            {
                textBox_title.Text = "Няма книга с такова ID";
                textBox_title.ForeColor = Color.Red;
                textBox_author.Text = "";
                textBox_publish.Text = "";
                label_qty.Text = "";
            }
        }
        //.......................КРАЙ НА ПРОВЕРКА ЗА СЪЩЕСТВУВАНЕТО / НАЛИЧНОСТ НА КНИГА............//

        //............ПРИ ВЪВЕЖДАНЕ НА ТЕКСТ В ПОЛЕТО ЗА ПОТРЕБИТЕЛ ЩЕ СЕ ТЪРСИ ДАЛИ ТАКЪВ СЪЩЕСТВУВА............../
        public void textBox_user_TextChanged(object sender, EventArgs e)
        {
            string username = textBox_user.Text;
            DataTable table = users.searchUser(username);

            if (table.Rows.Count > 0)
            {
                label_sUser.Text = "✔";
                label_sUser.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_sUser.Text = "❌";
                label_sUser.ForeColor = Color.Red;
            }
        }
        //.........................................КРАЙ...........................................................//

        //....................................ПРИ НАТИСКАНЕ НА БУТОН ВЗЕМАНЕ.....................................//
        private void button_take_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(numericUpDown_id.Value); //присвоява се стойността на числения контрол
            string userNick = textBox_user.Text.Trim();
            DateTime issueD = dateTimePicker_give.Value;
            DateTime returnD = dateTimePicker_back.Value;
            int bookQuantity = Convert.ToInt32(books.bookInfo(bookID)["Количество"].ToString()); // присвоява се количеството книги на съответната книга

            if (bookQuantity == 0 || label_qty.Text == "❌") // ако наличносста е 0 няма да се дава книга
            {
                MessageBox.Show("Книгата вече не е в наличност", "Няма Книга", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
            }
            else if (bookQuantity != 0 && label_qty.Text != "❌") // ако не е 0 и има наличност (label_qty не е Х) книгата ще се даде
            {
                if (issueD < returnD) // Датата на взимане трбва да е преди тази на връщане
                {
                    takeBook.IssueBook(bookID, userNick, "ВЗЕТА", issueD, returnD);

                    string username = textBox_user.Text;
                    DataTable table = users.searchUser(username);
                    string email = table.Rows[0][7].ToString(); // ще пази имеила на потребителя

                    //Имейл се пеащ за да потвърди поръчката
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("omg.bg.library@gmail.com");
                    mailMessage.To.Add(new MailAddress(email));
                    mailMessage.Subject = "Взета е нова книга!";
                    mailMessage.Body = "Здравейте " + userNick.Trim() + ", на дата " + issueD + " взехте книгата  \"" + textBox_title.Text + "\" от училищната библиотека на МГ \"Академик Кирил Попов\", " +
                                    "гр.Пловдив. До дата:" + returnD + " трябва да я върнете или да я презапишете. Благодарим!";

                    using (SmtpClient MailClient = new SmtpClient())
                    {
                        MailClient.Host = "smtp.gmail.com";
                        MailClient.Port = 587;
                        MailClient.EnableSsl = true;
                        MailClient.UseDefaultCredentials = false;
                        MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        MailClient.Credentials = new System.Net.NetworkCredential("omg.bg.library@gmail.com", "library2022");
                        MailClient.Send(mailMessage);

                        if (MessageBox.Show("Kнигата е наета!", "готово", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            takeBook.UpdateQuanTake(bookID); // функцията изпълнява sql заявка за махане на 1 книга от общото количество при вземане
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Датата на връщане трябва да е след тази на взимане", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
                }
            }

            //if (returnD < DateTime.Now)
            //{
            //    string username = textBox_user.Text;
            //    DataTable table = users.searchUser(username);
            //    string email = table.Rows[0][7].ToString(); // ще пази имеила на потребителя
            //    //Имейл се пеащ за да потвърди поръчката
            //    MailMessage mailMessage = new MailMessage();
            //    mailMessage.From = new MailAddress("omg.bg.library@gmail.com");
            //    mailMessage.To.Add(new MailAddress(email));
            //    mailMessage.Subject = "Просрочена е книга!";
            //    mailMessage.Body = "Здравейте " + userNick.Trim() + ", на дата " + issueD + " взехте книгата  \"" + textBox_title.Text + "\" от училищната библиотека на МГ \"Академик Кирил Попов\", " +
            //                    "гр.Пловдив. До дата:" + returnD + " трябваше да сте я върнали. Молим в най-скоро време да бъде върната! Благодарим!";


            //    using (SmtpClient MailClient = new SmtpClient())
            //    {
            //        MailClient.Host = "smtp.gmail.com";
            //        MailClient.Port = 587;
            //        MailClient.EnableSsl = true;
            //        MailClient.UseDefaultCredentials = false;
            //        MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //        MailClient.Credentials = new System.Net.NetworkCredential("omg.bg.library@gmail.com", "library2022");
            //        MailClient.Send(mailMessage);
            //    }
        }
    }
}


