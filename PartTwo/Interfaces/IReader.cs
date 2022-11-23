using System.Collections.Generic;
using PartTwo.Types;

namespace PartTwo.Interfaces
{
    public interface IReader
    {
        IList<Football> GetFootballData(string fileLocation);
    }
}