using System.Collections.Generic;
namespace _3.Company_Hierarchy.Interfaces
{
    interface IDeveloper : IRegularEmployee
    {
        List<Project> Projects { get; set; }
    }
}
