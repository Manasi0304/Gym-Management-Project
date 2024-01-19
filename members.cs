using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gym_managment
{
    public partial class members : Form
    {
        public members()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            addmem mem = new addmem();
            mem.TopLevel = false;
            mainpanel.Controls.Add(mem);
            mem.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            login mem = new login();
            
         
            mem.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            product mem = new product();
            mem.TopLevel = false;
            mainpanel.Controls.Add(mem);
            mem.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            fees mem = new fees();
            mem.TopLevel = false;
            mainpanel.Controls.Add(mem);
            mem.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
