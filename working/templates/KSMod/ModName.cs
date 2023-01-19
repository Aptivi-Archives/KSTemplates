using KS.Kernel.Events;
using KS.Modifications;
using KS.Shell.ShellBase.Commands;
using System;
using System.Collections.Generic;

namespace KSModTemplate
{
    public class ModName : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public Version MinimumSupportedApiVersion => new(3, 0, 25, 0);

        public void InitEvents(EventType Event)
        {

        }

        public void InitEvents(EventType Event, params object[] Args)
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
