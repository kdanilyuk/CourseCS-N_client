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
    public partial class AllNews : Form
    {
        Image p1 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconStandard.GetHbitmap());
        Image p2 = Image.FromHbitmap(NewsClient.Properties.Resources.closeiconActive.GetHbitmap());

        string[] news;

        public AllNews()
        {
            InitializeComponent();
        }

        public AllNews(string[] news) 
        {
            InitializeComponent();
            this.news = news;
        }

        private void AllNews_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 46, 48);
            pictureBox1.BackgroundImage = p1;

            richTextBox1.BackColor = Color.FromArgb(44, 46, 48);

            for(int i = news.Length-2; i > 0; i--)
            {
                richTextBox1.AppendText(news[i - 2] + " " + news[i - 1] + "\n");
                richTextBox1.AppendText("\t" + news[i] + "\n");
                i -= 2;
            }
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = p2;
        }
    }
}
