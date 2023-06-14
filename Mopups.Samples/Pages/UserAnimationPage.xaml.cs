using System;
using Mopups.Pages;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class UserAnimationPage : PopupPage
    {
        public UserAnimationPage()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e)
        {
            MopupService.Instance.PopAsync();
        }
    }
}
