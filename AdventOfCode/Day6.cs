using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day6
    {
        public static async Task Part1()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();
            
            var numListString = fileLines.First().Split('\u002C');
            var fishTimer = new List<int>();
            foreach (var line in numListString)
            {
                fishTimer.Add(int.Parse(line));
            }

            var days = 80;
            var addFishCount = 0;

            for (int i = 0; i < days; i++)
            {
                for (int j = 0; j < fishTimer.Count; j++)
                {
                    if (fishTimer[j] != 0)
                    {
                        fishTimer[j] -= 1;
                    }
                    else
                    {
                        fishTimer[j] = 6;
                        addFishCount++;
                    }
                }
                
                //add new fishies
                for (int j = 0; j < addFishCount; j++)
                {
                    fishTimer.Add(8);
                }
                addFishCount = 0; 
            }

            Console.WriteLine(fishTimer.Count);
        }

        public static async Task Part2()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();

            var numListString = fileLines.First().Split('\u002C');
            var fishTimer = new List<int>();
            foreach (var line in numListString)
            {
                fishTimer.Add(int.Parse(line));
            }

            var days = 256;
            long[] fishLives = new long[9];

            foreach (int i in fishTimer)
            {
                fishLives[i]++;
            }

            foreach (int i in fishLives)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < days; i++)
            {
                var buffer = new long[9];
                for (var j = 0; j < fishLives.Length; j++)
                {
                    if (j == 0)
                    {
                        buffer[6] += fishLives[j];
                        buffer[8] += fishLives[j];
                    }
                    else
                    {
                        buffer[j - 1] += fishLives[j];
                    }
                }

                fishLives = buffer;
            }

            Console.WriteLine(fishLives.Sum());
        }
    }
}