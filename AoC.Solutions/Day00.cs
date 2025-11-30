using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using AoC.Core;

namespace AoC.Solutions
{
    //A Day1 task from 2022 just to test out the setup
    public class Day00 : ISolver
    {
        public uint Day => 0;

        public string Title => "Calorie Counting";

        public object Part1(string input)
        {
            var groups = ParseElves(input);
            return groups.Max();
        }

        public object Part2(string input)
        {
            var groups = ParseElves(input);
            return groups.OrderByDescending(x => x).Take(3).Sum();
        }

        private List<int> ParseElves(string input)
        {
            var normalized = input.Replace("\r\n", "\n");
            var groups = normalized.Split("\n\n");

            List<int> caloriesPerGroup = new();

            foreach (var group in groups)
            {
                var lines = group.Split("\n", StringSplitOptions.RemoveEmptyEntries);
                var currentGroupSum = 0;

                foreach (var line in lines)
                {
                    if (int.TryParse(line, out int calories))
                    {
                        currentGroupSum += calories;
                    }
                }

                caloriesPerGroup.Add(currentGroupSum);
            }

            return caloriesPerGroup;
        }
    }
}
