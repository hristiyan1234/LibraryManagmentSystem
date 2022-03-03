using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class Publish_Manage_Form : Form
    {
        public Publish_Manage_Form()
        {
            InitializeComponent();
        }
        Classes.Publish newPub = new Classes.Publish();
        private void Publish_Manage_Form_Load(object sender, EventArgs e)
        {
            dataGridView_pub.DataSource = newPub.PubList();

        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red; // X става червен
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Ivory; //цветът се връща
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_addPubHouse_Click(object sender, EventArgs e)
        {
            string publishHouse = textBox_publishHouse.Text;
            if (newPub.UniqPub(publishHouse))
            {
                MessageBox.Show("Това издателство вече съществува в библиотеката!", "Съществуващо издателство", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newPub.AddPub(publishHouse)) // 
            {
                MessageBox.Show("Издателска къща " + publishHouse + " е добавенa!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_pub.DataSource = newPub.PubList();
                textBox_publishHouse.Text = "";
            }
        }
    }
}
