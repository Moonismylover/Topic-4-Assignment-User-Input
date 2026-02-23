using System;
using System.Numerics;

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

            Console.Title = "Part 1 ~ Conversation";

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

            Console.Title = "Part 2 ~ Student Information";

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
            Console.WriteLine("\tYour information: \n\n\tLogin:\t\t" + username + "\n\tID:\t\t" + idNum + "\n\tName:\t\t" + lastName + ", " + firstName + "\n\tAverage:\t" + grAverage + "\n\tGrade:\t\t" + grade);


        }

        public static void Part3()
        {
            string name;
            int age, fiveAhead, fiveBehind;

            Console.Title = "Part 3 ~ Age Math";

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
            double firstNum, secondNum, thirdNum, ans;   

            Console.Title = "Part 4 ~ Math Calculator";    

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey there! Give me three numbers.");
   
            Console.Write("First number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Second number: ");   
            Console.ForegroundColor = ConsoleColor.Red; 
            secondNum = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;   
            Console.Write("Third number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            thirdNum = Convert.ToDouble(Console.ReadLine());

            ans = (firstNum + secondNum + thirdNum) / 2;

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Did you know if you take the sum of {firstNum}, {secondNum}, and {thirdNum}, and then divide it by 2, the answer would be {ans}!?"); 
        }

        public static void Part5()
        {
            string item1, item2;
            double price1, price2, total, discount, alteredTotal, taxAmount, finalPrice;

            Console.Title = "Part 5 ~ Shopping";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey there! Welcome to the SUPERNOVA store!");
            Console.WriteLine("Please enter the name and price of your items!");
            Console.WriteLine(" ");

            Console.Write("Item 1 name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            item1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(item1 + " price: ");
            Console.ForegroundColor = ConsoleColor.Red;
            price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Item 2 name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            item2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(item2 + " price: ");
            Console.ForegroundColor = ConsoleColor.Red;
            price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            total = price1 + price2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congrats! You get a special discount of 20%!");
            Console.WriteLine(" ");

            discount = total * 0.2;
            alteredTotal = total - discount;
            taxAmount = alteredTotal * 0.13;
            finalPrice = alteredTotal + taxAmount;

            Console.WriteLine("\tSales Receipt");
            Console.WriteLine(" ");
            Console.WriteLine("\tItem 1: " + item1 + "\n\tPrice: " + price1.ToString("C"));
            Console.WriteLine("\tItem 2: " + item2 + "\n\tPrice: " + price2.ToString("C"));
            Console.WriteLine("\t===========================");
            Console.WriteLine("\tTotal: " + total.ToString("C"));
            Console.WriteLine("\tDiscount (20%): " + discount.ToString("C"));
            Console.WriteLine("\tSubtotal: " + alteredTotal.ToString("C"));
            Console.WriteLine("\tTax (13%): " + taxAmount.ToString("C"));
            Console.WriteLine("\t===========================");
            Console.WriteLine("\tTotal Owned: " + finalPrice.ToString("C"));

        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - Assignment (User Input)";    

            Part1();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n------------------------------\n");

            Part2();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n------------------------------\n");

            Part3();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n------------------------------\n");

            Part4();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n------------------------------\n");

            Part5();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n------------------------------\n");
        }
    }
}
