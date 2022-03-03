using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    partial class Authors_Manage_Form
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
            this.panel_author = new System.Windows.Forms.Panel();
            this.textBox_author_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_AddPhotoAuthor = new System.Windows.Forms.Button();
            this.pictureBox_author = new System.Windows.Forms.PictureBox();
            this.textBox_bio = new System.Windows.Forms.TextBox();
            this.label_authorBio = new System.Windows.Forms.Label();
            this.textBox_author_lName = new System.Windows.Forms.TextBox();
            this.textBox_author_fName = new System.Windows.Forms.TextBox();
            this.label_author_lName = new System.Windows.Forms.Label();
            this.label_author_fName = new System.Windows.Forms.Label();
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            this.button_removeAuthor = new System.Windows.Forms.Button();
            this.button_addAuthor = new System.Windows.Forms.Button();
            this.label_author = new System.Windows.Forms.Label();
            this.panel_author.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_author
            // 
            this.panel_author.BackColor = System.Drawing.Color.MistyRose;
            this.panel_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_author.Controls.Add(this.textBox_author_id);
            this.panel_author.Controls.Add(this.label_id);
            this.panel_author.Controls.Add(this.label_close);
            this.panel_author.Controls.Add(this.button_update);
            this.panel_author.Controls.Add(this.button_AddPhotoAuthor);
            this.panel_author.Controls.Add(this.pictureBox_author);
            this.panel_author.Controls.Add(this.textBox_bio);
            this.panel_author.Controls.Add(this.label_authorBio);
            this.panel_author.Controls.Add(this.textBox_author_lName);
            this.panel_author.Controls.Add(this.textBox_author_fName);
            this.panel_author.Controls.Add(this.label_author_lName);
            this.panel_author.Controls.Add(this.label_author_fName);
            this.panel_author.Controls.Add(this.dataGridView_authors);
            this.panel_author.Controls.Add(this.button_removeAuthor);
            this.panel_author.Controls.Add(this.button_addAuthor);
            this.panel_author.Controls.Add(this.label_author);
            this.panel_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_author.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_author.Location = new System.Drawing.Point(0, 0);
            this.panel_author.Name = "panel_author";
            this.panel_author.Size = new System.Drawing.Size(1165, 715);
            this.panel_author.TabIndex = 0;
            // 
            // textBox_author_id
            // 
            this.textBox_author_id.Enabled = false;
            this.textBox_author_id.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author_id.Location = new System.Drawing.Point(48, 92);
            this.textBox_author_id.Name = "textBox_author_id";
            this.textBox_author_id.Size = new System.Drawing.Size(250, 28);
            this.textBox_author_id.TabIndex = 18;
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.Color.Transparent;
            this.label_id.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(18, 92);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(36, 23);
            this.label_id.TabIndex = 19;
            this.label_id.Text = "ID:";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Location = new System.Drawing.Point(1138, -1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(26, 27);
            this.label_close.TabIndex = 17;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_close_MouseLeave);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(181, 661);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(137, 44);
            this.button_update.TabIndex = 16;
            this.button_update.Text = "ОБНОВИ";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_AddPhotoAuthor
            // 
            this.button_AddPhotoAuthor.BackColor = System.Drawing.Color.Wheat;
            this.button_AddPhotoAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddPhotoAuthor.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.button_AddPhotoAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_AddPhotoAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button_AddPhotoAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddPhotoAuthor.ForeColor = System.Drawing.Color.Black;
            this.button_AddPhotoAuthor.Location = new System.Drawing.Point(304, 306);
            this.button_AddPhotoAuthor.Name = "button_AddPhotoAuthor";
            this.button_AddPhotoAuthor.Size = new System.Drawing.Size(175, 37);
            this.button_AddPhotoAuthor.TabIndex = 15;
            this.button_AddPhotoAuthor.Text = "СНИМКА";
            this.button_AddPhotoAuthor.UseVisualStyleBackColor = false;
            this.button_AddPhotoAuthor.Click += new System.EventHandler(this.button_AddPhotoAuthor_Click);
            // 
            // pictureBox_author
            // 
            this.pictureBox_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_author.ErrorImage = null;
            this.pictureBox_author.Location = new System.Drawing.Point(304, 92);
            this.pictureBox_author.Name = "pictureBox_author";
            this.pictureBox_author.Size = new System.Drawing.Size(175, 208);
            this.pictureBox_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_author.TabIndex = 14;
            this.pictureBox_author.TabStop = false;
            // 
            // textBox_bio
            // 
            this.textBox_bio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bio.Location = new System.Drawing.Point(22, 373);
            this.textBox_bio.Multiline = true;
            this.textBox_bio.Name = "textBox_bio";
            this.textBox_bio.Size = new System.Drawing.Size(457, 282);
            this.textBox_bio.TabIndex = 13;
            // 
            // label_authorBio
            // 
            this.label_authorBio.BackColor = System.Drawing.Color.Transparent;
            this.label_authorBio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authorBio.Location = new System.Drawing.Point(18, 347);
            this.label_authorBio.Name = "label_authorBio";
            this.label_authorBio.Size = new System.Drawing.Size(153, 23);
            this.label_authorBio.TabIndex = 12;
            this.label_authorBio.Text = "Кратка биография:";
            this.label_authorBio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_author_lName
            // 
            this.textBox_author_lName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author_lName.Location = new System.Drawing.Point(22, 207);
            this.textBox_author_lName.Name = "textBox_author_lName";
            this.textBox_author_lName.Size = new System.Drawing.Size(276, 28);
            this.textBox_author_lName.TabIndex = 7;
            this.textBox_author_lName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_author_lName_KeyDown);
            // 
            // textBox_author_fName
            // 
            this.textBox_author_fName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author_fName.Location = new System.Drawing.Point(22, 150);
            this.textBox_author_fName.Name = "textBox_author_fName";
            this.textBox_author_fName.Size = new System.Drawing.Size(276, 28);
            this.textBox_author_fName.TabIndex = 6;
            this.textBox_author_fName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_author_fName_KeyDown);
            // 
            // label_author_lName
            // 
            this.label_author_lName.BackColor = System.Drawing.Color.Transparent;
            this.label_author_lName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author_lName.Location = new System.Drawing.Point(18, 181);
            this.label_author_lName.Name = "label_author_lName";
            this.label_author_lName.Size = new System.Drawing.Size(92, 23);
            this.label_author_lName.TabIndex = 5;
            this.label_author_lName.Text = "Фамилия:";
            this.label_author_lName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_author_fName
            // 
            this.label_author_fName.BackColor = System.Drawing.Color.Transparent;
            this.label_author_fName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author_fName.Location = new System.Drawing.Point(18, 124);
            this.label_author_fName.Name = "label_author_fName";
            this.label_author_fName.Size = new System.Drawing.Size(57, 23);
            this.label_author_fName.TabIndex = 4;
            this.label_author_fName.Text = "Име:";
            this.label_author_fName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_authors
            // 
            this.dataGridView_authors.AllowUserToDeleteRows = false;
            this.dataGridView_authors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_authors.Location = new System.Drawing.Point(496, 80);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_authors.RowTemplate.Height = 100;
            this.dataGridView_authors.Size = new System.Drawing.Size(664, 625);
            this.dataGridView_authors.StandardTab = true;
            this.dataGridView_authors.TabIndex = 3;
            this.dataGridView_authors.VirtualMode = true;
            this.dataGridView_authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_authors_CellClick);
            // 
            // button_removeAuthor
            // 
            this.button_removeAuthor.BackColor = System.Drawing.Color.IndianRed;
            this.button_removeAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removeAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeAuthor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeAuthor.Location = new System.Drawing.Point(342, 661);
            this.button_removeAuthor.Name = "button_removeAuthor";
            this.button_removeAuthor.Size = new System.Drawing.Size(137, 44);
            this.button_removeAuthor.TabIndex = 2;
            this.button_removeAuthor.Text = "ПРЕМАХНИ";
            this.button_removeAuthor.UseVisualStyleBackColor = false;
            this.button_removeAuthor.Click += new System.EventHandler(this.button_removeAuthor_Click);
            // 
            // button_addAuthor
            // 
            this.button_addAuthor.BackColor = System.Drawing.Color.ForestGreen;
            this.button_addAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addAuthor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addAuthor.Location = new System.Drawing.Point(22, 661);
            this.button_addAuthor.Name = "button_addAuthor";
            this.button_addAuthor.Size = new System.Drawing.Size(137, 44);
            this.button_addAuthor.TabIndex = 1;
            this.button_addAuthor.Text = "ДОБАВИ";
            this.button_addAuthor.UseVisualStyleBackColor = false;
            this.button_addAuthor.Click += new System.EventHandler(this.button_addAuthor_Click);
            // 
            // label_author
            // 
            this.label_author.BackColor = System.Drawing.Color.LimeGreen;
            this.label_author.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.Location = new System.Drawing.Point(0, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(1164, 70);
            this.label_author.TabIndex = 0;
            this.label_author.Text = "УПРАВЛЕНИЕ НА АВТОРИ";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authors_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel_author);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authors_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление на авторите";
            this.Load += new System.EventHandler(this.Authors_Manage_Form_Load);
            this.panel_author.ResumeLayout(false);
            this.panel_author.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_author;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Button button_removeAuthor;
        private System.Windows.Forms.Button button_addAuthor;
        private System.Windows.Forms.TextBox textBox_author_lName;
        private System.Windows.Forms.TextBox textBox_author_fName;
        private System.Windows.Forms.Label label_author_lName;
        private System.Windows.Forms.Label label_author_fName;
        private System.Windows.Forms.DataGridView dataGridView_authors;
        private System.Windows.Forms.TextBox textBox_bio;
        private System.Windows.Forms.Label label_authorBio;
        private System.Windows.Forms.Button button_AddPhotoAuthor;
        private System.Windows.Forms.PictureBox pictureBox_author;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_author_id;
    }
}