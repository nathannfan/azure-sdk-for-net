// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents database metrics.
    /// </summary>
    public partial class DatabaseMetric : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseMetric class.
        /// </summary>
        public DatabaseMetric() { }

        /// <summary>
        /// Initializes a new instance of the DatabaseMetric class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="resourceName">The name of the resource.</param>
        /// <param name="displayName">The metric display name.</param>
        /// <param name="currentValue">The current value of the metric.</param>
        /// <param name="limit">The current limit of the metric.</param>
        /// <param name="unit">The units of the metric.</param>
        /// <param name="nextResetTime">The next reset time for the metric
        /// (ISO8601 format).</param>
        public DatabaseMetric(string name = default(string), string id = default(string), string resourceName = default(string), string displayName = default(string), double? currentValue = default(double?), double? limit = default(double?), string unit = default(string), System.DateTime? nextResetTime = default(System.DateTime?))
            : base(name, id)
        {
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetTime = nextResetTime;
        }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; protected set; }

        /// <summary>
        /// Gets the metric display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; protected set; }

        /// <summary>
        /// Gets the current value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; protected set; }

        /// <summary>
        /// Gets the current limit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; protected set; }

        /// <summary>
        /// Gets the units of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; protected set; }

        /// <summary>
        /// Gets the next reset time for the metric (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public System.DateTime? NextResetTime { get; protected set; }

    }
}

