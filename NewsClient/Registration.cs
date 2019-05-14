using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsClient
{
    public partial class Registration : Form
    {
        Image p1 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconStandard.GetHbitmap());
        Image p2 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconActive.GetHbitmap());

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 46, 48);
            pictureBox1.BackgroundImage = p1;

            button1.BackColor = Color.FromArgb(170, 113, 232);
            button1.FlatAppearance.BorderSize = 0;

            richTextBox1.BackColor = Color.FromArgb(44, 46, 48);
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.BackColor = Color.FromArgb(44, 46, 48);
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox3.BackColor = Color.FromArgb(44, 46, 48);
            richTextBox3.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = Color.FromArgb(44, 46, 48);
            label6.ForeColor = Color.FromArgb(44, 46, 48);
            label7.ForeColor = Color.FromArgb(44, 46, 48);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = p1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = richTextBox1.Text;
            string password = richTextBox2.Text;
            string rptPassword = richTextBox3.Text;

            if(login == "" || password == "" || rptPassword == "")
            {
                label5.ForeColor = Color.FromArgb(237, 64, 64);
                return;
            }

            if (password != rptPassword)
            {
                label6.ForeColor = Color.FromArgb(237, 64, 64);
                return;
            }

            bool register = ClientRequest.RegisterAccount(login, password);
            if (register)
            {
                UserForm us = new UserForm(login, password);
                us.Show();
            }
            else
            {
                label7.ForeColor = Color.FromArgb(237, 64, 64);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = p2;
        }
    }
}
