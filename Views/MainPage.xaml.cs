using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Room_Management_Express.Logging;
using Room_Management_Express.ViewModels;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.WinUi3;
using Serilog.Sinks.WinUi3.LogViewModels;
using Serilog.Templates;

namespace Room_Management_Express.Views
{
    public sealed partial class MainPage : Page
    {


        public MainViewModel ViewModel
        {
            get;
        }

        public MainPage()
        {
            ViewModel = App.GetService<MainViewModel>();
            InitializeComponent();
            this.Loaded += async (o, args) => await MainPage_Loaded(o, args); 


        }

        private async Task MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.UI.Xaml.Controls.ContentDialog()
            {
                Title = "Please Authenticate ",
                XamlRoot = this.XamlRoot,
                CloseButtonText = "OK",

            };
            await dlg.ShowAsync();
        }


        
    }
}
