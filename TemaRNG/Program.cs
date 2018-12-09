using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random rng = new Random();
        int numberToGuess = rng.Next(1, 100);
        int userGuess = 0;
        while (userGuess != numberToGuess)
        {
            Console.Write("Ghiceste numarul: ");
            int.TryParse(Console.ReadLine(), out userGuess);
            if (userGuess > numberToGuess)
            {
                Console.Write("Ghiceste numarul: ");
                Console.WriteLine("{0} e prea mare!", userGuess);
            }
            else if (userGuess < numberToGuess)
            {
                Console.WriteLine("{0} e prea mic !", userGuess);
            }
            else
            {
                Console.WriteLine("{0} e corect! Felicitari", userGuess);
                Console.ReadLine();
            }
        }
    }
}