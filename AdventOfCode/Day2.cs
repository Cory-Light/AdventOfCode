using AdventOfCodeHelpers;

namespace AdventOfCode
{
    public class Day2
    {
        public static async Task Part1()
        {
            var arr = await new StringFileReader().ReadInputFromFile();

            var horizontal = 0;
            var vertical = 0; 
            foreach (var item in arr)
            {
                //Console.WriteLine(item);
                var parts = item.Split(' ');
                foreach (var word in parts)
                {
                    if(word == "forward")
                        horizontal+=int.Parse(parts[1]);
                    if(word == "up")
                        vertical-=int.Parse(parts[1]);
                    if(word == "down")
                        vertical+=int.Parse(parts[1]);
                    //Console.WriteLine(word);
                };
                //Console.WriteLine(horizontal);
                //Console.WriteLine(vertical);
            }
            //Console.WriteLine(horizontal);
            //Console.WriteLine(vertical);
            Console.WriteLine($"Part 1 Final answer = {horizontal*vertical}");
        }

        public static async Task Part2()
        {
            var arr = await new StringFileReader().ReadInputFromFile();

            var horizontal = 0;
            var vertical = 0; 
            var aim = 0;
            foreach (var item in arr)
            {
                //Console.WriteLine(item);
                var parts = item.Split(' ');
                foreach (var word in parts)
                {
                    if(word == "forward")
                    {
                        vertical += aim * int.Parse(parts[1]);
                        horizontal+=int.Parse(parts[1]);
                    }
                    if(word == "up")
                    { 
                        aim-=int.Parse(parts[1]);
                    }
                    if(word == "down")
                    {                       
                        aim+=int.Parse(parts[1]);
                    }
                    //Console.WriteLine(word);
                };
                //Console.WriteLine($"Horizonal: {horizontal}");
                //Console.WriteLine($"Vertical: {vertical}");
                //Console.WriteLine($"Aim: {aim}");
                //Console.WriteLine("\n");
            }
            //Console.WriteLine(horizontal);
            //Console.WriteLine(vertical);
            Console.WriteLine($"Part 2 Final answer = {horizontal*vertical}");
        }

    }
}