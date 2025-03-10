// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class WebApplicationFirewallCustomRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("matchConditions"u8);
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static WebApplicationFirewallCustomRule DeserializeWebApplicationFirewallCustomRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ETag> etag = default;
            int priority = default;
            WebApplicationFirewallRuleType ruleType = default;
            IList<MatchCondition> matchConditions = default;
            WebApplicationFirewallAction action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new WebApplicationFirewallRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    List<MatchCondition> array = new List<MatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchCondition.DeserializeMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new WebApplicationFirewallAction(property.Value.GetString());
                    continue;
                }
            }
            return new WebApplicationFirewallCustomRule(name.Value, Optional.ToNullable(etag), priority, ruleType, matchConditions, action);
        }
    }
}
