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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }
        SqlConnection my = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\gym.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataread;

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void fees_Load(object sender, EventArgs e)
        {
            cmd.Connection = my;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {

            if (id.Text != "" & name.Text != "" & gender.Text != "" & contact.Text != "" & batch.Text != "" & feesmode.Text != "")
                my.Open();
            cmd.CommandText = "insert into fees (id,name,gender,contact,batch,fees) values ('" + id.Text + "','" + name.Text + "','" + gender.Text + "','" + contact.Text + "','" + batch.Text + "','" + feesmode.Text + "')";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data insert Successfully");



            id.Clear();
            name.Clear();

            gender.Clear();

            contact.Clear();
            batch.Clear();

            feesmode.Clear();




            list();
        }

        private void list()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();


            my.Open();

            cmd.CommandText = "select * from fees";

            dataread = cmd.ExecuteReader();
            if (dataread.HasRows)
            {
                while (dataread.Read())
                {

                    listBox1.Items.Add(dataread["id"].ToString());


                    listBox2.Items.Add(dataread["name"].ToString());


                    listBox3.Items.Add(dataread["gender"].ToString());

                    listBox4.Items.Add(dataread["batch"].ToString());

                    listBox5.Items.Add(dataread["contact"].ToString());

                    listBox6.Items.Add(dataread["fees"].ToString());



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
            listBox5.SelectedIndex = list.SelectedIndex;
            listBox6.SelectedIndex = list.SelectedIndex;
           

            id.Text = listBox1.SelectedItem.ToString();


            name.Text = listBox2.SelectedItem.ToString();

            gender.Text = listBox3.SelectedItem.ToString();
            contact.Text = listBox5.SelectedItem.ToString();
            batch.Text = listBox4.SelectedItem.ToString();
            feesmode.Text = listBox5.SelectedItem.ToString();
            
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" & name.Text != "" & gender.Text != "" & contact.Text != "" & batch.Text != "" & feesmode.Text != "")
                my.Open();
            cmd.CommandText = "update fees set id='" + id.Text + "', name='" + name.Text + "', gender='" + gender.Text + "',contact='" + contact.Text + "',batch='" + batch.Text + "' ,fees='" + feesmode.Text + "'   where id= '" + listBox1.SelectedItem.ToString() + "' and name='" + listBox2.SelectedItem.ToString() + "' and gender='" + listBox3.SelectedItem.ToString() + "' and contact='" + listBox5.SelectedItem.ToString() + "' and batch='" + listBox4.SelectedItem.ToString() + "'and fees='" + listBox6.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data update Successfully");



            id.Clear();
            name.Clear();

            gender.Clear();

            contact.Clear();
            batch.Clear();
            
            feesmode.Clear();




            list();

        }

        private void search_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}