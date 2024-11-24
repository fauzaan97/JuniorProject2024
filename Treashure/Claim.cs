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
    public partial class Claim : Form
    {
        public Claim()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Claim_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Collection_Points collection_points = new Collection_Points();
            collection_points.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim();
            claim.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }
    }
}
