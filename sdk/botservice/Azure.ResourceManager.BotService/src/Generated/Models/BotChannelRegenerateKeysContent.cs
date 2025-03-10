// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Site information for WebChat or DirectLine Channels to identify which site to regenerate keys for. </summary>
    public partial class BotChannelRegenerateKeysContent
    {
        /// <summary> Initializes a new instance of BotChannelRegenerateKeysContent. </summary>
        /// <param name="siteName"> The site name. </param>
        /// <param name="key"> Determines which key is to be regenerated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public BotChannelRegenerateKeysContent(string siteName, BotServiceKey key)
        {
            Argument.AssertNotNull(siteName, nameof(siteName));

            SiteName = siteName;
            Key = key;
        }

        /// <summary> The site name. </summary>
        public string SiteName { get; }
        /// <summary> Determines which key is to be regenerated. </summary>
        public BotServiceKey Key { get; }
    }
}
