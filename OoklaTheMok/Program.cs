using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OoklaTheMok.Models;

namespace OoklaTheMok
{
    class Program
    {
        static void Main(string[] args)
        {
            FileGenerator generator = new FileGenerator();

            string tableName = args[0];
            generator.GenerateFiles(tableName);
        }

        
    }
}
