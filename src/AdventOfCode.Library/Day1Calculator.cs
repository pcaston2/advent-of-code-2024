using System.Data;

namespace AdventOfCode.Library;

public class Day1Calculator
{
    public List<int> left = new List<int>();
    public List<int> right = new List<int>();
    public Day1Calculator(string contents, string rowSeparator = "\r\n", string colSeparator = "   ") {

        foreach (var row in contents.Split(rowSeparator, StringSplitOptions.RemoveEmptyEntries))
        {
            var cols = row.Split(colSeparator);
            var key = int.Parse(cols.First());
            var value = int.Parse(cols.Skip(1).First());
            left.Add(key);
            right.Add(value);
        }
    }

    public int Distance()
    {
        left.Sort();
        right.Sort();
        var totalDistance = 0;
        for (var i = 0; i < left.Count; i++)
        {
            var diff = left[i] - right[i];
            var mag = Math.Abs(diff);
            totalDistance += mag;
        }
        return totalDistance;
    }

    public int Score()
    {
        var score = 0;
        for (var i = 0; i< left.Count; i++)
        {
            var curr = left[i];
            var count = right.Where(x => x == curr).Count();
            score += curr * count;
        }
        return score;
    }
}
