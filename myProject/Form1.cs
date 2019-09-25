using System;
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
           // MessageBox.Show("Connection Open !");
            cnn.Clone();
            
            MySqlCommand command;
            MySqlDataReader dateReader;
            String sql, Output = "";
            sql = "Select TutorialID,TutorialName from tutorial";
            command = new MySqlCommand(sql,cnn);
            dateReader = command.ExecuteReader();

            while (dateReader.Read()) {
                Output = Output + dateReader.GetValue(0) + " - " + dateReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);

            dateReader.Close();
            command.Dispose();
            cnn.Close();
           
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            

            sql = "Insert into testdb.tutorial (TutorialID,TutorialName) values(3,'" + "VEB.NET" + "')";

            command = new MySqlCommand(sql,cnn);
            adapter.InsertCommand = new MySqlCommand(sql,cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }
    }
}
