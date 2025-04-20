namespace Hashy.Commands
{
    public class SetCharsCommand : Command
    {
        public SetCharsCommand() : base("setchars", "Set the list of all the chars to use in the combinations generation.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            Program.SetChars(line);
            Console.WriteLine($"Succesfully changed the charset. Amount of characters: {Program.GetChars().Length}.");
        }
    }
}