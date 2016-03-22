using System.Collections.Generic;

namespace _3.Company_Hierarchy.Interfaces
{
    interface ISalesEmployee : IRegularEmployee
    {
        List<Sale> Sales { get; set;}
    }
}
