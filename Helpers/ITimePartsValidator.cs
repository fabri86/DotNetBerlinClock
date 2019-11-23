namespace BerlinClock.Helpers
{
    public interface ITimePartsValidator
    {
        bool IsValidTime(int hours, int minutes, int seconds);
    }
}