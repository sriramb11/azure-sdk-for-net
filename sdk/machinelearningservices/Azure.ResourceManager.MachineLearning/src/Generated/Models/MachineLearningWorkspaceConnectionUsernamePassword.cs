// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceConnectionUsernamePassword. </summary>
    public partial class MachineLearningWorkspaceConnectionUsernamePassword
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceConnectionUsernamePassword. </summary>
        public MachineLearningWorkspaceConnectionUsernamePassword()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceConnectionUsernamePassword. </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        internal MachineLearningWorkspaceConnectionUsernamePassword(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
        /// <summary> Gets or sets the password. </summary>
        public string Password { get; set; }
    }
}
