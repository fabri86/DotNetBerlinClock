using System.Threading.Tasks;

namespace BerlinClock
{
    public interface ITimeConverter
    {
        Task<string> ConvertTime(string aTime);
    }
}