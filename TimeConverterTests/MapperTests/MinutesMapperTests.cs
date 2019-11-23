using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeConverterTests.MapperTests
{
    [TestClass]
    public class MinutesMapperTests
    {
        private const char Yellow = TimeConverter.Yellow;
        private const char Red = TimeConverter.Red;

        [TestMethod]
        public void Must_Return_Sequence_OOOO_When_Value_Is_Equal_To_0()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(0, Yellow);

            Assert.AreEqual("OOOO", codeForFirstRow, "Expected code is OOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YOOO__When_Value_Is_Equal_To_1()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(1, Yellow);

            Assert.AreEqual("YOOO", codeForFirstRow, "Expected code is YOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYOO_When_Value_Is_Equal_To_2()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(2, Yellow);

            Assert.AreEqual("YYOO", codeForFirstRow, "Expected code is YYOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYYO_When_Value_Is_Equal_To_3()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(3, Yellow);

            Assert.AreEqual("YYYO", codeForFirstRow, "Expected code is YYYO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYYY_When_Value_Is_Equal_To_4()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForFirstRow = mapper.GetCode(4, Yellow);

            Assert.AreEqual("YYYY", codeForFirstRow, "Expected code is YYYY");
        }

        [TestMethod]
        public void Must_Return_Sequence_OOOOOOOOOOO_When_Value_Is_Equal_To_0()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(0, Yellow, Red);

            Assert.AreEqual("OOOOOOOOOOO", codeForMinuteRow, "Expected code is OOOOOOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YOOOOOOOOOO_When_Value_Is_Equal_To_1()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(1, Yellow, Red);

            Assert.AreEqual("YOOOOOOOOOO", codeForMinuteRow, "Expected code is YOOOOOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYOOOOOOOOO_When_Value_Is_Equal_To_2()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(2, Yellow, Red);

            Assert.AreEqual("YYOOOOOOOOO", codeForMinuteRow, "Expected code is YYOOOOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYROOOOOOOO_When_Value_Is_Equal_To_3()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(3, Yellow, Red);

            Assert.AreEqual("YYROOOOOOOO", codeForMinuteRow, "Expected code is YYROOOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYOOOOOOO_When_Value_Is_Equal_To_4()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(4, Yellow, Red);

            Assert.AreEqual("YYRYOOOOOOO", codeForMinuteRow, "Expected code is YYRYOOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYOOOOOO_When_Value_Is_Equal_To_5()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(5, Yellow, Red);

            Assert.AreEqual("YYRYYOOOOOO", codeForMinuteRow, "Expected code is YYRYYOOOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYROOOOO_When_Value_Is_Equal_To_6()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(6, Yellow, Red);

            Assert.AreEqual("YYRYYROOOOO", codeForMinuteRow, "Expected code is YYRYYROOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYRYOOOO_When_Value_Is_Equal_To_7()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(7, Yellow, Red);

            Assert.AreEqual("YYRYYRYOOOO", codeForMinuteRow, "Expected code is YYRYYRYOOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYRYYOOO_When_Value_Is_Equal_To_8()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(8, Yellow, Red);

            Assert.AreEqual("YYRYYRYYOOO", codeForMinuteRow, "Expected code is YYRYYRYYOOO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYRYYROO_When_Value_Is_Equal_To_9()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(9, Yellow, Red);

            Assert.AreEqual("YYRYYRYYROO", codeForMinuteRow, "Expected code is YYRYYRYYROO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYRYYRYO_When_Value_Is_Equal_To_10()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(10, Yellow, Red);

            Assert.AreEqual("YYRYYRYYRYO", codeForMinuteRow, "Expected code is YYRYYRYYRYO");
        }

        [TestMethod]
        public void Must_Return_Sequence_YYRYYRYYRYY_When_Value_Is_Equal_To_11()
        {
            TimeMapper mapper = new TimeMapper();

            string codeForMinuteRow = mapper.GetCodeForElevenRectangleMinuteRow(11, Yellow, Red);

            Assert.AreEqual("YYRYYRYYRYY", codeForMinuteRow, "Expected code is YYRYYRYYRYY");
        }
    }
}



