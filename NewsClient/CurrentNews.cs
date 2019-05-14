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
    public partial class CurrentNews : Form
    {
        Image p1 = Image.FromHbitmap(NewsClient.Properties.Resources.prevIconPassive.GetHbitmap());
        Image p2 = Image.FromHbitmap(NewsClient.Properties.Resources.prevIconActive.GetHbitmap());

        string text;

        public CurrentNews()
        {
            InitializeComponent();
        }

        public CurrentNews(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        private void CurrentNews_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(44, 46, 48);
            pictureBox1.BackgroundImage = p1;

            richTextBox1.BackColor = Color.FromArgb(44, 46, 48);
            richTextBox1.AppendText(text);
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
