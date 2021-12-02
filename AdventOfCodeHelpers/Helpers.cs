namespace AdventOfCodeHelpers
{
    public abstract class FileReader<TOutput>
    {
        #region Instance Methods

        public async Task<List<TOutput>> ReadInputFromFile()
        {
            await using var file = File.OpenRead("C:\\Users\\clight\\Documents\\GitHub\\AdventOfCode\\AdventOfCodeHelpers\\Day2Input.txt");
            using var reader = new StreamReader(file);

            var outputs = new List<TOutput>();

            while (!reader.EndOfStream)
            {
                var nextLine = await reader.ReadLineAsync();

                if(nextLine != null)
                {
                    var output = ProcessLineOfFile(nextLine);
                    outputs.Add(output);
                }

            }

            return outputs;
        }

        protected abstract TOutput ProcessLineOfFile(string line);

        #endregion
    }

    public class IntFileReader : FileReader<int>
    {
        #region Instance Methods

        protected override int ProcessLineOfFile(string line)
        {
            return int.Parse(line);
        }

        #endregion
    }
    public class StringFileReader : FileReader<string>
    {
        #region Instance Methods

        protected override string ProcessLineOfFile(string line)
        {
            return (line);
        }

        #endregion
    }
}