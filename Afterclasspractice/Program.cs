using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterclasspractice
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Write Hello World ten times
            //for (int i = 0; i <10; i++) 
            //{
            //    Console.WriteLine("Hello World");
            //}

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string family = ( "Mike, Jennarae, Damon, Kaileigh  ");
            ////for (int i = 0; i < family.Length; i++)
            ////{
            ////    Console.Write(family[i]);
            ////}

            //foreach (char word in family)
            //{
            //    Console.WriteLine(family);
            //}

            //Console.WriteLine("Please enter a word or phrase");
            //string phrase = Console.ReadLine();
            //int vowels = 0;
            //foreach(char letter in phrase.ToLower())
            //{
            //    if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowels += 1;
            //    }
            //}
            //Console.WriteLine(vowels);


            Console.WriteLine("Pick a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you want this repeated");
            int repeat = int.Parse(Console.ReadLine());

            for(int i =1; i<=repeat; i++)
            {
                Console.WriteLine(number);
            }









        }
    }
}
