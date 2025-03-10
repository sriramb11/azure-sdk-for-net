// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Variable values. </summary>
    public partial class VariableValues
    {
        /// <summary> Initializes a new instance of VariableValues. </summary>
        /// <param name="variable"> Variable name of the last detection request. </param>
        /// <param name="timestamps"> Time stamps of the last detection request. </param>
        /// <param name="values"> Values of variables. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="variable"/>, <paramref name="timestamps"/> or <paramref name="values"/> is null. </exception>
        public VariableValues(string variable, IEnumerable<string> timestamps, IEnumerable<float> values)
        {
            Argument.AssertNotNull(variable, nameof(variable));
            Argument.AssertNotNull(timestamps, nameof(timestamps));
            Argument.AssertNotNull(values, nameof(values));

            Variable = variable;
            Timestamps = timestamps.ToList();
            Values = values.ToList();
        }

        /// <summary> Variable name of the last detection request. </summary>
        public string Variable { get; }
        /// <summary> Time stamps of the last detection request. </summary>
        public IList<string> Timestamps { get; }
        /// <summary> Values of variables. </summary>
        public IList<float> Values { get; }
    }
}
