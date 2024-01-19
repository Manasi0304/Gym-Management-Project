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
    public partial class addmem : Form
    {
        public addmem()
        {
            InitializeComponent();
        }

        SqlConnection my = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\gym.mdf;Integrated Security=True;User Instance=True");
         SqlCommand cmd = new SqlCommand();
        SqlDataReader dataread;

        private void addmem_Load(object sender, EventArgs e)
        {
            cmd.Connection = my;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void addnewstd_Click(object sender, EventArgs e)
        {

        }

        private void ftname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (id.Text != "" & name.Text != "" & gender.Text != "" & height.Text != "" & weight.Text != "" & contact.Text != "" & batch.Text != "" & workout.Text != "" & feesmode.Text != "")
                my.Open();
            cmd.CommandText = "insert into addinfo (id,name,gender,height,weight,contact,batch,workout,feesmode) values ('" + id.Text + "','" + name.Text + "','" + gender.Text + "','" + height.Text + "','" + weight.Text + "','" + contact.Text + "','" + batch.Text + "','" + workout.Text + "','" + feesmode.Text + "')";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data insert Successfully");



            id.Clear();
            name.Clear();

            gender.Clear();
            height.Clear();
            weight.Clear();
            contact.Clear();
            batch.Clear();
            workout.Clear();
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
            listBox7.Items.Clear();
            listBox10.Items.Clear();
            listBox9.Items.Clear();
            
            my.Open();

            cmd.CommandText = "select * from addinfo";

            dataread = cmd.ExecuteReader();
            if (dataread.HasRows)
            {
                while (dataread.Read())
                {

                    listBox1.Items.Add(dataread["name"].ToString());


                    listBox2.Items.Add(dataread["gender"].ToString());

                    listBox3.Items.Add(dataread["height"].ToString());

                    listBox4.Items.Add(dataread["weight"].ToString());

                    listBox5.Items.Add(dataread["contact"].ToString());

                    listBox6.Items.Add(dataread["batch"].ToString());

                    listBox7.Items.Add(dataread["workout"].ToString());

                    listBox10.Items.Add(dataread["feesmode"].ToString());
                    listBox9.Items.Add(dataread["id"].ToString());

                }

                my.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void search_Click(object sender, EventArgs e)
        {
            list();
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if (list.SelectedIndex != -1)

                listBox1.SelectedIndex = list.SelectedIndex;
            listBox2.SelectedIndex = list.SelectedIndex;
            listBox3.SelectedIndex = list.SelectedIndex;
            listBox4.SelectedIndex = list.SelectedIndex;
            listBox5.SelectedIndex = list.SelectedIndex;
            listBox6.SelectedIndex = list.SelectedIndex;
            listBox7.SelectedIndex = list.SelectedIndex;
            listBox10.SelectedIndex = list.SelectedIndex;
            listBox9.SelectedIndex = list.SelectedIndex;

            id.Text = listBox9.SelectedItem.ToString();


            name.Text = listBox1.SelectedItem.ToString();

            gender.Text = listBox2.SelectedItem.ToString();
            height.Text = listBox3.SelectedItem.ToString();
            weight.Text = listBox4.SelectedItem.ToString();
            contact.Text = listBox5.SelectedItem.ToString();
            batch.Text = listBox6.SelectedItem.ToString();
            workout.Text = listBox7.SelectedItem.ToString();
            feesmode.Text = listBox10.SelectedItem.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id.Text != " ")
                my.Open();
            cmd.CommandText = "delete from addinfo where id='" + id.Text + "'";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data delete Successfully");



            id.Clear();
            name.Clear();

            gender.Clear();
            height.Clear();
            weight.Clear();
            contact.Clear();
            batch.Clear();
            workout.Clear();
            feesmode.Clear();
            list();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" & name.Text != "" & gender.Text != "" & height.Text != "" & weight.Text != "" & contact.Text != "" & batch.Text != "" & workout.Text != "" & feesmode.Text != "")
                my.Open();
            cmd.CommandText = "update addinfo set id='" + id.Text + "', name='" + name.Text + "', gender='" + gender.Text + "',height='" + height.Text + "',weight='" + weight.Text + "',contact='" + contact.Text + "',batch='" + batch.Text  + "',workout ='" + workout.Text + "' ,feesmode='" + feesmode.Text + "'   where id= '" + listBox9.SelectedItem.ToString() + "' and name='" + listBox1.SelectedItem.ToString() + "' and gender='" + listBox2.SelectedItem.ToString() + "' and height='" + listBox3.SelectedItem.ToString() + "' and weight='" + listBox4.SelectedItem.ToString() + "' and contact='" + listBox5.SelectedItem.ToString() + "' and batch='" + listBox6.SelectedItem.ToString() + "'and workout='" + listBox7.SelectedItem.ToString() + "'and feesmode='" + listBox10.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            my.Close();
            MessageBox.Show("Data update Successfully");



            id.Clear();
            name.Clear();

            gender.Clear();
            height.Clear();
            weight.Clear();
            contact.Clear();
            batch.Clear();
            workout.Clear();
            feesmode.Clear();




            list();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {




          
           
        }

        private void feesmode_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

