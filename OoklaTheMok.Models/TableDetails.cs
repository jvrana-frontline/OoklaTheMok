using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoklaTheMok.Models
{
    public class TableDetails
    {
        public string TableName { get; set; }

        private List<FieldDetails> _fields;

        public List<FieldDetails> Fields
        {
            get
            {
                if (_fields == null)
                {
                    _fields = new List<FieldDetails>();
                }
                return _fields;
            }
            set { _fields = value; }
        }

        public string ClassName
        {
            get
            {
                string str = TableName.Remove(0,4);
                if (str.EndsWith("s"))
                {
                    str = str.TrimEnd('s');
                }
                return str;
            }
           
        }

        public void UpdateIdField()
        {
            foreach (var f in Fields)
            {
                if (f.ModifiedFieldName.ToUpper() == ClassName.ToUpper() + "ID")
                {
                    f.ModifiedFieldName = "Id";
                }
            }
        }
    }
}
