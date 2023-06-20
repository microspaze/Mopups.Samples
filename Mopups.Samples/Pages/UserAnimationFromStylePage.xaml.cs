using System;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class UserAnimationFromStylePage
    {
        public UserAnimationFromStylePage()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e)
        {
            MopupService.Instance.PopAsync();
        }
    }
}
