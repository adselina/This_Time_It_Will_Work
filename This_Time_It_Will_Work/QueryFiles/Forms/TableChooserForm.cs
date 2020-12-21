using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace QueryMaker
{
    public partial class TableChooserForm : Form
    {
        string DataBaseName { get; set; }

        string Connection { 
            get
            {
                return $"server=localhost;user=root;database={DataBaseName};port=3306;password=root";
            }
        }

        List<string> mainConnectedColumns = new List<string>();
        List<string> joinConnectedColumns = new List<string>();
        List<Column> columns = new List<Column>();
        List<Relation> relations = new List<Relation>();

        public TableChooserForm()
        {
            InitializeComponent();
            DataBaseName = "user_db";
        }

        public TableChooserForm(string dbname)
        {
            InitializeComponent();
            DataBaseName = dbname;
        }

        private void TableChooserForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Connection);

            try
            {
                conn.Open();

                string sql = "SHOW TABLES;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TablesComboBox.Items.Add(rdr[0]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablesComboBox.SelectedItem != null)
            {
                AllConnectedTablesListBox.Items.Clear();
                ChosenConnectedTablesListBox.Items.Clear();
                AllColumnsListBox.Items.Clear();

                FillAllConnectedTablesListBox();
                FillAllColumnsListBox();

                ConnectedTablesGroupBox.Enabled = true;
                ColumnsGroupBox.Enabled = true;
                GoButton.Enabled = true;

                SetConnectedTablesModules();
                SetColumnModules();

            }
        }

        public void SetConnectedTablesModules()
        {
            if (AllConnectedTablesListBox.Items.Count > 0)
            {
                if (AllConnectedTablesListBox.SelectedItem == null)
                    AllConnectedTablesListBox.SelectedIndex = 0;

                ShiftTableToRightButton.Enabled = true;
            }
            else
            {
                ShiftTableToRightButton.Enabled = false;
            }

            if (ChosenConnectedTablesListBox.Items.Count > 0)
            {
                if (ChosenConnectedTablesListBox.SelectedItem == null)
                    ChosenConnectedTablesListBox.SelectedIndex = 0;
                ShiftTableToLeftButton.Enabled = true;
            } 
            else
            {
                ShiftTableToLeftButton.Enabled = false;
            }
        }

        public void SetColumnModules()
        {
            if (AllColumnsListBox.Items.Count > 0)
            {
                if (AllColumnsListBox.SelectedItem == null)
                    AllColumnsListBox.SelectedIndex = 0;

                ShiftColumnToRightButton.Enabled = true;
            }
            else
            {
                ShiftColumnToRightButton.Enabled = false;
            }
            if (ChosenColumnsListBox.Items.Count > 0)
            {
                if (ChosenColumnsListBox.SelectedItem == null)
                    ChosenColumnsListBox.SelectedIndex = 0;

                ShiftColumnToLeftbutton.Enabled = true;
            }
            else
            {
                ShiftColumnToLeftbutton.Enabled = false;
            }
        }

        private void ShiftToRightButton_Click(object sender, EventArgs e)
        {
            string item = AllConnectedTablesListBox.SelectedItem.ToString();
            ChosenConnectedTablesListBox.Items.Add(item);
            AllConnectedTablesListBox.Items.Remove(item);
            FillAllColumnsListBox();
        }

        private void ShiftToLeftButton_Click(object sender, EventArgs e)
        {
            string item = ChosenConnectedTablesListBox.SelectedItem.ToString();
            AllConnectedTablesListBox.Items.Add(item);
            ChosenConnectedTablesListBox.Items.Remove(item);
            FillAllColumnsListBox();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string mainTable = TablesComboBox.SelectedItem.ToString();

            List<string> shownColumns = new List<string>();
            foreach (var item in ChosenColumnsListBox.Items)
            {
                shownColumns.Add(item.ToString());
            }

            ColumnConditionsForm conditionsForm = new ColumnConditionsForm(DataBaseName, columns, relations, shownColumns, mainTable);
            conditionsForm.ShowDialog();
        }

        public void FillAllConnectedTablesListBox()
        {
            AllColumnsListBox.Items.Clear();
            mainConnectedColumns.Clear();
            joinConnectedColumns.Clear();
            relations.Clear();

            MySqlConnection conn = new MySqlConnection(Connection);

            try
            {
                conn.Open();

                string table = TablesComboBox.SelectedItem.ToString();
                string sql = "SELECT `REFERENCED_TABLE_NAME`, `COLUMN_NAME`, `REFERENCED_COLUMN_NAME` " +
                             "FROM `INFORMATION_SCHEMA`.`KEY_COLUMN_USAGE` " +
                             $"WHERE `REFERENCED_TABLE_NAME` IS NOT NULL AND `TABLE_SCHEMA` = '{DataBaseName}' AND `TABLE_NAME`=@table;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@table", table);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    AllConnectedTablesListBox.Items.Add(rdr[0]);
                    relations.Add(new Relation(table, rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString()));
                    mainConnectedColumns.Add(rdr[1].ToString());
                    joinConnectedColumns.Add(rdr[2].ToString());
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        public void FillAllColumnsListBox()
        {
            AllColumnsListBox.Items.Clear();
            ChosenColumnsListBox.Items.Clear();
            columns.Clear();

            List<string> tableNames = new List<string>();
            tableNames.Add(TablesComboBox.SelectedItem.ToString());
            foreach (var table in ChosenConnectedTablesListBox.Items)
            {
                tableNames.Add(table.ToString());
            }

            MySqlConnection conn = new MySqlConnection(Connection);

            try
            {
                conn.Open();

                string sql = $"SELECT `COLUMN_NAME`, `DATA_TYPE` FROM `INFORMATION_SCHEMA`.`COLUMNS`" +
                             $" WHERE `TABLE_SCHEMA` = '{DataBaseName}' AND `TABLE_NAME`=@table;";
                MySqlCommand cmd;
                MySqlDataReader rdr;
                foreach (string table in tableNames)
                {
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@table", table);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        columns.Add(new Column(rdr[0].ToString(), table, rdr[1].ToString()));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            foreach (Column column in columns)
            {
                AllColumnsListBox.Items.Add(column.FullName);
            }
        }

        private void ShiftColumnToRightButton_Click(object sender, EventArgs e)
        {
            string item = AllColumnsListBox.SelectedItem.ToString();
            ChosenColumnsListBox.Items.Add(item);
            AllColumnsListBox.Items.Remove(item);
        }

        private void ShiftColumnToLeftbutton_Click(object sender, EventArgs e)
        {
            string item = ChosenColumnsListBox.SelectedItem.ToString();
            AllColumnsListBox.Items.Add(item);
            ChosenColumnsListBox.Items.Remove(item);
        }

        private void AllConnectedTablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConnectedTablesModules();
        }

        private void ChosenConnectedTablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConnectedTablesModules();
        }

        private void AllColumnsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnModules();
        }

        private void ChosenColumnsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColumnModules();
        }
    }
}
