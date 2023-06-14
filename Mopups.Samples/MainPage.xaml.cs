using Mopups.Services;
using Mopups.Samples.Pages;
using System.Diagnostics;

namespace Mopups.Samples
{
    public partial class MainPage : ContentPage
    {
        private LoginPopupPage _loginPopup;

        public MainPage()
        {
            InitializeComponent();

            MopupService.Instance.Pushing += (sender, e) => Debug.WriteLine($"[Popup] Pushing: {e.Page.GetType().Name}");
            MopupService.Instance.Pushed += (sender, e) => Debug.WriteLine($"[Popup] Pushed: {e.Page.GetType().Name}");
            MopupService.Instance.Popping += (sender, e) => Debug.WriteLine($"[Popup] Popping: {e.Page.GetType().Name}");
            MopupService.Instance.Popped += (sender, e) => Debug.WriteLine($"[Popup] Popped: {e.Page.GetType().Name}");

            _loginPopup = new LoginPopupPage();
        }

        private async void OnOpenPupup(object sender, EventArgs e)
        {
            await MopupService.Instance.PushAsync(_loginPopup);
        }

        private async void OnUserAnimationPupup(object sender, EventArgs e)
        {
            var page = new UserAnimationPage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenSystemOffsetPage(object sender, EventArgs e)
        {
            var page = new SystemOffsetPage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenListViewPage(object sender, EventArgs e)
        {
            var page = new ListViewPage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenUserAnimationFromResource(object sender, EventArgs e)
        {
            var page = new UserAnimationFromResourcePage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenUserAnimationFromStyle(object sender, EventArgs e)
        {
            var page = new UserAnimationFromStylePage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenSettingsPage(object sender, EventArgs e)
        {
            var page = new SettingsPage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnOpenMvvmPage(object sender, EventArgs e)
        {
            var page = new MvvmPage();

            await MopupService.Instance.PushAsync(page);
        }

        private async void OnTestCurrentViewController(object sender, EventArgs e)
        {
            var page = new TestCurrentViewController(0);

            await MopupService.Instance.PushAsync(page);
        }
    }
}