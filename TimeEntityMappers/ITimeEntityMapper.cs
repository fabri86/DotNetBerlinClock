namespace BerlinClock.TimeEntityMappers
{
    public interface ITimeEntityMapper
    {
        string GetCode(int value, char color);
    }
}