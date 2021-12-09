using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day9
    {
        static int arrSizeX = 0;
        static int arrSizeY = 0;
        static List<Coordinates> handledCoords = new();
        public static async Task Part1()
        {
            var fileLines = await new CharArrayFileReader().ReadInputFromFile();
            arrSizeX = fileLines.First().Length;
            arrSizeY = fileLines.Count;
            int[,] arr = new int[arrSizeX, arrSizeY];
            var yVal = 0;

            foreach (var line in fileLines)
            {
                for (int i = 0; i < arrSizeX; i++)
                {
                    var value = line[i] - '0';
                    arr[i, yVal] = value;
                }
                yVal++;
            }
            //Print(arr);
            CheckForLowest(arr);
        }
        public static List<Coordinates> CheckForLowest(int[,] arr)
        {
            var listOfLowest = new List<int>();
            List<Coordinates> cords = new();
            for (int y = 0; y < arrSizeY; y++)
            {
                for (int x = 0; x < arrSizeX; x++)
                {
                    //Console.WriteLine(x);
                    if (x == 0 && y == 0) //1
                    {
                        if (arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (y == 0 && x != arrSizeX - 1) //2
                    {
                        if (arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (x == arrSizeX - 1 && y == 0) // 3
                    {
                        if (arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (x == 0 && y != arrSizeY - 1) //4
                    {
                        if (arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x, y - 1] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (x == arrSizeX - 1) //5
                    {
                        if (arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x, y - 1] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if ((y == arrSizeY - 1) && (x == 0)) //6
                    {
                        if (arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x, y - 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (y == arrSizeY - 1) //7
                    {
                        if (arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x, y - 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else if (x == arrSizeY - 1 && y == arrSizeX - 1) //8
                    {
                        if (arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x, y - 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                    else
                    {
                        if (arr[x, y] < arr[x + 1, y] && arr[x, y] < arr[x - 1, y] && arr[x, y] < arr[x, y - 1] && arr[x, y] < arr[x, y + 1])
                        {
                            //Console.WriteLine($"Adding {arr[x, y]} to lowest number list.");
                            listOfLowest.Add(arr[x, y] + 1);
                            cords.Add(new Coordinates(x, y));
                        }
                    }
                }
            }
            Console.WriteLine($"The sum is {listOfLowest.Sum()}");
            return cords;
        }

        public static void Print(int[,] arr)
        {
            for (int y = 0; y < arrSizeY; y++)
            {
                for (int x = 0; x < arrSizeX; x++)
                {
                    Console.Write(arr[x, y]);
                }
                Console.WriteLine();
            }
        }

        public static async Task Part2()
        {
            var fileLines = await new CharArrayFileReader().ReadInputFromFile();
            arrSizeX = fileLines.First().Length;
            arrSizeY = fileLines.Count;
            int[,] arr = new int[arrSizeX, arrSizeY];
            var yVal = 0;

            foreach (var line in fileLines)
            {
                for (int i = 0; i < arrSizeX; i++)
                {
                    var value = line[i] - '0';
                    arr[i, yVal] = value;
                }
                yVal++;
            }
            //Print(arr);
            var cords = CheckForLowest(arr);
            foreach (var c in cords)
            {
                Console.WriteLine($"X: {c.xVal} Y: {c.yVal}");
            }
            var basinList = FindBasins(cords, arr);
            foreach (var basin in basinList)
            {
                Console.WriteLine(basin.Item2);
            }
            Console.WriteLine($"The product of basins is {basinList.Aggregate(1, (acc, val) => acc * val.Item2)}");

        }

        public static IEnumerable<(Coordinates, int)> FindBasins(List<Coordinates> cords, int[,] arr)
        {
            var basinList = new List<(Coordinates, int)>();
            foreach (var c in cords)
            {
                var bSize = CheckCoords(c, arr);
                Console.WriteLine($"BasinSize for cord X: {c.xVal} Y: {c.yVal} is {bSize}");
                basinList.Add((c, bSize));
                handledCoords = new List<Coordinates>();
            }
            var top3 = basinList.OrderByDescending(i => i.Item2).Take(3);
            return top3;
        }
        public static int CheckCoords(Coordinates cord, int[,] arr)
        {
            Console.WriteLine($"Running CheckCords on cord X: {cord.xVal} Y: {cord.yVal}");
            if (!handledCoords.Any(c => c.xVal == cord.xVal && c.yVal == cord.yVal))
            {
                handledCoords.Add(cord);
                var size = 1;
                if (cord.xVal != 0 && arr[cord.xVal - 1, cord.yVal] > arr[cord.xVal, cord.yVal] && arr[cord.xVal - 1, cord.yVal] != 9 && !handledCoords.Contains(new Coordinates(cord.xVal - 1, cord.yVal)))
                {
                    size += CheckCoords(new Coordinates(cord.xVal -1, cord.yVal), arr);
                }
                if (cord.xVal != arrSizeX - 1 && arr[cord.xVal + 1, cord.yVal] > arr[cord.xVal, cord.yVal] && arr[cord.xVal + 1, cord.yVal] != 9 && !handledCoords.Contains(new Coordinates(cord.xVal + 1, cord.yVal)))
                {
                    size += CheckCoords(new Coordinates(cord.xVal + 1, cord.yVal), arr);
                }
                if (cord.yVal != 0 && arr[cord.xVal, cord.yVal - 1] > arr[cord.xVal, cord.yVal] && arr[cord.xVal, cord.yVal - 1] != 9 && !handledCoords.Contains(new Coordinates(cord.xVal, cord.yVal - 1)))
                {
                    size += CheckCoords(new Coordinates(cord.xVal, cord.yVal - 1), arr);
                }
                if (cord.yVal != arrSizeY - 1 && arr[cord.xVal, cord.yVal + 1] > arr[cord.xVal, cord.yVal] && arr[cord.xVal, cord.yVal + 1] != 9 && !handledCoords.Contains(new Coordinates(cord.xVal, cord.yVal + 1)))
                {
                    size += CheckCoords(new Coordinates(cord.xVal, cord.yVal + 1), arr);
                }
                return size;
            }
            return 0;
        }

        public class Coordinates
        {
            public Coordinates(int x, int y)
            {
                xVal = x;
                yVal = y;
            }

            readonly public int xVal;
            readonly public int yVal;
        }
    }
}