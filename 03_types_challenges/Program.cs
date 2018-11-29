using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_types_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "I was born on ";
            string month = "August";
            int date = 15;
            int year = 1982;
            float weight = 9.8f;
            string units = "lbs";
            Console.WriteLine(statement+month+" "+date+"th, "+year+" and I weighed "+weight+units+".");

            Console.WriteLine("{0} {1} {2}th, {3} and weighed {4}{5}.",statement,month,date,year,weight,units);
            Console.WriteLine($"I was born on {month} {date}th, {year} and toted a whopping {weight + units}.");
        }
    }
}
