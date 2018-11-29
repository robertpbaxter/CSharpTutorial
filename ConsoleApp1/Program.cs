using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type reference guide

            int i = 0; // A whole number with a size of 32 bits and range from -2,147,483,648 to 2,147,483,647.

            short sh = 32767; // A whole number with size 16 bits and range from -32,768 to 32,767.

            byte by = 255; // A whole number with size of 8 bits and range from 0 to 255.

            string s = "Hey!"; // A collection of characters with a size of up to 2 gigs or 2^32 bytes, or Int32.MaxValue.

            char c = 'i'; // A single character with a size of 16 bits.

            var s2 = @"a \tree"; // The @ symbol is used when about to call a reference tree as to specify a directory file on your machine such as \DotNetPreWork\HelloWorld.

            bool b = false; // Boolean

            long l = 7; // Long is an integer data type that can just hold more than a normal int type.  Exactly 2 times more.  The size is 64 bit and the range is -9223372036854775808 to 9223372036854775808.  Another way to assign this type is Int64.

            decimal p = 99.99999999999999999999999999m; // A numeral that can go to a 128-bit precision decimal with a range of 28-29 decimal places.  A very costly data type that takes a lot of energy for the program to run.  A decimal data type is often used to represent money or other data that needs to be exact.

            double d = 7.80000000000000; // A numeral that has a 15-16 digit precision with a 64-bit size.

            float f = 10.8f; // Floating point integer, must put f explicit conversion afterwards.  Float is similar to a double only it is stored as 32 bits within the memory.

            decimal dd = 7.80; // Without the suffix m, the number is treated as a double and generates a compiler error.

            int? ni = null; // ? means the value can be null

        }
    }
}
