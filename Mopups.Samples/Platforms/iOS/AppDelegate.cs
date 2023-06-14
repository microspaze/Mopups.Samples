using Foundation;
using Microsoft.Maui.LifecycleEvents;
using UIKit;

namespace Mopups.Samples
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp()
        {
            return MauiProgram.CreateMauiApp();
        }
    }
}