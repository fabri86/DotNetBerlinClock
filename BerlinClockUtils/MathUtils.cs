namespace BerlinClockUtils
{
    public static class MathUtils
    {
        public static bool IsEven(int integerNumber)
        {
            return integerNumber % 2 == 0;
        }

        public static bool IsMultipleOf(int source, int multipleBase)
        {
            return source % multipleBase == 0;
        }
    }
}