// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridData.Models
{
    internal static partial class HybridDataJobStatusExtensions
    {
        public static string ToSerialString(this HybridDataJobStatus value) => value switch
        {
            HybridDataJobStatus.None => "None",
            HybridDataJobStatus.InProgress => "InProgress",
            HybridDataJobStatus.Succeeded => "Succeeded",
            HybridDataJobStatus.WaitingForAction => "WaitingForAction",
            HybridDataJobStatus.Failed => "Failed",
            HybridDataJobStatus.Cancelled => "Cancelled",
            HybridDataJobStatus.Cancelling => "Cancelling",
            HybridDataJobStatus.PartiallySucceeded => "PartiallySucceeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HybridDataJobStatus value.")
        };

        public static HybridDataJobStatus ToHybridDataJobStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return HybridDataJobStatus.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "InProgress")) return HybridDataJobStatus.InProgress;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Succeeded")) return HybridDataJobStatus.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "WaitingForAction")) return HybridDataJobStatus.WaitingForAction;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return HybridDataJobStatus.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Cancelled")) return HybridDataJobStatus.Cancelled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Cancelling")) return HybridDataJobStatus.Cancelling;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PartiallySucceeded")) return HybridDataJobStatus.PartiallySucceeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HybridDataJobStatus value.");
        }
    }
}
