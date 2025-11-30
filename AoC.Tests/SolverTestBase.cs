using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC.Core;
using FluentAssertions;

namespace AoC.Tests
{
    public abstract class SolverTestBase<TSolver> where TSolver: ISolver, new()
    {
        protected readonly TSolver _sut = new();

        protected abstract string SampleInput {  get; }

        [Fact]
        public void Solver_HasCorrectDay()
        {
            var typeName = typeof(TSolver).Name;
            var expectedDay = uint.Parse(typeName.Substring(typeName.Length - 2));

            _sut.Day.Should().Be(expectedDay);
        }
    }
}
