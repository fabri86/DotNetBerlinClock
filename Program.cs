using Autofac;
using System;
using System.Threading;

namespace BerlinClock
{
    class Program
    {
        public static void Main()
        {
            var container = ContainerConfig.Configure();
            container.Resolve<BerlinClockApp>().Run();

            Console.WriteLine("Thanks for using the BerlinClockApp!");
            Thread.Sleep(2000);
        }
    }
}