public class Program
{
    private const string ProgramName = "Hashy";
    private const string ProgramAuthor = "https://github.com/GabryB03/";
    private static CommandManager? _commandManager;
    private static string _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789\\|!\"`£$%€/()=?'ì^<>,;.:-_òç@èé[{+*]}ù§~&# " + '\t'.ToString();
    private static List<string> _wordlist = new List<string>();

    public static void Main()
    {
        _commandManager = new CommandManager();
        Console.Title = $"{ProgramName} | Made by {ProgramAuthor}";
        Console.WriteLine($"Welcome to {ProgramName}. Please, type \"help\" to get the list of available commands.");

        while (true)
        {
            Console.Write("> ");
            string? command = Console.ReadLine();
            ProcessCommand(command);
        }
    }

    public static void ProcessCommand(string command)
    {
        command = command.ToLower();
        _commandManager?.ProcessCommand(command);
    }

    public static CommandManager GetCommandManager()
    {
        return _commandManager;
    }

    public static string GetChars()
    {
        return _chars;
    }

    public static void SetChars(string chars)
    {
        _chars = chars;
    }

    public static void LoadWordlist()
    {
        _wordlist = new List<string>();

        foreach (string line in File.ReadAllLines("wordlist.txt"))
        {
            if (line != "")
            {
                _wordlist.Add(line);
            }
        }
    }

    public static int GetWordlistCount()
    {
        return _wordlist.Count;
    }
}