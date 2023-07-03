using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Bmw : Car
    {
        public Bmw(string model, int year) : base(model, year)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Brand: BMW Model:{Model} Year: {Year}");
        }
    }
}
