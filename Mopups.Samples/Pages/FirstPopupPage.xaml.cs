using System;
using System.Threading.Tasks;
using Mopups.Pages;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class FirstPopupPage : PopupPage
    {
        public FirstPopupPage()
        {
            InitializeComponent();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await MopupService.Instance.PopAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return Content.FadeTo(0.5);
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return Content.FadeTo(1);
        }
    }
}
