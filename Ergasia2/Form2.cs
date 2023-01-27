using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia2
{
    public partial class Form2 : Form
    {
        //int score = 0;
        Random rand = new Random();
        List<PictureBox> list = new List<PictureBox>();
        int pictureBoxCount = 0;
        public Form2()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Controls.Remove(pictureBox1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            /*Controls.Remove(pictureBox1);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image= Image.FromFile("C:\\programming\\C#\\Efarmogi2-master\\Ergasia2\\bin\\Debug\\cat.jpg");
            pictureBox.Size = new System.Drawing.Size(90, 88);
            int x = rand.Next(0, this.Width - pictureBox.Width);
            int y = rand.Next(0, this.Height - pictureBox.Height);
            pictureBox.Location = new Point(x, y);
            Controls.Add(pictureBox);
            */
        }
    }
}
