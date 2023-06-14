using Mopups.Pages;
using Mopups.Services;

namespace Mopups.Samples.Extensions;

public static class NavigationExtension
{
    public static Task PushPopupAsync(this INavigation sender, PopupPage page, bool animate = true)
    {
        return MopupService.Instance.PushAsync(page, animate);
    }

    public static Task PopPopupAsync(this INavigation sender, bool animate = true)
    {
        return MopupService.Instance.PopAsync(animate);
    }

    public static Task PopAllPopupAsync(this INavigation sender, bool animate = true)
    {
        return MopupService.Instance.PopAllAsync(animate);
    }

    public static Task RemovePopupPageAsync(this INavigation sender, PopupPage page, bool animate = true)
    {
        return MopupService.Instance.RemovePageAsync(page, animate);
    }
}