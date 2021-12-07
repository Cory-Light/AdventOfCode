using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day7
    {
        public static async Task Part1()
        {
            var horizontalPositions = (await new StringFileReader().ReadInputFromFile()).SelectMany(x => x.Split(',')).Select(x => int.Parse(x)).ToList();

            var minPos = horizontalPositions.Min();
            var maxPos = horizontalPositions.Max();

            List<(int,int)> FuelCost = new();
            var fuelSum = 0;

            foreach (var position in horizontalPositions)
            {
                foreach (var position2 in horizontalPositions)
                {
                    //Console.WriteLine($"Position 1: {position} Position 2: {position2} Difference: {Math.Abs(position - position2)}");
                    fuelSum+= Math.Abs(position - position2);
                }
                //Console.WriteLine(fuelSum);
                FuelCost.Add((fuelSum, position));
                fuelSum = 0;
            }
            var lowest = FuelCost.OrderBy(x => x.Item1).First();
            Console.WriteLine(lowest);
        }
        public static async Task Part2()
        {
            var horizontalPositions = (await new StringFileReader().ReadInputFromFile()).SelectMany(x => x.Split(',')).Select(x => int.Parse(x)).ToList();

            var minPos = horizontalPositions.Min();
            var maxPos = horizontalPositions.Max();

            List<(int, int)> FuelCost = new();
            var fuelSum = 0;

            foreach (var position in horizontalPositions)
            {
                foreach (var position2 in horizontalPositions)
                {
                    //Console.WriteLine($"Position 1: {position} Position 2: {position2} Difference: {Math.Abs(position - position2)}");
                    fuelSum += Math.Abs(position - position2) * (Math.Abs(position - position2) + 1) / 2;
                }
                //Console.WriteLine(fuelSum);
                FuelCost.Add((fuelSum, position));
                fuelSum = 0;
            }
            var lowest = FuelCost.OrderBy(x => x.Item1).First();
            Console.WriteLine(lowest);
        }

        //grabbed from subreddit. Interesting method.
        public static async Task Extra()
        {
            var horizontalPositions = (await new StringFileReader().ReadInputFromFile()).SelectMany(x => x.Split(',')).Select(x => int.Parse(x)).ToList();
            string SolvePart1(string input) => Solve(horizontalPositions, true);
            string SolvePart2(string input) => Solve(horizontalPositions, false);

            string Solve(List<int> input, bool constantFuel)
                => Enumerable.Range(1, input.Max())
                    .Select(i =>
                        (pos: i, fuel: input.Sum(n => constantFuel ? Math.Abs(i - n) : Math.Abs(i - n) * (Math.Abs(i - n) + 1) / 2)))
                    .ToDictionary(i => i.pos)
                    .Min(k => k.Value.fuel)
                    .ToString();
            Console.WriteLine(SolvePart1(Solve(horizontalPositions, true)));
            Console.WriteLine(SolvePart2(Solve(horizontalPositions, false)));
        }
    }
}
