// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Configuration affecting the Trial Matcher model's inference. </summary>
    public partial class TrialMatcherModelConfiguration
    {
        /// <summary> Initializes a new instance of TrialMatcherModelConfiguration. </summary>
        /// <param name="clinicalTrials">
        /// The clinical trials that the patient(s) should be matched to. &lt;br /&gt;The trial
        /// selection can be given as a list of custom clinical trials and/or a list of
        /// filters to known clinical trial registries. In case both are given, the
        /// resulting trial set is a union of the two sets.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clinicalTrials"/> is null. </exception>
        public TrialMatcherModelConfiguration(ClinicalTrials clinicalTrials)
        {
            Argument.AssertNotNull(clinicalTrials, nameof(clinicalTrials));

            ClinicalTrials = clinicalTrials;
        }

        /// <summary> An indication whether the model should produce verbose output. </summary>
        public bool? Verbose { get; set; }
        /// <summary> An indication whether the model's output should include evidence for the inferences. </summary>
        public bool? IncludeEvidence { get; set; }
        /// <summary>
        /// The clinical trials that the patient(s) should be matched to. &lt;br /&gt;The trial
        /// selection can be given as a list of custom clinical trials and/or a list of
        /// filters to known clinical trial registries. In case both are given, the
        /// resulting trial set is a union of the two sets.
        /// </summary>
        public ClinicalTrials ClinicalTrials { get; }
    }
}
