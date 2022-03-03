using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    partial class Books_Manage_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.panel_books = new System.Windows.Forms.Panel();
            this.pictureBox_barcode = new System.Windows.Forms.PictureBox();
            this.textBox_publishHouse = new System.Windows.Forms.TextBox();
            this.label_publishHouse = new System.Windows.Forms.Label();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.label_genre = new System.Windows.Forms.Label();
            this.textBox_ann = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label_isbn = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button_AddBookCover = new System.Windows.Forms.Button();
            this.pictureBox_bookCover = new System.Windows.Forms.PictureBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_bookID = new System.Windows.Forms.Label();
            this.button_updateBook = new System.Windows.Forms.Button();
            this.button_removeBook = new System.Windows.Forms.Button();
            this.button_addBook = new System.Windows.Forms.Button();
            this.label_manageBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            this.panel_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.AllowDrop = true;
            this.dataGridView_books.AllowUserToDeleteRows = false;
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_books.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_books.Location = new System.Drawing.Point(441, 90);
            this.dataGridView_books.Name = "dataGridView_books";
            this.dataGridView_books.RowTemplate.Height = 100;
            this.dataGridView_books.Size = new System.Drawing.Size(719, 612);
            this.dataGridView_books.TabIndex = 0;
            this.dataGridView_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_books_CellClick);
            // 
            // panel_books
            // 
            this.panel_books.BackColor = System.Drawing.Color.MistyRose;
            this.panel_books.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_books.Controls.Add(this.pictureBox_barcode);
            this.panel_books.Controls.Add(this.textBox_publishHouse);
            this.panel_books.Controls.Add(this.label_publishHouse);
            this.panel_books.Controls.Add(this.textBox_genre);
            this.panel_books.Controls.Add(this.numericUpDown_quantity);
            this.panel_books.Controls.Add(this.label_quantity);
            this.panel_books.Controls.Add(this.label_close);
            this.panel_books.Controls.Add(this.comboBox_author);
            this.panel_books.Controls.Add(this.label_genre);
            this.panel_books.Controls.Add(this.textBox_ann);
            this.panel_books.Controls.Add(this.label_description);
            this.panel_books.Controls.Add(this.label_author);
            this.panel_books.Controls.Add(this.textBox_isbn);
            this.panel_books.Controls.Add(this.label_isbn);
            this.panel_books.Controls.Add(this.label_date);
            this.panel_books.Controls.Add(this.dateTimePicker_date);
            this.panel_books.Controls.Add(this.button_AddBookCover);
            this.panel_books.Controls.Add(this.pictureBox_bookCover);
            this.panel_books.Controls.Add(this.textBox_title);
            this.panel_books.Controls.Add(this.label_title);
            this.panel_books.Controls.Add(this.textBox_id);
            this.panel_books.Controls.Add(this.label_bookID);
            this.panel_books.Controls.Add(this.button_updateBook);
            this.panel_books.Controls.Add(this.button_removeBook);
            this.panel_books.Controls.Add(this.button_addBook);
            this.panel_books.Controls.Add(this.label_manageBooks);
            this.panel_books.Controls.Add(this.dataGridView_books);
            this.panel_books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_books.Location = new System.Drawing.Point(0, 0);
            this.panel_books.Name = "panel_books";
            this.panel_books.Size = new System.Drawing.Size(1165, 715);
            this.panel_books.TabIndex = 6;
            // 
            // pictureBox_barcode
            // 
            this.pictureBox_barcode.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_barcode.Location = new System.Drawing.Point(335, 225);
            this.pictureBox_barcode.Name = "pictureBox_barcode";
            this.pictureBox_barcode.Size = new System.Drawing.Size(100, 60);
            this.pictureBox_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_barcode.TabIndex = 52;
            this.pictureBox_barcode.TabStop = false;
            // 
            // textBox_publishHouse
            // 
            this.textBox_publishHouse.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_publishHouse.Location = new System.Drawing.Point(18, 351);
            this.textBox_publishHouse.Name = "textBox_publishHouse";
            this.textBox_publishHouse.Size = new System.Drawing.Size(240, 30);
            this.textBox_publishHouse.TabIndex = 51;
            this.textBox_publishHouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_publishHouse_KeyDown);
            // 
            // label_publishHouse
            // 
            this.label_publishHouse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_publishHouse.Location = new System.Drawing.Point(14, 321);
            this.label_publishHouse.Name = "label_publishHouse";
            this.label_publishHouse.Size = new System.Drawing.Size(139, 27);
            this.label_publishHouse.TabIndex = 50;
            this.label_publishHouse.Text = "Издателство: *";
            this.label_publishHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_genre
            // 
            this.textBox_genre.AutoCompleteCustomSource.AddRange(new string[] {
            "Алба (поезия)",
            "Анали",
            "Анекдот",
            "Антивоенна литература",
            "Апева",
            "Апофтегма",
            "Афоризъм",
            "Балада",
            "Басня",
            "Бейт",
            "Беседа (литература)",
            "Бестиарий",
            "Биография",
            "Булевардна литература",
            "Буриме",
            "Газела (стихотворение)",
            "Гримоар",
            "Дамаскин",
            "Даскалска поезия",
            "Дастан",
            "Детска литература‎ ",
            "Диван (литература)",
            "Дилогия",
            "Драма",
            "Еклога (стихотворение)",
            "Елегия",
            "Епиграма",
            "Епистоларна литература",
            "Епиталамий",
            "Епитафия",
            "Епоси",
            "Епопея",
            "Есе",
            "Забавна литература",
            "Идилия",
            "Импресия",
            "Комедия‎ ",
            "Криминална литература‎ ",
            "Критически реализъм",
            "Легендиа",
            "Летопис",
            "Либрето",
            "Лимерик (поезия)",
            "Лирическа миниатюра",
            "Литература за израстването",
            "Литературен реализъм",
            "Магически реализъм‎ ",
            "Макабра",
            "Мелодрама",
            "Менипея",
            "Миниатюра (литература)",
            "Научна фантастика)",
            "Ода",
            "Очерк",
            "Панегирик",
            "Пародия",
            "Пасквил",
            "Перипъл",
            "Песен",
            "Пикаресков роман",
            "Писма‎ ",
            "Поговорка",
            "Поеми‎ ",
            "Пословица",
            "Приключенска литература",
            "Притчи",
            "Проза‎ ",
            "Процедурен жанр",
            "Псалм",
            "Публицистика",
            "Пътепис",
            "Рецензия",
            "Римувана рецепта",
            "Рицарски роман",
            "Розови четива",
            "Романс",
            "Рондо",
            "Сатира",
            "Сборник",
            "Сонет",
            "Социалистически реализъм",
            "Статия",
            "Стихотворение",
            "Тавтограма",
            "Трагедия",
            "Трагикомедия",
            "Трансгресия",
            "Трилъри",
            "Труд",
            "Учебник",
            "Фаблио",
            "Фантастика",
            "Фарс",
            "Фейлетон",
            "Фентъзи",
            "Филипика",
            "Фрашка",
            "Хайку",
            "Химн",
            "Хорова лирика",
            "Хроника",
            "Черен роман",
            "Чиклит",
            "Шванк",
            "Шпионски роман"});
            this.textBox_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_genre.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_genre.Location = new System.Drawing.Point(264, 351);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(171, 30);
            this.textBox_genre.TabIndex = 49;
            this.textBox_genre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_genre_KeyDown);
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(264, 413);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(171, 30);
            this.numericUpDown_quantity.TabIndex = 47;
            // 
            // label_quantity
            // 
            this.label_quantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(264, 385);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(139, 27);
            this.label_quantity.TabIndex = 48;
            this.label_quantity.Text = "Количество: *";
            this.label_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Location = new System.Drawing.Point(1136, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 29);
            this.label_close.TabIndex = 46;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // comboBox_author
            // 
            this.comboBox_author.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_author.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_author.DropDownHeight = 100;
            this.comboBox_author.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.IntegralHeight = false;
            this.comboBox_author.Location = new System.Drawing.Point(18, 287);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(240, 31);
            this.comboBox_author.Sorted = true;
            this.comboBox_author.TabIndex = 45;
            this.comboBox_author.SelectedIndexChanged += new System.EventHandler(this.comboBox_author_SelectedIndexChanged);
            this.comboBox_author.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_author_KeyDown);
            // 
            // label_genre
            // 
            this.label_genre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.Location = new System.Drawing.Point(264, 321);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(85, 27);
            this.label_genre.TabIndex = 44;
            this.label_genre.Text = "Жанр: *";
            this.label_genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ann
            // 
            this.textBox_ann.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ann.Location = new System.Drawing.Point(18, 484);
            this.textBox_ann.Multiline = true;
            this.textBox_ann.Name = "textBox_ann";
            this.textBox_ann.Size = new System.Drawing.Size(417, 168);
            this.textBox_ann.TabIndex = 42;
            // 
            // label_description
            // 
            this.label_description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(14, 454);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(112, 27);
            this.label_description.TabIndex = 41;
            this.label_description.Text = "Анотация:";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_author
            // 
            this.label_author.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.Location = new System.Drawing.Point(14, 258);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(112, 27);
            this.label_author.TabIndex = 39;
            this.label_author.Text = "Автор: *";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_isbn.Location = new System.Drawing.Point(18, 226);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(240, 30);
            this.textBox_isbn.TabIndex = 38;
            this.textBox_isbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_isbn_KeyDown);
            // 
            // label_isbn
            // 
            this.label_isbn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isbn.Location = new System.Drawing.Point(14, 196);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(112, 27);
            this.label_isbn.TabIndex = 37;
            this.label_isbn.Text = "ISBN: *";
            this.label_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(18, 385);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(240, 27);
            this.label_date.TabIndex = 36;
            this.label_date.Text = "Дата на приемане:";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Location = new System.Drawing.Point(18, 413);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(240, 30);
            this.dateTimePicker_date.TabIndex = 35;
            // 
            // button_AddBookCover
            // 
            this.button_AddBookCover.BackColor = System.Drawing.Color.Wheat;
            this.button_AddBookCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddBookCover.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.button_AddBookCover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_AddBookCover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button_AddBookCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddBookCover.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddBookCover.ForeColor = System.Drawing.Color.Black;
            this.button_AddBookCover.Location = new System.Drawing.Point(264, 287);
            this.button_AddBookCover.Name = "button_AddBookCover";
            this.button_AddBookCover.Size = new System.Drawing.Size(171, 31);
            this.button_AddBookCover.TabIndex = 30;
            this.button_AddBookCover.Text = "СНИМКА";
            this.button_AddBookCover.UseVisualStyleBackColor = false;
            this.button_AddBookCover.Click += new System.EventHandler(this.button_AddBookCover_Click);
            // 
            // pictureBox_bookCover
            // 
            this.pictureBox_bookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_bookCover.Location = new System.Drawing.Point(264, 90);
            this.pictureBox_bookCover.Name = "pictureBox_bookCover";
            this.pictureBox_bookCover.Size = new System.Drawing.Size(171, 195);
            this.pictureBox_bookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bookCover.TabIndex = 29;
            this.pictureBox_bookCover.TabStop = false;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(18, 163);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(240, 30);
            this.textBox_title.TabIndex = 26;
            this.textBox_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_title_KeyDown);
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(14, 133);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(112, 27);
            this.label_title.TabIndex = 25;
            this.label_title.Text = "Заглавие: *";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(49, 90);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(209, 30);
            this.textBox_id.TabIndex = 24;
            // 
            // label_bookID
            // 
            this.label_bookID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookID.Location = new System.Drawing.Point(14, 90);
            this.label_bookID.Name = "label_bookID";
            this.label_bookID.Size = new System.Drawing.Size(42, 27);
            this.label_bookID.TabIndex = 23;
            this.label_bookID.Text = "ID: ";
            this.label_bookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_updateBook
            // 
            this.button_updateBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_updateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateBook.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateBook.Location = new System.Drawing.Point(159, 658);
            this.button_updateBook.Name = "button_updateBook";
            this.button_updateBook.Size = new System.Drawing.Size(135, 44);
            this.button_updateBook.TabIndex = 22;
            this.button_updateBook.Text = "ОБНОВИ";
            this.button_updateBook.UseVisualStyleBackColor = false;
            this.button_updateBook.Click += new System.EventHandler(this.button_updateBook_Click);
            // 
            // button_removeBook
            // 
            this.button_removeBook.BackColor = System.Drawing.Color.IndianRed;
            this.button_removeBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removeBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeBook.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeBook.Location = new System.Drawing.Point(300, 658);
            this.button_removeBook.Name = "button_removeBook";
            this.button_removeBook.Size = new System.Drawing.Size(135, 44);
            this.button_removeBook.TabIndex = 21;
            this.button_removeBook.Text = "ПРЕМАХНИ";
            this.button_removeBook.UseVisualStyleBackColor = false;
            this.button_removeBook.Click += new System.EventHandler(this.button_removeBook_Click);
            // 
            // button_addBook
            // 
            this.button_addBook.BackColor = System.Drawing.Color.ForestGreen;
            this.button_addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addBook.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addBook.Location = new System.Drawing.Point(18, 658);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(135, 44);
            this.button_addBook.TabIndex = 20;
            this.button_addBook.Text = "ДОБАВИ";
            this.button_addBook.UseVisualStyleBackColor = false;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // label_manageBooks
            // 
            this.label_manageBooks.BackColor = System.Drawing.Color.LimeGreen;
            this.label_manageBooks.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageBooks.Location = new System.Drawing.Point(0, 0);
            this.label_manageBooks.Name = "label_manageBooks";
            this.label_manageBooks.Size = new System.Drawing.Size(1164, 70);
            this.label_manageBooks.TabIndex = 6;
            this.label_manageBooks.Text = "УПРАВЛЕНИЕ НА КНИГИТЕ";
            this.label_manageBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Books_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление на книгите";
            this.Load += new System.EventHandler(this.Books_Manage_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            this.panel_books.ResumeLayout(false);
            this.panel_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_books;
        private System.Windows.Forms.Panel panel_books;
        private System.Windows.Forms.Label label_manageBooks;
        private System.Windows.Forms.Button button_updateBook;
        private System.Windows.Forms.Button button_removeBook;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_bookID;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_AddBookCover;
        private System.Windows.Forms.PictureBox pictureBox_bookCover;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label_isbn;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.TextBox textBox_ann;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Label label_quantity;
        private TextBox textBox_genre;
        private TextBox textBox_publishHouse;
        private Label label_publishHouse;
        private PictureBox pictureBox_barcode;
    }
}