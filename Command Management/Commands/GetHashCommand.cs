using System.Text;

namespace Hashy.Commands
{
    public class GetHashCommand : Command
    {
        public GetHashCommand() : base("gethash", "Get the hash string by using a specific algorithm of a UTF-8 input string.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            string algorithm = arguments[0].ToUpper();

            if (!HashingUtils.IsAlgorithmValid(algorithm))
            {
                Console.WriteLine("The specified algorithm is not valid. Please, get the list of all available hashing algorithms via using the command \"getalgorithms\".");
                return;
            }

            Console.WriteLine(HashingUtils.GetHash(Encoding.UTF8.GetBytes(line.Substring(algorithm.Length + 1)), algorithm));
        }
    }
}