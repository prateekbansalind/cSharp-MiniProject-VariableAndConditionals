using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //plan and build a Console application that asks a user for their name and their age.
            //if their name is Prateek or Ram, address them as a professor.
            //if the person is under 21, recommend that they wait x years to start this class.


            // Version 1  

            //Console.Write("Enter your first name: ");
            //string firstName = Console.ReadLine();

            //Console.Write("Enter you age: ");
            //string ageText = Console.ReadLine();

            //bool isValidAge = int.TryParse(ageText, out int age);

            //if ((firstName.ToLower() == "prateek" || firstName.ToLower() == "ram") && (age >= 21))
            //{
            //    Console.WriteLine($"Hello Professor {firstName}, Welcome to the class.");
            //}
            //else if ((firstName.ToLower() == "prateek" || firstName.ToLower() == "ram") && (age < 21))
            //{
            //    Console.WriteLine($"Hello Professor {firstName}, you have to wait for {21 - age} years to take the class.");
            //}
            //else if (age >= 21)
            //{
            //    Console.WriteLine($"Hello {firstName}, Welcome to the class.");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello {firstName}, you have to wait for {21 - age} to take this class.");
            //}


            //version 2

            Console.Write("Enter you first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);


            //what's this below line does it that if the user inputs the incorrect format of age means in the string format, not in numbers, the Console will prompt the message that it's not a valid format. The "return" keyword in the loop will close out the program directly without going down to the below remaining code and Console.Readline() will pause the screen to make the user read the prompt message carefully before trying it again.. 
            if (isValidAge == false)
            {
                Console.WriteLine("That's the not the valid format.");
                Console.WriteLine("Please enter the age in whole number.");
                Console.ReadLine();
                return;
            }
            

            string formattedName = "";

            if (firstName.ToLower() == "prateek" || firstName.ToLower() == "ram")
            {
                 formattedName = $"Professor {firstName}"; 
            }
            else
            {
                 formattedName = $"{firstName}";
            }

            if (age >= 21)
            {
                Console.WriteLine($"{formattedName}, Welcome to the class.");
            }
            else
            {
                int timeToWait = 21 - age;
                Console.WriteLine($"{formattedName}, I recommend you should wait for {timeToWait} years to take a class.");
            }



            Console.ReadLine();
        }
    }
}