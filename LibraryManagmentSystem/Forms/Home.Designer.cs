namespace LibraryManagmentSystem.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_TakedBooks = new System.Windows.Forms.Panel();
            this.dataGridView_takedBooks = new System.Windows.Forms.DataGridView();
            this.label_books = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_homepage = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_TakedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_TakedBooks);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label_homepage);
            this.panel1.Controls.Add(this.label_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 715);
            this.panel1.TabIndex = 0;
            // 
            // panel_TakedBooks
            // 
            this.panel_TakedBooks.BackColor = System.Drawing.Color.Tan;
            this.panel_TakedBooks.Controls.Add(this.dataGridView_takedBooks);
            this.panel_TakedBooks.Controls.Add(this.label_books);
            this.panel_TakedBooks.Location = new System.Drawing.Point(20, 361);
            this.panel_TakedBooks.Name = "panel_TakedBooks";
            this.panel_TakedBooks.Size = new System.Drawing.Size(576, 321);
            this.panel_TakedBooks.TabIndex = 49;
            // 
            // dataGridView_takedBooks
            // 
            this.dataGridView_takedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_takedBooks.Location = new System.Drawing.Point(9, 65);
            this.dataGridView_takedBooks.Name = "dataGridView_takedBooks";
            this.dataGridView_takedBooks.Size = new System.Drawing.Size(561, 253);
            this.dataGridView_takedBooks.TabIndex = 0;
            // 
            // label_books
            // 
            this.label_books.AutoSize = true;
            this.label_books.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books.Location = new System.Drawing.Point(143, 13);
            this.label_books.Name = "label_books";
            this.label_books.Size = new System.Drawing.Size(301, 38);
            this.label_books.TabIndex = 1;
            this.label_books.Text = "Вашите взети книги";
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
            this.label_close.TabIndex = 48;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_homepage
            // 
            this.label_homepage.BackColor = System.Drawing.Color.LimeGreen;
            this.label_homepage.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homepage.Location = new System.Drawing.Point(0, 0);
            this.label_homepage.Name = "label_homepage";
            this.label_homepage.Size = new System.Drawing.Size(1165, 70);
            this.label_homepage.TabIndex = 8;
            this.label_homepage.Text = "СИСТЕМА ЗА УПРАВЛЕНИЕ НА БИБЛИОТЕКА";
            this.label_homepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(12, 81);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(218, 45);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Здравейте, ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_TakedBooks.ResumeLayout(false);
            this.panel_TakedBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label_homepage;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel_TakedBooks;
        private System.Windows.Forms.DataGridView dataGridView_takedBooks;
        private System.Windows.Forms.Label label_books;
    }
}