using AdventOfCodeHelpers.Solver;
using AdventOfCodeHelpers;
using System.Text;
using AdventOfCode;

namespace AdventOfCode
{
    public class Day10 : ProblemBase
    {
        List<String> input = new();
        public override async Task ReadInput()
        {
            input = await new StringFileReader().ReadInputFromFile();
        }

        protected override Task<string> SolvePartOneInternal()
        {
            Task<string> result = Task.FromResult("done");
            foreach (var input in input)
            {
                Console.WriteLine(input);
            }
            return result;
        }

        protected override Task<string> SolvePartTwoInternal()
        {
            throw new NotImplementedException();
        }
    }
}
