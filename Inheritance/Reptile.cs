using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        new public int MaxSize { get; set; }
        new public bool IsPoisonous { get; set; }
        new public bool CanSwim { get; set; }
        new public int TailLength { get; set; }

    }
}
