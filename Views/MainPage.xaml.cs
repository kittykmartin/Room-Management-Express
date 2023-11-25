using Microsoft.UI;
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


        }




    }
}
