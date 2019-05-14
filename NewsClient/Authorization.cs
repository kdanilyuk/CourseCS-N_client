using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsClient
{
    public partial class Authorization : Form
    {
        //Image p1 = Image.FromFile("D:\\Study\\4sem\\КСиС\\Курсовая\\Images\\closeiconStandard.png");
        //Image p2 = Image.FromFile("D:\\Study\\4sem\\КСиС\\Курсовая\\Images\\closeiconActive.png");
        Image p1 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconStandard.GetHbitmap());
        Image p2 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconActive.GetHbitmap());

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 46, 48);

            passwordChecker.BackColor = Color.FromArgb(44, 46, 48);
            passwordChecker.BorderStyle = BorderStyle.FixedSingle;
            loginChecker.BackColor = Color.FromArgb(44, 46, 48);
            loginChecker.BorderStyle = BorderStyle.FixedSingle;
            signin.BackColor = Color.FromArgb(170, 113, 232);
            signin.FlatAppearance.BorderSize = 0;
            signup.BackColor = Color.FromArgb(170, 113, 232);
            signup.FlatAppearance.BorderSize = 0;

            pictureBox1.BackgroundImage = p1;
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
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            string currentLogin = loginChecker.Text;
            string currentPassword = passwordChecker.Text;
            string message = currentLogin + "#" + currentPassword;

            bool isLogin = ClientRequest.ValidationCheck(currentLogin, currentPassword);

            if(isLogin)
            {
                label1.ForeColor = Color.FromArgb(96, 255, 33);
                label2.ForeColor = Color.FromArgb(96, 255, 33);
                UserForm us = new UserForm(currentLogin, currentPassword);
                us.Show();
            }
            else
            {
                label1.ForeColor = Color.FromArgb(237, 64, 64);
                label2.ForeColor = Color.FromArgb(237, 64, 64);
            }       
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = p2;
        }
    }
}
