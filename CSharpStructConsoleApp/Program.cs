using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStructConsoleApp
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the \"Struct\" Demonstration Application!");
        Console.WriteLine("This brief example shows a struct in action! Thank you for demoing my application!");
        Console.WriteLine();

        Number number = new Number() { Amount = 0.112358132134m };
        Console.WriteLine("Here is our decimal being housed inside of our \"Number\" struct: " + number.Amount);
        Console.WriteLine("Press enter to exit!");
        Console.ReadLine();
    }
}

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
