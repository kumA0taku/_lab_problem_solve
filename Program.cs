using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace salt_gacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.Write("Please input number : ");
                string num_ber = Console.ReadLine();
                Hashtable employees = new Hashtable();

                employees.Add("123", "Venti");
                employees.Add("438", "Sayu");
                employees.Add("469", "Eula");
                employees.Add("583", "Yae Miko");
                employees.Add("623", "Ei");
                employees.Add("786", "Kaedehara Kazuha");
                employees.Add("862", "Fischl");
                employees.Add("873", "Ganyu");
                employees.Add("945", "Jean");

                if (employees.ContainsKey(num_ber))
                {
                    string empName = (string)employees[num_ber];
                    Console.WriteLine("You got " + "{0}!! \n", empName);
                }
                else
                    Console.WriteLine("Bad luck, You got Qiqi again.. \n");
            }
        }
    }
}
