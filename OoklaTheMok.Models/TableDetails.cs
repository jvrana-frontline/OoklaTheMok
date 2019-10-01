using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Globalization;
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
                string str;

                CultureInfo ci = new CultureInfo("en-us");
                PluralizationService ps = PluralizationService.CreateService(ci);

               

                if (TableName.StartsWith("tbl_"))
                    str = TableName.Remove(0, 4);
                else
                {
                    str = TableName;
                }

                if (ps.IsPlural(str))
                {
                    str = ps.Singularize(str);
                }
                return str;
            }

        }

        public string ClassNameLower
        {
            get
            {
                var str = ClassName.ToLower();
                return str;
            }
        }

        public string ClassNamePlural
        {
            get
            {
                CultureInfo ci = new CultureInfo("en-us");
                PluralizationService ps =PluralizationService.CreateService(ci);

                return ps.Pluralize(ClassName);
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
