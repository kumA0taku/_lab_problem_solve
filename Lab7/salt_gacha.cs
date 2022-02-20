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
                Hashtable store_char = new Hashtable();

                store_char.Add("123", "Venti");
                store_char.Add("438", "Sayu");
                store_char.Add("469", "Eula");
                store_char.Add("583", "Yae Miko");
                store_char.Add("623", "Ei");
                store_char.Add("786", "Kaedehara Kazuha");
                store_char.Add("862", "Fischl");
                store_char.Add("873", "Ganyu");
                store_char.Add("945", "Jean");

                if (store_char.ContainsKey(num_ber))
                {
                    string num_char = (string)store_char[num_ber];
                    Console.WriteLine("You got " + "{0}!! \n", num_char);
                    //string name_char = (string)store_char[num_ber];
                    //Console.WriteLine("You got " + "{0}!! \n", name_char);
                }
                else
                    Console.WriteLine("Bad luck, You got Qiqi again.. \n");
            }
        }
    }
}
