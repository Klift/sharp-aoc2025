using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC.Solutions;
using FluentAssertions;

namespace AoC.Tests
{
    public class Day01Tests : SolverTestBase<Day01>
    {
        protected override string SampleInput => """
            L68
            L30
            R48
            L5
            R60
            L55
            L1
            L99
            R14
            L82
            """;

        [Fact]
        public void Part1_ShouldMatchTheSample()
        {
            var result = _sut.Part1(SampleInput);
            result.Should().Be(3);
        }

        [Fact]
        public void Part2_ShouldMatchTheSample()
        {
            _sut.Part2(SampleInput).Should().Be(6);
        }

        [Theory]
        [InlineData("R200", 2)] // Multiple Full Positive Rotations
        [InlineData("R150", 2)] // Stopping at 0
        [InlineData("L75", 1)] // Sign Change non-complete
        [InlineData("L200", 2)] // Sign Change multiple complete
        [InlineData("L150", 2)] // Sign Change stopping at 0
        [InlineData("L50\nL150\nR200", 4)] // changing signs with more complex rotation
        public void Part2_EdgeCases(string input, int expected)
        {
            // Act
            var result = _sut.Part2(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}
