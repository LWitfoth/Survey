using System;

namespace helloword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //example user input

            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("How old are you");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var DOB = TryAnswer();

            Console.WriteLine("Your Name is: {0} ", name);
            Console.WriteLine("You are {0} years old", age);
            Console.WriteLine("Your birth month is {0}", DOB);

            //example if statement
            if (DOB == "March")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (DOB == "April")
            {
                Console.WriteLine("You are an April");
            }
            else if (DOB == "May")
            {
                Console.WriteLine("You are an Gemini");
            }

            //example of loop and if
            var passcode = "";

            //while loop
            while (passcode != "secret")
            {
                Console.WriteLine("What is the passcode?");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.WriteLine("You are not Authenticated");
                }
                Console.WriteLine("You are Authenticated");
            }

            for (int a = 0; a <= 5; a++)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 1; i >= 10; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //example of a function that takes in values
        private static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't enter anything, try again");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}