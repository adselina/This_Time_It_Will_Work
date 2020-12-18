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
using QueryMaker.Classes;

namespace QueryMaker
{
    public partial class JoinQueryResultForm : Form
    {
        string DataBaseName { get; set; }
        string Connection
        {
            get
            {
                return $"server=localhost;user=root;database={DataBaseName};port=3306;password=root";
            }
        }
        public string MainTable { get; set; }
        public List<string> ShownColumns { get; set; }
        public List<Relation> Relations { get; set; }
        public List<Condition> Conditions { get; set; }

        MySqlDataAdapter adapter;
        DataSet set;

        public JoinQueryResultForm(string dataBaseName, string mainTable, List<string> shownColumns, List<Relation> relations, List<Condition> conditions)
        {
            InitializeComponent();
            DataBaseName = dataBaseName;
            MainTable = mainTable;
            ShownColumns = new List<string>(shownColumns);
            Relations = new List<Relation>(relations);
            Conditions = new List<Condition>(conditions);
        }

        private void JoinQueryResultForm_Load(object sender, EventArgs e)
        {
            string cols = "";
            if (ShownColumns.Count == 0)
            {
                cols = "*";
            } else
            {
                cols += $"{ShownColumns[0]} AS {ShownColumns[0].Replace('.', '_')}";
                for (int i = 1; i < ShownColumns.Count; i++)
                {
                    cols += $", {ShownColumns[i]} AS {ShownColumns[i].Replace('.', '_')}";
                }
            }

            string joins = "";
            if (Relations.Count > 0)
            {
                foreach (Relation rel in Relations)
                {
                    joins += rel.ToString();
                }
            }

            string conds = "";
            if (Conditions.Count > 0)
            {
                conds = $"WHERE {Conditions[0]} ";
                for (int i = 1; i < Conditions.Count; i++)
                {
                    conds += $"\nAND {Conditions[i]} ";
                }
                
            }

            MySqlConnection conn = new MySqlConnection(Connection);
            try
            {
                string sql = $"SELECT {cols} FROM {MainTable} {joins} {conds}";

                adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                set = new DataSet();
                adapter.Fill(set, MainTable);
                ResultDataGridView.DataSource = set;
                ResultDataGridView.DataMember = MainTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
