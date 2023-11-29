using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Management_Express
{
    public static class Constants
    {
        /// <summary>
        /// The base URI for the Datasync service.
        /// </summary>
        public static string ServiceUri = "http://localhost:5211/";

        /// <summary>
        /// The application (client) ID for the native app within Microsoft Entra ID
        /// </summary>
        public static string ApplicationId = "bfcdbe91-5346-4160-b6fd-28d01a6e7254";

        /// <summary>
        /// The list of scopes to request
        /// </summary>
        public static string[] Scopes = new[]
        {
            "<scope>"
        };
    }
}
