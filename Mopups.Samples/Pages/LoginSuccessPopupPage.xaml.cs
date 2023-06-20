using System.Linq;
using System.Threading.Tasks;
using Mopups.Pages;
using Mopups.Services;

namespace Mopups.Samples.Pages
{
    public partial class LoginSuccessPopupPage : PopupPage
    {
        public LoginSuccessPopupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            HidePopup();
        }

        private async void HidePopup()
        {
            await Task.Delay(4000);

            if (MopupService.Instance.PopupStack.Contains(this))
                await MopupService.Instance.RemovePageAsync(this);
        }
    }
}
