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
    public partial class TableDescriptionForm : Form
    {
        public string currentDB;
        public string tableName;

        public TableDescriptionForm()
        {
            InitializeComponent();
        }

        public TableDescriptionForm(string DataBaseName, string chgTable)
        {
            InitializeComponent();
            currentDB = DataBaseName;
            tableName = chgTable;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB, tableName);
            form.Show();
            this.Hide();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);

            mData.OpenConnection();
            DataTable table = GetTable(mData);
            int nextID;
            if (table.Rows.Count > 0)
                nextID = UnicID(table);
            else nextID = 1; 
            MySqlCommand commandIns = new MySqlCommand($"INSERT INTO `table` (Table_ID,Name,Description) VALUES ({nextID},\"{tableName}\",\"{richTextBox1.Text}\")", mData.GetConnection());
            commandIns.ExecuteNonQuery();

            userDB.OpenConnection();
            MySqlCommand commandCreate = new MySqlCommand($@"
                    CREATE TABLE {tableName}
                    (I_D INT NOT NULL)", userDB.GetConnection()) ;
            commandCreate.ExecuteNonQuery();

            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
            MessageBox.Show($"Таблица {tableName} успешно добавлена!");

        }

        private void TableDescriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private DataTable GetTable(DataBase connection)
        {
            connection.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string query_select_id = $"SELECT * FROM `table`";
            MySqlCommand command = new MySqlCommand(query_select_id, connection.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int UnicID(DataTable table)
        {
            int max_value = Convert.ToInt32(table.Select("Table_ID = MAX(Table_ID)")[0][0].ToString());
            return max_value + 1;
        }
    }
}
