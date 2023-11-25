using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Room_Management_Express.Logging;
using Room_Management_Express.ViewModels;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;
using Serilog.Sinks.WinUi3;
using Serilog.Sinks.WinUi3.LogViewModels;
using Serilog.Templates;

namespace Room_Management_Express.Views
{
    public sealed partial class logPage : Page
    {
        private ItemsRepeaterLogBroker _logBroker;
        public logViewModel ViewModel
        {
            get;
        }

        public logPage()
        {
            ViewModel = App.GetService<logViewModel>();
            InitializeComponent();
            BuildLogging();
            App.Logger.Information("Starting Logging");

        }

        private void BuildLogging()
        {
            // Create your custom LogBroker.
            _logBroker = new ItemsRepeaterLogBroker(
                LogViewer,
                LogScrollViewer,
                new EmojiLogViewModelBuilder(defaultForeground: Colors.BlueViolet)
                    // Timestamp format
                    .SetTimestampFormat(new ExpressionTemplate("[{@t:yyyy-MM-dd HH:mm:ss.fff}]"))
                    // Level format and colors
                    .SetLevelsFormat(new ExpressionTemplate("{@l:u3}"))
                    .SetMessageForeground(LogEventLevel.Verbose, Colors.Crimson)
                    .SetMessageForeground(LogEventLevel.Debug, Colors.DarkOrange)
                    .SetMessageForeground(LogEventLevel.Warning, Colors.Gray)
                    .SetMessageForeground(LogEventLevel.Error, Colors.Red)
                    .SetMessageForeground(LogEventLevel.Fatal, Colors.HotPink)
                    // Message format and colors
                    .SetMessageFormat(new ExpressionTemplate("{@m}"))
                    .SetMessageForeground(LogEventLevel.Verbose, Colors.Crimson)
                    .SetMessageForeground(LogEventLevel.Debug, Colors.DarkOrange)
                    .SetMessageForeground(LogEventLevel.Warning, Colors.Gray)
                    .SetMessageForeground(LogEventLevel.Error, Colors.Red)
                    .SetMessageForeground(LogEventLevel.Fatal, Colors.HotPink)
                    // Exception format and color
                    .SetExceptionFormat(new ExpressionTemplate("{@x}"))
                    .SetExceptionForeground(Colors.HotPink)
            );



            App.Logger = new LoggerConfiguration()
                .WriteTo.WinUi3Control(_logBroker)
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            App.Logger.Information("Application Build Complete");
            App.Logger.Information("Application Running");


        }
    }
}
