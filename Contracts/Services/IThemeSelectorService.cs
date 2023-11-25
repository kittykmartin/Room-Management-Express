using Microsoft.UI.Xaml;

namespace Room_Management_Express.Contracts.Services
{
    public interface IThemeSelectorService
    {
        ElementTheme Theme
        {
            get;
        }

        Task InitializeAsync();

        Task SetThemeAsync(ElementTheme theme);

        Task SetRequestedThemeAsync();
    }
}
