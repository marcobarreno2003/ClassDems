using System;

namespace npcnames
{
    class Program
    {
        public static void Main()
        {
            string [] Names = new string [] {"Sol", "Andrea", "Sebastian","Marco", "Andres", "Diego","Sebastian","Camila", "Cory","Raul"};
            Random r = new Random();
            int genRand = r.Next(0,9);
            Console.WriteLine (Names[genRand]);
        }
    }
}