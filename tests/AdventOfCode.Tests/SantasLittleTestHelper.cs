using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{


    public class SantasLittleTestHelper
    {
        public static string GetTestPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
        }

        public static string GetFileContents(string filePath)
        {
            return File.ReadAllText(Path.Combine(GetTestPath(), filePath));
        }
    }
}
