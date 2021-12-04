using AdventOfCodeHelpers;
using System.Text.RegularExpressions;
using static AdventOfCode.Day4.BingoBoard;

namespace AdventOfCode
{
    public class Day4
    {
        public static async Task Part1()
        {
            var arr = await new StringFileReader().ReadInputFromFile();
            var inputList = arr[0].Split(',');
            //Console.WriteLine($"InputNums: {inputList}");
            List<BingoBoard> bingoBoards = new();
            var Row1 = new List<BingoSlot>();
            var Row2 = new List<BingoSlot>();
            var Row3 = new List<BingoSlot>();
            var Row4 = new List<BingoSlot>();
            var Row5 = new List<BingoSlot>();

            for (var i = 2; i < arr.Count; i++)// each row in input
            {
                var it = 0;
                if (arr[i] != "")
                {
                    //Console.WriteLine(arr[i]);
                    var resultString = Regex.Replace(arr[i], @"\s+", ",");
                    //Console.WriteLine($"Just Numbers: {resultString}");
                    var numList = resultString.Split('\u002C');
                    foreach (var num in numList)// each num in row
                    {
                        switch (it)
                        {
                            case 0:
                                {
                                    if (num != "")
                                    {
                                        Row1.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"num: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (num != "")
                                    {
                                        Row2.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row2: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (num != "")
                                    {
                                        Row3.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row3: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (num != "")
                                    {
                                        Row4.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row4: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (num != "")
                                    {
                                        Row5.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row5: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("wtf");
                                    break;
                                }


                        }
                    }
                }
                else
                {
                    //Console.WriteLine("Finishing board.");
                    //foreach (var val in Row1)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row2)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row3)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row4)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row5)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    var newBoard = new BingoBoard(Row1, Row2, Row3, Row4, Row5);
                    //newBoard.Print();
                    bingoBoards.Add(newBoard);
                    Row1 = new List<BingoSlot>();
                    Row2 = new List<BingoSlot>();
                    Row3 = new List<BingoSlot>();
                    Row4 = new List<BingoSlot>();
                    Row5 = new List<BingoSlot>();
                    it = 0;

                }
            }

            RunInputs(bingoBoards, inputList);
        }


        public static async Task Part2()
        {
            var arr = await new StringFileReader().ReadInputFromFile();
            var inputList = arr[0].Split(',');
            //Console.WriteLine($"InputNums: {inputList}");
            List<BingoBoard> bingoBoards = new();
            var Row1 = new List<BingoSlot>();
            var Row2 = new List<BingoSlot>();
            var Row3 = new List<BingoSlot>();
            var Row4 = new List<BingoSlot>();
            var Row5 = new List<BingoSlot>();

            for (var i = 2; i < arr.Count; i++)// each row in input
            {
                var it = 0;
                if (arr[i] != "")
                {
                    //Console.WriteLine(arr[i]);
                    var resultString = Regex.Replace(arr[i], @"\s+", ",");
                    //Console.WriteLine($"Just Numbers: {resultString}");
                    var numList = resultString.Split('\u002C');
                    foreach (var num in numList)// each num in row
                    {
                        switch (it)
                        {
                            case 0:
                                {
                                    if (num != "")
                                    {
                                        Row1.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"num: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (num != "")
                                    {
                                        Row2.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row2: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (num != "")
                                    {
                                        Row3.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row3: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (num != "")
                                    {
                                        Row4.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row4: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (num != "")
                                    {
                                        Row5.Add(new BingoSlot(num, false));
                                        //Console.WriteLine($"Row5: {num}");
                                        it++;
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("wtf");
                                    break;
                                }


                        }
                    }
                }
                else
                {
                    //Console.WriteLine("Finishing board.");
                    //foreach (var val in Row1)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row2)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row3)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row4)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    //foreach (var val in Row5)
                    //{
                    //    Console.Write($"({val.Number}, {val.Marked})");
                    //}
                    //Console.Write("\n");
                    var newBoard = new BingoBoard(Row1, Row2, Row3, Row4, Row5);
                    //newBoard.Print();
                    bingoBoards.Add(newBoard);
                    Row1 = new List<BingoSlot>();
                    Row2 = new List<BingoSlot>();
                    Row3 = new List<BingoSlot>();
                    Row4 = new List<BingoSlot>();
                    Row5 = new List<BingoSlot>();
                    it = 0;

                }
            }

            RunInputsPart2(bingoBoards, inputList);
        }

        private static void RunInputs(List<BingoBoard> bingoBoards, string[] inputList)
        {
            foreach(var input in inputList)
            {
                for (int i = 0; i < bingoBoards.Count; i++)
                {
                    for(int j = 0; j < bingoBoards[i].Row1.Count; j++)
                    {
                        if (bingoBoards[i].Row1[j].Number == input)
                        {
                            bingoBoards[i].Row1[j].Marked = true;
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row2.Count; j++)
                    {
                        if (bingoBoards[i].Row2[j].Number == input)
                        {
                            bingoBoards[i].Row2[j].Marked = true;
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row3.Count; j++)
                    {
                        if (bingoBoards[i].Row3[j].Number == input)
                        {
                            bingoBoards[i].Row3[j].Marked = true;
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row4.Count; j++)
                    {
                        if (bingoBoards[i].Row4[j].Number == input)
                        {
                            bingoBoards[i].Row4[j].Marked = true;
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row5.Count; j++)
                    {
                        if (bingoBoards[i].Row5[j].Number == input)
                        {
                            bingoBoards[i].Row5[j].Marked = true;
                        }
                    }
                    if (bingoBoards[i].CheckWinner(int.Parse(input)))
                    {
                        Console.WriteLine($"RING A DING DONG MOTHER FUCKERS! Winner for input {input}.");
                        bingoBoards[i].ScoreBoard(int.Parse(input));
                        return;
                    }
                    
                }
            }
        }

        private static void RunInputsPart2(List<BingoBoard> bingoBoards, string[] inputList)
        {
            var initialSize = bingoBoards.Count;
            var finishedBoards = new List<BingoBoard>();
            foreach (var input in inputList)
            {
                Console.WriteLine($"Checking for input {input}.");
                for (int i = 0; i < bingoBoards.Count; i++)
                {
                    for (int j = 0; j < bingoBoards[i].Row1.Count; j++)
                    {
                        if (bingoBoards[i].Row1[j].Number == input)
                        {
                            bingoBoards[i].Print();
                            bingoBoards[i].Row1[j].Marked = true;
                            bingoBoards[i].Print();
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row2.Count; j++)
                    {
                        if (bingoBoards[i].Row2[j].Number == input)
                        {
                            bingoBoards[i].Print();
                            bingoBoards[i].Row2[j].Marked = true;
                            bingoBoards[i].Print();
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row3.Count; j++)
                    {
                        if (bingoBoards[i].Row3[j].Number == input)
                        {
                            bingoBoards[i].Print();
                            bingoBoards[i].Row3[j].Marked = true;
                            bingoBoards[i].Print();
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row4.Count; j++)
                    {
                        if (bingoBoards[i].Row4[j].Number == input)
                        {
                            bingoBoards[i].Print();
                            bingoBoards[i].Row4[j].Marked = true;
                            bingoBoards[i].Print();
                        }
                    }
                    for (int j = 0; j < bingoBoards[i].Row5.Count; j++)
                    {
                        if (bingoBoards[i].Row5[j].Number == input)
                        {
                            bingoBoards[i].Print();
                            bingoBoards[i].Row5[j].Marked = true;
                            bingoBoards[i].Print();
                        }
                    }
                    if (bingoBoards[i].CheckWinnerPart2(int.Parse(input)))
                    {
                        if(!finishedBoards.Contains(bingoBoards[i]))
                        {
                            Console.WriteLine("Adding board:");
                            bingoBoards[i].Print();
                            finishedBoards.Add(bingoBoards[i]);
                            bingoBoards.RemoveAt(i);
                            i--;
                        }
                    }

                    //bingoBoards[i].Print();
                }
                Console.WriteLine($"Finished Boards:{finishedBoards.Count} vs All boards {bingoBoards.Count}");
                if(finishedBoards.Count == initialSize)
                {
                    finishedBoards.Last().Print();
                    finishedBoards.Last().ScoreBoard(int.Parse(input));
                    return;
                }
            }
        }

        public class BingoBoard
        {
            public BingoBoard(List<BingoSlot> Row1Input, List<BingoSlot> Row2Input, List<BingoSlot> Row3Input, List<BingoSlot> Row4Input, List<BingoSlot> Row5Input)
            {
                Row1 = Row1Input;
                Row2 = Row2Input;
                Row3 = Row3Input;
                Row4 = Row4Input;
                Row5 = Row5Input;
            }
            public class BingoSlot
            {
                public BingoSlot(string number,bool marked)
                {
                    Number = number;
                    Marked = marked;
                }
                public string Number = "";
                public bool Marked = false;
            }

            public void Print()
            {
                Console.Write("Board Row1:");
                foreach (var num in Row1)
                {
                    Console.Write($"({num.Number}, {num.Marked})");
                }
                Console.Write("\n");

                Console.Write("Board Row2:");
                foreach (var num in Row2)
                {
                    Console.Write($"({num.Number}, {num.Marked})");
                }
                Console.Write("\n");

                Console.Write("Board Row3:");
                foreach (var num in Row3)
                {
                    Console.Write($"({num.Number}, {num.Marked})");
                }
                Console.Write("\n");

                Console.Write("Board Row4:");
                foreach (var num in Row4)
                {
                    Console.Write($"({num.Number}, {num.Marked})");
                }
                Console.Write("\n");

                Console.Write("Board Row5:");
                foreach (var num in Row5)
                {
                    Console.Write($"({num.Number}, {num.Marked})");
                }
                Console.WriteLine("\n");
            }

            public bool CheckWinner(int input)
            {
                if(this.Row1.All(r => r.Marked == true))
                {
                    Console.WriteLine("Winner board at row 1");
                    this.Print();
                    this.ScoreBoard(input);
                    return true;
                }
                else if (this.Row2.All(r => r.Marked == true))
                {
                    Console.WriteLine("Winner board at row 2");
                    this.Print();
                    this.ScoreBoard(input);
                    return true;
                }
                else if (this.Row3.All(r => r.Marked == true))
                {
                    Console.WriteLine("Winner board at row 3");
                    this.Print();
                    this.ScoreBoard(input);
                    return true;
                }
                else if (this.Row4.All(r => r.Marked == true))
                {
                    Console.WriteLine("Winner board at row 4");
                    this.Print();
                    this.ScoreBoard(input);
                    return true;
                }
                else if (this.Row5.All(r => r.Marked == true))
                {
                    Console.WriteLine("Winner board at row 5");
                    this.Print();
                    this.ScoreBoard(input);
                    return true;
                }
                else
                {
                    for (int i = 0; i < Row1.Count; i++)
                    {
                        if(Row1[i].Marked == true && Row2[i].Marked == true && Row3[i].Marked == true && Row4[i].Marked == true && Row5[i].Marked == true)
                        {
                            Console.WriteLine($"Winner board at column {i}");
                            this.Print();
                            return true;
                        }
                    }
                    return false;
                }
            }
            public bool CheckWinnerPart2(int input)
            {
                if (this.Row1.All(r => r.Marked == true))
                {
                    return true;
                }
                else if (this.Row2.All(r => r.Marked == true))
                {
                    return true;
                }
                else if (this.Row3.All(r => r.Marked == true))
                {
                    return true;
                }
                else if (this.Row4.All(r => r.Marked == true))
                {
                    return true;
                }
                else if (this.Row5.All(r => r.Marked == true))
                {
                    return true;
                }
                else
                {
                    for (int i = 0; i < Row1.Count; i++)
                    {
                        if (Row1[i].Marked == true && Row2[i].Marked == true && Row3[i].Marked == true && Row4[i].Marked == true && Row5[i].Marked == true)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            public void ScoreBoard(int finalInput)
            {
                var uncheckedScore = 0;
                foreach(var num in this.Row1)
                {
                    if(num.Marked == false)
                    {
                        uncheckedScore += int.Parse(num.Number);
                    }
                }
                foreach (var num in this.Row2)
                {
                    if (num.Marked == false)
                    {
                        uncheckedScore += int.Parse(num.Number);
                    }
                }
                foreach (var num in this.Row3)
                {
                    if (num.Marked == false)
                    {
                        uncheckedScore += int.Parse(num.Number);
                    }
                }
                foreach (var num in this.Row4)
                {
                    if (num.Marked == false)
                    {
                        uncheckedScore += int.Parse(num.Number);
                    }
                }
                foreach (var num in this.Row5)
                {
                    if (num.Marked == false)
                    {
                        uncheckedScore += int.Parse(num.Number);
                    }
                }
                Console.WriteLine($"UncheckedScore: {uncheckedScore}");
                Console.WriteLine($"Final Input: {finalInput}");
                Console.WriteLine($"Board Score: {uncheckedScore * finalInput}");
            }

            public List<BingoSlot> Row1 { get; set; }
            public List<BingoSlot> Row2 { get; set; }
            public List<BingoSlot> Row3 { get; set; }
            public List<BingoSlot> Row4 { get; set; }
            public List<BingoSlot> Row5 { get; set; }
        }

    }
}