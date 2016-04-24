using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCode
{
    public static class DataTypeMapping
    {
        private static Dictionary<string, string> _dataMapping { get; set; }
        public static Dictionary<string, string> DataMapping {
            get
            {
                if (_dataMapping==null)
                {
                    _dataMapping = new Dictionary<string, string>();
                    _dataMapping.Add("int", "int");
                    _dataMapping.Add("smallint", "Int16");
                    _dataMapping.Add("binint", "Int64");
                    _dataMapping.Add("char", "string");
                    _dataMapping.Add("nchar", "string");
                    _dataMapping.Add("varchar", "string");
                    _dataMapping.Add("nvarchar", "string");
                    _dataMapping.Add("bit", "bool");
                    _dataMapping.Add("datetime", "DateTime");
                    _dataMapping.Add("date", "DateTime");
                    _dataMapping.Add("decimal", "decimal");
                    _dataMapping.Add("money", "decimal");
                    _dataMapping.Add("numeric", "decimal");
                    _dataMapping.Add("float", "float");
                }
                
                return _dataMapping;
            }

        }
    }
}
