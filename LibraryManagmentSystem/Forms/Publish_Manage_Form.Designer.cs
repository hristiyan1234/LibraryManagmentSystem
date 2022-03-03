namespace LibraryManagmentSystem.Forms
{
    partial class Publish_Manage_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publish_Manage_Form));
            this.panel_pub = new System.Windows.Forms.Panel();
            this.textBox_pub_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_publishHouse = new System.Windows.Forms.TextBox();
            this.label_pub = new System.Windows.Forms.Label();
            this.button_updatePubHouse = new System.Windows.Forms.Button();
            this.button_removePubHouse = new System.Windows.Forms.Button();
            this.button_addPubHouse = new System.Windows.Forms.Button();
            this.dataGridView_pub = new System.Windows.Forms.DataGridView();
            this.label_managePubs = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel_pub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pub)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_pub
            // 
            this.panel_pub.BackColor = System.Drawing.Color.MistyRose;
            this.panel_pub.Controls.Add(this.label_close);
            this.panel_pub.Controls.Add(this.textBox_pub_id);
            this.panel_pub.Controls.Add(this.label_id);
            this.panel_pub.Controls.Add(this.textBox_publishHouse);
            this.panel_pub.Controls.Add(this.label_pub);
            this.panel_pub.Controls.Add(this.button_updatePubHouse);
            this.panel_pub.Controls.Add(this.button_removePubHouse);
            this.panel_pub.Controls.Add(this.button_addPubHouse);
            this.panel_pub.Controls.Add(this.dataGridView_pub);
            this.panel_pub.Controls.Add(this.label_managePubs);
            this.panel_pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pub.Location = new System.Drawing.Point(0, 0);
            this.panel_pub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_pub.Name = "panel_pub";
            this.panel_pub.Size = new System.Drawing.Size(524, 277);
            this.panel_pub.TabIndex = 0;
            // 
            // textBox_pub_id
            // 
            this.textBox_pub_id.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pub_id.Location = new System.Drawing.Point(38, 75);
            this.textBox_pub_id.Name = "textBox_pub_id";
            this.textBox_pub_id.Size = new System.Drawing.Size(84, 28);
            this.textBox_pub_id.TabIndex = 28;
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.Color.Transparent;
            this.label_id.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(9, 75);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(36, 23);
            this.label_id.TabIndex = 29;
            this.label_id.Text = "ID:";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_publishHouse
            // 
            this.textBox_publishHouse.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_publishHouse.Location = new System.Drawing.Point(166, 75);
            this.textBox_publishHouse.Name = "textBox_publishHouse";
            this.textBox_publishHouse.Size = new System.Drawing.Size(336, 28);
            this.textBox_publishHouse.TabIndex = 27;
            // 
            // label_pub
            // 
            this.label_pub.BackColor = System.Drawing.Color.Transparent;
            this.label_pub.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pub.Location = new System.Drawing.Point(125, 77);
            this.label_pub.Name = "label_pub";
            this.label_pub.Size = new System.Drawing.Size(57, 23);
            this.label_pub.TabIndex = 26;
            this.label_pub.Text = "Име:";
            this.label_pub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_updatePubHouse
            // 
            this.button_updatePubHouse.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_updatePubHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_updatePubHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updatePubHouse.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatePubHouse.Location = new System.Drawing.Point(13, 161);
            this.button_updatePubHouse.Name = "button_updatePubHouse";
            this.button_updatePubHouse.Size = new System.Drawing.Size(109, 44);
            this.button_updatePubHouse.TabIndex = 25;
            this.button_updatePubHouse.Text = "ОБНОВИ";
            this.button_updatePubHouse.UseVisualStyleBackColor = false;
            // 
            // button_removePubHouse
            // 
            this.button_removePubHouse.BackColor = System.Drawing.Color.IndianRed;
            this.button_removePubHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removePubHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removePubHouse.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removePubHouse.Location = new System.Drawing.Point(13, 211);
            this.button_removePubHouse.Name = "button_removePubHouse";
            this.button_removePubHouse.Size = new System.Drawing.Size(109, 44);
            this.button_removePubHouse.TabIndex = 24;
            this.button_removePubHouse.Text = "ПРЕМАХНИ";
            this.button_removePubHouse.UseVisualStyleBackColor = false;
            // 
            // button_addPubHouse
            // 
            this.button_addPubHouse.BackColor = System.Drawing.Color.ForestGreen;
            this.button_addPubHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addPubHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addPubHouse.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPubHouse.Location = new System.Drawing.Point(13, 111);
            this.button_addPubHouse.Name = "button_addPubHouse";
            this.button_addPubHouse.Size = new System.Drawing.Size(109, 44);
            this.button_addPubHouse.TabIndex = 23;
            this.button_addPubHouse.Text = "ДОБАВИ";
            this.button_addPubHouse.UseVisualStyleBackColor = false;
            this.button_addPubHouse.Click += new System.EventHandler(this.button_addPubHouse_Click);
            // 
            // dataGridView_pub
            // 
            this.dataGridView_pub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pub.Location = new System.Drawing.Point(129, 111);
            this.dataGridView_pub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_pub.Name = "dataGridView_pub";
            this.dataGridView_pub.Size = new System.Drawing.Size(373, 144);
            this.dataGridView_pub.TabIndex = 8;
            // 
            // label_managePubs
            // 
            this.label_managePubs.BackColor = System.Drawing.Color.LimeGreen;
            this.label_managePubs.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_managePubs.Location = new System.Drawing.Point(0, 0);
            this.label_managePubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_managePubs.Name = "label_managePubs";
            this.label_managePubs.Size = new System.Drawing.Size(524, 63);
            this.label_managePubs.TabIndex = 7;
            this.label_managePubs.Text = "ИЗДАТЕЛСКИ КЪЩИ";
            this.label_managePubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.LimeGreen;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Ivory;
            this.label_close.Location = new System.Drawing.Point(498, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(26, 27);
            this.label_close.TabIndex = 30;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // Publish_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.Controls.Add(this.panel_pub);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Publish_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление на издателски къщи";
            this.Load += new System.EventHandler(this.Publish_Manage_Form_Load);
            this.panel_pub.ResumeLayout(false);
            this.panel_pub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pub;
        private System.Windows.Forms.DataGridView dataGridView_pub;
        private System.Windows.Forms.Label label_managePubs;
        private System.Windows.Forms.Button button_updatePubHouse;
        private System.Windows.Forms.Button button_removePubHouse;
        private System.Windows.Forms.Button button_addPubHouse;
        private System.Windows.Forms.TextBox textBox_pub_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_publishHouse;
        private System.Windows.Forms.Label label_pub;
        private System.Windows.Forms.Label label_close;
    }
}