using System;
class TheUseOfQuiotations
{
    static void Main()
    {
        string use = "\"use\"";
        Console.WriteLine("The {0} of quotations causes difficulties.", use);
        string use2 = @"""use""";
        Console.WriteLine("The {0} of quotations causes difficulties.", use2);
    }
}
