using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerWorker
{
    public class Employee
    {
        public int Salary { get; set; }

        #region Solution 1
        public virtual int GetTotalSalary(int sum)
        {
            return 0;
        }
        #endregion
        public int GetTotalSalary2(Employee employee) => employee switch
        {
            Manager m => m.GetTotalSalary() + Salary,
            Worker w => w.Salary,
            _ => 0,
        };
    }

    public class Manager : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        #region Solution 1
        //public override int GetTotalSalary(int sum)
        //{   
        //    Employees.ForEach(x => 
        //    {
        //        sum += x.GetTotalSalary(sum);                
        //    });
        //    return sum += Employees.Sum(x => x.Salary);
        //}
        #endregion

        public int GetTotalSalary()
        {
            int sum = 0;
            Employees.ForEach(x =>
            {
                sum += x.GetTotalSalary2(x);
            });
            return sum;
        }
        
    }

    public class Worker : Employee
    {

    }
}
