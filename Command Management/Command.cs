public abstract class Command
{
    public string Name { get; set; }
    public string[] Arguments { get; set; }
    public string? Description { get; set; }

    public Command(string name, string description)
    {
        Name = name;
        Arguments = new string[] { };
        Description = description;
    }

    public Command(string name, string[] arguments)
    {
        Name = name;
        Arguments = arguments;
    }

    public Command(string name, string[] arguments, string description) : this(name, arguments)
    {
        Description = description;
    }

    public abstract void ProcessCommand(string[] arguments, string line);
}