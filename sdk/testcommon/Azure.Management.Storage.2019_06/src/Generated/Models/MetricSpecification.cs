// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> Metric specification of operation. </summary>
    public partial class MetricSpecification
    {
        /// <summary> Initializes a new instance of MetricSpecification. </summary>
        internal MetricSpecification()
        {
            Dimensions = new ChangeTrackingList<Dimension>();
        }

        /// <summary> Initializes a new instance of MetricSpecification. </summary>
        /// <param name="name"> Name of metric specification. </param>
        /// <param name="displayName"> Display name of metric specification. </param>
        /// <param name="displayDescription"> Display description of metric specification. </param>
        /// <param name="unit"> Unit could be Bytes or Count. </param>
        /// <param name="dimensions"> Dimensions of blobs, including blob type and access tier. </param>
        /// <param name="aggregationType"> Aggregation type could be Average. </param>
        /// <param name="fillGapWithZero"> The property to decide fill gap with zero or not. </param>
        /// <param name="category"> The category this metric specification belong to, could be Capacity. </param>
        /// <param name="resourceIdDimensionNameOverride"> Account Resource Id. </param>
        internal MetricSpecification(string name, string displayName, string displayDescription, string unit, IReadOnlyList<Dimension> dimensions, string aggregationType, bool? fillGapWithZero, string category, string resourceIdDimensionNameOverride)
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            Dimensions = dimensions;
            AggregationType = aggregationType;
            FillGapWithZero = fillGapWithZero;
            Category = category;
            ResourceIdDimensionNameOverride = resourceIdDimensionNameOverride;
        }

        /// <summary> Name of metric specification. </summary>
        public string Name { get; }
        /// <summary> Display name of metric specification. </summary>
        public string DisplayName { get; }
        /// <summary> Display description of metric specification. </summary>
        public string DisplayDescription { get; }
        /// <summary> Unit could be Bytes or Count. </summary>
        public string Unit { get; }
        /// <summary> Dimensions of blobs, including blob type and access tier. </summary>
        public IReadOnlyList<Dimension> Dimensions { get; }
        /// <summary> Aggregation type could be Average. </summary>
        public string AggregationType { get; }
        /// <summary> The property to decide fill gap with zero or not. </summary>
        public bool? FillGapWithZero { get; }
        /// <summary> The category this metric specification belong to, could be Capacity. </summary>
        public string Category { get; }
        /// <summary> Account Resource Id. </summary>
        public string ResourceIdDimensionNameOverride { get; }
    }
}
