
// The KS.Shell.ShellBase import is necessary for the class implementation to work.

using KS.Shell.ShellBase.Commands;

namespace KSModTemplate
{
    // Change the Command2 class to your command name
    internal class Command2 : CommandExecutor, ICommand
    {
        public override void Execute(string StringArgs, string[] ListArgs, string[] ListArgsOnly, string[] ListSwitchesOnly)
        {
            // Here you can write statements about what happens when a mod command is executed. The arguments are split automatically by
            // the shell, so you don't need to split the yourself. In case they don't fit your needs, here's a string literal version
            // of the passed arguments, StringArgs, which you can split it yourself.
        }
    }
}
