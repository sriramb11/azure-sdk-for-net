// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Identity
{
    internal partial class CommunicationIdentityAccessToken
    {
        internal static CommunicationIdentityAccessToken DeserializeCommunicationIdentityAccessToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            DateTimeOffset expiresOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresOn"u8))
                {
                    expiresOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new CommunicationIdentityAccessToken(token, expiresOn);
        }
    }
}
