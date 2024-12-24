using System.Reflection;

namespace AdventOfCode.Tests;

public class When_Doing_Day_1
{
    private string getTestPath()
    {
        return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
    }

    private string getFileContents(string filePath)
    {
        return File.ReadAllText(Path.Combine(getTestPath(), filePath));
    }

    [Fact]
    public void Should_Load_Sample_File_Contents()
    {
        //arrange
        var path = "input/d01sample.txt";

        //act
        var contents = getFileContents(path);

        //assert
        Assert.StartsWith("3   4", contents);
        Assert.EndsWith("3   3", contents);
    }

    [Fact]
    public void Should_Load_Sample_Input_Contents()
    {
        //arrange
        var path = "input/d01input.txt";

        //act
        var contents = getFileContents(path);

        //assert
        Assert.StartsWith("88276   66757", contents);
        Assert.EndsWith("36438   47508\n", contents);
    }

    [Fact]
    public void Should_Parse_Numbers_For_Sample()
    {
        //arrange
        var path = "input/d01sample.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents);

        //assert
        Assert.Equal(3, sut.left.First());
        Assert.Equal(4, sut.right.First());
        Assert.Equal(2, sut.left.Skip(2).First());
        Assert.Equal(9, sut.right.Skip(4).First());
    }

    [Fact]
    public void Should_Parse_Numbers_For_Input()
    {
        //arrange
        var path = "input/d01input.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents, "\n");

        //assert
        Assert.Equal(88276, sut.left.First());
        Assert.Equal(66757, sut.right.First());
        Assert.Equal(58877, sut.left.Skip(2).First());
        Assert.Equal(62485, sut.right.Skip(4).First());
    }

    [Fact]
    public void Should_Calculate_Total_For_Sample()
    {
        //arrange
        var path = "input/d01sample.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents);

        //assert
        Assert.Equal(11, sut.Distance());
    }

    [Fact]
    public void Should_Calculate_Total_For_Input()
    {
        //arrange
        var path = "input/d01input.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents, "\n");

        //assert
        Assert.Equal(1970720, sut.Distance());
    }
    
    [Fact]
    public void Should_Calculate_Score_For_Sample()
    {
        //arrange
        var path = "input/d01sample.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents);

        //assert
        Assert.Equal(31, sut.Score());
    }

    [Fact]
    public void Should_Calculate_Score_For_Input()
    {
        //arrange
        var path = "input/d01input.txt";
        var contents = getFileContents(path);

        //act
        var sut = new Day1Calculator(contents, "\n");

        //assert
        Assert.Equal(17191599, sut.Score());
    }
}