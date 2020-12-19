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
    public partial class ConnectionSetUpForm : Form
    {
        public string currentDB;

        public ConnectionSetUpForm()
        {
            InitializeComponent();
            CheckAttrsSelection();
        }

        public ConnectionSetUpForm(string db)
        {
            InitializeComponent();
            currentDB = db;
            FillListTables();
            CheckAttrsSelection();
        }

        private void ConnectionSetUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void CreateConnectionButton_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);

            bool flag = false;
            userDB.OpenConnection();
            try
            {
                MySqlCommand com = new MySqlCommand($"ALTER TABLE `{depTableComboBox.Text}` ADD CONSTRAINT {depAttrListBox.SelectedItem}_refto_{refAttrListBox.SelectedItem} FOREIGN KEY ({depAttrListBox.SelectedItem}) REFERENCES `{refTableComboBox.Text}` ({refAttrListBox.SelectedItem}) ON UPDATE CASCADE ON DELETE CASCADE", userDB.GetConnection());
                com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Невозможно установить связь по данным атрибутам");
                flag = true;
            }
            mData.OpenConnection();
            if (!flag)
            {
                DataTable table = GetTable(mData);
                int nextID;
                if (table.Rows.Count > 0)
                    nextID = UnicID(table);
                else nextID = 1;

                MySqlCommand com = new MySqlCommand($"INSERT INTO `connection` (Connection_ID,Connection_Name,First_Atr_ID,Second_Atr_ID,Connection_Description) VALUES ({nextID}, \"{depAttrListBox.SelectedItem}_refto_{refAttrListBox.SelectedItem}\", {GetAttrID(depAttrListBox.SelectedItem.ToString())}, {GetAttrID(refAttrListBox.SelectedItem.ToString())}, \"{richTextBox1.Text}\")", mData.GetConnection());
                com.ExecuteNonQuery();
                MessageBox.Show("Связь успешно добавлена");
            }
            userDB.CloseConnection();
            mData.CloseConnection();

        }

        private void depTableComboBox_TextChanged(object sender, EventArgs e)
        {
            depAttrListBox.Items.Clear();
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Attribute_Name FROM `attribute` WHERE Table_ID = {GetTableID(depTableComboBox.Text)}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                depAttrListBox.Items.Add(reader.GetValue(0).ToString());
            }
            mData.CloseConnection();
            CheckAttrsSelection();
        }

        private void refTableComboBox_TextChanged(object sender, EventArgs e)
        {
            refAttrListBox.Items.Clear();
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Attribute_Name FROM `attribute` WHERE Table_ID = {GetTableID(refTableComboBox.Text)}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                refAttrListBox.Items.Add(reader.GetValue(0).ToString());
            }
            mData.CloseConnection();
            CheckAttrsSelection();
        }
        private void FillListTables()
        {
            DataBase db = new DataBase("prime_db");
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT Name FROM `table`", db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                depTableComboBox.Items.Add(reader.GetValue(0).ToString());
                refTableComboBox.Items.Add(reader.GetValue(0).ToString());
            }
            db.CloseConnection();

        }

        private int GetTableID(string tName)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Table_ID FROM `table` WHERE Name = \"{tName}\"", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader.GetValue(0).ToString());

        }

        private int GetAttrID(string aName)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Attribute_ID FROM `attribute` WHERE Attribute_Name = \"{aName}\"", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader.GetValue(0).ToString());

        }

        private DataTable GetTable(DataBase connection)
        {
            connection.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string query_select_id = $"SELECT * FROM `connection`";
            MySqlCommand command = new MySqlCommand(query_select_id, connection.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int UnicID(DataTable table)
        {
            int max_value = Convert.ToInt32(table.Select("Connection_ID = MAX(Connection_ID)")[0][0].ToString());
            return max_value + 1;
        }

        private void depTableComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void refTableComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void depAttrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAttrsSelection();
        }

        private void refAttrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAttrsSelection();
        }

        private void CheckAttrsSelection()
        {
            if (depTableComboBox.Text == refTableComboBox.Text || depAttrListBox.SelectedItem == null || refAttrListBox.SelectedItem == null) CreateConnectionButton.Enabled = false;
            else CreateConnectionButton.Enabled = true;
        }
    }
}
