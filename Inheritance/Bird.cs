using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        new public string Color { get; set; }
        new public int WingSpan { get; set; }
        new public string BeakStyle { get; set; }
        new public bool CanFly { get; set; }

    }
}
