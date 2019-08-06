using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoklaTheMok.Models
{
    public class FieldDetails
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int FieldLength { get; set; }
        public bool Nullable { get; set; }
        public bool IsKey { get; set; }
        public string ModifiedFieldName { get; set; }
        public string ModifiedFieldType { get; set; }

        public string NullText
        {
            get
            {
                if (Nullable)
                {
                    return "Null";
                }
                else
                {
                    return "NotNull";
                }
            }

        }
        public void ConvertField()
        {
            ModifiedFieldName = GetFieldName(FieldName);
            string prefix = GetFieldPrefix(FieldName);

            switch (prefix)
            {
                case "var":
                case "chr":
                    ModifiedFieldType = "string";
                    break;
                case "int":
                    ModifiedFieldType = "int";
                    break;
                case "rl":
                    ModifiedFieldType = "float";
                    break;
                case "dt":
                    ModifiedFieldType = "DateTime";
                    if (Nullable)
                    {
                        ModifiedFieldType += "?";
                    }
                    break;
                case "bit":
                    ModifiedFieldType = "bool";
                    break;
                 default:
                     ModifiedFieldType = prefix;
                    break;
            }
           
        }

        public string GetFieldPrefix(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                int charLocation = str.IndexOf("_", StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return str.Substring(0, charLocation);
                }
            }
            return String.Empty;
        }

        public string GetFieldName(string str)
        {
            string prefix = GetFieldPrefix(str);
            return str.Remove(0,$"{prefix}_".Length);
        }
    }
}
