using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCode
{
    public class Tableclass
    {
        public string NameSpace { get; set; }
        public string Tablename { get; set; }
        public string Type { get; set; }
        public List<Column> Columns { get; set; }

    }
    public class Column
    {
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string FileDesc { get; set; }
        public short Length { get; set; }
        public int Digits { get; set; }
        public string Flag { get; set; }
        public string IsPkey { get; set; }
        public string IsNullable { get; set; }
        
    }
}
