using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryMaker
{
    public class Column
    {
        public string Name { get; set; }
        public string Table { get; set; }
        public string Type { get; set; }

        public string FullName
        {
            get
            {
                return $"{Table}.{Name}";
            }
        }

        public Column(string name, string table, string type)
        {
            Name = name;
            Table = table;
            Type = type;
        }
    }
}
