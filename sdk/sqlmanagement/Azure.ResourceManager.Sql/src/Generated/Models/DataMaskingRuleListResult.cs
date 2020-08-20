// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list data masking rules request. </summary>
    public partial class DataMaskingRuleListResult
    {
        /// <summary> Initializes a new instance of DataMaskingRuleListResult. </summary>
        internal DataMaskingRuleListResult()
        {
            Value = new ChangeTrackingList<DataMaskingRule>();
        }

        /// <summary> Initializes a new instance of DataMaskingRuleListResult. </summary>
        /// <param name="value"> The list of database data masking rules. </param>
        internal DataMaskingRuleListResult(IReadOnlyList<DataMaskingRule> value)
        {
            Value = value;
        }

        /// <summary> The list of database data masking rules. </summary>
        public IReadOnlyList<DataMaskingRule> Value { get; }
    }
}
