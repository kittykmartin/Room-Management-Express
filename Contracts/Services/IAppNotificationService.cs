using System.Collections.Specialized;

namespace Room_Management_Express.Contracts.Services
{
    public interface IAppNotificationService
    {
        void Initialize();

        bool Show(string payload);

        NameValueCollection ParseArguments(string arguments);

        void Unregister();
    }
}
