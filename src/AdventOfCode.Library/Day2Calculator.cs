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
        public Day2Calculator(List<int> report) {
            Report = report;
        }

        public bool safe
        {
            get
            {
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
                        return false;
                    }

                    var currUp = next > curr;
                    if (currUp != up)
                    {
                        return false;
                    }
                    var diff = Math.Abs(curr - next);
                }
                return true;
            }
        }

    }
}
