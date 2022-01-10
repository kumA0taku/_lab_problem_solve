using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {

        //main
        static void Main(string[] args)
        {
            Console.Write("Say Hi \t\n"); // "\t" = tab , "n" = new row
            Animal animal = new Animal();
            animal.AnimalType = "owl";
            animal.Color = "rainbow";
            animal.Weight = 180;
            animal._show_data();

            Pet pet = new Pet();
            pet.AnimalType = "cat";
            pet.Color = "pink";
            pet.Weight = 2.3;
            pet.Nickname = "Chacoll";
            pet._show_data();
        }
        //main

        public class Animal
        {
            public string AnimalType, Color;
            public double Weight;

            virtual public void _show_data()
            {
                Console.WriteLine("Type : {0} Color : {1} Weiht : {2}", AnimalType, Color, Weight);
            }
        }
        public class Pet : Animal
        {
            public string Nickname;

            override

            public void _show_data()
            {
                Console.WriteLine("Type : {0} Color : {1} Weight : {2} Nickname : {3}", AnimalType, Color, Weight, Nickname);
            }
        }
    }
}
