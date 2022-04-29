using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class Authors_Manage_Form : Form
    {
        public Authors_Manage_Form()
        {
            InitializeComponent();
        }
        //..........................при натискане на ернтер курсорът минава на следващо поле за въвеждане...........................//
        private void textBox_author_fName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_author_lName.Focus(); // курсорът отива на другото поле
            }
        }

        private void textBox_author_lName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_bio.Focus(); // курсорът отива на другото поле
            }
        }
        //........................................край на събитията за нов ред при ентер............................................//

        //....................събития при поставяне, махане, кликане с мишката върху хикса, с цел затваряне на приложението...............//
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
        //..................................................край на събитията свързани с хикса............................................//


        Classes.Authors newAuthor = new Classes.Authors();
        Classes.Users users = new Classes.Users();


        private void Authors_Manage_Form_Load(object sender, EventArgs e)
        {
            pictureBox_author.Image = Image.FromFile("../../Images/user.png"); //defaut изображение за автор
            dataGridView_authors.DataSource = newAuthor.AuthorList(false); //изобразява се таблицата с данните на авторите, запазени в базата данни
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_authors.Columns[4];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        //...............................при натискане на СНИМКА бутонът.......................//
        private void button_AddPhotoAuthor_Click(object sender, EventArgs e) // добавяне снимка на автора
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изберете снимка(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_author.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        //.........................................................................................//

        //..при натискане на бутон "добавяне" се осъществява добавяне на нов автор в базата......//
        private void button_addAuthor_Click(object sender, EventArgs e)
        {
            string firstName = textBox_author_fName.Text; //колоната firstname взима информацията от textbox_author_fName
            string lastName = textBox_author_lName.Text; //(...)
            string biography = textBox_bio.Text; //(...)
            MemoryStream memoryStream = new MemoryStream();
            if (pictureBox_author.Image != null)
            {
                pictureBox_author.Image.Save(memoryStream, pictureBox_author.Image.RawFormat);
            }
            byte[] photo = memoryStream.ToArray();


            if (firstName.Trim().Equals(""))  // ако не с въведени главните данни за автора - име то: 
            {
                MessageBox.Show("Въведете пълното име на автора!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
            }

            if (MessageBox.Show("Да се създаде ли авторът " + firstName + " " + lastName + "?", "Премахване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newAuthor.AddAuthor(firstName, lastName, biography, photo)) // 
                {
                    if (textBox_author_lName.Equals(""))
                    {
                        dataGridView_authors.Columns[2].Equals("-");
                    }
                    MessageBox.Show("Автор " + firstName + " " + lastName + " е запазен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_authors.DataSource = newAuthor.AuthorList(false);
                    textBox_author_id.Text = "";
                    textBox_author_fName.Text = "";
                    textBox_author_lName.Text = "";
                    textBox_bio.Text = "";
                    pictureBox_author.Image = Image.FromFile("../../Images/user.png");
                }
            }
        }
        //.......................................................................................

        //..при натискане на бутон "обнови" се осъществява актуализация на данните на съществуващ автор в базата:...//
        private void button_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изкате ли да актуализирате данните за този автор?", "Обновяване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int id = Convert.ToInt32(textBox_author_id.Text); //колоната id взима информацията от textbox_author_id
                string firstName = textBox_author_fName.Text; //колоната firstname взима информацията от textbox_author_fName
                string lastName = textBox_author_lName.Text; //(...)
                string biography = textBox_bio.Text; //(...)
                MemoryStream memoryStream = new MemoryStream();
                if (pictureBox_author.Image != null)
                {
                    pictureBox_author.Image.Save(memoryStream, pictureBox_author.Image.RawFormat);
                }
                byte[] photo = memoryStream.ToArray();

                if (firstName.Trim().Equals("")) // ако не с въведени главните данни за автора - име, то: 
                {
                    MessageBox.Show("Въведете данни!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
                }
                else if (newAuthor.EditAuthor(id, firstName, lastName, biography, photo)) // 
                {
                    MessageBox.Show("Данните на автор {" + id + "} са обновени!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_authors.DataSource = newAuthor.AuthorList(false);
                    textBox_author_id.Text = "";
                    textBox_author_fName.Text = "";
                    textBox_author_lName.Text = "";
                    textBox_bio.Text = "";
                    pictureBox_author.Image = Image.FromFile("../../Images/user.png");
                }
            }
        }
        //..........................................................................................................//

        //...........................................при натискане на бутон "премахване (...).......................//
        private void button_removeAuthor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_author_id.Text); //колоната id взима информацията от textbox_author_id
            if (MessageBox.Show("Изкате ли да изтриете този автор?", "Премахване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newAuthor.deleteAuthors(id))
                {
                    MessageBox.Show("Aвтор {" + id + "} e премахнат!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_authors.DataSource = newAuthor.AuthorList(false);
                    textBox_author_id.Text = "";
                    textBox_author_fName.Text = "";
                    textBox_author_lName.Text = "";
                    textBox_bio.Text = "";
                    pictureBox_author.Image = Image.FromFile("../../Images/user.png");
                }
                else
                {
                    MessageBox.Show("Данните за автор {" + id + "} не се изтриха!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //..............................................................................................................//


        //.............изобразяване на данните на съответен потребител при селектиране на съответен ред.................//
        private void dataGridView_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //при натискане на ред от таблицата данните в клетка[t] се изписват в съответните textbox-ове за да може да се редактирват
            textBox_author_id.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_author_fName.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_author_lName.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_bio.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();

            Byte[] img = new Byte[0];
            img = (Byte[])(dataGridView_authors.CurrentRow.Cells[4]).Value;
            MemoryStream memoryStream = new MemoryStream(img);
            pictureBox_author.Image = Image.FromStream(memoryStream);
        }
        //................................................................................................................//
    }
}
