using System;

namespace Topic_4___Assignment__User_Input_
{
    internal class Program
    {
        // Angel 
        public static void Part1()
        {
            string name;
            int age;
            double hourlyWage;

            Console.Title = "Topic 4 - Assignment (User Input)";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your name? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Nice to meet you!");

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your age? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Damn! You are " + age + " years old! That's ancient!");

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("So since you are so old, you must have a job! How much do you make hourly? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Double.TryParse(Console.ReadLine(), out hourlyWage);
            Console.WriteLine("Wow! You make " + hourlyWage.ToString("C") + " an hour! That's great cause I make ZERO!");
        }

        public static void Part2()
        {
            string firstName, lastName, username;
            int grade, idNum;
            double grAverage;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("First name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            firstName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Last name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            lastName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Grade (9-12): ");
            Console.ForegroundColor = ConsoleColor.Red;
            grade = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Student ID: ");
            Console.ForegroundColor = ConsoleColor.Red;
            idNum = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Login: ");
            Console.ForegroundColor = ConsoleColor.Red;
            username = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Average: ");
            Console.ForegroundColor = ConsoleColor.Red;
            grAverage = Convert.ToDouble(Console.ReadLine());

            // Output 

            Console.WriteLine(" ");
            Console.WriteLine("Your information: \n\tLogin:\t\t" + username + "\n\tID:\t\t" + idNum + "\n\tName:\t\t" + lastName + ", " + firstName + "\n\tAverage:\th" + grAverage + "\n\tGrade:\t\t" + grade);


        }

        public static void Part3()
        {
            string name;
            int age, fiveAhead, fiveBehind;

            Console.Title = "Topic 4 - Assignment (User Input)";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hello! What is your name? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hi, " + name + "! How old are you? \nEnter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            fiveAhead = age + 5;
            fiveBehind = age - 5;
            Console.Write("Did you know that in five year you will be " + fiveAhead + " years old? And five years you were " + fiveBehind + "? Imagine that!");
            Console.WriteLine(" ");
        }

        public static void Part4()
        { 
            string firstNum, secondNum, thirdNum;   

            Console.Title = "Topic 4 - Assignment (User Input)";    
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey there! Give me three numbers.");
   
            Console.Write("First number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            firstNum = Console.ReadLine();

            if (int.TryParse(firstNum, out int))

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Second number: ");   
            Console.ForegroundColor = ConsoleColor.Red; 

            Console.ForegroundColor = ConsoleColor.Green;   
            Console.Write("Third number: ");
            Console.ForegroundColor = ConsoleColor.Red;


        }

        static void Main(string[] args)
        {
            
    }
    }
}
