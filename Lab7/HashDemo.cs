using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HashDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();

            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            if (employees.ContainsKey("333-44-55555"))
            {
                string empName = (string)employees["333-44-55555"];
                //string empName = (string)employees["333-44-55555"];
                //Console.WriteLine("Employee 111-22-3333's name is:  {0}", empName);
                Console.WriteLine("Employee 333-44-55555's name is:  {0}", empName);
            }
            else
                Console.WriteLine("Employee 111-22-3333 is not in the  hash table...");
            Console.ReadLine();
        }
    }
}
