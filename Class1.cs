using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MDB1");
            MyDatabase mdb1 = new MyDatabase();
            mdb1.ShowCustomer();
            Console.WriteLine("MDB2");
            MyDatabase mdb2 = new MyDatabase(101, "Thai", "RT 106");
            mdb2.ShowCustomer();
        }
    }
}