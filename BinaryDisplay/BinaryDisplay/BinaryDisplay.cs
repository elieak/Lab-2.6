using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    class BinaryDisplay
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Enter an integer to convert to Binary: ");
            int.TryParse(Console.ReadLine(), out input);
            var bin = Convert.ToString(input, 2);

            if (input > 0)
            {
                Console.WriteLine("The answer is: " + ToBinary(input));
                Console.WriteLine(bin);
            }
            else
            {
                Console.WriteLine("Can't calculate negative number");
            }

        }

        public static double ToBinary(int value)
        {
            var len = ((Math.Log(value) / Math.Log(2)) + 1);
            while (value > 0)
            {
                len += 1;
                value = value & (value - 1);
            }
            return len;
        }
    }
}
