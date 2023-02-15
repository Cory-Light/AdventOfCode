using Spectre.Console;

namespace AdventOfCodeHelpers.Solver
{
    public abstract class ProblemBase
    {
        public async Task<string> SolvePartOne()
        {
            var partOneResult = await SolvePartOneInternal();

            AnsiConsole.MarkupLine($"[yellow]Part One Result: {partOneResult}.[/]");

            return partOneResult;
        }

        protected abstract Task<string> SolvePartOneInternal();

        public async Task<string> SolvePartTwo()
        {
            var partTwoResult = await SolvePartTwoInternal();

            AnsiConsole.MarkupLine($"[yellow]Part Two Result: {partTwoResult}.[/]");

            return partTwoResult;
        }

        protected abstract Task<string> SolvePartTwoInternal();

        public abstract Task ReadInput();
    }
}
