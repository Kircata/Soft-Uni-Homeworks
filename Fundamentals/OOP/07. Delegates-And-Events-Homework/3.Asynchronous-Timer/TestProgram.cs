namespace _3.Asynchronous_Timer
{
    using System;

    class TestProgram
    {
        public static void Main()
        {

            AsyncTimer asyncTimer = new AsyncTimer(Console.WriteLine, 3, 1000);
            asyncTimer.Run();
        }
    }
}
