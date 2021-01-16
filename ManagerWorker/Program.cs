using System;
using System.Collections.Generic;

namespace ManagerWorker
{
    class Program
    {
        private static List<Manager> Managers { get; set; } = new List<Manager>();
        static void Main(string[] args)
        {
            SeedData();
            Managers.ForEach(x =>
            {
                Console.WriteLine(x.GetTotalSalary());
            });

            Console.ReadKey();
        }

        private static void SeedData()
        {
            Manager manager = new Manager();            
            manager.Employees.Add(new Manager() { Salary = 200  });
            manager.Employees.Add(new Worker() { Salary = 150  });
            manager.Employees.Add(SeedData2());
            manager.Employees.Add(new Worker() { Salary = 100  });
            Managers.Add(manager);
        }

        private static Manager SeedData2()
        {            
            Manager manager = new Manager();
            manager.Salary = 250;
            manager.Employees.Add(new Manager() { Salary = 20 });
            manager.Employees.Add(new Worker() { Salary = 15 });
            manager.Employees.Add(new Manager() { Salary = 25 });
            manager.Employees.Add(new Worker() { Salary = 10 });
            return manager;
        }
    }
}
