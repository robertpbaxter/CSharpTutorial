using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess what number I'm thinking of? Take a guess between 0 to 100");
            int answer = 23;
            int guess = Convert.ToInt16(Console.ReadLine());
            if (guess > 100 || guess < 0) { Console.WriteLine("Ummm, I told you to pick a number within a range. Listen."); }
            else if (guess == answer) { Console.WriteLine("Winner winner chicken dinner!"); }
            else if (Math.Abs(guess-answer)>2) { Console.WriteLine("LITERALLY on fire."); }
            else if (Math.Abs(guess-answer)>5) { Console.WriteLine("So close you're on fire!"); }
            else if (Math.Abs(guess-answer)>10) { Console.WriteLine("Getting hotter."); }
            else if (Math.Abs(guess-answer)>20) { Console.WriteLine("Getting warmer."); }
            else if (Math.Abs(guess-answer)>30) { Console.WriteLine("Cool, but getting warmer."); }
            else if (Math.Abs(guess-answer)>40) { Console.WriteLine("Cold. Try again."); }
            else if (Math.Abs(guess-answer)>50) { Console.WriteLine("Freezing cold. You're not very good at this, are you?"); }
            else if (Math.Abs(guess-answer)>70) { Console.WriteLine("Have you ever played this game before?"); }
            else { Console.WriteLine("Did you even read the instructions???"); }
            Console.ReadLine();
        }
    }
}
