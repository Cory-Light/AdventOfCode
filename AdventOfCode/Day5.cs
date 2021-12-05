using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day5
    {
        public static async Task Part1()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();
            var arrSize = 1000;
            int[,] arr = new int[arrSize, arrSize];

            foreach (var line in fileLines)
            {
                //Console.WriteLine($"{line.Split(" -> ")[1]} : {line.Split(" -> ")[1]}");
                var x1 = int.Parse(line.Split(" -> ")[0].Split(",")[0]);
                var x2 = int.Parse(line.Split(" -> ")[1].Split(",")[0]);
                var y1 = int.Parse(line.Split(" -> ")[0].Split(",")[1]);
                var y2 = int.Parse(line.Split(" -> ")[1].Split(",")[1]);
                if (x1 == x2)
                {
                    var tempY = y1;
                    if (y1 > y2)
                    {
                        while (tempY != y2)
                        {
                            arr[x1, tempY]++;
                            tempY--;
                        }
                        arr[x1, tempY]++;
                    }
                    else if (y1 < y2)
                    {
                        while (tempY != y2)
                        {
                            arr[x1, tempY]++;
                            tempY++;
                        }
                        arr[x1, tempY]++;
                    }
                }
                else if (y1 == y2)
                {
                    var tempX = x1;
                    if (x1 > x2)
                    {
                        while (tempX != x2)
                        {
                            arr[tempX, y1]++;
                            tempX--;
                        }
                        arr[tempX, y1]++;
                    }
                    else if (x1 < x2)
                    {
                        while (tempX != x2)
                        {
                            arr[tempX, y1]++;
                            tempX++;
                        }
                        arr[tempX, y1]++;
                    }
                }
            }
            var numberOfHits = 0;
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    if(arr[i, j] >= 2)
                    {
                        numberOfHits++;
                    }
                }
            }
            Console.WriteLine(numberOfHits);
        }

        public static async Task Part2()
        {
            var fileLines = await new StringFileReader().ReadInputFromFile();
            var arrSize = 1000;
            int[,] arr = new int[arrSize, arrSize];

            foreach (var line in fileLines)
            {
                //Console.WriteLine($"{line.Split(" -> ")[1]} : {line.Split(" -> ")[1]}");
                var x1 = int.Parse(line.Split(" -> ")[0].Split(",")[0]);
                var x2 = int.Parse(line.Split(" -> ")[1].Split(",")[0]);
                var y1 = int.Parse(line.Split(" -> ")[0].Split(",")[1]);
                var y2 = int.Parse(line.Split(" -> ")[1].Split(",")[1]);
                if (x1 == x2)
                {
                    var tempY = y1;
                    if (y1 > y2)
                    {
                        while (tempY != y2)
                        {
                            arr[x1, tempY]++;
                            tempY--;
                        }
                        arr[x1, tempY]++;
                    }
                    else if (y1 < y2)
                    {
                        while (tempY != y2)
                        {
                            arr[x1, tempY]++;
                            tempY++;
                        }
                        arr[x1, tempY]++;
                    }
                }
                else if (y1 == y2)
                {
                    var tempX = x1;
                    if (x1 > x2)
                    {
                        while (tempX != x2)
                        {
                            arr[tempX, y1]++;
                            tempX--;
                        }
                        arr[tempX, y1]++;
                    }
                    else if (x1 < x2)
                    {
                        while (tempX != x2)
                        {
                            arr[tempX, y1]++;
                            tempX++;
                        }
                        arr[tempX, y1]++;
                    }
                }
                else
                {
                    var yInc = y1 > y2 ? -1 : 1;
                    var xInc = x1 > x2 ? -1 : 1;

                    var tempX = x1;
                    var tempY = y1;
                    while (tempX != x2 && tempY != y2)
                    {
                        arr[tempX, tempY]++;
                        tempX+= xInc;
                        tempY += yInc;
                    }
                    arr[tempX, tempY]++;
                }
            }
            var numberOfHits = 0;
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    //Console.Write(arr[i, j]);
                    if (arr[i, j] >= 2)
                    {
                        numberOfHits++;
                    }
                }
                //Console.WriteLine();
            }
            Console.WriteLine(numberOfHits);
        }
    }
}