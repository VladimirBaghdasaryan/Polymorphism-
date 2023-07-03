using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Toyota : Car
    {
        public Toyota(string model, int year) : base(model, year)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Brand: Toyota  Model:{Model} Year: {Year}");
        }

    }
}
