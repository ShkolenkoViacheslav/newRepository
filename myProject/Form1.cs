﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace myProject
{
    public partial class Form1 : Form
    {
        MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password = 1111; database = testdb; Port = 3306");



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cnn.Open();
            MessageBox.Show("Connection Open !");
            cnn.Clone();
        }
    }
}
