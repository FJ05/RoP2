using System;

namespace RoP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //fråga användaren hur många trianglar trädet ska ha
            Console.WriteLine("Välj antalet trianglar i ditt jul träd: ");
            int antal = int.Parse(Console.ReadLine());

            //loopar för antal trianglar som ska bildas
            for (int i = 1; i <= antal; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //branch ska bli "*" j antal gånger
                    string branch = new String('*', j);
                    Console.ForegroundColor = ConsoleColor.Green;
                    //skriver ut så att det bildas en triangel
                    Console.WriteLine(branch.PadLeft(antal + 3) + "*" + branch);
                    
                }
            }
            Console.ReadLine();
        }
    }
}

