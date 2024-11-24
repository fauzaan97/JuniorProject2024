using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treashure
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form4 = new Form3();
            form4.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Visible = false;
        }
    }
}
