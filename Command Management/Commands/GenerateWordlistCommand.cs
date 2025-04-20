namespace Hashy.Commands
{
    public class GenerateWordlistCommand : Command
    {
        public GenerateWordlistCommand() : base("generatewordlist", new string[] { "length" }, "Generate a word-list of all possible characters combinations by specified length.") { }

        private int _numChars;
        private string _chars;
        private string _result;

        public override void ProcessCommand(string[] arguments, string line)
        {
            _result = "";
            string maxLengthStr = arguments[0];

            if (!uint.TryParse(maxLengthStr, out uint maxLength))
            {
                Console.WriteLine("The \"length\" parameter must be numeric.");
                return;
            }

            if (File.Exists("wordlist.txt"))
            {
                File.Delete("wordlist.txt");
            }

            _numChars = (int)maxLength;
            _chars = Program.GetChars();

            Console.WriteLine("Generating your word-list, please wait a while.");
            GenerateCombinations("", 0);

            File.WriteAllText("wordlist.txt", _result);
            Console.WriteLine("Succesfully generated your word-list. The output is in the file named \"wordlist.txt\".");
        }

        private void GenerateCombinations(string prefix, int level)
        {
            if (level == _numChars)
            {
                _result += $"\r\n{prefix}";
                return;
            }

            foreach (char c in _chars)
            {
                GenerateCombinations(prefix + c, level + 1);
            }
        }
    }
}