using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberSmallBars = Chocolate.MakeChocolate(4, 1, 7);
            Console.WriteLine(numberSmallBars);
        }
    }
}
