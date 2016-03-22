using System.Collections.Generic;

namespace _3.Company_Hierarchy.Interfaces
{
    interface IManager : IEmployee
    {
        List<Employee> Employees { get; set; }
    }
}
