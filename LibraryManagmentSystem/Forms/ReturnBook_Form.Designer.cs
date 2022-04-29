namespace LibraryManagmentSystem.Forms
{
    partial class ReturnBook_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.textBox_publish = new System.Windows.Forms.TextBox();
            this.label_pub = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.label_returnDate = new System.Windows.Forms.Label();
            this.dateTimePicker_back = new System.Windows.Forms.DateTimePicker();
            this.label_takeDate = new System.Windows.Forms.Label();
            this.dateTimePicker_give = new System.Windows.Forms.DateTimePicker();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_returnbook = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.label_qty = new System.Windows.Forms.Label();
            this.label_qty1 = new System.Windows.Forms.Label();
            this.label_sUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_sUser);
            this.panel1.Controls.Add(this.label_qty);
            this.panel1.Controls.Add(this.label_qty1);
            this.panel1.Controls.Add(this.numericUpDown_id);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.button_return);
            this.panel1.Controls.Add(this.textBox_user);
            this.panel1.Controls.Add(this.label_user);
            this.panel1.Controls.Add(this.label_quantity);
            this.panel1.Controls.Add(this.numericUpDown_quantity);
            this.panel1.Controls.Add(this.textBox_publish);
            this.panel1.Controls.Add(this.label_pub);
            this.panel1.Controls.Add(this.textBox_author);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.label_returnDate);
            this.panel1.Controls.Add(this.dateTimePicker_back);
            this.panel1.Controls.Add(this.label_takeDate);
            this.panel1.Controls.Add(this.dateTimePicker_give);
            this.panel1.Controls.Add(this.textBox_title);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.label_returnbook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 603);
            this.panel1.TabIndex = 9;
            // 
            // label_id
            // 
            this.label_id.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(30, 79);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(124, 27);
            this.label_id.TabIndex = 57;
            this.label_id.Text = "ID: ";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Location = new System.Drawing.Point(405, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 29);
            this.label_close.TabIndex = 56;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // button_return
            // 
            this.button_return.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.button_return.BackColor = System.Drawing.Color.ForestGreen;
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.Location = new System.Drawing.Point(224, 512);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(164, 44);
            this.button_return.TabIndex = 55;
            this.button_return.Text = "ВРЪЩАНЕ";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(34, 139);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(354, 30);
            this.textBox_user.TabIndex = 54;
            this.textBox_user.TextChanged += new System.EventHandler(this.textBox_user_TextChanged);
            // 
            // label_user
            // 
            this.label_user.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(30, 109);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(124, 27);
            this.label_user.TabIndex = 53;
            this.label_user.Text = "Потребител:";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_quantity
            // 
            this.label_quantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(30, 491);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(139, 27);
            this.label_quantity.TabIndex = 52;
            this.label_quantity.Text = "Количество: *";
            this.label_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_quantity.Enabled = false;
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(34, 521);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(171, 30);
            this.numericUpDown_quantity.TabIndex = 51;
            this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_publish
            // 
            this.textBox_publish.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.textBox_publish.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_publish.Location = new System.Drawing.Point(34, 326);
            this.textBox_publish.Name = "textBox_publish";
            this.textBox_publish.Size = new System.Drawing.Size(354, 30);
            this.textBox_publish.TabIndex = 41;
            // 
            // label_pub
            // 
            this.label_pub.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label_pub.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pub.Location = new System.Drawing.Point(30, 296);
            this.label_pub.Name = "label_pub";
            this.label_pub.Size = new System.Drawing.Size(124, 27);
            this.label_pub.TabIndex = 40;
            this.label_pub.Text = "Издателство:";
            this.label_pub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_author
            // 
            this.textBox_author.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author.Location = new System.Drawing.Point(34, 264);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(354, 30);
            this.textBox_author.TabIndex = 39;
            // 
            // label_author
            // 
            this.label_author.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.Location = new System.Drawing.Point(30, 234);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(103, 27);
            this.label_author.TabIndex = 38;
            this.label_author.Text = "Автор:";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_returnDate
            // 
            this.label_returnDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_returnDate.Location = new System.Drawing.Point(30, 427);
            this.label_returnDate.Name = "label_returnDate";
            this.label_returnDate.Size = new System.Drawing.Size(163, 27);
            this.label_returnDate.TabIndex = 37;
            this.label_returnDate.Text = "Дата на връщане:";
            this.label_returnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_back
            // 
            this.dateTimePicker_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_back.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_back.Location = new System.Drawing.Point(34, 457);
            this.dateTimePicker_back.Name = "dateTimePicker_back";
            this.dateTimePicker_back.Size = new System.Drawing.Size(354, 30);
            this.dateTimePicker_back.TabIndex = 36;
            // 
            // label_takeDate
            // 
            this.label_takeDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_takeDate.Location = new System.Drawing.Point(30, 361);
            this.label_takeDate.Name = "label_takeDate";
            this.label_takeDate.Size = new System.Drawing.Size(163, 27);
            this.label_takeDate.TabIndex = 35;
            this.label_takeDate.Text = "Дата на вземане:";
            this.label_takeDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_give
            // 
            this.dateTimePicker_give.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_give.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_give.Location = new System.Drawing.Point(34, 391);
            this.dateTimePicker_give.Name = "dateTimePicker_give";
            this.dateTimePicker_give.Size = new System.Drawing.Size(354, 30);
            this.dateTimePicker_give.TabIndex = 34;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(34, 202);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(354, 30);
            this.textBox_title.TabIndex = 9;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(30, 172);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(103, 27);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "Заглавие:";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_returnbook
            // 
            this.label_returnbook.BackColor = System.Drawing.Color.LimeGreen;
            this.label_returnbook.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_returnbook.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_returnbook.Location = new System.Drawing.Point(0, 0);
            this.label_returnbook.Name = "label_returnbook";
            this.label_returnbook.Size = new System.Drawing.Size(432, 70);
            this.label_returnbook.TabIndex = 7;
            this.label_returnbook.Text = "ВРЪЩАНЕ НА КНИГА";
            this.label_returnbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_id.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_id.Location = new System.Drawing.Point(71, 79);
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(134, 30);
            this.numericUpDown_id.TabIndex = 59;
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.BackColor = System.Drawing.SystemColors.Window;
            this.label_qty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_qty.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty.ForeColor = System.Drawing.Color.Ivory;
            this.label_qty.Location = new System.Drawing.Point(366, 86);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(22, 23);
            this.label_qty.TabIndex = 63;
            this.label_qty.Text = "X";
            // 
            // label_qty1
            // 
            this.label_qty1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty1.Location = new System.Drawing.Point(279, 82);
            this.label_qty1.Name = "label_qty1";
            this.label_qty1.Size = new System.Drawing.Size(91, 27);
            this.label_qty1.TabIndex = 64;
            this.label_qty1.Text = "Наличност:";
            this.label_qty1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_sUser
            // 
            this.label_sUser.AutoSize = true;
            this.label_sUser.BackColor = System.Drawing.SystemColors.Window;
            this.label_sUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sUser.ForeColor = System.Drawing.Color.Ivory;
            this.label_sUser.Location = new System.Drawing.Point(348, 142);
            this.label_sUser.Name = "label_sUser";
            this.label_sUser.Size = new System.Drawing.Size(22, 23);
            this.label_sUser.TabIndex = 65;
            this.label_sUser.Text = "X";
            // 
            // ReturnBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook_Form";
            this.Load += new System.EventHandler(this.ReturnBook_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.TextBox textBox_publish;
        private System.Windows.Forms.Label label_pub;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_returnDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_back;
        private System.Windows.Forms.Label label_takeDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_give;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_returnbook;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.Label label_qty1;
        private System.Windows.Forms.Label label_sUser;
    }
}