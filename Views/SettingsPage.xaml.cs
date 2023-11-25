using Microsoft.UI.Xaml.Controls;

using Room_Management_Express.ViewModels;

namespace Room_Management_Express.Views
{
    // TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
    public sealed partial class SettingsPage : Page
    {
        public SettingsViewModel ViewModel
        {
            get;
        }

        public SettingsPage()
        {
            ViewModel = App.GetService<SettingsViewModel>();
            InitializeComponent();
        }
    }
}
