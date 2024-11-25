using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Treashure
{
    public partial class Collection_Points : Form
    {
        public Collection_Points()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void Collection_Points_Load(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            string city = tbCity.Text;
            try
            {
                StringBuilder address = new StringBuilder();
                address.Append("https://maps.google.com/maps?q=");
                if (city != string.Empty)
                {
                    address.Append(city + "," + "+");
                }
                webView21.Source = new Uri(address.ToString()); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }
    }
}
