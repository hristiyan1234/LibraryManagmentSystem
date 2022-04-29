using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class Books_Manage_Form : Form
    {
        public Books_Manage_Form()
        {
            InitializeComponent();
        }
        Classes.Books newBooks = new Classes.Books();
        private void Books_Manage_Form_Load(object sender, EventArgs e)
        {
            pictureBox_bookCover.Image = Image.FromFile("../../Images/library.png");
            dataGridView_books.DataSource = newBooks.BooksList();
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_books.Columns[9];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Classes.Authors authors = new Classes.Authors();
            comboBox_author.DataSource = authors.AuthorList(true);
            comboBox_author.DisplayMember = "name";
            comboBox_author.ValueMember = "id";
        }

        //..........................при натискане на ернтер курсорът минава на следващо поле за въвеждане...........................//
        private void textBox_title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_isbn.Focus(); // курсорът отива на другото поле
            }
        }
        private void textBox_isbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                comboBox_author.Focus(); // курсорът отива на другото поле
            }
        }

        private void comboBox_author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_publishHouse.Focus(); // курсорът отива на другото поле
            }
        }

        private void textBox_publishHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_genre.Focus(); // курсорът отива на другото поле
            }
        }

        private void textBox_genre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) //kaто се натисне ENTER,
            {
                textBox_ann.Focus(); // курсорът отива на другото поле
            }
        }
        //...................................КРАЙ на събитията за преминаване на нов ред......................................//

        //................събития при поставяне, махане, кликане с мишката върху хикса, с цел затваряне на приложението...........//
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
        //.................................................КРАЙ на събитията отговарящи за затварянето на апликацията.......................//

        //...............................при натискане на СНИМКА бутонът.......................//
        private void button_AddBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изберете снимка(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_bookCover.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private void comboBox_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_author.Text = "";
            DataRowView dataRowView = (DataRowView)comboBox_author.SelectedItem;
            string name = dataRowView["name"].ToString();
        }
        //.....................................................................................//

        //...................ФУНКЦИЯ ЗА ГЕНЕРИРАНЕ НА БАРКОД НА КНИГАТА ПО НЕЙНОТО ISBN.............//
        //private void barcodeGenerator()
        //{
        //    string barcode = textBox_isbn.Text;
        //    Bitmap bitm = new Bitmap(barcode.Length * 45, 160);
        //    using (Graphics graphic = Graphics.FromImage(bitm))
        //    {
        //        Font newfont = new Font("IDAutomationHC39M", 20);
        //        PointF point = new PointF(2f, 2f);
        //        SolidBrush black = new SolidBrush(Color.Black);
        //        SolidBrush white = new SolidBrush(Color.White);
        //        graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
        //        graphic.DrawString("*" + barcode + "*", newfont, black, point);
        //    }

        //    using (MemoryStream Mmst = new MemoryStream())
        //    {
        //        bitm.Save("ms", ImageFormat.Jpeg);
        //        pictureBox_barcode.Image = bitm;
        //        pictureBox_barcode.Width = bitm.Width;
        //        pictureBox_barcode.Height = bitm.Height;
        //    }
        //}
        //................................................................................................//

        //..при натискане на бутон "добавяне" се осъществява добавяне на нова книга в базата......//
        private void button_addBook_Click(object sender, EventArgs e)
        {
            string title = textBox_title.Text; //колоната title взима информацията от textBox_title
            int author_id = Convert.ToInt32(comboBox_author.SelectedValue); //(...)
            string isbn = textBox_isbn.Text; //(...)
            string genre = textBox_genre.Text; //(...)
            string publish = textBox_publishHouse.Text; //(...)
            int quantity = Convert.ToInt32(numericUpDown_quantity.Value); //(...)
            string annotation = textBox_ann.Text; //(...)
            DateTime addDate = dateTimePicker_date.Value; //(...)
            MemoryStream memoryStream = new MemoryStream();
            if (pictureBox_bookCover.Image != null)
            {
                pictureBox_bookCover.Image.Save(memoryStream, pictureBox_bookCover.Image.RawFormat);
            }
            byte[] coverPhoto = memoryStream.ToArray();

            // проверка за повтаряне на повече от една книга с едно и също isbn
            if (newBooks.UniqISBN(isbn))
            {
                MessageBox.Show("Това ISBN вече е заето!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show("Да се добави ли книга " + title + " ?", "Добавяне", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                {
                    // ако не сa въведени главните данни за книгата - заглавие, автор, isbn, жанр,  то: 
                    if (title.Trim().Equals("") || author_id.ToString().Trim().Equals("") || isbn.Trim().Equals("") || genre.Trim().Equals(""))
                    {
                        MessageBox.Show("Въведете данните за книгата, които са със '*'!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
                    }
                    else if (newBooks.AddBook(title, author_id, isbn, genre, publish, quantity, addDate, annotation, coverPhoto)) // 
                    {
                        MessageBox.Show("kнигата " + title + " е добавенa!" + "Имате " + quantity + " броя от нея", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_books.DataSource = newBooks.BooksList();
                        // barcodeGenerator();
                        textBox_id.Text = "";
                        textBox_title.Text = "";
                        textBox_isbn.Text = "";
                        textBox_genre.Text = "";
                        textBox_publishHouse.Text = "";
                        textBox_ann.Text = "";
                        comboBox_author.Text = "";
                        dateTimePicker_date.Value = DateTime.Now;
                        pictureBox_bookCover.Image = Image.FromFile("../../Images/library.png");
                    }
                }
            }
        }
        //..................................................................................................//

        //..при натискане на бутон "обнови" се осъществява актуализация на даните за съответна книга в базата......//
        private void button_updateBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            string title = textBox_title.Text;
            int author_id = Convert.ToInt32(comboBox_author.SelectedValue); //(...)
            string isbn = textBox_isbn.Text; //(...)
            string genre = textBox_genre.Text; //(...)
            string publish = textBox_publishHouse.Text; //(...)
            int quantity = Convert.ToInt32(numericUpDown_quantity.Value); //(...)
            string annotation = textBox_ann.Text; //(...)
            DateTime addDate = dateTimePicker_date.Value; //(...)
            MemoryStream memoryStream = new MemoryStream();
            if (pictureBox_bookCover.Image != null)
            {
                pictureBox_bookCover.Image.Save(memoryStream, pictureBox_bookCover.Image.RawFormat);
            }
            byte[] coverPhoto = memoryStream.ToArray();

            //if (newBooks.UniqISBN(isbn))
            //{
            //    MessageBox.Show("Това ISBN вече е заето!", "Заети данни", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if (title.Trim().Equals("") || author_id.ToString().Trim().Equals("") || isbn.Trim().Equals("") || genre.Trim().Equals(""))
            {
                MessageBox.Show("Въведете данните за книгата, които са със '*'!", "Липсват данни", MessageBoxButtons.OK, MessageBoxIcon.Warning); // съобщение
            }
            else if (MessageBox.Show("Да се обновят ли данните за книгата " + title + " ?", "Обновяване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newBooks.UpdateBook(id, title, author_id, isbn, genre, publish, quantity, addDate, annotation, coverPhoto)) // 
                {
                    MessageBox.Show("kнигата" + title + " е обновена!" + "Имате " + quantity + " броя от нея", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_books.DataSource = newBooks.BooksList();
                    // barcodeGenerator();
                    textBox_id.Text = "";
                    textBox_title.Text = "";
                    textBox_isbn.Text = "";
                    textBox_genre.Text = "";
                    textBox_publishHouse.Text = "";
                    textBox_ann.Text = "";
                    comboBox_author.Text = "";
                    dateTimePicker_date.Value = DateTime.Now;
                    pictureBox_bookCover.Image = Image.FromFile("../../Images/library.png");
                }
            }
        }
        //...................................................................................................//

        //...........при натискане на бутон премахване се изтриват данните за съответната книга от базата данни..........//
        private void button_removeBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            if (MessageBox.Show("Да се премахне ли книга " + id + " ?", "Премахване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (newBooks.DeleteBook(id))
                {
                    MessageBox.Show("Книга {" + id + "} e премахната!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_books.DataSource = newBooks.BooksList();
                    textBox_id.Text = "";
                    textBox_title.Text = "";
                    textBox_isbn.Text = "";
                    textBox_genre.Text = "";
                    textBox_publishHouse.Text = "";
                    textBox_ann.Text = "";
                    comboBox_author.Text = "";
                    dateTimePicker_date.Value = DateTime.Now;
                    pictureBox_bookCover.Image = Image.FromFile("../../Images/library.png");
                }
            }
        }
        //.................................................................................................................//

        //.............изобразяване на данните на съответен потребител при селектиране на съответен ред.................//
        private void dataGridView_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_author.Text = string.Empty;
            textBox_id.Text = dataGridView_books.CurrentRow.Cells[0].Value.ToString();
            textBox_title.Text = dataGridView_books.CurrentRow.Cells[1].Value.ToString();
            comboBox_author.SelectedText = dataGridView_books.CurrentRow.Cells[2].Value.ToString();
            textBox_isbn.Text = dataGridView_books.CurrentRow.Cells[3].Value.ToString();
            textBox_genre.Text = dataGridView_books.CurrentRow.Cells[4].Value.ToString();
            textBox_publishHouse.Text = dataGridView_books.CurrentRow.Cells[5].Value.ToString();
            numericUpDown_quantity.Value = decimal.Parse(dataGridView_books.CurrentRow.Cells[6].Value.ToString());
            dateTimePicker_date.Value = DateTime.Parse(dataGridView_books.CurrentRow.Cells[7].Value.ToString());
            textBox_ann.Text = dataGridView_books.CurrentRow.Cells[8].Value.ToString();

            Byte[] img = new Byte[0];
            img = (Byte[])(dataGridView_books.CurrentRow.Cells[9]).Value;
            MemoryStream memoryStream = new MemoryStream(img);
            pictureBox_bookCover.Image = Image.FromStream(memoryStream);
        }
        //.............................................................................................................//
    }
}
