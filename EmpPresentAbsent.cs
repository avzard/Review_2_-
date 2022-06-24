using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    public abstract class DataEmpWage
    {
        public abstract void CheckPartTimeEmpWage();
        
    }
    public  class EmpPresentAbsent : DataEmpWage
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int WagePerHour = 20;
        public int FullDayHour = 8;
        public int PartTimeDayHour = 4;
        public int DailyWage = 0;
        public override void CheckPartTimeEmpWage()
        {
            Random Empcheck = new Random();
            int value = Empcheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    DailyWage = WagePerHour * FullDayHour;
                    Console.WriteLine("Employee is Present,in Full time and Dailywage = {0}", DailyWage);
                }
                else
                {
                    DailyWage = WagePerHour * PartTimeDayHour;
                    Console.WriteLine("Employee is present,in Part time and Dailywage = {0}", DailyWage);
                }
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}