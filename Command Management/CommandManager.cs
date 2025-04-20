using System.Reflection;

public class CommandManager
{
    private List<Command> _commands;

    public CommandManager()
    {
        _commands = new List<Command>();
        InitializeCommands();
    }

    private void InitializeCommands()
    {
        // The best way!
        string commandsNamespace = "Hashy.Commands";

        IEnumerable<Type> commandTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.Namespace == commandsNamespace && type.IsSubclassOf(typeof(Command)));

        _commands = commandTypes.Select(type => (Command)Activator.CreateInstance(type)).ToList();

        /*_commands.Add(new HelpCommand());
        _commands.Add(new GenerateWordlistCommand());
        _commands.Add(new GenerateCompleteWordlistCommand());
        _commands.Add(new SetCharsCommand());
        _commands.Add(new GetCharsCommand());
        _commands.Add(new LoadWordlistCommand());
        _commands.Add(new GetAlgorithmsCommand());
        _commands.Add(new GetHashCommand());*/
    }

    private void ThrowUnrecognizedCommand()
    {
        Console.WriteLine("Unrecognized command. Please, type \"help\" to get the list of all available commands.");
    }

    private void ThrowBadArguments()
    {
        Console.WriteLine("Please, specify all the required arguments for that command.");
    }

    public List<Command> GetCommands()
    {
        return _commands;
    }

    public void ProcessCommand(string? command)
    {
        if (command == null || command.Length == 0 || command.Replace(" ", "").Replace('\t'.ToString(), "").Length == 0)
        {
            ThrowUnrecognizedCommand();
            return;
        }

        string baseCommand, line = "";
        string[] arguments = new string[] { };

        if (command.Contains(" "))
        {
            baseCommand = command.Split(' ')[0];
            line = command.Substring(baseCommand.Length + 1);
            arguments = line.Split(" ");
        }
        else
        {
            baseCommand = command;
        }

        foreach (Command cmd in _commands)
        {
            if (cmd.Name.Equals(baseCommand))
            {
                if (cmd.Arguments.Length != 0 && cmd.Arguments.Length != arguments.Length)
                {
                    ThrowBadArguments();
                    return;
                }

                cmd.ProcessCommand(arguments, line);
                return;
            }
        }

        ThrowUnrecognizedCommand();
    }
}