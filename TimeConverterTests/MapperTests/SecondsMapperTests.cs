using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeConverterTests.MapperTests
{
    [TestClass]
    public class SecondsMapperTests
    {
        [TestMethod]
        public void Must_Return_Y_Value_When_Number_Of_Seconds_Is_Even()
        {
            TimeMapper mapper = new TimeMapper();

            string value = mapper.GetCodeForBlinkingLed(0, TimeConverter.Yellow);

            Assert.AreEqual(TimeConverter.Yellow.ToString(), value, "Value must be Y since we have a even number of seconds");
        }

        [TestMethod]
        public void Must_Return_O_Value_When_Number_Of_Seconds_Is_Odd()
        {
            TimeMapper mapper = new TimeMapper();

            string value = mapper.GetCodeForBlinkingLed(1, TimeConverter.Yellow);

            Assert.AreEqual(TimeConverter.Off.ToString(), value, "Value must be O since we have a even number of seconds");
        }
    }
}
