using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnotherJiraRestClient
{
    /// <summary>
    /// Class representing a Jira server acount
    /// </summary>
    [Serializable()]
    public class JiraAccount
    {
        /// <summary>
        /// Jira server url, for example https://example.atalassian.net. Please note that the
        /// protocol needs to be https.
        /// </summary>
        public string ServerUrl { get; set; }

        /// <summary>
        /// Jira server user name
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Jira server password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Constructs a JiraAccount
        /// </summary>
        /// <param name="serverUrl">jira instance server address</param>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        public JiraAccount(string serverUrl, string username, string password)
        {
            ServerUrl = serverUrl;
            User = username;
            Password = password;
        }
    }
}
