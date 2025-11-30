using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC.Solutions;
using FluentAssertions;

namespace AoC.Tests
{
    public class Day00Tests : SolverTestBase<Day00>
    {
        protected override string SampleInput => """
            1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000
            """;


        [Fact]
        public void Part1_SolvesExample_Correctly()
        {

            var result = _sut.Part1(SampleInput);

            // The answer should be integer 24000
            result.Should().Be(24000);
        }

        [Fact]
        public void Part2_SolvesExample_Correctly()
        {

            var result = _sut.Part2(SampleInput);

            // The answer should be integer 45000
            result.Should().Be(45000);
        }
    }
}
