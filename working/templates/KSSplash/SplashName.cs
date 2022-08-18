
// The KS.Misc.Splash import is necessary for custom splash routine to work. You can specify ISplash explicitly, but it may reduce the readability of your
// splash code.

using KS.Misc.Splash;

namespace KSCustomSplashTemplate
{
    // Change the SplashName class to your splash name
    public class SplashName : ISplash
    {
        // This is the splash closing flag. When the kernel calls Closing(), it means that you need to set this to true in that routine.
        public bool SplashClosing { get; set; }

        // Choose where do you want to write the progress percentage. Use these values if you're going to print the progress percentage.
        public int ProgressWritePositionX => throw new System.NotImplementedException();
        public int ProgressWritePositionY => throw new System.NotImplementedException();

        // Choose where do you want to write the progress text. Use these values if you're going to print the progress text.
        public int ProgressReportWritePositionX => throw new System.NotImplementedException();
        public int ProgressReportWritePositionY => throw new System.NotImplementedException();

        // If you want your custom splash to display the progress, set this to true. Here, we set it to false. Just implement your progress
        // displaying logic in the Report() sub.
        public bool SplashDisplaysProgress => false;

        // Change this property to your custom splash name
        string ISplash.SplashName => "SplashName";

        public void Opening()
        {
            // Choose how would you like to make an opening transition / intro. The simplest one is clearing the console.
        }

        public void Display()
        {
            // Choose how would you like to display the splash. You could make it report progress once and wait until SplashClosing is true, or you
            // could make it display an animation, e.g. indeterminate progress bar, while the kernel is booting.
        }

        public void Report(int Progress, string ProgressReport, params object[] Vars)
        {
            // Choose how would you like to update the progress report. This can be as simple as updating the area where progress percentage and text
            // is written, or you can increment the progress bar. This is called everytime the kernel makes some progress while booting.
        }

        public void Closing()
        {
            // Choose how would you like to make a closing transition / outro. The simplest one is setting the value of SplashClosing to true and clearing
            // the console.
        }
    }
}

// Refer to https://eoflaoe.github.io/Kernel-Simulator for up-to-date API documentation for splash developers.
