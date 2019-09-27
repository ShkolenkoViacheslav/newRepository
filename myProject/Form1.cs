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
            cnn.Close();



            /*
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
            */
            
            
                MySqlCommand command;
                MySqlDataReader dateReader;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                String sql = "";
                // Create TutorialID = 3, TutorialName = VEB.NET
                // sql = "Insert into testdb.tutorial (TutorialID,TutorialName) values(3,'" + "VEB.NET" + "')";
                // Change TutorialName = FFF.NET,TutorialID=3
                // sql = "Update tutorial set TutorialName = '"+"FFF.NET"+"' where TutorialID=3";


                sql = "Delete from [tutorial] where TutorialID=3";

                command = new MySqlCommand(sql, cnn);
                adapter.DeleteCommand = new MySqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
            
            /*Change TutorialName = FFF.NET,TutorialID=3
             adapter.UpdateCommand = new MySqlCommand(sql,cnn);
            adapter.UpdateCommand.ExecuteNonQuery();*/

            /*Create TutorialID = 3, TutorialName = VEB.NET
             adapter.InsertCommand = new MySqlCommand(sql,cnn);
             adapter.InsertCommand.ExecuteNonQuery();*/


        }
    }
}
