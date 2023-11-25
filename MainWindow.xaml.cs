using Microsoft.UI;
using Room_Management_Express.Helpers;
using Windows.UI.ViewManagement;

namespace Room_Management_Express
{
    public sealed partial class MainWindow : WinUIEx.WindowEx
    {
        private Microsoft.UI.Dispatching.DispatcherQueue dispatcherQueue;

        private UISettings settings;

        public MainWindow()
        {
            InitializeComponent();

            AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
            Content = null;
            Title = "AppDisplayName".GetLocalized();


            // Theme change code picked from https://github.com/microsoft/WinUI-Gallery/pull/1239
            dispatcherQueue = Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread();
            settings = new UISettings();
            settings.ColorValuesChanged += Settings_ColorValuesChanged; // cannot use FrameworkElement.ActualThemeChanged event
                                                                        // trying to configure serilog 


        }

        // this handles updating the caption button colors correctly when windows system theme is changed
        // while the app is open
        private void Settings_ColorValuesChanged(UISettings sender, object args)
        {
            // This calls comes off-thread, hence we will need to dispatch it to current app's thread
            dispatcherQueue.TryEnqueue(() =>
            {
                TitleBarHelper.ApplySystemThemeToCaptionButtons();
            });
        }
    }
}
