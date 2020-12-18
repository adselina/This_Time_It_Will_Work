using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryMaker
{
    public class Relation
    {
        public string Table { get; set; }
        public string ReferencedTable { get; set; }
        public string Column { get; set; }
        public string ReferencedColumn { get; set; }

        public Relation(string table, string referencedTable, string column, string referencedColumn)
        {
            Table = table;
            ReferencedTable = referencedTable;
            Column = column;
            ReferencedColumn = referencedColumn;
        }

        public override string ToString()
        {
            return $"INNER JOIN {ReferencedTable} ON {Table}.{Column} = {ReferencedTable}.{ReferencedColumn}\n";
        }
    }
}
