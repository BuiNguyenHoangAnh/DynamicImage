using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rep == DialogResult.OK)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            this.timer1.Enabled = true;
            this.button2.Visible = false;
            this.button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            this.button2.Visible = true;
            this.timer1.Enabled = false;
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int temp1,temp2;
            temp1 = r.Next(0, 4);
            temp2 = r.Next(0, 4);
            if (i % 3 == 0)
                this.pictureBox1.Location = new Point(this.pictureBox1.Location.X + temp1, this.pictureBox1.Location.Y + temp2);
            else
                this.pictureBox1.Location = new Point(this.pictureBox1.Location.X - temp1, this.pictureBox1.Location.Y - temp2);
            i++;
        }
    }
}
