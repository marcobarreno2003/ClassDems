using System;

namespace npcnames
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter the name of the food");
            Console.ForegroundColor = ConsoleColor.White;
            string FoodName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter the calories of the food");
            Console.ForegroundColor = ConsoleColor.White;
            int Calories = Convert.ToInt32(Console.ReadLine());
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string [] Names = new string [] {"breakfast", "lunch","dinner"};
            Random r = new Random();
            int genRand = r.Next(0,2);

            TextWriter tr = new StreamWriter("Food.txt");
            tr.WriteLine("Food Name is " + FoodName);
            tr.WriteLine("The Calories are " + Calories);
            tr.WriteLine("The Current Date Without Time is {0}.", Date);
            tr.WriteLine("Its most likely to be " + Names[genRand]);
            tr.Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Submitted!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}