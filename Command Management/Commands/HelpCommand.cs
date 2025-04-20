namespace Hashy.Commands
{
    public class HelpCommand : Command
    {
        public HelpCommand() : base("help", "Get the list of all available commands.") { }

        public override void ProcessCommand(string[] arguments, string line)
        {
            string result = "Here is a full list of all available commands:\r\n";

            foreach (Command command in Program.GetCommandManager().GetCommands())
            {
                result += $"\r\n! {command.Name}";
                string theArguments = "";

                if (command.Arguments.Length != 0)
                {
                    foreach (string argument in command.Arguments)
                    {
                        if (theArguments == "")
                        {
                            theArguments = $"<{argument}>";
                        }
                        else
                        {
                            theArguments += $" <{argument}>";
                        }
                    }

                    result += $" {theArguments}";
                }

                if (command.Description != null)
                {
                    result += $" - {command.Description}";
                }
            }

            Console.WriteLine(result);
        }
    }
}