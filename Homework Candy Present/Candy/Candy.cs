using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Candy_Present
{
    public abstract class Candy
    {
        
        public abstract string Name { get;  set; }
        public abstract int Weight { get; set; }
        public abstract double Sugar { get; set; }

    }
}
