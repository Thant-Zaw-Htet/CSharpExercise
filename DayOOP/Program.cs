using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            pet.Type = "cat";
            pet.Color = "Yellow";


            Console.WriteLine(pet.Type);
            Console.WriteLine(pet.Color);
            pet.characteristic(10);
            pet.characteristic(10, "male");
            pet.makeSound();


            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// 9
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
        

    }


    public class Animal
    {
        public string Type;
        public string Color;

        public void makeSound()
        {
            Console.WriteLine("Anime make sound");
        }
    }

    public class Pet : Animal { 
    
        public void makeSound() //method overriding
        {
            Console.WriteLine("Meow Meow");
        }

        public void characteristic(int age)// method overloading
        {
            Console.WriteLine($"this is {age} years old");
        }

        public void characteristic(int age, string gender)
        {
            Console.WriteLine($"this is {age} years old and this is {gender}");
        }

    }


    public interface Drive
    {
        void Drive();
    }

    public class car : Drive
    {
        public void Drive() 
        {
            Console.WriteLine("The car is drivinf");
        }

    }

}
