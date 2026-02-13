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
            Double.TryParse(Console.ReadLine(), out hourlyWage);
            Console.WriteLine("Wow! You make " + hourlyWage.ToString("C") + " an hour! That's great cause I make ZERO!");



        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - Assignment (User Input)";

        }
    }
}
