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

using QueryMaker;

namespace This_Time_It_Will_Work
{
    //Коммент для push
    public partial class MainForm : Form
    {
        public string currentDB;
        public MainForm()
        {
            InitializeComponent();
            currentDB = "user_db";
            try
            {
                DataBase db = new DataBase(currentDB);
                db.OpenConnection();
            }
            catch(MySqlException ex)
            {
                currentDB = null;
            }
            if (currentDB == null)
            {
                buttonChangeDB.Enabled = false;
                buttonEntries.Enabled = false;
                buttonQueries.Enabled = false;
            }
        }

        public MainForm(string dbName)
        {
            InitializeComponent();
            currentDB = dbName;
            if (currentDB == null)
            {
                buttonChangeDB.Enabled = false;
                buttonEntries.Enabled = false;
                buttonQueries.Enabled = false;
            }
        }

        private void CreateDbButton_Click(object sender, EventArgs e)
        {
            DBCreationFrom form = new DBCreationFrom(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonChangeDB_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonEntries_Click(object sender, EventArgs e)
        {
            EntriesManipulationForm form = new EntriesManipulationForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            TableChooserForm queryForm = new TableChooserForm(currentDB);
            queryForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
