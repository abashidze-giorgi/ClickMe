using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMe
{
    public partial class Form1 : Form
    {
        int posX = 0;
        int posY = 0;
        Point point;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Location = PointPos();
        }

        private Point PointPos()
        {
            Random random = new Random();
            posX = random.Next(this.Width - btn1.Width);
            posY = random.Next(this.Height - btn1.Height);
            point = new Point(posX, posY);
            return point;
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            btn1.Location = PointPos();
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            btn1.Location = PointPos();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(btn1.Location.X > this.Width - btn1.Width || btn1.Location.Y > this.Height)
            {
                btn1.Location = PointPos();
            }
        }

        private void btn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
