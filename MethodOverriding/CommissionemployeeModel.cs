using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class CommissionemployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPayCheckAmount(int hoursWorked)
        {
            decimal initialPay =  base.GetPayCheckAmount(hoursWorked);

            return initialPay + CommissionAmount;
        }
    }
}
