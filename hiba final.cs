using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class MONTHLYEMP

    {
        int basePay;
        int hourlyPayRate;
        int overtimeHours;
        int overtimePay;
        int unitPay;
        int Grosspay;
        int hoursWorked;
        int BASE_HOURS;
        int OVERTIME_RATE;
        public void Calculate_Salary()
        {
            if(hoursWorked > BASE_HOURS)
            { 
            basePay = hourlyPayRate * BASE_HOURS;
            overtimeHours = hoursWorked - BASE_HOURS;
            overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;
            unitPay = 3 * unit produced;
            Grosspay = basePay + overtimePay + unitPay
        }
    }
}
