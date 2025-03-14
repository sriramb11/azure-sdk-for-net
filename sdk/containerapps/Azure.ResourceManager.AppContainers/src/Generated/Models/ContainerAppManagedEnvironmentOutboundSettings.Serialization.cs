// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppManagedEnvironmentOutboundSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OutBoundType))
            {
                writer.WritePropertyName("outBoundType"u8);
                writer.WriteStringValue(OutBoundType.Value.ToString());
            }
            if (Optional.IsDefined(VirtualNetworkApplianceIP))
            {
                writer.WritePropertyName("virtualNetworkApplianceIp"u8);
                writer.WriteStringValue(VirtualNetworkApplianceIP.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppManagedEnvironmentOutboundSettings DeserializeContainerAppManagedEnvironmentOutboundSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppManagedEnvironmentOutBoundType> outBoundType = default;
            Optional<IPAddress> virtualNetworkApplianceIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outBoundType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outBoundType = new ContainerAppManagedEnvironmentOutBoundType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkApplianceIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkApplianceIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
            }
            return new ContainerAppManagedEnvironmentOutboundSettings(Optional.ToNullable(outBoundType), virtualNetworkApplianceIP.Value);
        }
    }
}
