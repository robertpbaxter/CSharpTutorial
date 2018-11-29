using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sleepy = new Student
            {
                FirstName = "Robert",
                LastName = "Baxter",
                DateRegistered = "November, 16th, 2018"
            };


            Console.WriteLine($"{sleepy.FirstName} {sleepy.LastName} is a very sleepy guy who registered on {sleepy.DateRegistered}");
        }
    }
}
