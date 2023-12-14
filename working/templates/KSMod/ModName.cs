using KS.Modifications;
using System;
using System.Collections.ObjectModel;
using System.Reflection;

namespace NitrocidMod
{
    public class ModName : IMod
    {
        public string Name { get; set; } = "My Mod";
        public string ModPart { get; set; } = "Main";
        public string Version { get; set; } = "1.0.0";

        public Version MinimumSupportedApiVersion => new(3, 0, 25, 377);

        public ReadOnlyDictionary<string, Delegate> PubliclyAvailableFunctions => null;

        public ReadOnlyDictionary<string, PropertyInfo> PubliclyAvailableProperties => null;

        public ReadOnlyDictionary<string, FieldInfo> PubliclyAvailableFields => null;

        public void StartMod()
        {

        }

        public void StopMod()
        {

        }
    }
}

// Refer to https://aptivi.github.io/Kernel-Simulator for up-to-date API documentation for mod developers.
