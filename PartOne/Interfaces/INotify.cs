using System.Collections.Generic;
using PartOne.Types;

namespace PartOne.Interfaces
{
    public interface INotify
    {
        int GetDayOfLeastTemperatureChange(IList<Weather> weatherData);
    }
}