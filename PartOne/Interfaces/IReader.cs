using System.Collections.Generic;
using PartOne.Types;

namespace PartOne.Interfaces
{
    public interface IReader
    {
        IList<Weather> GetWeatherData(string fileLocation);
    }
}