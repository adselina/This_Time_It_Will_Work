using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QueryMaker.Classes;

namespace QueryMaker
{
    public partial class ColumnConditionsForm : Form
    {
        string[] varcharOperators = { "=", "!=", "IS NULL", "IS NOT NULL"};
        string[] _operators = { "=", "!=", ">", "<", ">=", "<=", "IS NULL", "IS NOT NULL" };
        
        List<Condition> conditions = new List<Condition>();

        List<string> ShownColumns { get; set; }
        List<Column> Columns { get; set; }
        List<Relation> Relations { get; set; }
        string Table { get; set; }
        string DataBaseName { get; set; }

        public ColumnConditionsForm(string dataBaseName, List<Column> columns, List<Relation> relations, List<string> shownColumns, string table)
        {
            InitializeComponent();
            DataBaseName = dataBaseName;
            Columns = new List<Column>(columns);
            Relations = new List<Relation>(relations);
            ShownColumns = new List<string>(shownColumns);
            Table = table;
        }

        private void ColumnConditionsForm_Load(object sender, EventArgs e)
        {
            foreach (Column column in Columns)
            {
                ColumnsComboBox.Items.Add($"{column.Table}.{column.Name}");
            }
        }

        private void ColumnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColumnsComboBox.SelectedItem != null)
            {
                SetConditionModules();

                SetOperators(GetColumnType());
                SwitchTextBoxes(IsDate(GetColumnType()));
            }
        }

        public void SetConditionModules()
        {
            if (ColumnsComboBox.SelectedItem == null)
            {
                OperatorsComboBox.Enabled = false;
                ValueTextBox.Enabled = false;
            }
            else
            {
                OperatorsComboBox.Enabled = true;
                ValueTextBox.Enabled = true;
            }
            AddConditionButton.Enabled = false;
        }

        public void DisableConditionModules()
        {
            OperatorsComboBox.Items.Clear();
            ValueTextBox.Clear();
            DateValueMaskedTextBox.Clear();
            OperatorsComboBox.Enabled = false;
            ValueTextBox.Enabled = false;
            DateValueMaskedTextBox.Enabled = false;
            AddConditionButton.Enabled = false;
            ColumnsComboBox.SelectedIndex = -1;
        }

        public void SwitchTextBoxes(bool isDate)
        {
            if (isDate)
            {
                DateValueMaskedTextBox.Clear();
                ValueTextBox.Clear();
                DateValueMaskedTextBox.Enabled = true;
                DateValueMaskedTextBox.Visible = true;
                ValueTextBox.Enabled = false;
                ValueTextBox.Visible = false;

            } else
            {
                DateValueMaskedTextBox.Clear();
                ValueTextBox.Clear();
                DateValueMaskedTextBox.Enabled = false;
                DateValueMaskedTextBox.Visible = false;
                ValueTextBox.Enabled = true;
                ValueTextBox.Visible = true;
            }
        }

        public void SetOperators(string columnType)
        {
            OperatorsComboBox.Items.Clear();
            if (columnType == "varchar")
            {
                OperatorsComboBox.Items.AddRange(varcharOperators);
            } else {
                OperatorsComboBox.Items.AddRange(_operators);
            }
        }

        private void OperatorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OperatorsComboBox.SelectedItem != null)
                AddConditionButton.Enabled = true;

            string op = OperatorsComboBox.SelectedItem.ToString();
            if (op == "IS NULL" || op == "IS NOT NULL")
            {
                DateValueMaskedTextBox.Clear();
                ValueTextBox.Clear();
                DateValueMaskedTextBox.Enabled = false;
                ValueTextBox.Enabled = false;
            } else
            {
                SwitchTextBoxes(IsDate(GetColumnType()));
            }
        }

        public bool IsDate(string columnType)
        {

            return columnType == "date" || columnType == "datetime";
        }

        public string GetColumnType()
        {
            Column selectedColumn = GetColumn();
            return selectedColumn.Type;
        }

        public Column GetColumn()
        {
            string fullName = ColumnsComboBox.SelectedItem.ToString();
            List<Column> buf = new List<Column>(Columns.Where(c => c.FullName == fullName));
            Column selectedColumn = buf[0];

            return selectedColumn;
        }

        public Condition GetCondition()
        {
            string toString = ConditionsListBox.SelectedItem.ToString();
            List<Condition> buf = new List<Condition>(conditions.Where(c => c.ToString() == toString));
            Condition selectedCondition = buf[0];

            return selectedCondition;
        }

        public string GetValue()
        {
            string value = "";
            string op = OperatorsComboBox.SelectedItem.ToString();
            if (op != "IS NULL" && op != "IS NOT NULL")
            {
                if (IsDate(GetColumnType()))
                {
                    value = DateValueMaskedTextBox.Text;
                }
                else
                {
                    value = ValueTextBox.Text;
                }
            }

            return value.Trim();
        }

        public string GetOperator()
        {
            return OperatorsComboBox.SelectedItem.ToString();
        }

        public bool IsParsing(string value)
        {
            string columnType = GetColumnType();
            string op = OperatorsComboBox.Text;
            if (op == "IS NULL" || op == "IS NOT NULL") return true;
            if (value == "") return false;
            if (columnType == "varchar") return true;
            if (IsDate(columnType))
            {
                return DateTime.TryParseExact(value, "yyyy.MM.dd",
                                              CultureInfo.InvariantCulture,
                                              DateTimeStyles.None, out DateTime date);
            }
            return int.TryParse(value, out int num);
        }

        private void AddConditionButton_Click(object sender, EventArgs e)
        {
            if (IsParsing(GetValue()))
            {
                Condition condition = new Condition(GetColumn(), GetOperator(), GetValue());
                ConditionsListBox.Items.Add(condition.ToString());
                conditions.Add(condition);
                ConditionsListBox.SelectedIndex = 0;
                DisableConditionModules();
            } else
            {
                ValueTextBox.Clear();
                DateValueMaskedTextBox.Clear();
                MessageBox.Show("Not Parsed!");
            }
        }

        private void DeleteConditionButton_Click(object sender, EventArgs e)
        {
            conditions.Remove(GetCondition());
            ConditionsListBox.Items.Remove(ConditionsListBox.SelectedItem);

        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            JoinQueryResultForm queryResultForm = new JoinQueryResultForm(DataBaseName, Table, ShownColumns, Relations, conditions);
            queryResultForm.ShowDialog();
        }

        private void ConditionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConditionsListBox.Items.Count > 0)
            {
                if (ConditionsListBox.SelectedItem == null)
                    ConditionsListBox.SelectedIndex = 0;
                DeleteConditionButton.Enabled = true;
            } 
            else
            {
                DeleteConditionButton.Enabled = false;
            }
        }
    }
}
