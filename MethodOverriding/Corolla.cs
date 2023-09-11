using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with the Corolla clock");
        }
    }
}
