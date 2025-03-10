// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class ExtractedSummaryDocumentResultWithDetectedLanguage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DetectedLanguage))
            {
                writer.WritePropertyName("detectedLanguage"u8);
                writer.WriteObjectValue(DetectedLanguage.Value);
            }
            writer.WritePropertyName("sentences"u8);
            writer.WriteStartArray();
            foreach (var item in Sentences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings"u8);
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExtractedSummaryDocumentResultWithDetectedLanguage DeserializeExtractedSummaryDocumentResultWithDetectedLanguage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DetectedLanguageInternal> detectedLanguage = default;
            IList<ExtractedSummarySentence> sentences = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("detectedLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectedLanguage = DetectedLanguageInternal.DeserializeDetectedLanguageInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("sentences"u8))
                {
                    List<ExtractedSummarySentence> array = new List<ExtractedSummarySentence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtractedSummarySentence.DeserializeExtractedSummarySentence(item));
                    }
                    sentences = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new ExtractedSummaryDocumentResultWithDetectedLanguage(id, warnings, Optional.ToNullable(statistics), sentences, Optional.ToNullable(detectedLanguage));
        }
    }
}
