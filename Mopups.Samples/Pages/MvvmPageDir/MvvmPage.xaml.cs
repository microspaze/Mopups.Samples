using System;
using Mopups.Pages;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class MvvmPage : PopupPage
    {
        public MvvmPage()
        {
            InitializeComponent();
            BindingContext = new MvvmPageViewModel();
        }

        private void OnClose(object sender, EventArgs e)
        {
            MopupService.Instance.PopAsync();
        }
    }
}
