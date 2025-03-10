// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ElasticSan;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal partial class ElasticSanList
    {
        internal static ElasticSanList DeserializeElasticSanList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ElasticSanData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ElasticSanData> array = new List<ElasticSanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticSanData.DeserializeElasticSanData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ElasticSanList(value, nextLink.Value);
        }
    }
}
