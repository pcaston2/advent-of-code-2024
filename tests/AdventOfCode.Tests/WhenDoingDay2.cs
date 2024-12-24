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

        [Theory]
        [InlineData(true, 7, 6, 4, 2, 1)]
        [InlineData(false, 1, 2, 7, 8 , 9)]
        [InlineData(false, 9, 7, 6, 2, 1)]
        [InlineData(false, 1, 3, 2, 4, 5)]
        [InlineData(false, 8, 6, 4, 4, 1)]
        [InlineData(true, 1, 3, 6, 7, 9)]

        public void Should_Satisfy_Sample_Data(bool safe, params int[] report)
        {
            //Arrange
            var sut = new Day2Calculator(report!.ToList());

            //Act
            var result = sut.safe;

            //Assert
            Assert.Equal(safe, result);
        }

        [Fact]
        public void Should_Count_Safe_Reports()
        {

            //arrange
            var path = "input/d02input.txt";
            var contents = SantasLittleTestHelper.GetFileContents(path);

            //act
            var result = Day2Calculator.CountSafe(contents);

            //assert
            Assert.Equal(432, result);
        }


        [Theory]
        [InlineData(true, 7, 6, 4, 2, 1)]
        [InlineData(false, 1, 2, 7, 8, 9)]
        [InlineData(false, 9, 7, 6, 2, 1)]
        [InlineData(true, 1, 3, 2, 4, 5)]
        [InlineData(true, 8, 6, 4, 4, 1)]
        [InlineData(true, 1, 3, 6, 7, 9)]

        public void Should_Satisfy_Sample_Data_With_Problem_Dampener(bool safe, params int[] report)
        {
            //Arrange
            var sut = new Day2Calculator(report!.ToList(), true);

            //Act
            var result = sut.safe;

            //Assert
            Assert.Equal(safe, result);
        }

        [Fact]
        public void Should_Count_Safe_Reports_With_Problem_Dampener()
        {

            //arrange
            var path = "input/d02input.txt";
            var contents = SantasLittleTestHelper.GetFileContents(path);

            //act
            var result = Day2Calculator.CountSafe(contents, true);

            //assert
            Assert.Equal(472, result);
        }
    }
}
