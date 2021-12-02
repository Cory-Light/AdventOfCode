using AdventOfCodeHelpers;

namespace AdventOfCodeDay2
{
    public class Day2
    {
        public static async Task Part1()
        {
            var arr = await new IntFileReader().ReadInputFromFile();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}