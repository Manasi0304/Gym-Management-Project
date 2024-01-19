using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace gym_managment
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        SqlConnection my = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\gym.mdf;Integrated Security=True;User Instance=True");
 
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataread;
      
        private void product_Load(object sender, EventArgs e)
        {
            cmd.Connection = my;

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (id.Text != "" & name.Text != "" & fees.Text != "" & qunatity.Text != "")
                my.Open();
            cmd.CommandText = "insert into product (id,name,fees,qunatity) values ('" + id.Text + "','" + name.Text + "','" + fees.Text + "','" + qunatity.Text + "')";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data insert Successfully");



            id.Clear();
            name.Clear();

            fees.Clear();
            qunatity.Clear();






            list();
        }

        private void list()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();


            my.Open();

            cmd.CommandText = "select * from product";

            dataread = cmd.ExecuteReader();
            if (dataread.HasRows)
            {
                while (dataread.Read())
                {

                    listBox1.Items.Add(dataread["id"].ToString());


                    listBox2.Items.Add(dataread["name"].ToString());



                    listBox3.Items.Add(dataread["fees"].ToString());
                    listBox4.Items.Add(dataread["qunatity"].ToString());



                }

                my.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if (list.SelectedIndex != -1)

                listBox1.SelectedIndex = list.SelectedIndex;
            listBox2.SelectedIndex = list.SelectedIndex;
            listBox3.SelectedIndex = list.SelectedIndex;

            listBox4.SelectedIndex = list.SelectedIndex;
          


            id.Text = listBox1.SelectedItem.ToString();


            name.Text = listBox2.SelectedItem.ToString();

            fees.Text = listBox3.SelectedItem.ToString();
            qunatity.Text = listBox4.SelectedItem.ToString();
        
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" & name.Text != ""  & qunatity.Text != "" & fees.Text != "")
                my.Open();
            cmd.CommandText = "update product set id='" + id.Text + "', name='" + name.Text + "', fees='" + fees.Text + "',qunatity='" + qunatity.Text + "'  where id= '" + listBox1.SelectedItem.ToString() + "' and name='" + listBox2.SelectedItem.ToString() + "' and fees='" + listBox3.SelectedItem.ToString() + "' and qunatity='" + listBox4.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data update Successfully");



            id.Clear();
            name.Clear();

            qunatity.Clear();
            fees.Clear();




            list();

        }

        private void search_Click(object sender, EventArgs e)
        {
            list();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        
       
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           
           







            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        }
    }
