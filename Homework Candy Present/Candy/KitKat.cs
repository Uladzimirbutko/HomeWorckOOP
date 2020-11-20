using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Candy_Present
{
    class KitKat : Candy
    {
        
        public sealed override string Name { get;  set; }

        public sealed override int Weight { get;  set; }

        public sealed override double Sugar { get;  set; }
        public KitKat(string name, int weight, double sugar)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
        }
    }
}
