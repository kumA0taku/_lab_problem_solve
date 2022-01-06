using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTest
{
    class Program
    {
        private static int id;
        private static string name;
        static void Main(string[] args)
        {
            ShowData(101, "Miss Thailand", "5 Thai Rd.");
            changeID();
            changeNAME("5 Thai Rd.");
        }
        public static void ShowData(int id, string name, string address)
        {
            Console.WriteLine("Customer ID is {0}", id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }
        public static void changeID()
        {
            Console.Write("Please Enter new Customer ID: ");
            id = int.Parse(Console.ReadLine());
        }
        public static void changeNAME(string address)
        {
            Console.Write("Please Enter new Customer Name: ");
            name = Console.ReadLine();
            Console.WriteLine("New Customer ID is {0}", id);
            Console.WriteLine("New Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }
    }
}
