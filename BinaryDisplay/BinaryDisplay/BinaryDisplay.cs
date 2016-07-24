using System;
using System.Linq;

namespace BinaryDisplay
{
    //Prints "0" for invalid input.
    class BinaryDisplay
    {
        static void Main()
        {
            int input;
            var tb = new BinaryDisplay();

            Console.Write("Enter an integer to convert to Binary: ");
            int.TryParse(Console.ReadLine(), out input);
            var bin = Convert.ToString(input, 2);

            //Consider using string interpolation (with the $ sign), string.Format or even the overload of Console.WriteLine that accepts a format (Console.WriteLIne("foo{0}", "bat");)
            Console.WriteLine("Binary number representation: " + bin);

            if (input > 0)
            {
                Console.WriteLine("Positive int binary count: " + tb.ToBinary(input));
            }
            else
            {
                Console.WriteLine("Negative int binary count: " + tb.ToNegativeBinary(bin));
            }

        }

        //Nice.
        public double ToBinary(int value)
        {
            var a = value;
            var count = 0;

            while (a > 0)
            {
                if ((a & 1) == 1)
                    count++;
                var orig = a >> 1;
                a = orig;
            }
            return count;
        }

        //Ok. But bitwise would have worked fine with "<<". This is cheating ;)
        public string ToNegativeBinary(string value)
        {
            var arr = value.ToCharArray();
            var counter = arr.Count(one => one == '1');
            return counter.ToString();
        }
    }
}