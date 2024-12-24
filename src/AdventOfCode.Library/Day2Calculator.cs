using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Library
{
    public class Day2Calculator
    {
        private List<int> Report;
        private bool problemDampener;
        public Day2Calculator(List<int> report, bool problemDampener = false)
        {
            Report = report;
            this.problemDampener = problemDampener;
        }

        public Day2Calculator(string report, bool problemDampener = false)
        {
            Report = report.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            this.problemDampener = problemDampener;
        }

        public static int CountSafe(string input, bool problemDampener = false)
        {
            var reports = input.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            return reports.Select(r => new Day2Calculator(r, problemDampener)).Count(r => r.safe);
        }

        public bool safe
        {
            get
            {
                var problem = false;
                if (Report.Count <= 1)
                {
                    return true;
                }
                var up = Report[1] > Report[0];
                for (int i = 0; i < Report.Count - 1; i++)
                {
                    var curr = Report[i];
                    var next = Report[i + 1];
                    if (curr == next)
                    {
                        problem = true;
                    }

                    var currUp = next > curr;
                    if (currUp != up)
                    {
                        problem = true;
                    }
                    var diff = Math.Abs(curr - next);
                    if (diff > 3)
                    {
                        problem = true;
                    }
                    if (problem && problemDampener)
                    {
                        var currReport = new List<int>(Report);
                        currReport.RemoveAt(i+1);
                        var newCalc = new Day2Calculator(currReport);
                        return newCalc.safe;
                    }
                    if (problem)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
