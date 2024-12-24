using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    public class When_Doing_Day_2
    {
        [Fact]
        public void Should_Be_Safe_When_Decrementing()
        {
            //arrange
            var report = new List<int> { 3, 2, 1 };

            //act
            var sut = new Day2Calculator(report);

            //assert
            Assert.True(sut.safe);
        }

        [Fact]
        public void Should_Be_Safe_When_Incrementing()
        {
            //arrange
            var report = new List<int> { 1, 2, 3 };

            //act
            var sut = new Day2Calculator(report);

            //assert
            Assert.True(sut.safe);
        }

        [Fact]
        public void Should_Not_Be_Safe_When_Alternating()
        {
            //arrange
            var report = new List<int> { 1, 2, 1 };

            //act
            var sut = new Day2Calculator(report);

            //assert
            Assert.False(sut.safe);
        }

        [Fact]
        public void Should_Not_Be_Safe_When_Not_Changing()
        {
            //arrange
            var report = new List<int> { 1, 1, 1 };

            //act
            var sut = new Day2Calculator(report);

            //assert
            Assert.False(sut.safe);
        }

        [Fact]
        public void Should_Not_Be_Safe_When_Big_Difference()
        {
            //arrange
            var report = new List<int> { 1, 5 };

            //act
            var sut = new Day2Calculator(report);

            //assert
            Assert.False(sut.safe);
        }
    }
}
