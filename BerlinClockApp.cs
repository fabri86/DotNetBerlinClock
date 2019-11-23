using System;

namespace BerlinClock
{
    public class BerlinClockApp
    {
        private readonly ITimeConverter _timeConverter;

        public BerlinClockApp(ITimeConverter timeConverter)
        {
            _timeConverter = timeConverter;
        }

        public void Run()
        {
            var nextUserInput = true;
            while (nextUserInput)
            {
                Console.WriteLine("Please, enter a time in the format hh:mm:ss or enter 'q' to quit.\n\n");

                var input = Console.ReadLine();
                if (input == "q")
                {
                    nextUserInput = false;
                    continue;
                }

                var output = _timeConverter.ConvertTime(input);
                output.Wait();

                if (string.IsNullOrEmpty(output.Result))
                {
                    Console.WriteLine("Invalid time provided...\n\n");
                }
                else
                {
                    Console.WriteLine("The Berlin clock time is:\n\n");
                    Console.WriteLine($"{output.Result}\n\n");
                }
            }
        }
    }
}