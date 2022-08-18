using KS.Modifications;
using KS.Shell.ShellBase.Commands;
using System.Collections.Generic;

namespace KSModTemplate
{
    public class ModName : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public void InitEvents(string ev)
        {
        }

        public void InitEvents(string ev, params object[] Args)
        {
        }

        public void StartMod()
        {
        }

        public void StopMod()
        {
        }
    }
}

// Refer to https://eoflaoe.github.io/Kernel-Simulator for up-to-date API documentation for mod developers.
