using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Core
{
    public interface ISolver
    {
        uint Day { get; }
        string Title { get; }
        object Part1(string input);
        object Part2(string input);
    }
}
