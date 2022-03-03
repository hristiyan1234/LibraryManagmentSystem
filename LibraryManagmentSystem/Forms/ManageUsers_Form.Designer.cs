using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    partial class ManageUsers_Form
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
            this.panel_users = new System.Windows.Forms.Panel();
            this.textBox_midName = new System.Windows.Forms.TextBox();
            this.label_midName = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_user = new System.Windows.Forms.DateTimePicker();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label_class = new System.Windows.Forms.Label();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.label_position = new System.Windows.Forms.Label();
            this.button_AddPhotoUser = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.pictureBox_userPhoto = new System.Windows.Forms.PictureBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.button_updateUser = new System.Windows.Forms.Button();
            this.button_removeUser = new System.Windows.Forms.Button();
            this.button_addUser = new System.Windows.Forms.Button();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_manageUser = new System.Windows.Forms.Label();
            this.panel_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_users
            // 
            this.panel_users.BackColor = System.Drawing.Color.MistyRose;
            this.panel_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_users.Controls.Add(this.textBox_midName);
            this.panel_users.Controls.Add(this.label_midName);
            this.panel_users.Controls.Add(this.label_pass);
            this.panel_users.Controls.Add(this.textBox_pass);
            this.panel_users.Controls.Add(this.label_close);
            this.panel_users.Controls.Add(this.label_date);
            this.panel_users.Controls.Add(this.dateTimePicker_user);
            this.panel_users.Controls.Add(this.comboBox_class);
            this.panel_users.Controls.Add(this.label_class);
            this.panel_users.Controls.Add(this.comboBox_position);
            this.panel_users.Controls.Add(this.label_position);
            this.panel_users.Controls.Add(this.button_AddPhotoUser);
            this.panel_users.Controls.Add(this.dataGridView_users);
            this.panel_users.Controls.Add(this.textBox_mail);
            this.panel_users.Controls.Add(this.label_mail);
            this.panel_users.Controls.Add(this.pictureBox_userPhoto);
            this.panel_users.Controls.Add(this.textBox_phone);
            this.panel_users.Controls.Add(this.label_phone);
            this.panel_users.Controls.Add(this.button_updateUser);
            this.panel_users.Controls.Add(this.button_removeUser);
            this.panel_users.Controls.Add(this.button_addUser);
            this.panel_users.Controls.Add(this.textBox_lastName);
            this.panel_users.Controls.Add(this.label_lastName);
            this.panel_users.Controls.Add(this.textBox_username);
            this.panel_users.Controls.Add(this.label_username);
            this.panel_users.Controls.Add(this.textBox_firstName);
            this.panel_users.Controls.Add(this.label_firstName);
            this.panel_users.Controls.Add(this.textBox_id);
            this.panel_users.Controls.Add(this.label_userID);
            this.panel_users.Controls.Add(this.label_manageUser);
            this.panel_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_users.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_users.Location = new System.Drawing.Point(0, 0);
            this.panel_users.Name = "panel_users";
            this.panel_users.Size = new System.Drawing.Size(1165, 715);
            this.panel_users.TabIndex = 0;
            // 
            // textBox_midName
            // 
            this.textBox_midName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_midName.Location = new System.Drawing.Point(16, 242);
            this.textBox_midName.Name = "textBox_midName";
            this.textBox_midName.Size = new System.Drawing.Size(168, 30);
            this.textBox_midName.TabIndex = 39;
            // 
            // label_midName
            // 
            this.label_midName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_midName.Location = new System.Drawing.Point(12, 212);
            this.label_midName.Name = "label_midName";
            this.label_midName.Size = new System.Drawing.Size(93, 27);
            this.label_midName.TabIndex = 38;
            this.label_midName.Text = "Презиме: ";
            this.label_midName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pass
            // 
            this.label_pass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(199, 349);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(145, 27);
            this.label_pass.TabIndex = 37;
            this.label_pass.Text = "Парола: *";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(199, 379);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(171, 30);
            this.textBox_pass.TabIndex = 36;
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
            this.label_close.TabIndex = 35;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(12, 552);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(202, 27);
            this.label_date.TabIndex = 34;
            this.label_date.Text = "Дата на добавяне:";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_user
            // 
            this.dateTimePicker_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_user.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_user.Location = new System.Drawing.Point(16, 582);
            this.dateTimePicker_user.Name = "dateTimePicker_user";
            this.dateTimePicker_user.Size = new System.Drawing.Size(354, 30);
            this.dateTimePicker_user.TabIndex = 33;
            // 
            // comboBox_class
            // 
            this.comboBox_class.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_class.DropDownHeight = 95;
            this.comboBox_class.Enabled = false;
            this.comboBox_class.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.IntegralHeight = false;
            this.comboBox_class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_class.Location = new System.Drawing.Point(199, 509);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(171, 31);
            this.comboBox_class.TabIndex = 32;
            // 
            // label_class
            // 
            this.label_class.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_class.Location = new System.Drawing.Point(199, 479);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(100, 27);
            this.label_class.TabIndex = 31;
            this.label_class.Text = "Клас:";
            this.label_class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_position
            // 
            this.comboBox_position.AutoCompleteCustomSource.AddRange(new string[] {
            "Библиотекар",
            "Учител",
            "Ученик",
            "Гост"});
            this.comboBox_position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_position.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "Админ",
            "Гост",
            "Ученик",
            "Учител"});
            this.comboBox_position.Location = new System.Drawing.Point(199, 445);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(171, 31);
            this.comboBox_position.Sorted = true;
            this.comboBox_position.TabIndex = 30;
            this.comboBox_position.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_SelectedIndexChanged);
            // 
            // label_position
            // 
            this.label_position.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(195, 415);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(114, 27);
            this.label_position.TabIndex = 29;
            this.label_position.Text = "Длъжност: *";
            this.label_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AddPhotoUser
            // 
            this.button_AddPhotoUser.BackColor = System.Drawing.Color.Wheat;
            this.button_AddPhotoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddPhotoUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.button_AddPhotoUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_AddPhotoUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button_AddPhotoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddPhotoUser.ForeColor = System.Drawing.Color.Black;
            this.button_AddPhotoUser.Location = new System.Drawing.Point(199, 295);
            this.button_AddPhotoUser.Name = "button_AddPhotoUser";
            this.button_AddPhotoUser.Size = new System.Drawing.Size(171, 37);
            this.button_AddPhotoUser.TabIndex = 28;
            this.button_AddPhotoUser.Text = "СНИМКА";
            this.button_AddPhotoUser.UseVisualStyleBackColor = false;
            this.button_AddPhotoUser.Click += new System.EventHandler(this.button_AddPhotoUser_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_users.Location = new System.Drawing.Point(376, 81);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.RowTemplate.Height = 100;
            this.dataGridView_users.Size = new System.Drawing.Size(784, 621);
            this.dataGridView_users.TabIndex = 27;
            this.dataGridView_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellClick);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(16, 509);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(168, 30);
            this.textBox_mail.TabIndex = 26;
            // 
            // label_mail
            // 
            this.label_mail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.Location = new System.Drawing.Point(12, 479);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(93, 27);
            this.label_mail.TabIndex = 25;
            this.label_mail.Text = "E-mail: *";
            this.label_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_userPhoto
            // 
            this.pictureBox_userPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_userPhoto.Location = new System.Drawing.Point(199, 94);
            this.pictureBox_userPhoto.Name = "pictureBox_userPhoto";
            this.pictureBox_userPhoto.Size = new System.Drawing.Size(171, 195);
            this.pictureBox_userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_userPhoto.TabIndex = 24;
            this.pictureBox_userPhoto.TabStop = false;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(16, 446);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(168, 30);
            this.textBox_phone.TabIndex = 21;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(12, 415);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(93, 27);
            this.label_phone.TabIndex = 20;
            this.label_phone.Text = "Телефон:";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_updateUser
            // 
            this.button_updateUser.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateUser.Location = new System.Drawing.Point(136, 658);
            this.button_updateUser.Name = "button_updateUser";
            this.button_updateUser.Size = new System.Drawing.Size(114, 44);
            this.button_updateUser.TabIndex = 19;
            this.button_updateUser.Text = "ОБНОВИ";
            this.button_updateUser.UseVisualStyleBackColor = false;
            this.button_updateUser.Click += new System.EventHandler(this.button_updateUser_Click);
            // 
            // button_removeUser
            // 
            this.button_removeUser.BackColor = System.Drawing.Color.IndianRed;
            this.button_removeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeUser.Location = new System.Drawing.Point(256, 658);
            this.button_removeUser.Name = "button_removeUser";
            this.button_removeUser.Size = new System.Drawing.Size(114, 44);
            this.button_removeUser.TabIndex = 18;
            this.button_removeUser.Text = "ПРЕМАХНИ";
            this.button_removeUser.UseVisualStyleBackColor = false;
            this.button_removeUser.Click += new System.EventHandler(this.button_removeUser_Click);
            // 
            // button_addUser
            // 
            this.button_addUser.BackColor = System.Drawing.Color.ForestGreen;
            this.button_addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addUser.Location = new System.Drawing.Point(16, 658);
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.Size = new System.Drawing.Size(114, 44);
            this.button_addUser.TabIndex = 17;
            this.button_addUser.Text = "ДОБАВИ";
            this.button_addUser.UseVisualStyleBackColor = false;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_Click);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastName.Location = new System.Drawing.Point(16, 305);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(168, 30);
            this.textBox_lastName.TabIndex = 8;
            // 
            // label_lastName
            // 
            this.label_lastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(12, 275);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(104, 27);
            this.label_lastName.TabIndex = 7;
            this.label_lastName.Text = "Фамилия: *";
            this.label_lastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(16, 379);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(168, 30);
            this.textBox_username.TabIndex = 6;
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(12, 349);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(191, 27);
            this.label_username.TabIndex = 5;
            this.label_username.Text = "Никнейм: *";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstName.Location = new System.Drawing.Point(16, 170);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(168, 30);
            this.textBox_firstName.TabIndex = 4;
            // 
            // label_firstName
            // 
            this.label_firstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(12, 140);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(69, 27);
            this.label_firstName.TabIndex = 3;
            this.label_firstName.Text = "Име: *";
            this.label_firstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(47, 94);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(137, 30);
            this.textBox_id.TabIndex = 2;
            // 
            // label_userID
            // 
            this.label_userID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userID.Location = new System.Drawing.Point(12, 94);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(42, 27);
            this.label_userID.TabIndex = 1;
            this.label_userID.Text = "ID: ";
            this.label_userID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_manageUser
            // 
            this.label_manageUser.BackColor = System.Drawing.Color.LimeGreen;
            this.label_manageUser.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manageUser.Location = new System.Drawing.Point(0, 0);
            this.label_manageUser.Name = "label_manageUser";
            this.label_manageUser.Size = new System.Drawing.Size(1164, 70);
            this.label_manageUser.TabIndex = 0;
            this.label_manageUser.Text = "УПРАВЛЕНИЕ НА ПОТРЕБИТЕЛИТЕ";
            this.label_manageUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageUsers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление на потребителите";
            this.Load += new System.EventHandler(this.ManageUsers_Form_Load);
            this.panel_users.ResumeLayout(false);
            this.panel_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_users;
        private System.Windows.Forms.Label label_manageUser;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.PictureBox pictureBox_userPhoto;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Button button_updateUser;
        private System.Windows.Forms.Button button_removeUser;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Button button_AddPhotoUser;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_user;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.TextBox textBox_midName;
        private System.Windows.Forms.Label label_midName;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_pass;
    }
}