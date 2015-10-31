using System;
class StringsAndObjects
{
    static void Main(string[] args)
    {
        string greet = "Hello";
        string world = "World!";
        object VarConc1 = greet + "" + world;
        string VarConc2 = (string)VarConc1;
        Console.WriteLine(VarConc1);
        Console.WriteLine(VarConc2);

    }
}
