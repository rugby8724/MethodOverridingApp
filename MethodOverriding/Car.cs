using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        public abstract void SetClock();
    }
}
