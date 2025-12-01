using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC.Core;

namespace AoC.Solutions
{
    public class Day01 : ISolver
    {
        public uint Day => 1u;

        public string Title => "Secret Entrance";

        public object Part1(string input)
        {
            var lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int currentDial = 50;
            int result = 0;

            foreach (var line in lines)
            {
                
                int rotateBy = int.Parse(line.Substring(1));
                currentDial += (line.StartsWith('L') ? -1 : +1) * rotateBy;

                if (currentDial % 100 == 0)
                {
                    result += 1;
                }
            }

            return result;
        }

        public object Part2(string input)
        {
            var lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            long currentDial = 50;
            long result = 0;

            foreach (var line in lines)
            {
                int rotateBy = int.Parse(line.Trim().Substring(1));
                int direction = line.Trim().StartsWith('L') ? -1 : 1;

                for (int i = 0; i < rotateBy; i++)
                {
                    currentDial += direction;

                    if (currentDial % 100 == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
