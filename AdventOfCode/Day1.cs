using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day1
    {
        public static async Task Part1()
        {
            var fileLines = await new IntFileReader().ReadInputFromFile();

            var increases = 0;

            for (var i = 1; i < fileLines.Count; i++)
            {
                if (fileLines[i - 1] < fileLines[i])
                {
                    increases++;
                }
            }

            Console.WriteLine(increases);
        }

        public static async Task Part2()
        {
            var fileLines = await new IntFileReader().ReadInputFromFile();

            var increases = 0;

            for (var i = 0; i < fileLines.Count - 3; i++)
            {
                var section1 = (fileLines[i + 1] + fileLines[i + 2] + fileLines[i + 3]);
                var section2 = (fileLines[i] + fileLines[i + 1] + fileLines[i + 2]);
                if (section1 > section2)
                {
                    increases++;
                }
            }

            Console.WriteLine(increases);
        }
    }
}