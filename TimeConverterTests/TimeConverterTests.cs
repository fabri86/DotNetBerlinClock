using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeConverterTests
{
    [TestClass]
    public class TimeConverterTests
    {
        private const string Time030801 = "O\r\nOOOO\r\nRRRO\r\nYOOOOOOOOOO\r\nYYYO";
        private const string Time223700 = "Y\r\nRRRR\r\nRROO\r\nYYRYYRYOOOO\r\nYYOO";

        [TestMethod]
        public void Must_Return_The_Proper_Value_When_Time_Is_03_08_01()
        {
            TimeConverter timeComverter = new TimeConverter(new TimeMapper(), new TimeSplitter());

            var stringCode = timeComverter.ConvertTime("03:08:01");

            Assert.AreEqual(Time030801, stringCode, "Time was not conveted properly");
        }

        [TestMethod]
        public void Must_Return_The_Proper_Value_When_Time_Is_22_38_00()
        {
            TimeConverter timeComverter = new TimeConverter(new TimeMapper(), new TimeSplitter());

            var stringCode = timeComverter.ConvertTime("22:37:00");

            Assert.AreEqual(Time223700, stringCode, "Time was not conveted properly");
        }
    }
}
