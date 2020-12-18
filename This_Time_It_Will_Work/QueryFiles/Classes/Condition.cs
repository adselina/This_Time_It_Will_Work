using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryMaker.Classes
{
    public class Condition
    {
        public Column Column { get; set; }

        public string Operator { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            if (Column.Type == "date" || Column.Type == "datetime")
            {
                return $"{Column.FullName} {Operator} \'{Value}\'";
            }
            return $"{Column.FullName} {Operator} {Value}";
        }

        public Condition(Column column, string _operator, string value)
        {
            Column = column;
            Operator = _operator;
            Value = value;
        }

    }
}
