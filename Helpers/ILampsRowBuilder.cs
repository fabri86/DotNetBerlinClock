using System.Text;

namespace BerlinClock.Helpers
{
    public interface ILampsRowBuilder
    {
        StringBuilder BuildSwitchedOffLampsRow(int lampsNumber);
    }
}