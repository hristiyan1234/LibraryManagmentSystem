using System.Drawing;

namespace LibraryManagmentSystem.Forms
{
    partial class Take_Return_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_takeReturn = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.panel_search = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.radioButton_pub = new System.Windows.Forms.RadioButton();
            this.button_search = new System.Windows.Forms.Button();
            this.radioButton_author = new System.Windows.Forms.RadioButton();
            this.radioButton_isbn = new System.Windows.Forms.RadioButton();
            this.radioButton_title = new System.Windows.Forms.RadioButton();
            this.label_search = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.button_take = new System.Windows.Forms.Button();
            this.button_takenBooks = new System.Windows.Forms.Button();
            this.button_books = new System.Windows.Forms.Button();
            this.dataGridView_all = new System.Windows.Forms.DataGridView();
            this.label_takeReturn = new System.Windows.Forms.Label();
            this.panel_takeReturn.SuspendLayout();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_takeReturn
            // 
            this.panel_takeReturn.BackColor = System.Drawing.Color.MistyRose;
            this.panel_takeReturn.Controls.Add(this.button_print);
            this.panel_takeReturn.Controls.Add(this.button_download);
            this.panel_takeReturn.Controls.Add(this.panel_search);
            this.panel_takeReturn.Controls.Add(this.button_return);
            this.panel_takeReturn.Controls.Add(this.label_close);
            this.panel_takeReturn.Controls.Add(this.button_take);
            this.panel_takeReturn.Controls.Add(this.button_takenBooks);
            this.panel_takeReturn.Controls.Add(this.button_books);
            this.panel_takeReturn.Controls.Add(this.dataGridView_all);
            this.panel_takeReturn.Controls.Add(this.label_takeReturn);
            this.panel_takeReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_takeReturn.Location = new System.Drawing.Point(0, 0);
            this.panel_takeReturn.Name = "panel_takeReturn";
            this.panel_takeReturn.Size = new System.Drawing.Size(1165, 715);
            this.panel_takeReturn.TabIndex = 0;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.Location = new System.Drawing.Point(365, 124);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(171, 32);
            this.button_print.TabIndex = 52;
            this.button_print.Text = "ПРИНТИРАНЕ";
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // button_download
            // 
            this.button_download.BackColor = System.Drawing.Color.SpringGreen;
            this.button_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_download.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_download.Location = new System.Drawing.Point(365, 86);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(171, 32);
            this.button_download.TabIndex = 51;
            this.button_download.Text = "ИЗТЕГЛЯНЕ";
            this.button_download.UseVisualStyleBackColor = false;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // panel_search
            // 
            this.panel_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_search.Controls.Add(this.textBox_search);
            this.panel_search.Controls.Add(this.radioButton_pub);
            this.panel_search.Controls.Add(this.button_search);
            this.panel_search.Controls.Add(this.radioButton_author);
            this.panel_search.Controls.Add(this.radioButton_isbn);
            this.panel_search.Controls.Add(this.radioButton_title);
            this.panel_search.Controls.Add(this.label_search);
            this.panel_search.Location = new System.Drawing.Point(542, 86);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(611, 70);
            this.panel_search.TabIndex = 50;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(191, 24);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(333, 31);
            this.textBox_search.TabIndex = 56;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // radioButton_pub
            // 
            this.radioButton_pub.AutoSize = true;
            this.radioButton_pub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_pub.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_pub.Location = new System.Drawing.Point(3, 46);
            this.radioButton_pub.Name = "radioButton_pub";
            this.radioButton_pub.Size = new System.Drawing.Size(114, 23);
            this.radioButton_pub.TabIndex = 55;
            this.radioButton_pub.TabStop = true;
            this.radioButton_pub.Text = "Издателство";
            this.radioButton_pub.UseVisualStyleBackColor = true;
            this.radioButton_pub.CheckedChanged += new System.EventHandler(this.radioButton_pub_CheckedChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.SpringGreen;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(530, 24);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(73, 31);
            this.button_search.TabIndex = 51;
            this.button_search.Text = "ТЪРСИ";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // radioButton_author
            // 
            this.radioButton_author.AutoSize = true;
            this.radioButton_author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_author.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_author.Location = new System.Drawing.Point(117, 46);
            this.radioButton_author.Name = "radioButton_author";
            this.radioButton_author.Size = new System.Drawing.Size(68, 23);
            this.radioButton_author.TabIndex = 54;
            this.radioButton_author.TabStop = true;
            this.radioButton_author.Text = "Автор";
            this.radioButton_author.UseVisualStyleBackColor = true;
            this.radioButton_author.CheckedChanged += new System.EventHandler(this.radioButton_author_CheckedChanged);
            // 
            // radioButton_isbn
            // 
            this.radioButton_isbn.AutoSize = true;
            this.radioButton_isbn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_isbn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_isbn.Location = new System.Drawing.Point(117, 24);
            this.radioButton_isbn.Name = "radioButton_isbn";
            this.radioButton_isbn.Size = new System.Drawing.Size(62, 23);
            this.radioButton_isbn.TabIndex = 53;
            this.radioButton_isbn.TabStop = true;
            this.radioButton_isbn.Text = "ISBN";
            this.radioButton_isbn.UseVisualStyleBackColor = true;
            this.radioButton_isbn.CheckedChanged += new System.EventHandler(this.radioButton_isbn_CheckedChanged);
            // 
            // radioButton_title
            // 
            this.radioButton_title.AutoSize = true;
            this.radioButton_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_title.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_title.Location = new System.Drawing.Point(3, 24);
            this.radioButton_title.Name = "radioButton_title";
            this.radioButton_title.Size = new System.Drawing.Size(85, 23);
            this.radioButton_title.TabIndex = 52;
            this.radioButton_title.TabStop = true;
            this.radioButton_title.Text = "Заглавие";
            this.radioButton_title.UseVisualStyleBackColor = true;
            this.radioButton_title.CheckedChanged += new System.EventHandler(this.radioButton_title_CheckedChanged);
            // 
            // label_search
            // 
            this.label_search.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_search.Location = new System.Drawing.Point(-1, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(300, 31);
            this.label_search.TabIndex = 51;
            this.label_search.Text = "Търсене на книги по:";
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.Location = new System.Drawing.Point(189, 86);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(171, 32);
            this.button_return.TabIndex = 49;
            this.button_return.Text = "ВРЪЩАНЕ";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Location = new System.Drawing.Point(1137, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 29);
            this.label_close.TabIndex = 47;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // button_take
            // 
            this.button_take.BackColor = System.Drawing.Color.SpringGreen;
            this.button_take.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_take.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_take.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_take.Location = new System.Drawing.Point(189, 124);
            this.button_take.Name = "button_take";
            this.button_take.Size = new System.Drawing.Size(171, 32);
            this.button_take.TabIndex = 11;
            this.button_take.Text = "ВЗЕМАНЕ";
            this.button_take.UseVisualStyleBackColor = false;
            this.button_take.Click += new System.EventHandler(this.button_take_Click);
            // 
            // button_takenBooks
            // 
            this.button_takenBooks.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_takenBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_takenBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_takenBooks.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_takenBooks.Location = new System.Drawing.Point(12, 124);
            this.button_takenBooks.Name = "button_takenBooks";
            this.button_takenBooks.Size = new System.Drawing.Size(171, 32);
            this.button_takenBooks.TabIndex = 10;
            this.button_takenBooks.Text = "ВЗЕТИ КНИГИ";
            this.button_takenBooks.UseVisualStyleBackColor = false;
            this.button_takenBooks.Click += new System.EventHandler(this.button_takenBooks_Click);
            // 
            // button_books
            // 
            this.button_books.BackColor = System.Drawing.Color.SpringGreen;
            this.button_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_books.Location = new System.Drawing.Point(12, 86);
            this.button_books.Name = "button_books";
            this.button_books.Size = new System.Drawing.Size(171, 32);
            this.button_books.TabIndex = 9;
            this.button_books.Text = "НАЛИЧНИ КНИГИ";
            this.button_books.UseVisualStyleBackColor = false;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // dataGridView_all
            // 
            this.dataGridView_all.AllowDrop = true;
            this.dataGridView_all.AllowUserToAddRows = false;
            this.dataGridView_all.AllowUserToDeleteRows = false;
            this.dataGridView_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_all.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_all.Location = new System.Drawing.Point(12, 162);
            this.dataGridView_all.Name = "dataGridView_all";
            this.dataGridView_all.ReadOnly = true;
            this.dataGridView_all.RowTemplate.Height = 100;
            this.dataGridView_all.Size = new System.Drawing.Size(1141, 541);
            this.dataGridView_all.TabIndex = 8;
            // 
            // label_takeReturn
            // 
            this.label_takeReturn.BackColor = System.Drawing.Color.LimeGreen;
            this.label_takeReturn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_takeReturn.Location = new System.Drawing.Point(0, 0);
            this.label_takeReturn.Name = "label_takeReturn";
            this.label_takeReturn.Size = new System.Drawing.Size(1165, 70);
            this.label_takeReturn.TabIndex = 7;
            this.label_takeReturn.Text = "УПРАВЛЕНИЕ НА ОБРАЩЕНИЕТО НА КНИГИТЕ";
            this.label_takeReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Take_Return_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel_takeReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Take_Return_Manage";
            this.Text = "Обращение на книгите";
            this.Load += new System.EventHandler(this.Take_Return_Manage_Load);
            this.panel_takeReturn.ResumeLayout(false);
            this.panel_takeReturn.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_takeReturn;
        private System.Windows.Forms.Label label_takeReturn;
        private System.Windows.Forms.Button button_takenBooks;
        private System.Windows.Forms.Button button_books;
        private System.Windows.Forms.DataGridView dataGridView_all;
        private System.Windows.Forms.Button button_take;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.RadioButton radioButton_isbn;
        private System.Windows.Forms.RadioButton radioButton_title;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.RadioButton radioButton_author;
        private System.Windows.Forms.RadioButton radioButton_pub;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_print;
    }
}