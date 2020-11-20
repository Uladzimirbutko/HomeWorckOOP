using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Candy_Present
{
    class Twix : Candy
    {
        public sealed override string Name { get;  set; }

        public sealed override int Weight { get;  set; }

        public sealed override double Sugar { get;  set; }
        public Twix(string name, int weight, double sugar)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
        }

    }
}
