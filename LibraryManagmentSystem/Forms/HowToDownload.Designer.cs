namespace LibraryManagmentSystem.Forms
{
    partial class HowToDownload
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
            this.button_pdf = new System.Windows.Forms.Button();
            this.button_exel = new System.Windows.Forms.Button();
            this.button_doc = new System.Windows.Forms.Button();
            this.label_how = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_pdf
            // 
            this.button_pdf.BackColor = System.Drawing.Color.SeaShell;
            this.button_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pdf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pdf.Location = new System.Drawing.Point(38, 170);
            this.button_pdf.Name = "button_pdf";
            this.button_pdf.Size = new System.Drawing.Size(96, 33);
            this.button_pdf.TabIndex = 0;
            this.button_pdf.Text = "PDF";
            this.button_pdf.UseVisualStyleBackColor = false;
            this.button_pdf.Click += new System.EventHandler(this.button_pdf_Click);
            // 
            // button_exel
            // 
            this.button_exel.BackColor = System.Drawing.Color.SeaShell;
            this.button_exel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exel.Location = new System.Drawing.Point(150, 170);
            this.button_exel.Name = "button_exel";
            this.button_exel.Size = new System.Drawing.Size(96, 33);
            this.button_exel.TabIndex = 1;
            this.button_exel.Text = "EXEL";
            this.button_exel.UseVisualStyleBackColor = false;
            // 
            // button_doc
            // 
            this.button_doc.BackColor = System.Drawing.Color.SeaShell;
            this.button_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doc.Location = new System.Drawing.Point(262, 170);
            this.button_doc.Name = "button_doc";
            this.button_doc.Size = new System.Drawing.Size(96, 33);
            this.button_doc.TabIndex = 2;
            this.button_doc.Text = "DOC";
            this.button_doc.UseVisualStyleBackColor = false;
            // 
            // label_how
            // 
            this.label_how.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_how.Location = new System.Drawing.Point(38, 59);
            this.label_how.Name = "label_how";
            this.label_how.Size = new System.Drawing.Size(320, 94);
            this.label_how.TabIndex = 3;
            this.label_how.Text = "В какъв формат да бъде \r\nизтеглена таблицата?\r\n";
            this.label_how.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Black;
            this.label_close.Location = new System.Drawing.Point(392, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 29);
            this.label_close.TabIndex = 47;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // HowToDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(421, 219);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_how);
            this.Controls.Add(this.button_doc);
            this.Controls.Add(this.button_exel);
            this.Controls.Add(this.button_pdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HowToDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowToDownload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pdf;
        private System.Windows.Forms.Button button_exel;
        private System.Windows.Forms.Button button_doc;
        private System.Windows.Forms.Label label_how;
        private System.Windows.Forms.Label label_close;
    }
}