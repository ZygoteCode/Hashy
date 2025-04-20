namespace Hashy.Commands
{
    public class GetCharsCommand : Command
    {
        public GetCharsCommand() : base("getchars", "Get the list of all the chars to use in the combinations generation.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            Console.WriteLine($"Current charset: {Program.GetChars()}\r\nFull charset length: {Program.GetChars().Length}");
        }
    }
}