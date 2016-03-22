using System;
using System.Collections.Generic;
namespace _3.Company_Hierarchy
{
    class TestProgram
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Developer(69, "Maëly", "Howell", 998.88m, DepartamentType.Production),
                new SalesEmployee(159, "Matthew", "Hart", 898.88m, DepartamentType.Sales),
                new SalesEmployee(85, "Alice", "Nguyen", 798.88m, DepartamentType.Sales),
                new Manager(1, "Beverly", "Jenkins", 698.88m, DepartamentType.Accounting),
                new Manager(333, "Steven", "Rose", 1998.88m, DepartamentType.Marketing),
                new Developer(5698, "Norma", "Lynch", 2098.88m, DepartamentType.Production),
                new SalesEmployee(197, "Heather", "Simpson", 80.88m, DepartamentType.Sales),
                new SalesEmployee(179, "Samuel", "Price", 80.88m, DepartamentType.Sales),
                new Manager(6, "Kathy", "Lawson", 9908.88m, DepartamentType.Marketing),
                new Developer(9, "Janet", "Willis", 198.88m, DepartamentType.Production),
                new Manager(123, "Kelly", "Gutierrez", 398.88m, DepartamentType.Accounting),
            };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
