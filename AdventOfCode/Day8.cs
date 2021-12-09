using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day8
    {
        public static async Task Part1()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();
            var numOfDigits = 0;

            foreach (var line in fileLines)
            {
                var outputLines = line.Split(new[] { "|" }, StringSplitOptions.None)[1];

                var outputs = outputLines.Split(new[] {" " }, StringSplitOptions.None);

                foreach (var output in outputs)
                {
                    if (output.Length == 2 || output.Length == 3 || output.Length == 4 || output.Length == 7)
                    {
                        numOfDigits++;
                    }
                }
            }
            Console.WriteLine(numOfDigits);
        }

        public static async Task Part2()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();
            var numOfDigits = 0;

            foreach (var line in fileLines)
            {
                var inputLine = line.Split(new[] { "|" }, StringSplitOptions.None)[0];
                var outputLine = line.Split(new[] { "|" }, StringSplitOptions.None)[1];
                var inputs = inputLine.Split(new[] { " " }, StringSplitOptions.None);

                foreach (var input in inputs)
                {

                }
            }
            //var outputs = outputLine.Split(new[] { " " }, StringSplitOptions.None);
            Console.WriteLine(numOfDigits);
        }
    }
}