using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace This_Time_It_Will_Work
{
    public partial class EntriesManipulationForm : Form
    {
        public string currentDB;

        public EntriesManipulationForm()
        {
            InitializeComponent();
            
        }
        public void Optional_table_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Неверный формат данных!");
            anError.ThrowException = false;
        }
        public EntriesManipulationForm(string name)
        { 
            InitializeComponent();
            currentDB = name;
            FillListTables();
            button_delete.Enabled = false;
            button_insert.Enabled = false;
            button_select.Enabled = false;
            button_update.Enabled = false;
            button_do.Enabled = false;
            InputKeyHide();
            Optional_table.DataError += new DataGridViewDataErrorEventHandler(Optional_table_DataError);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }
        private void EntriesManipulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
      
        //заполнение Box c именами таблиц | обращение к метаданным
        private void FillListTables()
        {
            get_table.Items.Clear();

            try
            {
                DataBase db = new DataBase("prime_db");
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT Name FROM prime_db.table", db.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    get_table.Items.Add(reader.GetValue(0).ToString());
                }
                db.CloseConnection();
            }
            catch
            {

            }
            
        }

        public DataTable dataTable = new DataTable();
        //заполнение CheckBox именами атрибутов | обращение к метаданным
        private void FillCheckBoxList()
        {
            dataTable = new DataTable();
            checkedList_atribytes.Items.Clear();
            DataBase db = new DataBase("prime_db");
            db.OpenConnection();

            //вытащить из метаданных
            string query = $"SELECT attribute.Attribute_Name, attribute.Type, attribute.Is_Key FROM `attribute` INNER JOIN `table` ON (`attribute`.Table_ID = `table`.Table_ID) WHERE `table`.Name = \"{get_table.Text}\"";
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            DataColumn column;
            DataRow row;
            row = dataTable.NewRow();

            while (reader.Read())
            {
                column = new DataColumn();
                if (reader.GetValue(2).ToString() == "True")
                    column.ColumnName = reader.GetValue(0).ToString() + "*";              //название колонки 
                else
                    column.ColumnName = reader.GetValue(0).ToString();              //название колонки 

                column.DataType = Type.GetType(get_type(reader.GetValue(1).ToString()));  //тип колонки

                dataTable.Columns.Add(column);
                checkedList_atribytes.Items.Add(reader.GetValue(0).ToString());
                try { row[column.ColumnName] = DBNull.Value.Equals(column.DataType); }
                catch
                {
                    row[column.ColumnName] = Convert.ToDateTime("1999-01-01");
                }
            }

            dataTable.Rows.Add(row);
            Optional_table.DataSource = dataTable;
            Optional_table.Enabled = false;
        }

        private string get_type(string type)
        {
            if (type.Contains("Int"))
                return "System.Int32";
            else if (type.Contains("Date"))
                return "System.String";
            else 
                return "System.String";
            

        }
        //подключение к таблице
        private DataTable GetTable(DataBase db, string table_name)
        {
            try
            {
                db.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string query_select_id = $"SELECT * FROM `{table_name}`";
                MySqlCommand command = new MySqlCommand(query_select_id, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();
                return table;
            }
            catch
            {
                MessageBox.Show("Данной таблицы не существует");
                return null;
            }
        }

        //заполнение Box именами таблиц
        private void get_table_TextChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase(currentDB);
            db.OpenConnection();
            dataGridView.DataSource = GetTable(db, get_table.Text);
            FillCheckBoxList();
            button_select.Enabled = false;

            button_delete.Enabled = true;
            button_insert.Enabled = true;
            button_update.Enabled = true;
            button_do.Enabled = true;

            button_insert.BackColor = Color.FromArgb(227, 227, 227);
            button_delete.BackColor = Color.FromArgb(227, 227, 227);
            button_update.BackColor = Color.FromArgb(227, 227, 227);
            InputKeyHide();
            delete_step = 0;
            update_step = 0;

            dataTable.Rows.Clear();
        }

        //выбор атрибутов
        private void button_select_Click(object sender, EventArgs e)
        {
            List<string> checkedItems = new List<string>();
            if (checkedList_atribytes.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedList_atribytes.CheckedItems.Count; x++)

                    checkedItems.Add(checkedList_atribytes.CheckedItems[x].ToString());
            }
            DataBase db = new DataBase(currentDB);
            db.OpenConnection();
            dataGridView.DataSource = select_some_atr(db, get_table.Text, checkedItems);

        }

        //таблица с выбранными атрибутами
        private DataTable select_some_atr(DataBase connection, string table_name, List<string> checkedItems)
        {
            connection.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string new_string = "";
            foreach (string tt in checkedItems)
            {
                new_string += tt + ", ";
            }
            new_string = new_string.Trim(',', ' ');
            string query_select_id = $"SELECT {new_string} FROM `{table_name}`";
            MySqlCommand command = new MySqlCommand(query_select_id, connection.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int delete_step = 0;
        public int update_step = 0;
        private void button_do_Click(object sender, EventArgs e)
        {
            if (delete_step >= 2)
                    delete_step = 0;
                       
            if (update_step >= 2)   
                update_step = 0;
                
            string key = textBox_inputKey.Text;

            if (button_insert.BackColor == Color.LightBlue)
                Insert();

            else if (button_delete.BackColor == Color.LightBlue)
                Delete(key);

            else if (button_update.BackColor == Color.LightBlue)
                Update(key);
        }
           

        private void button_insert_Click(object sender, EventArgs e)
        {
            Optional_table.Enabled = true;
            if (button_insert.BackColor == Color.LightBlue)
            {
                button_insert.BackColor = Color.FromArgb(227, 227, 227); 
                Optional_table.Enabled = false;
                button_do.Enabled = false;
                dataTable.Rows.Clear();
            }
            else
            {
                InputKeyHide();
                dataTable.Rows.Clear();
                Optional_table.DataSource = dataTable;
                button_do.Enabled = true;
                button_insert.BackColor = Color.LightBlue;
                button_delete.BackColor = Color.FromArgb(227, 227, 227); 
                button_update.BackColor = Color.FromArgb(227, 227, 227); 
                AddDefaultRow();
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            Optional_table.Enabled = true;
            if (button_delete.BackColor == Color.LightBlue)
            {
                button_delete.BackColor = Color.FromArgb(227, 227, 227); 
                Optional_table.Enabled = false;
                button_do.Enabled = false;
                InputKeyHide();
            }
            else
            {
                delete_step = 0;
                Optional_table.DataSource = dataTable;
                button_do.Enabled = true;
                button_insert.BackColor = Color.FromArgb(227, 227, 227); 
                button_delete.BackColor = Color.LightBlue;
                button_update.BackColor = Color.FromArgb(227, 227, 227); 
                InputKeyShow();  
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataTable.Rows.Count; i++)
                dataTable.Rows[i].Delete();
            dataTable.Rows.Clear();
            Optional_table.Enabled = true;
            if (button_update.BackColor == Color.LightBlue)
            {
                button_update.BackColor = Color.FromArgb(227, 227, 227); 
                Optional_table.Enabled = false;
                button_do.Enabled = false;
                InputKeyHide();
            }
            else
            { 
                update_step = 0;
                Optional_table.DataSource = dataTable;
                button_do.Enabled = true;
                button_insert.BackColor = Color.FromArgb(227, 227, 227); 
                button_delete.BackColor = Color.FromArgb(227, 227, 227); 
                button_update.BackColor = Color.LightBlue;
               
                InputKeyShow();
            }
        }
        public void GetKeyAttrib()
        {
            DataBase db;
            MySqlCommand command;
            MySqlDataReader reader;
            string query;
            query = $"SELECT attribute.Attribute_Name, attribute.Is_Key FROM `attribute` INNER JOIN `table` ON (`attribute`.Table_ID = `table`.Table_ID) WHERE `table`.Name = \"{get_table.Text}\"";
            db = new DataBase("prime_db");
            command = new MySqlCommand(query, db.GetConnection());
            db.OpenConnection();
            reader = command.ExecuteReader();

            while (reader.Read())
                if (reader.GetValue(1).ToString() == "True")
                    attr_name = reader.GetValue(0).ToString();
            db.CloseConnection();
            reader.Close();
        }
        public string attr_name = "";
        private void Insert()
        {
            //char kavichka = '"';
            string query = $"SELECT attribute.Attribute_Name, attribute.Is_Key FROM `attribute` INNER JOIN `table` ON (`attribute`.Table_ID = `table`.Table_ID) WHERE `table`.Name = \"{get_table.Text}\"";
            DataBase db= new DataBase("prime_db");
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            attr_name = "";

            while (reader.Read())
            {
                attr_name += "`"  + reader.GetValue(0).ToString() + "`,";
            }
            attr_name = attr_name.Trim(',');
            db.CloseConnection();
            db = new DataBase(currentDB);

            try
            {

                db.OpenConnection();
                string values = "";
                string temp;
                for (int i = 0; i < Optional_table.Columns.Count; i++)
                {
                    temp = Optional_table.Rows[0].Cells[i].Value.ToString();
                    if (dataTable.Columns[i].DataType.ToString() == "System.DateTime")
                        values += $"\"{temp}\", ";
                    else
                        if (dataTable.Columns[i].DataType.ToString() == "System.String")
                        values += $"\"{temp}\", ";
                    else
                        values += temp.ToString() + ", ";
                }
                values = values.Trim();
                values = values.Trim(',');
                query = $"INSERT INTO `{get_table.Text}` ({attr_name}) VALUES ({values})";
                command = new MySqlCommand(query, db.GetConnection());

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно добавлена");
                    dataGridView.DataSource = GetTable(db, get_table.Text);
                    dataTable.Rows.Clear();
                    AddDefaultRow();
                }
                else
                {
                    MessageBox.Show("Ой! Что-то пошло не так!");
                }
                db.CloseConnection();


            }
            catch (MySqlException)
            {
                MessageBox.Show("Данное значение ключевого атрибута уже существует в таблице. Введите уникальное значение.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }


        }
        private void Update(string key_value)
        {
            GetKeyAttrib();
            DataBase db;
            MySqlCommand command;
            
            string query;
            
            if (update_step == 0)
            {
                ShowOptionalTable(key_value, "update");
                AddDefaultRow();  
            }
            else
            {
                db = new DataBase(currentDB);
                string values = "";
                string temp="";
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    temp = Optional_table[i, 1].Value.ToString();
                    if (dataTable.Columns[i].DataType.ToString() == "System.DateTime")
                        temp = $"\"{temp}\"";

                    if (dataTable.Columns[i].DataType.ToString() == "System.String")
                        temp = $"\"{temp}\"";

                        values += $"`{dataTable.Columns[i].ColumnName.Trim('*')}`={temp},";
                }
                values = values.Trim(',');
                
                query = $"UPDATE `{get_table.Text}` SET {values} WHERE {attr_name} = {key_value}";
                db.OpenConnection();
                command = new MySqlCommand(query, db.GetConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно обновлена");
                    dataTable.Rows.Clear();
                    Optional_table.DataSource = dataTable;
                    InputKeyShow();
                    update_step++;
                }
                else
                {
                    MessageBox.Show("");
                    dataTable.Rows.Clear();
                    InputKeyShow();
                }
                dataGridView.DataSource = GetTable(db, get_table.Text);
                db.CloseConnection();
            }
        }
        private void Delete(string key_value)
        {
            GetKeyAttrib();
            DataBase db;
            MySqlCommand command;
            string query;

            
            if (delete_step == 0)
            {
                ShowOptionalTable(key_value, "delete");
            }
            else
            {
                db = new DataBase(currentDB);
                query = $"DELETE FROM {get_table.Text} WHERE {attr_name} = {key_value}";
                db.OpenConnection();
                command = new MySqlCommand(query, db.GetConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    if (dataTable.Rows.Count != 0)
                        dataTable.Rows[0].Delete();
                    Optional_table.DataSource = dataTable;
                    InputKeyShow();
                }
                else
                {
                    MessageBox.Show("Запись с данными значениями отсутствует");
                    dataTable.Rows.Clear();
                    InputKeyShow();
                }
                dataGridView.DataSource = GetTable(db, get_table.Text);
                db.CloseConnection();

            }
        }


        private void AddDefaultRow()
        {
            DataRow row;
            row = dataTable.NewRow();
            for (int i = 0; i < dataTable.Columns.Count; i++)
                try { row[dataTable.Columns[i].ColumnName] = DBNull.Value.Equals(dataTable.Columns[i].DataType); }
                catch { row[dataTable.Columns[i].ColumnName] = Convert.ToDateTime("2001-06-05"); }
            dataTable.Rows.Add(row);
            Optional_table.DataSource = dataTable;
        }
        private void InputKeyShow()
        {
            label_inputKey.Show();
            textBox_inputKey.Show();
            textBox_inputKey.Text = "";
            Optional_table.DataSource = null;
        }
        private void InputKeyHide()
        {
            label_inputKey.Hide();
            textBox_inputKey.Hide();
            Optional_table.DataSource = dataTable;
        }

        #region check_checkbox

        private void checkedList_atribytes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedList_atribytes.CheckedItems.Count == 0)
                button_select.Enabled = false;
            else
                button_select.Enabled = true;
        }

        private void checkedList_atribytes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedList_atribytes.CheckedItems.Count == 0)
                button_select.Enabled = false;
            else
                button_select.Enabled = true;
        }

        private void checkedList_atribytes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkedList_atribytes.CheckedItems.Count == 0)
                button_select.Enabled = false;
            else
                button_select.Enabled = true;
        }

        #endregion

        private void textBox_inputKey_TextChanged(object sender, EventArgs e)
        {
            if (textBox_inputKey.Text.Trim(' ') == "")
                button_do.Enabled = false;
            else
                button_do.Enabled = true;
        }

        private void ShowOptionalTable(string key_value, string func)
        {
            GetKeyAttrib();
            DataBase db;
            MySqlCommand command;
            MySqlDataReader reader;
            string query;

            query = $"SELECT * FROM {get_table.Text} WHERE {attr_name} = {key_value}";
            db = new DataBase(currentDB);
            command = new MySqlCommand(query, db.GetConnection());
            db.OpenConnection();
            reader = command.ExecuteReader();

            try
            {

                DataRow row;
                row = dataTable.NewRow();
                if (reader.HasRows != false)
                {
                    while (reader.Read())
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                            row[$"{dataTable.Columns[i].ColumnName}"] = reader.GetValue(i);

                    dataTable.Rows.Add(row);
                    Optional_table.DataSource = dataTable;
                    reader.Close();
                    db.CloseConnection();
                    if (func == "delete")
                        delete_step++;
                    else
                        update_step++;
                    InputKeyHide();
                    MessageBox.Show("Выбрана следующая запись, для продолжения нажмите Далее");
                }
                else
                {
                    MessageBox.Show("Запись не найдена");
                    if (func == "delete")
                        delete_step = 0;
                    else
                        update_step = 0;
                }
             }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так!");
            }
        }

        
    }
    
}
