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
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string family = ("Mike, Jennarae, Damon, Kaileigh  ");
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
            //foreach (char letter in phrase.ToLower())
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowels += 1;
            //    }
            //}
            //Console.WriteLine(vowels);


            //Console.WriteLine("Pick a number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many times do you want this repeated");
            //int repeat = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= repeat; i++)
            //{
            //    Console.WriteLine(number);
            //}

            ////Write a program that takes your favorite foods and prints them out one at a time.(foreach loop)
            //string[] favoriteFoods = { "General Tso's", "Steak", "Pizza", "Burgers" };
            //foreach (string food in favoriteFoods)
            //{

            //    Console.WriteLine(food);
            //}

            ////Create an array of lucky number.Using foreach loop print the following
            ////          Your Lucky Number is: 3

            //Console.WriteLine("Find out your lucky numbers! Hit enter!");
            //Console.ReadLine();
            //int[] luckyNumbers = { 5, 12, 21, 9, 35 };
            //foreach (int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: {0}", number);
            //}



            ///*
            // * Ask the user if they would like to check the patient in for their appointment
            // * Using while loop run the following if the users answer is not yes
            // * Print "PATIENT CHECK IN SYSTEM
            // * Ask the iser for the clients full name
            // * clients 6 digit patient ID
            // * clients appointment time
            // * Ask the user if they would like to check the patient in*/ 
            //Console.WriteLine("Are you ready to check in for your appointment?");
            //string readyCheck = Console.ReadLine().ToLower();

            //while (readyCheck == "yes")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter your full name.");
            //    string patientsName = Console.ReadLine();
            //    Console.WriteLine("Please enter your 6 digit patient ID#.");
            //    int patientsIDNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter you appointment time.");
            //    int patientsTime = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Thank you for checking in!");
            //    Console.WriteLine("Are you ready to check in for your appointment?");
            //    readyCheck = Console.ReadLine().ToLower();
            //}




            ////Print a multiplication table using nested loops

            //for (int rows = 1; rows <= 5; rows++)
            //{
            //    for (int Columns = 1; Columns <= rows; Columns++)
            //    {
            //        Console.Write(Columns);
            //    }
            //    Console.WriteLine();
            //}




            //Create an array of your favorite movies, print out each movie unless the movie starts with a vowel Hint research .startsWith()

            string[] favoriteMovies = { "Anchorman", "BraveHeart", "Shawshank Redemtion", "The Jerk" };
          

            // Write a console app that asks the user for an integer if disible by 3 then write you won if not you lost keep asking until they win




        }
    }
}
