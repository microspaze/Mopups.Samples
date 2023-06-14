using System;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class UserAnimationFromResourcePage
    {
        public UserAnimationFromResourcePage()
        {
            InitializeComponent();
        }


        private void OnClose(object sender, EventArgs e)
        {
            MopupService.Instance.PopAsync();
        }
    }
}
