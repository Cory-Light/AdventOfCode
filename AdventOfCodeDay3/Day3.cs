using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day3
    {
        public static async Task Part1()
        {
            var gammaSequence = "";
            var epsilonSequence = "";
            
            var arr = await new StringFileReader().ReadInputFromFile();
            foreach (var item in arr)
            {
                for(int i = 0; i < item.Length; i++)
                {
                    var numOf0 = 0;
                    var numOf1 = 0;
                    for(int j = 0; j < arr.Count; j++)
                    {
                        var test = arr[j][i];
                        if (test == '0')
                        {
                            numOf0++;
                        }
                        else if (test == '1')
                        {
                            numOf1++;
                        }
                        Console.WriteLine(test);
                    }
                    gammaSequence += numOf1 > numOf0 ? "1" : "0";
                    epsilonSequence += numOf1 > numOf0 ? "0" : "1";
                    Console.WriteLine($"There are {numOf0} zeros");
                    Console.WriteLine($"There are {numOf1} ones");
                    Console.WriteLine("\n");
                }
                Console.WriteLine($"The gamma sequence is {gammaSequence}");
                Console.WriteLine($"The epsilon sequence is {epsilonSequence}");
                break;
            }
        }

        //Doesnt get the right ones
        public static async Task Part2()
        {
            var arr = await new StringFileReader().ReadInputFromFile();
            var oxygenList = SortArrayAtIndexForOxygen(arr, 0);
            var CO2List = SortArrayAtIndexForCO2(arr, 0);
            Console.WriteLine(oxygenList);
            Console.WriteLine(CO2List);
        }

        public static string SortArrayAtIndexForOxygen(List<string> array, int index)
        {
            Console.WriteLine($"Starting to sort at index {index} for Oxygen.");
            var newList = new List<string>();
            var numOf0 = 0;
            var numOf1 = 0;
            for (int j = 0; j < array.Count; j++)
            {
                var test = array[j][index];
                if (test == '0')
                {
                    numOf0++;
                }
                else if (test == '1')
                {
                    numOf1++;
                }
            }
            Console.WriteLine($"There are {numOf0} zeros");
            Console.WriteLine($"There are {numOf1} ones \n");
            var searchNumber = numOf1 >= numOf0 ? '1' : '0';
            Console.WriteLine($"Searching Number is {searchNumber}.\n");
            foreach (var item in array)
            {
                if (item[index] == searchNumber)
                {
                    newList.Add(item);
                }
            }
            Console.WriteLine("New List");
            foreach (var item in newList)
            {
                Console.WriteLine(item + "\n");
            }

            if (newList.Count == 1)
            {
                return newList.First();
            }
            return SortArrayAtIndexForOxygen(newList, index + 1);
        }
        public static string SortArrayAtIndexForCO2(List<string> array, int index)
        {
            Console.WriteLine($"Starting to sort at index {index} for CO2.");
            var newList = new List<string>();
            var numOf0 = 0;
            var numOf1 = 0;
            for (int j = 0; j < array.Count; j++)
            {
                var test = array[j][index];
                if (test == '0')
                {
                    numOf0++;
                }
                else if (test == '1')
                {
                    numOf1++;
                }
            }
            Console.WriteLine($"There are {numOf0} zeros");
            Console.WriteLine($"There are {numOf1} ones \n");
            var searchNumber = numOf1 >= numOf0 ? '0' : '1';
            Console.WriteLine($"Searching Number is {searchNumber}.");
            foreach (var item in array)
            {
                if (item[index] == searchNumber)
                {
                    newList.Add(item);
                }
            }
            Console.WriteLine("New List");
            foreach (var item in newList)
            {
                Console.WriteLine(item + "\n");
            }

            if (newList.Count == 1)
            {
                return newList.First();
            }
            return SortArrayAtIndexForCO2(newList, index + 1);
        }
    }
}