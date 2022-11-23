using System.Collections.Generic;
using PartTwo.Types;

namespace PartTwo.Interfaces
{
    public interface INotify
    {
        string GetTeamWithSmallestPointRange(IList<Football> footballData);
    }
}