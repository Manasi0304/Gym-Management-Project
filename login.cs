using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using gym_managment.Properties;
using System.Data.SqlClient;
using System.Configuration;

namespace gym_managment
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection my = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\gym.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username= '" + textBox1.Text + "' and passsword = '" + textBox2.Text + "'", my);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                members f1 = new members ();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check your Username|Password");
            }
        }

        private void loginbtn_MouseHover(object sender, EventArgs e)
        {
            loginbtn.Image = Resources.kkkkgjrkxhlhqvpfbrfl;
        }

        private void loginbtn_MouseLeave(object sender, EventArgs e)
        {
            loginbtn.Image = Resources.login_dark;
        }

        private void exitloginbtn_MouseHover(object sender, EventArgs e)
        {
            exitloginbtn.Image = Resources.img_487255;
        }

        private void exitloginbtn_MouseLeave(object sender, EventArgs e)
        {
            exitloginbtn.Image = Resources.exit_dark_;
        }

        private void exitloginbtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
