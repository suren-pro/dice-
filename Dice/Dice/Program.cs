using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0;
            Dice dice = new Dice();
            for (int i = 0; i < 50; i++)
            {
                c++;
                
                dice.Roll();
            }

            Console.ReadKey();
        }
    }
}
