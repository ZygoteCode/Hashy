namespace Hashy.Commands
{
    public class LoadWordlistCommand : Command
    {
        public LoadWordlistCommand() : base("loadwordlist", "Load a new wordlist, by using the \"wordlist.txt\" file.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            if (!File.Exists("wordlist.txt"))
            {
                Console.WriteLine("The file \"wordlist.txt\" does not exist.");
                return;
            }

            Program.LoadWordlist();
            Console.WriteLine($"Succesfully loaded your wordlist. Loaded words count: {Program.GetWordlistCount()}.");
        }
    }
}