// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SeverityFilterCondition. </summary>
    internal partial class SeverityFilterCondition
    {
        /// <summary> Initializes a new instance of SeverityFilterCondition. </summary>
        /// <param name="min"> min severity. </param>
        /// <param name="max"> max severity. </param>
        public SeverityFilterCondition(AnomalySeverity min, AnomalySeverity max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> min severity. </summary>
        public AnomalySeverity Min { get; }
        /// <summary> max severity. </summary>
        public AnomalySeverity Max { get; }
    }
}