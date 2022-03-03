using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LibraryManagmentSystem.Forms
{
    public partial class ManageUsers_Form : Form
    {
        public ManageUsers_Form()
        {
            InitializeComponent();
        }
        Classes.Users newUser = new Classes.Users();
        private void ManageUsers_Form_Load(object sender, EventArgs e)
        {
            pictureBox_userPhoto.Image = Image.FromFile("../../Images/user.png");
            dataGridView_users.DataSource = newUser.UserList(); //изобразява се таблицата с данните на потребителите, запазени в базата данни
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_users.Columns[11];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

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
            if (MessageBox.Show("Изкате ли да излезете от приложението?", "Излизане", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // проверка за домейна
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Преглежда домейн частта на имейла и я нормализира.
                string DomainMapper(Match match)
                {
                    // Използва клас IdnMapping, за да конвертирате Unicode имена на домейни.
                    var idn = new IdnMapping();

                    //Изважда и обработва име на домейн (връща ArgumentException при невалидно)
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        private void button_AddPhotoUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изберете снимка(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_userPhoto.Image = Image.FromFile(openFileDialog.FileName);
           }
        }
        
        //при натискане на бутон "добавяне" се осъществява добавяне на нов потребител в базата
        private void button_addUser_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text; //колоната firstname взима информацията от textbox_author_fName
            string firstName = textBox_firstName.Text; //колоната firstname взима информацията от textbox_author_fName
            string midName = textBox_midName.Text; //(...)
            string lastName = textBox_lastName.Text; //(...)
            string username = textBox_username.Text; //(...)
            string phone = textBox_phone.Text; //(...)
            string email = textBox_mail.Text; //(...)
            string password = textBox_pass.Text; //(...)
            string userType = comboBox_position.Text; //(...)
            string userClass = comboBox_class.Text; //(...)
            DateTime addDate = dateTimePicker_user.Value; //(...)
            MemoryStream memoryStream = new MemoryStream();
            if (pictureBox_userPhoto.Image != null)
            {
                pictureBox_userPhoto.Image.Save(memoryStream, pictureBox_userPhoto.Image.RawFormat);
            }
            byte[] photo = memoryStream.ToArray();

            // ако не сa въведени главните данни за потребителя - име и фамилия, потр, име, парола, имейл то: 
            if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || username.Trim().Equals("")
                || password.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Въведете данните на потребителя!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
            }
            if (MessageBox.Show("Да се създаде ли нов " + userType + " с username " + username + "?", "Добавяне", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // проверка за повтаряне на данни
                if (newUser.UniqID(id))
                {
                    MessageBox.Show("Потребител с това id вече е зает!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidEmail(email))
                {
                    MessageBox.Show("Невалиден имейл!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (newUser.UniqUsername(username))
                {
                    MessageBox.Show("Този username вече е зает!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (newUser.UniqMail(email))
                {
                    MessageBox.Show("Този имейл вече е зает!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!textBox_phone.Equals("") && newUser.UniqPhone(phone))
                {
                    MessageBox.Show("Този телефон вече е зает!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (newUser.AddUser(firstName, midName, lastName, username, phone, email, password, userType, userClass, addDate, photo)) // 
                {
                    MessageBox.Show("Потребителят с потр. име " + username + " е добавен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_users.DataSource = newUser.UserList();
                    textBox_id.Text = "";
                    textBox_firstName.Text = "";
                    textBox_midName.Text = "";
                    textBox_lastName.Text = "";
                    textBox_username.Text = "";
                    textBox_phone.Text = "";
                    textBox_mail.Text = "";
                    textBox_pass.Text = "";
                    comboBox_position.Text = "";
                    comboBox_class.Text = "";
                    pictureBox_userPhoto.Image = Image.FromFile("../../Images/user.png");
                }
            }
        }

        //........................................................................................................

        //при натискане на бутон "обнови" се осъществява актуализация на данните на съществуващ потребител в базата:
        private void button_updateUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text); //колоната id взима информацията от textBox_id
            string firstName = textBox_firstName.Text; //колоната firstname взима информацията от textbox_firstName
            string midName = textBox_midName.Text; //колоната textBox_midName взима информацията от textBox_midName
            string lastName = textBox_lastName.Text; //(...)
            string username = textBox_username.Text; //(...)
            string phone = textBox_phone.Text; //(...)
            string email = textBox_mail.Text; //(...)
            string password = textBox_pass.Text; //(...)
            string userType = comboBox_position.Text; //(...)
            string userClass = comboBox_class.Text; //(...)
            DateTime addDate = dateTimePicker_user.Value; //(...)
            MemoryStream memoryStream = new MemoryStream();
            if (pictureBox_userPhoto.Image != null)
            {
                pictureBox_userPhoto.Image.Save(memoryStream, pictureBox_userPhoto.Image.RawFormat);
            }
            byte[] photo = memoryStream.ToArray();
            // ако липсват главните данни за потребителя - име и фамилия, потр, име, парола, имейл то:: 
            if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || username.Trim().Equals("")
                || password.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Въведете данни!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
            }
            if (MessageBox.Show("Да се обноват ли данните на потребителя " + username + " ?", "Обновяване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newUser.EditUser(id, firstName, midName, lastName, username, phone, email, password, userType, userClass, addDate, photo)) // 
                {
                    MessageBox.Show("Данните за потребител " + username + " са обновени!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_users.DataSource = newUser.UserList();
                    textBox_id.Text = "";
                    textBox_firstName.Text = "";
                    textBox_midName.Text = "";
                    textBox_lastName.Text = "";
                    textBox_username.Text = "";
                    textBox_phone.Text = "";
                    textBox_mail.Text = "";
                    textBox_pass.Text = "";
                    comboBox_position.Text = "";
                    comboBox_class.Text = "";
                    pictureBox_userPhoto.Image = Image.FromFile("../../Images/user.png");
                }
            }
        }
        //........................................................................................................

        //при натискане на бутон "премахване" (...)
        private void button_removeUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            if (MessageBox.Show("Да се премахне ли потребителя " + id + " ?", "Премахване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newUser.DeleteUser(id))
                {
                    MessageBox.Show("Потребител {" + id + "} e премахнат!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_users.DataSource = newUser.UserList();
                    textBox_id.Text = "";
                    textBox_firstName.Text = "";
                    textBox_midName.Text = "";
                    textBox_lastName.Text = "";
                    textBox_username.Text = "";
                    textBox_phone.Text = "";
                    textBox_mail.Text = "";
                    textBox_pass.Text = "";
                    comboBox_position.Text = "";
                    comboBox_class.Text = "";
                    pictureBox_userPhoto.Image = Image.FromFile("../../Images/user.png");
                }
                else
                {
                    MessageBox.Show("Данните за потребител {" + id + "} не се изтриха!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //.......................................................

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox_position.Text.Trim().Equals("Ученик"))
            {
                comboBox_class.Enabled = false;
            }
            else
            {
                comboBox_class.Enabled = true;
            }
        }

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //при натискане на ред от таблицата данните в клетка[t] се изписват в съответните textbox-ове за да може да се редактирват
            textBox_id.Text = dataGridView_users.CurrentRow.Cells[0].Value.ToString();
            textBox_firstName.Text = dataGridView_users.CurrentRow.Cells[1].Value.ToString();
            textBox_midName.Text = dataGridView_users.CurrentRow.Cells[2].Value.ToString();
            textBox_lastName.Text = dataGridView_users.CurrentRow.Cells[3].Value.ToString();
            textBox_username.Text = dataGridView_users.CurrentRow.Cells[4].Value.ToString();
            textBox_pass.Text = dataGridView_users.CurrentRow.Cells[5].Value.ToString();
            textBox_phone.Text = dataGridView_users.CurrentRow.Cells[6].Value.ToString();
            textBox_mail.Text = dataGridView_users.CurrentRow.Cells[7].Value.ToString();
            comboBox_position.Text = dataGridView_users.CurrentRow.Cells[8].Value.ToString();
            comboBox_class.Text = dataGridView_users.CurrentRow.Cells[9].Value.ToString();
        }




    }
}
