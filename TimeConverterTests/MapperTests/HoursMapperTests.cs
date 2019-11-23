using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeConverterTests.MapperTests
{
    [TestClass]
    public class HoursMapperTests
    {
        private const char Red = 'R';

        [TestMethod]
        public void Must_Return_Sequence_OOOO_When_Value_Is_Equal_To_0()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(0, Red);

            Assert.AreEqual("OOOO", codeForFirstRow, "Expected code is OOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_ROOO__When_Value_Is_Equal_To_1()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(1, Red);

            Assert.AreEqual("ROOO", codeForFirstRow, "Expected code is ROOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_RROO_When_Value_Is_Equal_To_2()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(2, Red);

            Assert.AreEqual("RROO", codeForFirstRow, "Expected code is RROO");
        }

        [TestMethod]
        public void Must_Return_Sequence_RRRO_When_Value_Is_Equal_To_3()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(3, Red);

            Assert.AreEqual("RRRO", codeForFirstRow, "Expected code is RRRO");
        }

        [TestMethod]
        public void Must_Return_Sequence_RRRR_When_Value_Is_Equal_To_4()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(4, Red);

            Assert.AreEqual("RRRR", codeForFirstRow, "Expected code is RRRR");
        }

    }
}
