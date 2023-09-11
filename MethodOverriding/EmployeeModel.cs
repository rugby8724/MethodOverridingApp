using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPayCheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
