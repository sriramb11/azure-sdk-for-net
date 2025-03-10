// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DiscoveryConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CentralServerVmId))
            {
                writer.WritePropertyName("centralServerVmId"u8);
                writer.WriteStringValue(CentralServerVmId);
            }
            if (Optional.IsDefined(ManagedRgStorageAccountName))
            {
                writer.WritePropertyName("managedRgStorageAccountName"u8);
                writer.WriteStringValue(ManagedRgStorageAccountName);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static DiscoveryConfiguration DeserializeDiscoveryConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> centralServerVmId = default;
            Optional<string> managedRgStorageAccountName = default;
            Optional<AzureLocation> appLocation = default;
            SapConfigurationType configurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("centralServerVmId"u8))
                {
                    centralServerVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedRgStorageAccountName"u8))
                {
                    managedRgStorageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new DiscoveryConfiguration(configurationType, centralServerVmId.Value, managedRgStorageAccountName.Value, Optional.ToNullable(appLocation));
        }
    }
}
