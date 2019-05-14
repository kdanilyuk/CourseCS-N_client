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
    public partial class UserForm : Form
    {
        Image p1 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconStandard.GetHbitmap());
        Image p2 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconActive.GetHbitmap());
        string login;
        string password;
        string[] news;
        Random rnd = new Random();

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 46, 48);
            pictureBox1.BackgroundImage = p1;

            label1.Text = login;

            button1.BackColor = Color.FromArgb(170, 113, 232);
            button1.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.FromArgb(170, 113, 232);
            button2.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.FromArgb(170, 113, 232);
            button3.FlatAppearance.BorderSize = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            int numberOfNews = (news.Length) / 3;
            if (numberOfNews == 1)
            {
                time1.Text = news[0];
                news1.Text = news[1];
            }
            else if (numberOfNews == 2)
            {
                time1.Text = news[3];
                news1.Text = news[4];
                time2.Text = news[0];
                news2.Text = news[1];
            }
            else if (numberOfNews == 3)
            {
                time1.Text = news[6];
                news1.Text = news[7];
                time2.Text = news[3];
                news2.Text = news[4];
                time3.Text = news[0];
                news3.Text = news[1];
            }
            else if (numberOfNews == 4)
            {
                time1.Text = news[9];
                news1.Text = news[10];
                time2.Text = news[6];
                news2.Text = news[7];
                time3.Text = news[3];
                news3.Text = news[4];
                time4.Text = news[0];
                news4.Text = news[1];
            }
            else if (numberOfNews == 5)
            {
                time1.Text = news[12];
                news1.Text = news[13];
                time2.Text = news[9];
                news2.Text = news[10];
                time3.Text = news[6];
                news3.Text = news[7];
                time4.Text = news[3];
                news4.Text = news[4];
                time5.Text = news[0];
                news5.Text = news[1];
            }
            else if (numberOfNews == 6)
            {
                time1.Text = news[15];
                news1.Text = news[16];
                time2.Text = news[12];
                news2.Text = news[13];
                time3.Text = news[9];
                news3.Text = news[10];
                time4.Text = news[6];
                news4.Text = news[7];
                time5.Text = news[3];
                news5.Text = news[4];
                time6.Text = news[0];
                news6.Text = news[1];
            }
            else if (numberOfNews == 7)
            {
                time1.Text = news[18];
                news1.Text = news[19];
                time2.Text = news[15];
                news2.Text = news[16];
                time3.Text = news[12];
                news3.Text = news[13];
                time4.Text = news[9];
                news4.Text = news[10];
                time5.Text = news[6];
                news5.Text = news[7];
                time6.Text = news[3];
                news6.Text = news[4];
                time7.Text = news[0];
                news7.Text = news[1];
            }
            else
            {
                time1.Text = news[news.Length - 4];
                news1.Text = news[news.Length - 3];
                time2.Text = news[news.Length - 7];
                news2.Text = news[news.Length - 6];
                time3.Text = news[news.Length - 10];
                news3.Text = news[news.Length - 9];
                time4.Text = news[news.Length - 13];
                news4.Text = news[news.Length - 12];
                time5.Text = news[news.Length - 16];
                news5.Text = news[news.Length - 15];
                time6.Text = news[news.Length - 19];
                news6.Text = news[news.Length - 18];
                time7.Text = news[news.Length - 22];
                news7.Text = news[news.Length - 21];
            }

        }

        private void news1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news1_MouseLeave(object sender, EventArgs e)
        {
            news1.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void news2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news2_MouseLeave(object sender, EventArgs e)
        {
            news2.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void news3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void news3_MouseLeave(object sender, EventArgs e)
        {
            news3.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void news4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news4_MouseLeave(object sender, EventArgs e)
        {
            news4.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void news5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news5_MouseLeave(object sender, EventArgs e)
        {
            news5.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OfferNews of = new OfferNews(login, password);
            of.Show();
        }

        private void news6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news6_MouseLeave(object sender, EventArgs e)
        {
            news6.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void news7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void news7_MouseLeave(object sender, EventArgs e)
        {
            news7.ForeColor = Color.FromArgb(255, 255, 255);
        }

        string[] RefreshNews()
        {
            string actNews = ClientRequest.GetNews(login, password);
            string[] words = actNews.Split(new char[] { '#' });
            for (int i = 0; i < words.Length - 1; i++)
            {
                words[i] = words[i].Replace("\n", "");
            }

            return words;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            AllNews al = new AllNews(news);
            al.Show();
        }

        private void news1_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 3 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 2]);
                cr.Show();
            }
        }

        private void news2_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 6 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 5]);
                cr.Show();
            }
        }

        private void news3_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 9 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 8]);
                cr.Show();
            }
        }

        private void news4_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 12 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 11]);
                cr.Show();
            }
        }

        private void news5_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 15 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 14]);
                cr.Show();
            }
        }

        private void news6_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 18 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 17]);
                cr.Show();
            }
        }

        private void news7_Click(object sender, EventArgs e)
        {
            news = RefreshNews();
            if (news.Length > 21 && new string(news1.Text.Distinct().ToArray()) != "-")
            {
                CurrentNews cr = new CurrentNews(news[news.Length - 20]);
                cr.Show();
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = p2;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void news1_MouseEnter(object sender, EventArgs e)
        {
            news1.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news2_MouseEnter(object sender, EventArgs e)
        {
            news2.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news3_MouseEnter(object sender, EventArgs e)
        {
            news3.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news4_MouseEnter(object sender, EventArgs e)
        {
            news4.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news5_MouseEnter(object sender, EventArgs e)
        {
            news5.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news6_MouseEnter(object sender, EventArgs e)
        {
            news6.ForeColor = Color.FromArgb(45, 126, 255);
        }

        private void news7_MouseEnter(object sender, EventArgs e)
        {
            news7.ForeColor = Color.FromArgb(45, 126, 255);
        }
    }
}
