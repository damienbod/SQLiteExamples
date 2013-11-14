using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitySqlite;
using SqlLiteTest.HelloWorld;

namespace SqlLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicCrud.Run();

            RunEntityExample.RunExample();
        }
    }
}
