// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class SessionHostData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LastHeartBeatOn))
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartBeatOn.Value, "O");
            }
            if (Optional.IsDefined(Sessions))
            {
                writer.WritePropertyName("sessions"u8);
                writer.WriteNumberValue(Sessions.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AllowNewSession))
            {
                writer.WritePropertyName("allowNewSession"u8);
                writer.WriteBooleanValue(AllowNewSession.Value);
            }
            if (Optional.IsDefined(AssignedUser))
            {
                writer.WritePropertyName("assignedUser"u8);
                writer.WriteStringValue(AssignedUser);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsDefined(SxsStackVersion))
            {
                writer.WritePropertyName("sxSStackVersion"u8);
                writer.WriteStringValue(SxsStackVersion);
            }
            if (Optional.IsDefined(UpdateState))
            {
                writer.WritePropertyName("updateState"u8);
                writer.WriteStringValue(UpdateState.Value.ToString());
            }
            if (Optional.IsDefined(UpdateErrorMessage))
            {
                writer.WritePropertyName("updateErrorMessage"u8);
                writer.WriteStringValue(UpdateErrorMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SessionHostData DeserializeSessionHostData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> objectId = default;
            Optional<DateTimeOffset> lastHeartBeat = default;
            Optional<int> sessions = default;
            Optional<string> agentVersion = default;
            Optional<bool> allowNewSession = default;
            Optional<string> virtualMachineId = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> assignedUser = default;
            Optional<SessionHostStatus> status = default;
            Optional<DateTimeOffset> statusTimestamp = default;
            Optional<string> osVersion = default;
            Optional<string> sxsStackVersion = default;
            Optional<SessionHostUpdateState> updateState = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<string> updateErrorMessage = default;
            Optional<IReadOnlyList<SessionHostHealthCheckReport>> sessionHostHealthCheckResults = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastHeartBeat = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sessions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessions = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowNewSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowNewSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineId"u8))
                        {
                            virtualMachineId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("assignedUser"u8))
                        {
                            assignedUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SessionHostStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statusTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osVersion"u8))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sxSStackVersion"u8))
                        {
                            sxsStackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateState = new SessionHostUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateErrorMessage"u8))
                        {
                            updateErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionHostHealthCheckResults"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SessionHostHealthCheckReport> array = new List<SessionHostHealthCheckReport>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SessionHostHealthCheckReport.DeserializeSessionHostHealthCheckReport(item));
                            }
                            sessionHostHealthCheckResults = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SessionHostData(id, name, type, systemData.Value, objectId.Value, Optional.ToNullable(lastHeartBeat), Optional.ToNullable(sessions), agentVersion.Value, Optional.ToNullable(allowNewSession), virtualMachineId.Value, resourceId.Value, assignedUser.Value, Optional.ToNullable(status), Optional.ToNullable(statusTimestamp), osVersion.Value, sxsStackVersion.Value, Optional.ToNullable(updateState), Optional.ToNullable(lastUpdateTime), updateErrorMessage.Value, Optional.ToList(sessionHostHealthCheckResults));
        }
    }
}
