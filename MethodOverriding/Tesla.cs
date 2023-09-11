using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destination");
        }
        public override void SetClock()
        {
            Console.WriteLine("It sets itself");
        }
    }
}
