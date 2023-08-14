
// The KS.Misc.Screensaver import is necessary for mod routine to work. You can specify IScreensaver explicitly, but it may reduce the readability of your
// screensaver code.

using KS.Misc.Screensaver;
using System.Collections.Generic;

namespace KSScreensaverTemplate
{
    // Change the ScreensaverNameDisp class to your screensaver name
    public class ScreensaverNameDisp : BaseScreensaver, IScreensaver
    {
        public override string ScreensaverName { get; set; }
        public override Dictionary<string, object> ScreensaverSettings { get; set; }
        public override bool ScreensaverContainsFlashingImages { get; set; }

        public override void ScreensaverSeizureWarning()
        {
            // You can customize how the seizure warning will display here. Usually, you can just remove the override to use the default style.
        }

        public override void ScreensaverPreparation()
        {
            // Statements written here will be executed when the screensaver gets initialized. They usually get executed before the screensaver
            // logic starts. This usually contains variable initialization and screen clearing.
        }

        public override void ScreensaverLogic()
        {
            // All of the drawing statements must be done here. These statements are executed inside the loop of the custom screensaver.
        }

        public override void ScreensaverOutro()
        {
            // Statements written here will be executed when the screensaver gets finalized. They usually get executed before the screensaver
            // logic exits. This usually contains variable resets.
        }
    }
}

// Refer to https://aptivi.github.io/Kernel-Simulator for up-to-date API documentation for screensaver developers.
