using Microsoft.UI.Xaml;

using Room_Management_Express.Contracts.Services;
using Room_Management_Express.ViewModels;

namespace Room_Management_Express.Activation
{
    public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
    {
        private readonly INavigationService _navigationService;

        public DefaultActivationHandler(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
        {
            // None of the ActivationHandlers has handled the activation.
            return _navigationService.Frame?.Content == null;
        }

        protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
        {
            _navigationService.NavigateTo(typeof(MainViewModel).FullName!, args.Arguments);

            await Task.CompletedTask;
        }
    }
}
