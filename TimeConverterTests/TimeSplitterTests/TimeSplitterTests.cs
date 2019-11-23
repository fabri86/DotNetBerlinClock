using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeConverterTests.TimeSplitterTests
{
    [TestClass]
    public class TimeSplitterTests
    {
        private const string TimeString = "13:54:43";
        private const int ExpectedHours = 13;
        private const int ExpectedMinutes = 54;
        private const int ExpectedSeconds = 43;

        [TestMethod]
        public void Must_Return_The_Proper_Value_For_Hours()
        {
            TimeSplitter timeSplitter = new TimeSplitter();

            int hours = timeSplitter.GetHours(TimeString);

            Assert.AreEqual(ExpectedHours, hours, "Invalid number of hours.");
        }

        [TestMethod]
        public void Must_Return_The_Proper_Value_For_Minutes()
        {
            TimeSplitter timeSplitter = new TimeSplitter();

            int minutes = timeSplitter.GetMinutes(TimeString);

            Assert.AreEqual(ExpectedMinutes, minutes, "Invalid number of minutes.");
        }

        [TestMethod]
        public void Must_Return_The_Proper_Value_For_Seconds()
        {
            TimeSplitter timeSplitter = new TimeSplitter();

            int seconds = timeSplitter.GetSeconds(TimeString);

            Assert.AreEqual(ExpectedSeconds, seconds, "Invalid number of seconds.");
        }
    }
}
