using AdventOfCodeHelpers.Solver;
using AdventOfCodeHelpers;
using System.Text;
using AdventOfCode;
using AdventOfCodeHelpers.MapHelpers;
using Spectre.Console;
using AdventOfCodeHelpers.ArrayHelpers;

namespace AdventOfCode
{
    public class Day11 : ProblemBase
    {
        Cave? newCave;
        public override async Task ReadInput()
        {
            var octoList = await new OctopusReader().ReadInputFromFile();

            var octoArray = octoList.To2DArray();

            //_2DArrayExtensions.Draw<Octopus[]>(octoArray, (octo, string) => octo.

            //newCave = new Cave(octoArray);
        }

        protected override Task<string> SolvePartOneInternal()
        {
            Task<string> result = Task.FromResult("done");
            //foreach (var input in input)
            //{
            //    Console.WriteLine(input);
            //}
            return result;
        }

        protected override Task<string> SolvePartTwoInternal()
        {
            throw new NotImplementedException();
        }
    }


    class Cave
    {
        public Cave(Octopus[,] map)
        {
            CaveMap = map;
            AllOctopus = map.Cast<Octopus>()
                            .ToArray();
            NeighborMap = new Dictionary<Octopus, List<Octopus>>();
        }

        public Octopus[,] CaveMap { get; }

        public Octopus[] AllOctopus { get; }

        public Dictionary<Octopus, List<Octopus>> NeighborMap { get; }

        private List<Octopus> GetNeighbors(Octopus octopus)
        {
            if (NeighborMap.ContainsKey(octopus))
            {
                return NeighborMap[octopus];
            }

            var validNeighbors = octopus.Coordinate.GetNeighbors(true)
                                        .Where(coord => CaveMap.IsValidCoordinate(coord))
                                        .Select(coord => CaveMap[coord.X,
                                                                 coord.Y])
                                        .ToList();

            NeighborMap[octopus] = validNeighbors;

            return validNeighbors;
        }

        public int CalculateNumberOfFlashes(int turnsToRun)
        {
            var totalFlashes = 0;

            for (var i = 0; i < turnsToRun; i++)
            {
                //CaveMap.Draw(x => x.EnergyLevel.ToString());

                totalFlashes += RunTurn(out _);
            }

            return totalFlashes;
        }

        public int CalculateSyncTurn()
        {
            var turn = 0;

            while (true)
            {
                turn++;

                RunTurn(out var isSync);

                if (isSync)
                {
                    return turn;
                }

                if (turn % 100 == 0)
                {
                    AnsiConsole.MarkupLine($"[blue]Passing turn {turn}[/].");
                }
            }
        }

        private const int FlashLevel = 9;

        private int RunTurn(out bool sync)
        {
            var flashedThisTurn = new HashSet<Octopus>();

            foreach (var octopus in AllOctopus)
            {
                octopus.EnergyLevel += 1;
            }

            while (true)
            {
                var flashed = AllOctopus.Where(x => x.EnergyLevel > FlashLevel && !flashedThisTurn.Contains(x))
                                        .ToList();

                if (flashed.Count == 0)
                {
                    break;
                }

                flashed.ForEach(x =>
                {
                    var neighbors = GetNeighbors(x);

                    neighbors.ForEach(x => x.EnergyLevel += 1);

                    flashedThisTurn.Add(x);
                });
            }

            flashedThisTurn.ToList()
                           .ForEach(x => x.EnergyLevel = 0);

            sync = flashedThisTurn.Count == AllOctopus.Length;

            return flashedThisTurn.Count;
        }
    }

    class OctopusReader : FileReader<Octopus[]>
    {
        private int currentRow = 0;

        protected override Octopus[] ProcessLineOfFile(string line)
        {
            var energyLevels = line.ToCharArray()
                                  .Select(x => int.Parse(x.ToString()))
                                  .ToArray();

            var nextRow = new Octopus[energyLevels.Length];

            for (var x = 0; x < energyLevels.Length; x++)
            {
                nextRow[x] = new Octopus(new Coordinate(x,
                                                        currentRow))
                {
                    EnergyLevel = energyLevels[x]
                };
            }

            currentRow++;

            return nextRow;
        }
    }

    class Octopus : ObjectWithCoordinateEquality
    {
        public int EnergyLevel { get; set; }

        public Octopus(Coordinate coordinate)
            : base(coordinate)
        {
        }
    }
}
