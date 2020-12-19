using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_Time_It_Will_Work
{
    public partial class DBCreationFrom : Form
    {
        public string currentDB;
        public DBCreationFrom()
        {
            InitializeComponent();
        }

        public DBCreationFrom(string dbName)
        {
            InitializeComponent();
            currentDB = dbName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void DBCreationFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=root");
            con.Open();
            
            MySqlCommand com = new MySqlCommand($"DROP DATABASE IF EXISTS user_db", con);
            com.ExecuteNonQuery();
            
            MySqlCommand command = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS user_db", con);
            command.ExecuteNonQuery();
            currentDB = "user_db";

            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            string[] names = { "table", "connection", "attribute" };
            foreach (string t in names)
            {
                MySqlCommand del = new MySqlCommand($"DELETE FROM `{t}`", mData.GetConnection());
                del.ExecuteNonQuery();
            }

            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
            MessageBox.Show($"База данных {currentDB} создана успешно!");

        }

    }
}
