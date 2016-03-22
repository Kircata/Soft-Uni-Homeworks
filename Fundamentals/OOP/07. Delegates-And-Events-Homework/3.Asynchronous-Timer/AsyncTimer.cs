namespace _3.Asynchronous_Timer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        public AsyncTimer(Action<string> methodToBeCalled, int ticks, int timeInterval)
        {
            this.MethodToBeCalled = methodToBeCalled;
            this.Ticks = ticks;
            this.TimeInterval = timeInterval;
        }

        public Action<string> MethodToBeCalled { get; private set; }
        public int Ticks { get; set; }
        public int TimeInterval { get; set; }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        public void Execute()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.TimeInterval);
                this.MethodToBeCalled("Called the method");
                this.Ticks--;
            }
        }
    }
}
