using KS.Misc.Splash;
using System;

namespace NitrocidSplash
{
    public class MySplash : BaseSplash, ISplash
    {
        // Standalone splash information
        /// <inheritdoc/>
        public override string SplashName => "MyCustomSplash";

        // Property implementations
        /// <inheritdoc/>
        public override bool SplashClosing { get; set; }

        /// <inheritdoc/>
        public override bool SplashDisplaysProgress => false;

        // Actual logic
        /// <inheritdoc/>
        public override string Opening(SplashContext context) =>
            "";

        /// <inheritdoc/>
        public override string Display(SplashContext context) =>
            "";

        /// <inheritdoc/>
        public override string Closing(SplashContext context, out bool delayRequired)
        {
            delayRequired = false;
            return "";
        }

        /// <inheritdoc/>
        public override string Report(int Progress, string ProgressReport, params object[] Vars) =>
            "";

        /// <inheritdoc/>
        public override string ReportWarning(int Progress, string WarningReport, Exception ExceptionInfo, params object[] Vars) =>
            "";

        /// <inheritdoc/>
        public override string ReportError(int Progress, string ErrorReport, Exception ExceptionInfo, params object[] Vars) =>
            "";
    }
}

// Refer to https://aptivi.github.io/Kernel-Simulator for up-to-date API documentation for splash developers.
