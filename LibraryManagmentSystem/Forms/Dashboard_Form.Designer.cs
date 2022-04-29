namespace LibraryManagmentSystem.Forms
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_check = new System.Windows.Forms.Button();
            this.button_authors = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_books = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_view = new System.Windows.Forms.Panel();
            this.label_home = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_homepage = new System.Windows.Forms.Label();
            this.panel_TakedBooks = new System.Windows.Forms.Panel();
            this.dataGridView_takedBooks = new System.Windows.Forms.DataGridView();
            this.label_books = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_view.SuspendLayout();
            this.panel_TakedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_menu.Controls.Add(this.button_check);
            this.panel_menu.Controls.Add(this.button_authors);
            this.panel_menu.Controls.Add(this.button_users);
            this.panel_menu.Controls.Add(this.button_books);
            this.panel_menu.Controls.Add(this.button_home);
            this.panel_menu.Controls.Add(this.panel3);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.Name = "panel_menu";
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check.FlatAppearance.BorderSize = 0;
            this.button_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_check, "button_check");
            this.button_check.ForeColor = System.Drawing.Color.Salmon;
            this.button_check.Name = "button_check";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_authors
            // 
            this.button_authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_authors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_authors.FlatAppearance.BorderSize = 0;
            this.button_authors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button_authors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_authors, "button_authors");
            this.button_authors.ForeColor = System.Drawing.Color.Salmon;
            this.button_authors.Name = "button_authors";
            this.button_authors.UseVisualStyleBackColor = false;
            this.button_authors.Click += new System.EventHandler(this.button_authors_Click);
            // 
            // button_users
            // 
            this.button_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_users.FlatAppearance.BorderSize = 0;
            this.button_users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_users, "button_users");
            this.button_users.ForeColor = System.Drawing.Color.Salmon;
            this.button_users.Name = "button_users";
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_books
            // 
            this.button_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_books.FlatAppearance.BorderSize = 0;
            this.button_books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button_books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_books, "button_books");
            this.button_books.ForeColor = System.Drawing.Color.Salmon;
            this.button_books.Name = "button_books";
            this.button_books.UseVisualStyleBackColor = false;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button_home, "button_home");
            this.button_home.ForeColor = System.Drawing.Color.Salmon;
            this.button_home.Name = "button_home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagmentSystem.Properties.Resources.library;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel_view
            // 
            this.panel_view.BackColor = System.Drawing.Color.MistyRose;
            this.panel_view.Controls.Add(this.panel_TakedBooks);
            this.panel_view.Controls.Add(this.label_home);
            this.panel_view.Controls.Add(this.label_close);
            this.panel_view.Controls.Add(this.label_homepage);
            resources.ApplyResources(this.panel_view, "panel_view");
            this.panel_view.Name = "panel_view";
            this.panel_view.MouseEnter += new System.EventHandler(this.panel_view_MouseEnter);
            // 
            // label_home
            // 
            resources.ApplyResources(this.label_home, "label_home");
            this.label_home.Name = "label_home";
            // 
            // label_close
            // 
            resources.ApplyResources(this.label_close, "label_close");
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Name = "label_close";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_homepage
            // 
            this.label_homepage.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.label_homepage, "label_homepage");
            this.label_homepage.Name = "label_homepage";
            // 
            // panel_TakedBooks
            // 
            this.panel_TakedBooks.BackColor = System.Drawing.Color.Tan;
            this.panel_TakedBooks.Controls.Add(this.dataGridView_takedBooks);
            this.panel_TakedBooks.Controls.Add(this.label_books);
            resources.ApplyResources(this.panel_TakedBooks, "panel_TakedBooks");
            this.panel_TakedBooks.Name = "panel_TakedBooks";
            // 
            // dataGridView_takedBooks
            // 
            this.dataGridView_takedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView_takedBooks, "dataGridView_takedBooks");
            this.dataGridView_takedBooks.Name = "dataGridView_takedBooks";
            // 
            // label_books
            // 
            resources.ApplyResources(this.label_books, "label_books");
            this.label_books.Name = "label_books";
            // 
            // Dashboard_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Form";
            this.Shown += new System.EventHandler(this.Dashboard_Form_Shown);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_view.ResumeLayout(false);
            this.panel_view.PerformLayout();
            this.panel_TakedBooks.ResumeLayout(false);
            this.panel_TakedBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_books;
        protected System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_authors;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_homepage;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Panel panel_TakedBooks;
        private System.Windows.Forms.DataGridView dataGridView_takedBooks;
        private System.Windows.Forms.Label label_books;
    }
}