using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimalValue = Console.ReadLine();
            int decimalValue = Convert.ToInt32(hexaDecimalValue, 16);

            Console.WriteLine(decimalValue);


        }
    }
}
