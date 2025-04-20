namespace Hashy.Commands
{
    public class GetAlgorithmsCommand : Command
    {
        public GetAlgorithmsCommand() : base("getalgorithms", "Get the list of all available hashing algorithms.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            string result = "Here is a full list of all available algorithms:\r\n";
            int i = 0;

            foreach (string algorithm in HashingUtils.GetAlgorithms())
            {
                i++;
                result += $"\r\n[{i}] {algorithm}";
            }

            Console.WriteLine(result);
        }
    }
}